# C# Dapper基本用法

##   一、基础知识

####   1.1、Dapper简介

  Dapper是.NET下的一个micro ORM，它和Entity Framework或NHibnate不同，属于轻量级并且是半自动的（实体类都要自己写）。假如你喜欢原生的Sql语句，又喜欢ORM的简单，那你一定会喜欢上Dapper这款ORM。

####   1.2、Dapper优点

  1）轻量。只有一个文件（SqlMapper.cs）。

  2）速度快。Dapper的速度接近于IDataReader，取列表的数据超过了DataTable。

  3）支持多种数据库。包括SQLite、SqlCe、Firebird、Oracle、MySQL、PostgreSQL、SQL Server。

  4）可以映射一对一、一对多、多对多等多种关系。

  5）性能高。通过Emit反射IDataReader的序列队列，来快速地得到和产生对象。

####   1.3、Dapper安装

  此处使用Dapper扩展库Dapper.SimpleCRUD，它也会默认安装Dapper（依赖项）：

  项目右键->管理 NuGet 程序包->Dapper.SimpleCRUD。

![img](https://img2020.cnblogs.com/blog/1227623/202004/1227623-20200427171617571-396653034.png)

##   二、数据准备

####   2.1、数据表

  在SQL Server中创建4个数据表，分别是：Student（学生表）、Teacher（教师表）、Course（课程表）、Record（成绩表）。





```
--学生表
CREATE TABLE [dbo].[Student](
    [StudentID] [INT] IDENTITY(1,1) NOT NULL,
    [Name] [NVARCHAR](50) NULL,
    [Age] [SMALLINT] NULL,
    [Gender] [NVARCHAR](10) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
    [StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

--教师表
CREATE TABLE [dbo].[Teacher](
    [TeacherID] [INT] IDENTITY(1,1) NOT NULL,
    [Name] [NVARCHAR](50) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
    [TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

--课程表
CREATE TABLE [dbo].[Course](
    [CourseID] [int] IDENTITY(1,1) NOT NULL,
    [Name] [nvarchar](50) NULL,
    [TeacherID] [int] NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
    [CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

--成绩表
CREATE TABLE [dbo].[Record](
    [StudentID] [INT] NOT NULL,
    [CourseID] [INT] NOT NULL,
    [Score] [NUMERIC](8, 2) NULL,
 CONSTRAINT [PK_Score] PRIMARY KEY CLUSTERED 
(
    [StudentID] ASC,
    [CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

--学生表数据插入
INSERT INTO Student (Name,Age,Gender)
SELECT N'刘一',18,N'female'
UNION
SELECT N'陈二',19,N'female'
UNION
SELECT N'张三',18,N'male'
UNION
SELECT N'李四',19,N'male'
UNION
SELECT N'王五',18,N'male'
UNION
SELECT N'赵六',19,N'male'
UNION
SELECT N'孙七',19,N'female'

--教师表数据插入
INSERT INTO Teacher (Name)
SELECT N'周八'
UNION
SELECT N'吴九'
UNION
SELECT N'郑十'

--课程表数据插入
INSERT INTO Course (Name,TeacherID)
SELECT N'离散数学',1
UNION
SELECT N'程序设计',2
UNION
SELECT N'数据结构',3

--成绩表数据插入
INSERT INTO Record (StudentID,CourseID,Score )
SELECT 1,1,90
UNION
SELECT 2,1,91
UNION
SELECT 3,1,89
UNION
SELECT 4,1,75
UNION
SELECT 5,1,96
UNION
SELECT 6,1,78
UNION
SELECT 7,1,83
UNION
SELECT 1,2,86
UNION
SELECT 2,2,92
UNION
SELECT 3,2,77
UNION
SELECT 4,2,71
UNION
SELECT 5,2,66
UNION
SELECT 6,2,87
UNION
SELECT 7,2,93
UNION
SELECT 1,3,81
UNION
SELECT 2,3,90
UNION
SELECT 3,3,88
UNION
SELECT 4,3,82
UNION
SELECT 5,3,93
UNION
SELECT 6,3,91
UNION
SELECT 7,3,84
```



####   2.2、实体类

  Dapper的实体映射：

  1）属性不编辑，用[Editable(false)]这个特性标记，默认是true。

  2）类名到表名的映射，用[Table("TableName")]特性，TableName对应物理数据表名称。

  3）主键映射，如果您的实体类中有Id属性，Dapper会默认此属性为主键，否则要为作为主键的属性添加[Key]特性。

  由上可知，如Student表，其实体类应该生成下面这个样子：





```
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace LinkTo.Test.ConsoleDapper
{
    [Table("Student")]
    [Serializable]
    public class Student
    {
        [Key]
        public int? StudentID {get; set;}

        public string Name {get; set;}

        public short? Age {get; set;}

        public string Gender {get; set;}
    }
}
```



####   2.3、使用T4模板生成实体类

  2.3.1、T4Code文件夹的文本模板





```
<#@ assembly name="System.Core" #>
<#@ assembly name="System.Data" #>
<#@ import namespace="System.Linq" #>
<#@ import namespace="System.Text" #>
<#@ import namespace="System.Collections.Generic" #>
<#@ import namespace="System.Data"#>
<#@ import namespace="System.Data.SqlClient"#>
<#+
    #region T4Code
    /// <summary>
    /// 数据库架构接口
    /// </summary>
    public interface IDBSchema : IDisposable
    {
        List<string> GetTableList();
        DataTable GetTableMetadata(string tableName);
    }

    /// <summary>
    /// 数据库架构工厂
    /// </summary>
    public class DBSchemaFactory
    {
        static readonly string DatabaseType = "SqlServer";
        public static IDBSchema GetDBSchema()
        {
            IDBSchema dbSchema;
            switch (DatabaseType) 
            {
                case "SqlServer":
                    {
                        dbSchema =new SqlServerSchema();
                        break;
                    }
                default: 
                    {
                        throw new ArgumentException("The input argument of DatabaseType is invalid.");
                    }
            }
            return dbSchema;
        }
    }

    /// <summary>
    /// SqlServer
    /// </summary>
    public class SqlServerSchema : IDBSchema
    {
        public string ConnectionString = "Server=.;Database=Test;Uid=sa;Pwd=********;";
        public SqlConnection conn;

        public SqlServerSchema()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();
        }

        public List<string> GetTableList()
        {
            List<string> list = new List<string>();
            string commandText = "SELECT NAME TABLE_NAME FROM SYSOBJECTS WHERE XTYPE='U' ORDER BY NAME";

            using(SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (dr.Read())
                    {
                        list.Add(dr["TABLE_NAME"].ToString());
                    }
                }
            }

            return list;
        }
        
        public DataTable GetTableMetadata(string tableName)
        {
            string commandText=string.Format
                (
                    "SELECT A.NAME TABLE_NAME,B.NAME FIELD_NAME,C.NAME DATATYPE,ISNULL(B.PREC,0) LENGTH, "+
                        "CONVERT(BIT,CASE WHEN NOT F.ID IS NULL THEN 1 ELSE 0 END) ISKEY, "+
                        "CONVERT(BIT,CASE WHEN COLUMNPROPERTY(B.ID,B.NAME,'ISIDENTITY') = 1 THEN 1 ELSE 0 END) AS ISIDENTITY, "+
                        "CONVERT(BIT,B.ISNULLABLE) ISNULLABLE "+
                    "FROM SYSOBJECTS A INNER JOIN SYSCOLUMNS B ON A.ID=B.ID INNER JOIN SYSTYPES C ON B.XTYPE=C.XUSERTYPE "+
                        "LEFT JOIN SYSOBJECTS D ON B.ID=D.PARENT_OBJ AND D.XTYPE='PK' "+
                        "LEFT JOIN SYSINDEXES E ON B.ID=E.ID AND D.NAME=E.NAME "+
                        "LEFT JOIN SYSINDEXKEYS F ON B.ID=F.ID AND B.COLID=F.COLID AND E.INDID=F.INDID "+
                    "WHERE A.XTYPE='U' AND A.NAME='{0}' "+
                    "ORDER BY A.NAME,B.COLORDER", tableName
                );

            using(SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds,"Schema");
                return ds.Tables[0];
            }
        }

        public void Dispose()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
    #endregion
#>
```







```
<#@ assembly name="System.Core" #>
<#@ assembly name="System.Data" #>
<#@ assembly name="EnvDTE" #>
<#@ import namespace="System.Linq" #>
<#@ import namespace="System.Text" #>
<#@ import namespace="System.Collections.Generic" #>
<#@ import namespace="System.Data"#>
<#@ import namespace="System.IO"#>
<#@ import namespace="Microsoft.VisualStudio.TextTemplating"#>

<#+
// T4 Template Block manager for handling multiple file outputs more easily.
// Copyright (c) Microsoft Corporation.All rights reserved.
// This source code is made available under the terms of the Microsoft Public License (MS-PL)

// Manager class records the various blocks so it can split them up
class Manager
{
    public struct Block
    {
        public string Name;
        public int Start, Length;
    }

    public List<Block> blocks = new List<Block>();
    public Block currentBlock;
    public Block footerBlock = new Block();
    public Block headerBlock = new Block();
    public ITextTemplatingEngineHost host;
    public ManagementStrategy strategy;
    public StringBuilder template;
    public string OutputPath { get; set; }

    public Manager(ITextTemplatingEngineHost host, StringBuilder template, bool commonHeader)
    {
        this.host = host;
        this.template = template;
        OutputPath = string.Empty;
        strategy = ManagementStrategy.Create(host);
    }

    public void StartBlock(string name)
    {
        currentBlock = new Block { Name = name, Start = template.Length };
    }

    public void StartFooter()
    {
        footerBlock.Start = template.Length;
    }

    public void EndFooter()
    {
        footerBlock.Length = template.Length - footerBlock.Start;
    }

    public void StartHeader()
    {
        headerBlock.Start = template.Length;
    }

    public void EndHeader()
    {
        headerBlock.Length = template.Length - headerBlock.Start;
    }    

    public void EndBlock()
    {
        currentBlock.Length = template.Length - currentBlock.Start;
        blocks.Add(currentBlock);
    }

    public void Process(bool split)
    {
        string header = template.ToString(headerBlock.Start, headerBlock.Length);
        string footer = template.ToString(footerBlock.Start, footerBlock.Length);
        blocks.Reverse();
        foreach(Block block in blocks) {
            string fileName = Path.Combine(OutputPath, block.Name);
            if (split) {
                string content = header + template.ToString(block.Start, block.Length) + footer;
                strategy.CreateFile(fileName, content);
                template.Remove(block.Start, block.Length);
            } else {
                strategy.DeleteFile(fileName);
            }
        }
    }
}

class ManagementStrategy
{
    internal static ManagementStrategy Create(ITextTemplatingEngineHost host)
    {
        return (host is IServiceProvider) ? new VSManagementStrategy(host) : new ManagementStrategy(host);
    }

    internal ManagementStrategy(ITextTemplatingEngineHost host) { }

    internal virtual void CreateFile(string fileName, string content)
    {
        File.WriteAllText(fileName, content);
    }

    internal virtual void DeleteFile(string fileName)
    {
        if (File.Exists(fileName))
            File.Delete(fileName);
    }
}

class VSManagementStrategy : ManagementStrategy
{
    private EnvDTE.ProjectItem templateProjectItem;

    internal VSManagementStrategy(ITextTemplatingEngineHost host) : base(host)
    {
        IServiceProvider hostServiceProvider = (IServiceProvider)host;
        if (hostServiceProvider == null)
            throw new ArgumentNullException("Could not obtain hostServiceProvider");

        EnvDTE.DTE dte = (EnvDTE.DTE)hostServiceProvider.GetService(typeof(EnvDTE.DTE));
        if (dte == null)
            throw new ArgumentNullException("Could not obtain DTE from host");

        templateProjectItem = dte.Solution.FindProjectItem(host.TemplateFile);
    }

    internal override void CreateFile(string fileName, string content)
    {
        base.CreateFile(fileName, content);
        ((EventHandler)delegate { templateProjectItem.ProjectItems.AddFromFile(fileName); }).BeginInvoke(null, null, null, null);
    }

    internal override void DeleteFile(string fileName)
    {
        ((EventHandler)delegate { FindAndDeleteFile(fileName); }).BeginInvoke(null, null, null, null);
    }

    private void FindAndDeleteFile(string fileName)
    {
        foreach(EnvDTE.ProjectItem projectItem in templateProjectItem.ProjectItems)
        {
            if (projectItem.get_FileNames(0) == fileName)
            {
                projectItem.Delete();
                return;
            }
        }
    }
}
#>
```



  DBSchema.ttinclude主要实现了数据库工厂的功能。注：请将数据库连接字符串改成您自己的。

  MultiDocument.ttinclude主要实现了多文档的功能。

  2.3.2、生成实体类的文本模板





```
<#@ template debug="true" hostspecific="true" language="C#" #>
<#@ assembly name="System.Core" #>
<#@ import namespace="System.Linq" #>
<#@ import namespace="System.Text" #>
<#@ import namespace="System.Collections.Generic" #>
<#@ output extension=".cs" #>
<#@ include file="T4Code/DBSchema.ttinclude"#>
<#@ include file="T4Code/MultiDocument.ttinclude"#>
<# var manager = new Manager(Host, GenerationEnvironment, true) { OutputPath = Path.GetDirectoryName(Host.TemplateFile)}; #>
<#
    //System.Diagnostics.Debugger.Launch();//调试
    var dbSchema = DBSchemaFactory.GetDBSchema();
    List<string> tableList = dbSchema.GetTableList();
    foreach (string tableName in tableList)
    {
        manager.StartBlock(tableName+".cs");
        DataTable table = dbSchema.GetTableMetadata(tableName);

        //获取主键
        string strKey = string.Empty;
        foreach (DataRow dataRow in table.Rows)
        {
            if ((bool)dataRow["ISKEY"] == true)
            {
                strKey = dataRow["FIELD_NAME"].ToString();
                break;
            }
        }
        
#>
//-------------------------------------------------------------------------------
// 此代码由T4模板MultiModelAuto自动生成
// 生成时间 <#= DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") #>
// 对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
//-------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace LinkTo.Test.ConsoleDapper
{
    [Table("<#= tableName #>")]
    [Serializable]
    public class <#= tableName #>
    {
<#
        foreach (DataRow dataRow in table.Rows)
        {
            //获取数据类型
            string dbDataType = dataRow["DATATYPE"].ToString();
            string dataType = string.Empty;
                    
            switch (dbDataType)
            {
                case "decimal":
                case "numeric":
                case "money":
                case "smallmoney":
                    dataType = "decimal?";
                    break;
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext":
                    dataType = "string";
                    break;
                case "uniqueidentifier":
                    dataType = "Guid?";
                    break;
                case "bit":
                    dataType = "bool?";
                    break;
                case "real":
                    dataType = "Single?";
                    break;
                case "bigint":
                    dataType = "long?";
                    break;
                case "int":
                    dataType = "int?";
                    break;
                case "tinyint":
                case "smallint":
                    dataType = "short?";
                    break;
                case "float":
                    dataType = "float?";
                    break;
                case "date":
                case "datetime":
                case "datetime2":
                case "smalldatetime":
                    dataType = "DateTime?";
                    break;
                case "datetimeoffset ":
                    dataType = "DateTimeOffset?";
                    break;
                case "timeSpan ":
                    dataType = "TimeSpan?";
                    break;
                case "image":
                case "binary":
                case "varbinary":
                    dataType = "byte[]";
                    break;
                default:
                    break;
            }
            if (dataRow["FIELD_NAME"].ToString() == strKey)
            {
#>
        [Key]
        public <#= dataType #> <#= dataRow["FIELD_NAME"].ToString() #> {get; set;}
<#
            }
            else
            {
#>

        public <#= dataType #> <#= dataRow["FIELD_NAME"].ToString() #> {get; set;}
<# 
            }
        }
#>
    }
}
<#
        manager.EndBlock();
    }
    dbSchema.Dispose();
    manager.Process(true);
#>
```



##   三、CRUD

####   3.1、connectionStrings

  在App.config中添加数据库连接字符串：





```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <startup> 
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.6.1" />
  </startup>
  <connectionStrings>
    <add name="connString" connectionString="Server=.;Database=Test;Uid=sa;Pwd=********;" />
  </connectionStrings>
</configuration>
```



  添加一个DapperHelper类，实现数据库连接及后续的CRUD。





```
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace LinkTo.Test.ConsoleDapper
{
    public class DapperHelper
    {
        public IDbConnection Connection = null;
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public DapperHelper()
        { }

        private IDbConnection GetCon()
        {
            if (Connection == null)
            {
                Connection = new SqlConnection(ConnectionString);
            }
            else if (Connection.State == ConnectionState.Closed)
            {
                Connection.ConnectionString = ConnectionString;
            }
            else if (Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
                Connection.ConnectionString = ConnectionString;
            }
            return Connection;
        }
    }
}
```



####   3.2、Create

  a1）通过SQL插入单条数据(带参数)，返回结果是影响行数。





```
        /// <summary>
        /// 通过SQL插入单条数据(带参数)，返回结果是影响行数。
        /// </summary>
        /// <returns></returns>
        public int? InsertWithSqlA()
        {
            using (var conn = GetCon())
            {
                conn.Open();
                string strSql = "INSERT INTO Student (Name,Age,Gender) VALUES (@Name,@Age,@Gender)";
                return conn.Execute(strSql, new { Name = "Hello", Age = 18, Gender = "male" });
            }
        }
```



  a2）通过SQL插入单条数据(带实体)，返回结果是影响行数。





```
        /// <summary>
        /// 通过SQL插入单条数据(带实体)，返回结果是影响行数。
        /// </summary>
        /// <returns></returns>
        public int? InsertWithSqlB()
        {
            using (var conn = GetCon())
            {
                conn.Open();
                string strSql = "INSERT INTO Student (Name,Age,Gender) VALUES (@Name,@Age,@Gender)";
                Student student = new Student
                {
                    Name = "Hello",
                    Age = 18,
                    Gender = "male"
                };
                return conn.Execute(strSql, student);
            }
        }
```



  a3）通过SQL插入单条数据(带实体)，返回主键值。





```
        /// <summary>
        /// 通过SQL插入单条数据(带实体)，返回主键值。
        /// </summary>
        /// <returns></returns>
        public int? InsertWithSqlC()
        {
            using (var conn = GetCon())
            {
                conn.Open();
                string strSql = "INSERT INTO Student (Name,Age,Gender) VALUES (@Name,@Age,@Gender)";
                Student student = new Student
                {
                    Name = "Hello",
                    Age = 18,
                    Gender = "male"
                };
                strSql += " SELECT SCOPE_IDENTITY()";
                return conn.QueryFirstOrDefault<int>(strSql, student);
            }
        }
```



  a4）通过SQL插入多条数据(带实体)，返回结果是影响行数。





```
        /// <summary>
        /// 通过SQL插入多条数据(带实体)，返回结果是影响行数。
        /// </summary>
        /// <returns></returns>
        public int? InsertWithSqlD()
        {
            using (var conn = GetCon())
            {
                conn.Open();
                string strSql = "INSERT INTO Student (Name,Age,Gender) VALUES (@Name,@Age,@Gender)";
                List<Student> list = new List<Student>();
                for (int i = 0; i < 3; i++)
                {
                    Student student = new Student
                    {
                        Name = "World" + i.ToString(),
                        Age = 18,
                        Gender = "male"
                    };
                    list.Add(student);
                }
                return conn.Execute(strSql, list);
            }
        }
```



  b）通过实体插入数据，返回结果是主键值。





```
        /// <summary>
        /// 通过实体插入数据，返回结果是主键值。
        /// </summary>
        /// <returns></returns>
        public int? InsertWithEntity()
        {
            using (var conn = GetCon())
            {
                conn.Open();
                var entity = new Student { Name = "World", Age = 18, Gender = "male" };
                return conn.Insert(entity);
            }
        }
```



####   3.3、Read

  a1）通过SQL查询数据（查询所有数据）





```
        /// <summary>
        /// 通过SQL查询数据(查询所有数据)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> GetStudentList1()
        {
            string strSql = "SELECT * FROM Student";
            using (var conn = GetCon())
            {
                conn.Open();
                return conn.Query<Student>(strSql);
            }
        }
```



  a2）通过SQL查询数据（带参数）





```
        /// <summary>
        /// 通过SQL查询数据(带参数)
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public Student GetStudentList1A(int studentID)
        {
            string strSql = "SELECT * FROM Student WHERE StudentID=@StudentID";
            using (var conn = GetCon())
            {
                conn.Open();
                return conn.Query<Student>(strSql, new { StudentID = studentID }).FirstOrDefault();
            }
        }
```



  a3）通过SQL查询数据（IN）





```
        /// <summary>
        /// 通过SQL查询数据(IN)
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public IEnumerable<Student> GetStudentList1B(string studentID)
        {
            string strSql = "SELECT * FROM Student WHERE StudentID IN @StudentID";
            var idArr = studentID.Split(',');
            using (var conn = GetCon())
            {
                conn.Open();
                return conn.Query<Student>(strSql, new { StudentID = idArr });
            }
        }
```



  b1）通过实体查询数据（查询所有数据）





```
        /// <summary>
        /// 通过实体询数据(查询所有数据)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> GetStudentList2()
        {
            using (var conn = GetCon())
            {
                conn.Open();
                return conn.GetList<Student>();
            }
        }
```



  b2）通过实体查询数据（指定ID）





```
        /// <summary>
        /// 通过实体询数据(指定ID)
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public Student GetStudentList2A(int studentID)
        {
            using (var conn = GetCon())
            {
                conn.Open();
                return conn.Get<Student>(studentID);
            }
        }
```



  b3）通过实体查询数据（带参数）





```
        /// <summary>
        /// 通过实体询数据(带参数)
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public Student GetStudentList2B(int studentID)
        {
            using (var conn = GetCon())
            {
                conn.Open();
                return conn.GetList<Student>(new { StudentID = studentID }).FirstOrDefault();
            }
        }
```



  c1）多表查询(QueryMultiple)，主要操作：通过QueryMultiple方法，返回查询中每条SQL语句的数据集合。





```
        /// <summary>
        /// 多表查询(QueryMultiple)
        /// </summary>
        /// <returns></returns>
        public string GetMultiEntityA()
        {
            string strSql = "SELECT * FROM Student AS A;SELECT * FROM Teacher AS A";
            StringBuilder sbStudent = new StringBuilder();
            StringBuilder sbTeacher = new StringBuilder();
            using (var conn = GetCon())
            {
                conn.Open();
                var grid = conn.QueryMultiple(strSql);
                var students = grid.Read<Student>();
                var teachers = grid.Read<Teacher>();
                foreach (var item in students)
                {
                    sbStudent.Append($"StudentID={item.StudentID} Name={item.Name} Age={item.Age} Gender={item.Gender}\n");
                }
                foreach (var item in teachers)
                {
                    sbTeacher.Append($"TeacherID={item.TeacherID} Name={item.Name}\n");
                }
                return sbStudent.ToString() + sbTeacher.ToString();
            }
        }
```



  c2）多表查询(Query)，主要操作：通过SQL进行多表关联查询，返回查询结果的数据集合。





```
        /// <summary>
        /// 多表查询(Query)
        /// </summary>
        /// <returns></returns>
        public string GetMultiEntityB()
        {
            string strSql = "SELECT A.Name CourseName,B.Name TeacherName FROM Course A INNER JOIN Teacher B ON A.TeacherID=B.TeacherID";
            StringBuilder sbResult = new StringBuilder();
            using (var conn = GetCon())
            {
                conn.Open();
                var query = conn.Query(strSql);
                query.AsList().ForEach(q =>
                {
                    sbResult.Append($"CourseName={q.CourseName} TeacherName={q.TeacherName}\n");
                });
                return sbResult.ToString();
            }
        }
```



####   3.4、Update

  a1）通过SQL更新数据(带参数)，返回结果是影响行数。





```
        /// <summary>
        /// 通过SQL更新数据(带参数)，返回结果是影响行数。
        /// </summary>
        /// <returns></returns>
        public int? UpdateWithSqlA()
        {
            using (var conn = GetCon())
            {
                conn.Open();
                string strSql = "UPDATE Student SET Name=@Name,Age=@Age,Gender=@Gender WHERE StudentID=@StudentID";
                return conn.Execute(strSql, new { Name = "World3", Age = 19, Gender = "female", StudentID = 17 });
            }
        }
```



  a2）通过SQL插入单条数据(带实体)，返回结果是影响行数。





```
        /// <summary>
        /// 通过SQL更新数据(带实体)，返回结果是影响行数。
        /// </summary>
        /// <returns></returns>
        public int? UpdateWithSqlB()
        {
            using (var conn = GetCon())
            {
                conn.Open();
                string strSql = "UPDATE Student SET Name=@Name,Age=@Age,Gender=@Gender WHERE StudentID=@StudentID";
                Student student = new Student
                {
                    StudentID = 17,
                    Name = "World3",
                    Age = 18,
                    Gender = "male"
                };
                return conn.Execute(strSql, student);
            }
        }
```



  b）通过实体更新数据，返回结果是影响行数。





```
        /// <summary>
        /// 通过实体更新数据，返回结果是影响行数。
        /// </summary>
        /// <returns></returns>
        public int? UpdateWithEntity()
        {
            using (var conn = GetCon())
            {
                conn.Open();
                var entity = new Student { StudentID = 17, Name = "World4", Age = 18, Gender = "male" };
                return conn.Update(entity);
            }
        }
```



####   3.5、Delete

  a）通过SQL删除数据(带参数)，返回结果是影响行数。





```
        /// <summary>
        /// 通过SQL删除数据(带参数)，返回结果是影响行数。
        /// </summary>
        /// <returns></returns>
        public int? DeleteWithSql()
        {
            using (var conn = GetCon())
            {
                conn.Open();
                string strSql = "DELETE FROM Student WHERE StudentID=@StudentID";
                return conn.Execute(strSql, new { StudentID = 16 });
            }
        }
```



  b）通过实体删除数据，返回结果是影响行数。





```
        /// <summary>
        /// 通过实体删除数据，返回结果是影响行数。
        /// </summary>
        /// <returns></returns>
        public int? DeleteWithEntity()
        {
            using (var conn = GetCon())
            {
                conn.Open();
                var entity = new Student { StudentID = 17 };
                return conn.Delete(entity);
            }
        }
```



##   四、Procedure

  4.1、带输出参数的存储过程





```
CREATE PROCEDURE [dbo].[GetStudentAge]
    @StudentID INT,
    @Name NVARCHAR(50) OUTPUT
AS
BEGIN
    DECLARE @Age SMALLINT
    SELECT @Name=Name,@Age=Age FROM Student WHERE StudentID=@StudentID
    SELECT @Age
END
```







```
        /// <summary>
        /// 带输出参数的存储过程
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public Tuple<string, int> GetStudentAge(int studentID)
        {
            int age = 0;
            var para = new DynamicParameters();
            para.Add("StudentID", 1);
            para.Add("Name", string.Empty, DbType.String, ParameterDirection.Output);

            using (var conn = GetCon())
            {
                conn.Open();
                age = conn.Query<int>("GetStudentAge", para, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return Tuple.Create(para.Get<string>("Name"), age);
        }
```



##   五、Transaction

  5.1、在IDbConnection下事务，主要操作：在执行Insert方法时传入Transaction；在正常情况下Commit事务；在异常时回滚事务。





```
        /// <summary>
        /// 在IDbConnection下事务
        /// </summary>
        /// <returns></returns>
        public bool InsertWithTran()
        {
            using (var conn = GetCon())
            {
                conn.Open();
                int studentID = 0, teacherID = 0, result = 0;
                var student = new Student { Name = "Sandy", Age = 18, Gender = "female" };
                var teacher = new Teacher { Name = "Luci" };
                var tran = conn.BeginTransaction();
                try
                {
                    studentID = conn.Insert(student, tran).Value;
                    result++;
                    teacherID = conn.Insert(teacher, tran).Value;
                    result++;
                    tran.Commit();
                }
                catch
                {
                    result = 0;
                    tran.Rollback();
                }
                return result > 0;
            }
        }
```



  5.2、在存储过程下事务，主要操作：在存储过程中进行事务；通过DynamicParameters传递参数给存储过程；通过Query调用存储过程。





```
CREATE PROCEDURE [dbo].[InsertData]
    --Student
    @StudentName NVARCHAR(50),
    @Age SMALLINT,
    @Gender NVARCHAR(10),
    --Teacher
    @TeacherName NVARCHAR(50)
AS
BEGIN
    --变量定义
    DECLARE @Result BIT=1    --结果标识
    
    --事务开始
    BEGIN TRANSACTION

    --数据插入
    INSERT INTO Student (Name,Age,Gender) VALUES (@StudentName,@Age,@Gender)
    INSERT INTO Teacher (Name) VALUES (@TeacherName)
    
    --事务执行
    IF @@ERROR=0
    BEGIN
        COMMIT TRANSACTION
    END
    ELSE
    BEGIN
        SET @Result=0
        ROLLBACK TRANSACTION
    END

    --结果返回
    SELECT @Result
END
```







```
        /// <summary>
        /// 在存储过程下事务
        /// </summary>
        /// <returns></returns>
        public bool InsertWithProcTran()
        {
            var para = new DynamicParameters();
            para.Add("StudentName", "Hanmeimei");
            para.Add("Age", 18);
            para.Add("Gender", "female");
            para.Add("TeacherName", "Angel");

            using (var conn = GetCon())
            {
                conn.Open();
                return conn.Query<bool>("InsertData", para, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
```



##   六、Paging

  6.1、简单分页





```
        /// <summary>
        /// 简单分页
        /// </summary>
        /// <param name="beginRowNum"></param>
        /// <param name="endRowNum"></param>
        /// <returns></returns>
        public IEnumerable<Student> GetPaging(int beginRowNum = 1, int endRowNum = 5)
        {
            string strSql =
                    "SELECT * FROM " +
                        "( " +
                            "SELECT A.*, ROW_NUMBER() OVER(ORDER BY A.StudentID) RowNum " +
                            "FROM Student AS A " +
                        ") B " +
                    "WHERE B.RowNum BETWEEN @BeginRowNum AND @EndRowNum " +
                    "ORDER BY B.RowNum ";

            using (var conn = GetCon())
            {
                return conn.Query<Student>(strSql, new { BeginRowNum = beginRowNum, EndRowNum = endRowNum });
            }
        }
```



  6.2、通用分页





```
CREATE PROCEDURE [dbo].[PageList]
     @TableName VARCHAR(200),       --表名
     @FieldName VARCHAR(500) = '*', --字段名
     @Where VARCHAR(100) = NULL,    --条件语句
     @GroupBy VARCHAR(100) = NULL,  --分组字段
     @OrderBy VARCHAR(100),         --排序字段
     @PageIndex INT = 1,            --当前页数
     @PageSize INT = 20,            --每页显示记录数
     @TotalCount INT = 0 OUTPUT     --总记录数
AS
BEGIN
    --SQL拼接语句
    DECLARE @SQL NVARCHAR(4000)

    --总记录数
    SET @SQL='SELECT @RecordCount=COUNT(1) FROM ' + @TableName
    IF (ISNULL(@Where,'')<>'')
        SET @SQL=@SQL+' WHERE '+@Where
    ELSE IF (ISNULL(@GroupBy,'')<>'')
        SET @SQL=@SQL+' GROUP BY '+@GroupBy

    EXEC SP_EXECUTESQL @SQL,N'@RecordCount INT OUTPUT',@TotalCount OUTPUT

    --总页数
    DECLARE @PageCount INT
    SELECT @PageCount=CEILING((@TotalCount+0.0)/@PageSize)
    
    --简单分页
    SET @SQL='SELECT * FROM (SELECT ROW_NUMBER() OVER (ORDER BY '+@OrderBy+') AS RowNum,' + @FieldName + ' FROM '+@TableName+' AS A'
    IF (ISNULL(@Where,'')<>'')
        SET @SQL=@SQL+' WHERE '+@Where
    ELSE IF (ISNULL(@GroupBy,'')<>'')
        SET @SQL=@SQL+' GROUP BY '+@GroupBy

    IF (@PageIndex<=0)
        SET @PageIndex=1
    IF @PageIndex>@PageCount
        SET @PageIndex=@PageCount
     
    DECLARE @BeginRowNum INT,@EndRowNum INT  
    SET @BeginRowNum=(@PageIndex-1)*@PageSize+1
    SET @EndRowNum=@BeginRowNum+@PageSize-1

    SET @SQL=@SQL + ') AS B WHERE B.RowNum BETWEEN '+CONVERT(VARCHAR(32),@BeginRowNum)+' AND '+CONVERT(VARCHAR(32),@EndRowNum)
    EXEC(@SQL)
END
```







```
        /// <summary>
        /// 通用分页
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetCommonPaging<T>(string tableName, string fieldName, string where, string groupby, string orderby, int pageIndex, int pageSize)
        {
            var para = new DynamicParameters();
            para.Add("TableName", tableName);
            para.Add("FieldName", fieldName);
            para.Add("Where", where);
            para.Add("GroupBy", groupby);
            para.Add("OrderBy", orderby);
            para.Add("PageIndex", pageIndex);
            para.Add("PageSize", pageSize);
            para.Add("TotalCount", dbType: DbType.Int32, direction: ParameterDirection.Output);

            using (var conn = GetCon())
            {
                conn.Open();
                return conn.Query<T>("PageList", para, commandType: CommandType.StoredProcedure);
            }
        }
```

