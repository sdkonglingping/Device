# SqlServer存储过程应用二：分页查询数据并动态拼接where条件

**目录**

- 前言

- 创建存储过程并执行

- - 1、创建带参的存储过程
  - 2、定义一个参数，用于接受拼接后的sql语句
  - 3、创建一个临时表，用于存储查询拼接条件后的结果集
  - 4、分页查询返回最终的sql语句和总行数，查询条件加上临时表的数据，最后删除临时表

- 完整存储过程代码

- 调用存储过程

- - 1、没有动态拼接where条件
  - 2、有动态拼接where条件

 

------

**前言**

开发中查询功能是贯穿全文的，我们来盘一盘使用存储过程分页查询，并且支持动态拼接where条件。

划重点：**支持动态拼接where条件**

对存储过程的使用有疑问的同学去【SqlServer存储过程的创建与使用】补补课。

至于大家是使用自定义sql查询还是相关ORM框架查询就不讨论了，我们就简单介绍存储过程的查询（自定义sql查询）。

 

------

 **创建存储过程并执行**

流程图如下，我们根据流程图进行代码实现。

![img](https://oss-emcsprod-public.modb.pro/wechatSpider/modb_20210524_8f1b9268-bc60-11eb-807e-00163e068ecd.png)

 

------



## 1、创建带参的存储过程

>  
>
> 创建带参数的存储过程首先要在存储过程中声明该参数，每个存储过程参数都必须用惟一的名称进行定义。
>
> 与标准的Transact-SQL变量相同，参数名必须以@为前缀，并且遵从对象标识符规则。
>
> 当用户不提供该参数的值时可以使用一个默认值来代替。
>
> 在执行带参数的存储过程时，既可以通过显式指定参数名称并赋予适当的值，也可以通过提供在CREATE PROCEDURE语句中给定的参数值（不指定参数名称）来向存储过程传递值。
>
> 在存储过程PRO_Student_IN中命名4个参数，其定义顺序为@Chinese、@English、@maths和@class。
>
> 例如，将值传递给存储过程指定的参数名称。
>
> EXEC PRO_Student_IN @class=&quot;三年一班&quot;,@Chinese=85,@maths=85,@English=85
>
> 例如，按照参数的位置传递，而不命名参数名称。
>
> EXEC PRO_Student_IN 85,85,85,&quot;三年一班&quot;

 



## 2、定义一个参数，用于接受拼接后的sql语句

> 通过指定过程参数，调用程序可以将值传递给过程的主体。
>
> 如果将参数标记为 OUTPUT 参数，则过程参数还可以将值返回给调用程序。
>
> 一个过程最多可以有 2100 个参数，每个参数都有名称、数据类型和方向。 还可以为参数指定默认值（可选）。
>
> 使用过程调用提供的参数值必须为常量或变量，不能将函数名称作为参数值。 变量可以是用户定义的变量或系统变量（如 @@spid）。
>
> 1. 需要指定参数名称；
> 2. 指定参数数据类型；
> 3. 可以指定参数默认值；
> 4. 可以指定参数方式(默认为输入参数)。

 



## 3、创建一个临时表，用于存储查询拼接条件后的结果集

> 临时表与永久表相似，但临时表存储在tempdb中，当不再使用时会自动删除。临时表有两种类型：本地和全局。它们在名称、可见性以及可用性上有区别。
>
> 对于临时表有如下几个特点：
>
> - 本地临时表就是用户在创建表的时候添加了“#”前缀的表，其特点是根据数据库连接独立。只有创建本地临时表的数据库连接有表的访问权限，其它连接不能访问该表；
> - 不同的数据库连接中，创建的本地临时表虽然“名字”相同，但是这些表之间相互并不存在任何关系；
> - 在SQLSERVER中，通过特别的命名机制保证本地临时表在数据库连接上的独立性。
>
> 真正的临时表利用了数据库临时表空间，由数据库系统自动进行维护，因此节省了表空间。并且由于临时表空间一般利用虚拟内存，大大减少了硬盘的I/O次数，因此也提高了系统效率。
>
> 临时表在事务完毕或会话完毕数据自动清空，不必记得用完后删除数据。
>
> 本地临时表
>
> - 本地临时表的名称以单个数字符号 (#) 打头；
> - 它们仅对当前的用户连接（也就是创建本地临时表的connection）是可见的；
> - 当用户从 SQL Server 实例断开连接时被删除。



## 4、分页查询返回最终的sql语句和总行数，查询条件加上临时表的数据，最后删除临时表

> Sqlserver数据库分页查询一直是Sqlserver的短板，分页方式也有好几种，假设有表ARTICLE,字段ID、YEAR...(其他省略)，
>
> 数据53210条(客户真实数据，量不大)，分页查询每页30条，查询第1500页（即第45001-45030条数据），字段ID聚集索引，YEAR无索引。
>
> 
> **第一种方案**、最简单、普通的方法：
>
> ```
> SELECT TOP 30 * FROM ARTICLE WHERE ID NOT IN(SELECT TOP 45000 ID FROM ARTICLE ORDER BY YEAR DESC, ID DESC) ORDER BY YEAR DESC,ID DESC
> ```
>
> 平均查询100次所需时间：45s
>
>  
>
> **第二种方案：**
>
> ```
> SELECT * FROM (　　SELECT TOP 30 * FROM (SELECT TOP 45030 * FROM ARTICLE ORDER BY YEAR DESC, ID DESC) f ORDER BY f.YEAR ASC, f.ID DESC) s ORDER BY s.YEAR DESC,s.ID DESC 
> ```
>
> 平均查询100次所需时间：138S
>
>  
>
> **第三种方案：**
>
> SELECT * FROM ARTICLE w1,
>
> ```
> (
>     SELECT TOP 30 ID FROM 
>     (
>         SELECT TOP 50030 ID, YEAR FROM ARTICLE ORDER BY YEAR DESC, ID DESC
>     ) w ORDER BY w.YEAR ASC, w.ID ASC
> ) w2 WHERE w1.ID = w2.ID ORDER BY w1.YEAR DESC, w1.ID DESC
> ```
>
> 平均查询100次所需时间：21S
>
>  
>
> **第四种方案：**
>
> ```
> SELECT * FROM ARTICLE w1 
>     WHERE ID in 
>         (
>             SELECT top 30 ID FROM 
>             (
>                 SELECT top 45030 ID, YEAR FROM ARTICLE ORDER BY YEAR DESC, ID DESC
>             ) w ORDER BY w.YEAR ASC, w.ID ASC
>         ) 
>     ORDER BY w1.YEAR DESC, w1.ID DESC
> ```
>
> 平均查询100次所需时间：20S
>
>  
>
> **第五种方案：**
>
> ```
> SELECT w2.n, w1.* FROM ARTICLE w1, (　　SELECT TOP 50030 row_number() OVER (ORDER BY YEAR DESC, ID DESC) n, ID FROM ARTICLE ) w2 WHERE w1.ID = w2.ID AND w2.n > 50000 ORDER BY w2.n ASC 
> ```
>
> 平均查询100次所需时间：15S

------



# 完整存储过程代码



```
/**author：熊泽        date：2021-04-16    project：SqlServer存储过程应用二：分页查询数据并动态拼接where条件*/
--创建一个查询学生的存储过程
CREATE PROCEDURE ProcedureStudent
    @pageIndex INT ,        --当前页（如1：第1页）
    @pageCount INT,            --每页条数（如50：每页50条）
    @rowTotal INT OUTPUT ,    --返回的总行数 
    @strWhere VARCHAR(5000) --程序动态拼接的sql查询条件
AS
BEGIN
    /**begin创建拼接动态条件 */
    DECLARE @sq_temp AS VARCHAR(2000)  --定义拼接后的sql语句
    CREATE TABLE #temp (  --创建一个拼接查询条件查询出来的结果用于做子查询
        Number VARCHAR(50)
    )


    SET @sq_temp ='SELECT Number FROM a_Students where 1 = 1 '
                + CASE WHEN ISNULL(@strWhere,'') = '' THEN '' ELSE @strWhere END --动态拼接的条件


    --将拼接的条件写入临时表
    INSERT INTO #temp (Number) EXEC (@sq_temp);


    /**end创建拼接动态条件 */




     --分页查询语句sql
     SELECT * FROM (SELECT  
                        row_number()over (order by a.Number desc)Id,
                        a.Number 学号 ,
                        a.Name 姓名 ,
                        b.ClassName 班级 ,
                        c.Java ,
                        c.Python ,
                        c.C# ,
                        c.SqlDB
                FROM    a_Students a
                        LEFT JOIN a_StudentClass b ON a.ClassId = b.ClassId
                        LEFT JOIN a_StudentsScore c ON a.Number = c.Number
                        WHERE  a.Number IN (SELECT  Number FROM #temp)
                       )temp 
       WHERE temp.Id between (@pageIndex-1)*@pageCount+1 and @pageIndex*@pageCount;


       --返回总条数
       SELECT  @rowTotal=COUNT(*)  FROM dbo.a_Students WHERE Number IN (SELECT  Number FROM #temp)


       DROP TABLE #temp  --删除临时表
END
GO
```

------



# 调用存储过程

**1、没有****动态拼接where条件**



```
--调用分页存储过程，没有where条件
DECLARE @total INT 
EXEC ProcedureStudent 1,5,@total OUT,''
SELECT @total 返回的总行数
```

![img](https://oss-emcsprod-public.modb.pro/wechatSpider/modb_20210524_8f37cca8-bc60-11eb-807e-00163e068ecd.png)



**2、有动态拼接where条件**



```
--调用分页存储过程，有where条件：学号为100014的数据
DECLARE @total INT 
EXEC ProcedureStudent 1,5,@total OUT,' and Number=''100014'''  --动态拼接条件：学号为100014的数据
SELECT @total 返回的总行数
```

![img](https://oss-emcsprod-public.modb.pro/wechatSpider/modb_20210524_8f736452-bc60-11eb-807e-00163e068ecd.png)

 

------

 