C#里如何远程直接连接SQL Server数据库服务器


一、检测数据库服务器是否打开远程数据库连接和打开对应的端口

①打开服务器数据库

![img](https://img-blog.csdnimg.cn/20190807132024257.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3hpYW9jaGVuWElIVUE=,size_16,color_FFFFFF,t_70)

②打开数据库检查是否开启远程连接，如下所示;

![img](https://img-blog.csdnimg.cn/20190807132306323.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3hpYW9jaGVuWElIVUE=,size_16,color_FFFFFF,t_70)

③点击左下角开始-->打开SqlServer xxx配置管理器

![img](https://img-blog.csdnimg.cn/20190807132510184.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3hpYW9jaGVuWElIVUE=,size_16,color_FFFFFF,t_70)

④启用TCP/IP

![img](https://img-blog.csdnimg.cn/20190807132618853.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3hpYW9jaGVuWElIVUE=,size_16,color_FFFFFF,t_70)

⑤再查看服务器的网络端口状态（即在该数据库服务器电脑上打开CMD输入netstat  -an 查看服务器是否在1433端口上监听）

![img](https://img-blog.csdnimg.cn/20190807133426589.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3hpYW9jaGVuWElIVUE=,size_16,color_FFFFFF,t_70)

二、检测SqlServer数据库服务器是否可以ping通和查看该数据库的端口是否打开监听

①在需要连接到SqlServer数据库服务器的电脑上打开CMD窗口输入（ping 数据库服务器IP地址），ping通则如下所示：

![img](https://img-blog.csdnimg.cn/20190807133032109.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3hpYW9jaGVuWElIVUE=,size_16,color_FFFFFF,t_70)

②需要连接到SqlServer数据库服务器的电脑上打开CMD窗口，输入telnet  数据库服务器IP地址 1433

![img](https://img-blog.csdnimg.cn/20190807134144246.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3hpYW9jaGVuWElIVUE=,size_16,color_FFFFFF,t_70)



注意：如果如下所示的（'telnet' 不是内部或外部命令，也不是可运行的程序）则需要打开控制面板-->程序-->启用或关闭windows功能-->在Telnet Client前面打√，然后确认即可，如下图所示：

![img](https://img-blog.csdnimg.cn/20190807134248146.png)

![img](https://img-blog.csdnimg.cn/20190807134453481.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3hpYW9jaGVuWElIVUE=,size_16,color_FFFFFF,t_70)

注意2：如果出现在dos窗口下输入telnet 数据库服务器IP地址 端口号连接失败，则需要检查防火墙，添加1433端口的入站规则，操作如下：控制面板-->系统和安全-->Windows Defender防火墙-->高级设置进入规则配置界面；

入站规则-->新建规则--端口-->TCP连接特定端口1433-->允许连接-->下一步-->填写描述名称确认即可，如下所示

 ![img](https://img-blog.csdnimg.cn/20190807134959936.png)

![img](https://img-blog.csdnimg.cn/20190807135145344.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3hpYW9jaGVuWElIVUE=,size_16,color_FFFFFF,t_70)

![img](https://img-blog.csdnimg.cn/20190807135216186.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3hpYW9jaGVuWElIVUE=,size_16,color_FFFFFF,t_70)

![img](https://img-blog.csdnimg.cn/20190807135348226.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3hpYW9jaGVuWElIVUE=,size_16,color_FFFFFF,t_70)

![img](https://img-blog.csdnimg.cn/20190807135418314.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3hpYW9jaGVuWElIVUE=,size_16,color_FFFFFF,t_70)

![img](https://img-blog.csdnimg.cn/20190807135542878.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3hpYW9jaGVuWElIVUE=,size_16,color_FFFFFF,t_70)

![img](https://img-blog.csdnimg.cn/20190807135623323.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3hpYW9jaGVuWElIVUE=,size_16,color_FFFFFF,t_70)

![img](https://img-blog.csdnimg.cn/20190807135746640.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3hpYW9jaGVuWElIVUE=,size_16,color_FFFFFF,t_70)

