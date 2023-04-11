# C# 程序 修改 ConfigurationManager 后，不重启 刷新配置

**基本共识：**

ConfigurationManager 自带缓存，且不支持 写入。

如果 通过 文本写入方式 修改 配置文件，程序 无法刷新加载 最新配置。

PS. Web.config 除外：Web.config 修改后，网站会重启 （即 Web 程序 也无法在 运行时 刷新配置）。

 

**为什么要在程序运行时，修改配置（刷新配置）：**

\> 以前C++，VB 时代，用户在程序界面 勾选的配置，会写到 ini 文件。

\> C# 自带 .exe.config 配置文件 —— 但是，C# 自带的 ConfigurationManager 不支持 运行时 修改，运行时刷新配置。

\> 本文 提供工具类，彻底 解决 这个问题 —— 从此，用户手动勾选的配置 再也不用写入 ini，而是直接修改 .exe.config 文件，且立即刷新。

 

**刷新 ConfigurationManager 配置 的 代码 有两种：**

\> 第一种：

```
ConfigurationManager.RefreshSection("appSettings");        //刷新 appSettings 节点 （立即生效）
ConfigurationManager.RefreshSection("connectionString");   //刷新 connectionString 节点 （无法生效 —— 可能是 微软处理时，因为 LocalSqlServer 这个默认配置 而导致的疏忽）
```

 

\> 第二种：

```
FieldInfo fieldInfo = typeof(ConfigurationManager).GetField("s_initState", BindingFlags.NonPublic | BindingFlags.Static);
if (fieldInfo != null) fieldInfo.SetValue(null, 0); //将配置文件 设置为: 未分析 状态, 配置文件 将会在下次读取 时 重新分析.//立即生效，而且效果 明显 —— 就喜欢这种 暴力做法。
```

 

**一起反编译 ConfigurationManager 代码：**

\> 首先 下载 ILSpy 或 Reflector （本文使用的是 ILSpy.）

\> 打开 ILSpy 搜索 ConfigurationManager，执行如下操作：

![img](https://images2015.cnblogs.com/blog/166267/201609/166267-20160907141253223-1782947467.png)

![img](https://images2015.cnblogs.com/blog/166267/201609/166267-20160907141307441-910606496.png)

![img](https://images2015.cnblogs.com/blog/166267/201609/166267-20160907141317238-603839341.png)

![img](https://images2015.cnblogs.com/blog/166267/201609/166267-20160907141324394-1242235667.png)

![img](https://images2015.cnblogs.com/blog/166267/201609/166267-20160907141330379-1582482392.png)

\> 编写 反射代码，刷新 配置文件数据。（具体代码 在 文章最开始。）

 

**额外提供 配置文件 修改的 工具类代码：**

以下代码 实现如下功能：

\> 执行 配置写入操作时，自动创建 .exe.config 文件，自动创建 appSettings connectionString 节点。

\> .exe.config 写入配置时，如果 相同的 key  name 存在，则修改，不存在 则创建。

\> 额外的 **审美操作**：

   \> 很多人习惯 appSettings 显示在 connectionString 前面。

   \> 很多人习惯 appSettings 在 最前面。

   \> appSettings 必须在 configSections 后面。（configSections 配置文件 扩展配置节点，只能写在第一个，否则 程序报错。）

 

 

![img](https://images.cnblogs.com/OutliningIndicators/ExpandedBlockStart.gif)



```
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace InkFx.Utils
{
    public partial class Tools
    {

        private static ConfigAppSetting m_AppSettings;
        private static ConfigConnectionStrings m_ConnectionStrings;

        public static ConfigAppSetting AppSettings
        {
            get
            {
                if (m_AppSettings == null)
                {
                    m_AppSettings = new ConfigAppSetting();
                    m_AppSettings.AppSettingChanged += OnAppSettingChanged;
                }
                return m_AppSettings;
            }
        }
        public static ConfigConnectionStrings ConnectionStrings
        {
            get
            {
                if (m_ConnectionStrings == null)
                {
                    m_ConnectionStrings = new ConfigConnectionStrings();
                    m_ConnectionStrings.ConnectionStringsChanged += OnConnectionStringsChanged;
                }
                return m_ConnectionStrings;
            }
        }



        private static void OnAppSettingChanged(string name, string value)
        {
            string configPath = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            if (!File.Exists(configPath))
            {
                const string content = @"<?xml version=""1.0""?><configuration></configuration>";
                File.WriteAllText(configPath, content, Encoding.UTF8);
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(configPath);

            XmlNode nodeConfiguration = doc.SelectSingleNode(@"configuration");
            if (nodeConfiguration == null)
            {
                nodeConfiguration = doc.CreateNode(XmlNodeType.Element, "configuration", string.Empty);
                doc.AppendChild(nodeConfiguration);
            }

            XmlNode nodeAppSettings = nodeConfiguration.SelectSingleNode(@"appSettings");
            if (nodeAppSettings == null)
            {
                nodeAppSettings = doc.CreateNode(XmlNodeType.Element, "appSettings", string.Empty);
                if (!nodeConfiguration.HasChildNodes)
                    nodeConfiguration.AppendChild(nodeAppSettings);
                else
                {
                    //configSections 必须放在 第一个, 所以得 避开 configSections
                    XmlNode firstNode = nodeConfiguration.ChildNodes[0];
                    bool firstNodeIsSections = string.Equals(firstNode.Name, "configSections", StringComparison.CurrentCultureIgnoreCase);

                    if (firstNodeIsSections)
                        nodeConfiguration.InsertAfter(nodeAppSettings, firstNode);
                    else
                        nodeConfiguration.InsertBefore(nodeAppSettings, firstNode);
                }
            }

            string xmlName = FormatXmlStr(name);
            XmlNode nodeAdd = nodeAppSettings.SelectSingleNode(@"add[@key='" + xmlName + "']");
            if (nodeAdd == null)
            {
                nodeAdd = doc.CreateNode(XmlNodeType.Element, "add", string.Empty);
                nodeAppSettings.AppendChild(nodeAdd);
            }

            XmlElement nodeElem = (XmlElement)nodeAdd;
            nodeElem.SetAttribute("key", name);
            nodeElem.SetAttribute("value", value);
            doc.Save(configPath);

            try { ConfigurationManager.RefreshSection("appSettings"); } catch (Exception) { }
        }
        private static void OnConnectionStringsChanged(string name, string value)
        {
            string configPath = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            if (!File.Exists(configPath))
            {
                const string content = @"<?xml version=""1.0""?><configuration></configuration>";
                File.WriteAllText(configPath, content, Encoding.UTF8);
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(configPath);

            XmlNode nodeConfiguration = doc.SelectSingleNode(@"configuration");
            if (nodeConfiguration == null)
            {
                nodeConfiguration = doc.CreateNode(XmlNodeType.Element, "configuration", string.Empty);
                doc.AppendChild(nodeConfiguration);
            }

            XmlNode nodeAppSettings = nodeConfiguration.SelectSingleNode(@"appSettings");
            XmlNode nodeConnectionStrings = nodeConfiguration.SelectSingleNode(@"connectionStrings");
            if (nodeConnectionStrings == null)
            {
                nodeConnectionStrings = doc.CreateNode(XmlNodeType.Element, "connectionStrings", string.Empty);
                if (!nodeConfiguration.HasChildNodes)
                    nodeConfiguration.AppendChild(nodeConnectionStrings);
                else
                {
                    //优先将 connectionStrings 放在 appSettings 后面
                    if (nodeAppSettings != null)
                        nodeConfiguration.InsertAfter(nodeConnectionStrings, nodeAppSettings);
                    else
                    {
                        //如果 没有 appSettings 节点, 则 configSections 必须放在 第一个, 所以得 避开 configSections
                        XmlNode firstNode = nodeConfiguration.ChildNodes[0];
                        bool firstNodeIsSections = string.Equals(firstNode.Name, "configSections", StringComparison.CurrentCultureIgnoreCase);

                        if (firstNodeIsSections)
                            nodeConfiguration.InsertAfter(nodeConnectionStrings, firstNode);
                        else
                            nodeConfiguration.InsertBefore(nodeConnectionStrings, firstNode);
                    }
                }
            }

            string xmlName = FormatXmlStr(name);
            XmlNode nodeAdd = nodeConnectionStrings.SelectSingleNode(@"add[@name='" + xmlName + "']");
            if (nodeAdd == null)
            {
                nodeAdd = doc.CreateNode(XmlNodeType.Element, "add", string.Empty);
                nodeConnectionStrings.AppendChild(nodeAdd);
            }

            XmlElement nodeElem = (XmlElement)nodeAdd;
            nodeElem.SetAttribute("name", name);
            nodeElem.SetAttribute("connectionString", value);
            doc.Save(configPath);

            try
            {
                ConfigurationManager.RefreshSection("connectionString");  //RefreshSection 无法刷新 connectionString 节点
                FieldInfo fieldInfo = typeof(ConfigurationManager).GetField("s_initState", BindingFlags.NonPublic | BindingFlags.Static);
                if (fieldInfo != null) fieldInfo.SetValue(null, 0);       //将配置文件 设置为: 未分析 状态, 配置文件 将会在下次读取 时 重新分析.
            }
            catch (Exception) { }
        }

        private static string FormatXmlStr(string value)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;

            string result = value
                .Replace("<", "<")
                .Replace(">", ">")
                .Replace("&", "&")
                .Replace("'", "&apos;")
                .Replace("\"", """);
            return result;
//< < 小于号
//> > 大于号
//& & 和
//&apos; ' 单引号
//" " 双引号
        }


        public class ConfigAppSetting
        {
            private readonly InnerIgnoreDict<string> m_Hash = new InnerIgnoreDict<string>();

            public string this[string name]
            {
                get
                {
                    string value = m_Hash[name];
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        try { value = ConfigurationManager.AppSettings[name]; } catch(Exception) { }
                        m_Hash[name] = value;
                        return value;
                    }
                    return value;
                }
                set
                {
                    m_Hash[name] = value;
                    try{ ConfigurationManager.AppSettings[name] = value; } catch(Exception) { }
                    if (AppSettingChanged != null) AppSettingChanged(name, value);
                }
            }
            public AppSettingValueChanged AppSettingChanged;

            public delegate void AppSettingValueChanged(string name, string value);
        }
        public class ConfigConnectionStrings
        {
            private readonly InnerIgnoreDict<ConnectionStringSettings> m_Hash = new InnerIgnoreDict<ConnectionStringSettings>();

            public string this[string name]
            {
                get
                {
                    ConnectionStringSettings value = m_Hash[name];
                    if (value == null || string.IsNullOrWhiteSpace(value.ConnectionString))
                    {
                        try { value = ConfigurationManager.ConnectionStrings[name]; } catch (Exception) { }
                        m_Hash[name] = value;
                        return value == null ? string.Empty : value.ConnectionString;
                    }
                    return value.ConnectionString;
                }
                set
                {

                    ConnectionStringSettings setting = new ConnectionStringSettings();
                    setting.Name = name;
                    setting.ConnectionString = value;
                    m_Hash[name] = setting;
                    //try { ConfigurationManager.ConnectionStrings[name] = setting; } catch (Exception) { }
                    if (ConnectionStringsChanged != null) ConnectionStringsChanged(name, value);
                }
            }
            public ConnectionStringsValueChanged ConnectionStringsChanged;

            public delegate void ConnectionStringsValueChanged(string name, string value);
        }



        private class InnerIgnoreDict<T> : Dictionary<string, T>
        {
            public InnerIgnoreDict(): base(StringComparer.CurrentCultureIgnoreCase)
            {
            }

#if (!WindowsCE && !PocketPC)
            public InnerIgnoreDict(SerializationInfo info, StreamingContext context) : base(info, context) { }
#endif

            private readonly object getSetLocker = new object();
            private static readonly T defaultValue = default(T);

            public new T this[string key]
            {
                get
                {
                    if (key == null) return defaultValue;
                    lock (getSetLocker) //为了 多线程的 高并发, 取值也 加上 线程锁
                    {
                        T record;
                        if (TryGetValue(key, out record)) return record;
                        else return defaultValue;
                    }
                }
                set
                {
                    try
                    {
                        if (key != null)
                        {
                            lock (getSetLocker)
                            {
                                //if (!value.Equals(default(T)))
                                //{
                                if (base.ContainsKey(key)) base[key] = value;
                                else base.Add(key, value);
                                //}
                                //else
                                //{
                                //    base.Remove(key);
                                //}
                            }
                        }
                    }
                    catch (Exception) { }
                }
            }
        }

    }
}
```



 

 

**工具类使用代码：**

 



```
         static void Main(string[] args)
        {
            Tools.AppSettings["Test"] = "Love";                           //修改配置文件
            Console.WriteLine(ConfigurationManager.AppSettings["Test"]);  //传统方式 读取配置文件
            Console.WriteLine(Tools.AppSettings["Test"]);                 //工具类 读取配置文件

            Tools.ConnectionStrings["ConnString"] = "Data Source=127.0.0.1;Initial Catalog=master;User=sa;password=123.com;";
            Console.WriteLine(ConfigurationManager.ConnectionStrings["ConnString"]);
            Console.WriteLine(Tools.ConnectionStrings["ConnString"]);

            Tools.AppSettings["Test"] = "<Love>";
            Console.WriteLine(ConfigurationManager.AppSettings["Test"]);
            Console.WriteLine(Tools.AppSettings["Test"]);

            Console.ReadKey();
        }
```



 

 

**执行结果：**

 

![img](https://images2015.cnblogs.com/blog/166267/201609/166267-20160907142742691-1034222452.png)

**配置文件变化：**

\> 程序执行前，删除配置文件。

\> 程序执行后，自动生成配置文件。

![img](https://images2015.cnblogs.com/blog/166267/201609/166267-20160907142917894-997198410.png)

 