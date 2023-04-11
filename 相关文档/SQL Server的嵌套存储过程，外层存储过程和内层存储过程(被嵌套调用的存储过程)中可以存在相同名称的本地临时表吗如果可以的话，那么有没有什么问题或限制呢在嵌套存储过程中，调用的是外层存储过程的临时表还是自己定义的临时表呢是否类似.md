SQL Server的嵌套存储过程，外层存储过程和内层存储过程(被嵌套调用的存储过程)中可以存在相同名称的本地临时表吗?如果可以的话，那么有没有什么问题或限制呢?在嵌套存储过程中，调用的是外层存储过程的临时表还是自己定义的临时表呢?是否类似高级语言的变量一样，本地临时表有没有“作用域“范围呢?

注意：也可以称呼为父存储过程和子存储过程，外层存储过程和内层存储过程...。这些只是不同的称呼或叫法而已。我们这里统一使用外层存储过程和内层存储过程。后续文章部分不再述说。

我们先来看一个例子，如下所示，我们构造一个简单的例子。

```
IF EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PRC_TEST') AND OBJECTPROPERTY(object_id, 'IsProcedure') =1) 
BEGIN 
 DROP PROCEDURE dbo.PRC_TEST 
END 
GO 
CREATE PROC dbo.PRC_TEST 
AS 
BEGIN 
 
 CREATE TABLE #tmp_test(id INT); 
 
 INSERT INTO #tmp_test 
 SELECT 1; 
 
 SELECT * FROM #tmp_test; 
 
 EXEC PRC_SUB_TEST 
 
 SELECT * FROM #tmp_test 
  
 
END 
GO 
 
 
 
IF EXISTS(SELECT 1 FROM sys.objects WHERE object_id= OBJECT_ID(N'dbo.PRC_SUB_TEST' ) AND OBJECTPROPERTY(object_id, 'IsProcedure')=1) 
BEGIN 
 DROP PROCEDURE dbo.PRC_SUB_TEST; 
END 
GO 
 
 
CREATE PROCEDURE dbo.PRC_SUB_TEST 
AS 
BEGIN 
     
 CREATE TABLE #tmp_test(name VARCHAR(128)); 
 
 INSERT INTO #tmp_test 
 SELECT name FROM sys.objects 
 
 SELECT * FROM #tmp_test; 
END 
GO 
 
 
EXEC PRC_TEST; 
```

![img](https://s3.51cto.com/oss/202102/08/252e808c4d5414c3e7a8971c80c3519e.jpg)

简单测试似乎正常，并没有发现什么问题。如果此时你就下一个结论的话，那么就为时过早了!打个比方，你看见一只天鹅是白色的，如果你下了一个定论：“所有天鹅都是白色的”，其实这个世界真的有黑天鹅，只是你没有见过而已!如下所示，我们修改一下存储过程dbo.PRC_SUB_TEST，使用字段名name替换*，如下所示：

```
IF EXISTS(SELECT 1 FROM sys.objects WHERE object_id= OBJECT_ID(N'dbo.PRC_SUB_TEST' ) AND OBJECTPROPERTY(object_id, 'IsProcedure')=1) 
BEGIN 
 DROP PROCEDURE dbo.PRC_SUB_TEST; 
END 
GO 
 
CREATE PROCEDURE dbo.PRC_SUB_TEST 
AS 
BEGIN 
     
 CREATE TABLE #tmp_test(name VARCHAR(128)); 
 
 INSERT INTO #tmp_test 
 SELECT name FROM sys.objects 
 
 SELECT name FROM #tmp_test; 
END 
GO 
```

![img](https://s5.51cto.com/oss/202102/08/630e8b305ef37e77f78d64fc7743416c.jpg)

此时只要先我执行一次存储过程dbo.PRC_SUB_TEST，然后再去执行存储过程dbo.PRC_TEST就不会报错了。而且只要执行过一次这个存储过程，然后在当前会话或其它任何会话执行dbo.PRC_TEST都不会报错了。是否非常让人迷惑或不解。

```
EXEC dbo.PRC_SUB_TEST; 
EXEC PRC_TEST; 
```

如果你要再次重现这个现象的话，只能通过下面SQL或者删除/重建存储过程的方式，才能重现这个现象。似乎有点幽灵现象的感觉。

```
DBCC FREEPROCCACHE 
```

关于这个现象，官方文档(详见参考资料的链接地址)有这么一段描述：

A local temporary table created within a stored procedure or trigger can have the same name as a temporary table that was created before the stored procedure or trigger is called. However, if a query references a temporary table and two temporary tables with the same name exist at that time, it is not defined which table the query is resolved against. Nested stored procedures can also create temporary tables with the same name as a temporary table that was created by the stored procedure that called it. However, for modifications to resolve to the table that was created in the nested procedure, the table must have the same structure, with the same column names, as the table created in the calling procedure. This is shown in the following example.

在存储过程或触发器中创建的本地临时表的名称可以与在调用存储过程或触发器之前创建的临时表名称相同。但是，如果查询引用临时表，而同时有两个同名的临时表，则不定义针对哪个表解析该查询。嵌套存储过程同样可以创建与调用它的存储过程所创建的临时表同名的临时表。但是，为了对其进行修改以解析为在嵌套过程中创建的表，此表必须与调用过程创建的表具有相同的结构和列名。下面的示例说明了这一点。

```
CREATE PROCEDURE dbo.Test2 
AS 
    CREATE TABLE #t(x INT PRIMARY KEY); 
    INSERT INTO #t VALUES (2); 
    SELECT Test2Col = x FROM #t; 
GO 
 
CREATE PROCEDURE dbo.Test1 
AS 
    CREATE TABLE #t(x INT PRIMARY KEY); 
    INSERT INTO #t VALUES (1); 
    SELECT Test1Col = x FROM #t; 
EXEC Test2; 
GO 
 
CREATE TABLE #t(x INT PRIMARY KEY); 
INSERT INTO #t VALUES (99); 
GO 
 
EXEC Test1; 
GO 
```

官方文档中“同时有两个同名的临时表，则不定义针对哪个表解析该查询”这种阐述感觉还是让人有点迷糊。这里简单解释一下，在存储过程的嵌套调用中，允许外层过程和内层存储过程中存在相同名字的本地临时表，但是在内存过程中，如果要对其进行修改或解析(修改很好理解，例如新增索引，增加字段等这类DDL操作;关于解析，查询临时表，SQL中指定字段名，就需要解析resolve)，那么此时这个临时表必须表结构一致，否则就会报错。官方文档，就是这么一句话，告诉你不行，但是具体原因没有说。那么我们不妨做一些推测，在存储过程的嵌套调用中，是否创建了两个本地临时表呢?有没有可能实际只创建了一个本地临时表呢?出现本地临时表重用的情况呢?那么我们简单验证一下，如下所示，这里可以判断实际上创建了两个本地临时表。并没有出现临时表重用的情况。

```
SELECT *  
FROM sys.dm_os_performance_counters 
WHERE counter_name LIKE 'Temp Tables Creation Rate%'; 
 
EXEC PRC_TEST; 
 
SELECT *  
FROM sys.dm_os_performance_counters 
WHERE counter_name LIKE 'Temp Tables Creation Rate%'; 
```

![img](https://s3.51cto.com/oss/202102/08/ae6f06dd1f2f4bbe9cadcea8741a2a55.jpg)

当然你可以用下面SQL来进行验证，跟上面验证的结果一致。

```
IF EXISTS(SELECT 1 FROM sys.objects WHERE object_id= OBJECT_ID(N'dbo.PRC_SUB_TEST' ) AND OBJECTPROPERTY(object_id, 'IsProcedure')=1) 
BEGIN 
 DROP PROCEDURE dbo.PRC_SUB_TEST; 
END 
GO 
 
 
CREATE PROCEDURE dbo.PRC_SUB_TEST 
AS 
BEGIN 
     
 SELECT * FROM #tmp_test; 
 
 SELECT *  FROM tempdb.dbo.sysobjects WHERE name LIKE '#tmp_test%' 
 CREATE TABLE #tmp_test(name VARCHAR(128)); 
 
 INSERT INTO #tmp_test 
 SELECT name FROM sys.objects 
 SELECT *  FROM tempdb.dbo.sysobjects WHERE name LIKE '#tmp_test%' 
 SELECT * FROM #tmp_test; 
END 
GO 
```

然后我们来看看临时表的“作用域”，抱歉我用这么一个概念，官方文档是没有这个概念，这个只是我们思考的一个方面，细节方面没有必要抬杠。如下所示，我们修改一下存储过程

```
IF EXISTS(SELECT 1 FROM sys.objects WHERE object_id= OBJECT_ID(N'dbo.PRC_SUB_TEST' ) AND OBJECTPROPERTY(object_id, 'IsProcedure')=1) 
BEGIN 
 DROP PROCEDURE dbo.PRC_SUB_TEST; 
END 
GO 
CREATE PROCEDURE dbo.PRC_SUB_TEST 
AS 
BEGIN 
     
 SELECT * FROM #tmp_test; 
 CREATE TABLE #tmp_test(name VARCHAR(128)); 
 
 INSERT INTO #tmp_test 
 SELECT name FROM sys.objects 
 
 SELECT * FROM #tmp_test; 
END 
GO 
```

通过实验验证，我们发现外层存储过程的临时表在内层存储过程中有效，它的“作用域”是在内层存储过程的同名临时表创建之前， 这个跟高级语言中的全局变量和局部变量作用域有点类似。

[![img](https://s2.51cto.com/oss/202102/08/1018df88447d49a76d12e50dec68b28c.jpg)](https://s2.51cto.com/oss/202102/08/1018df88447d49a76d12e50dec68b28c.jpg)

 

既然创建了两个本地临时表，那么为什么修改或解析的时候就会报错呢?个人的一个猜测是，优化器解析过后，在执行过程中，解析或修改的时候，数据库引擎无法判断或者代码里面没有这种逻辑去控制检索哪一个临时表。有可能是代码里面的一个缺陷亦或是某种逻辑原因导致。上述仅仅是个人的一个猜测、推理。如有不足或不对的地方，敬请指正。