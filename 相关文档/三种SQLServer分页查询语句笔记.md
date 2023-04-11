# 三种SQLServer分页查询语句笔记





作为程序员来说，与数据库打交道是十分频繁的分页查询是一个开发者必须掌握的基本知识点，目前整理了下面三种SQLServer分页查询语句的写法，仅供参考。

**一、Top Not IN 方式（查询靠前的数据较快）**

语法格式：

select top pageSize 列名  from tablename

select top 条数 * from tablename

where Id not in (select top pageSize*(pageIndex-1)  Id from tablename)

示例：

SELECT TOP 2  * FROM Users

WHERE Id NOT IN (SELECT TOP 2

Id FROM Users)

**二、ROW_NUMBER() OVER()方式  （查询靠后的数据速度比上一种较快）**

语法格式：

SELECT * FROM (SELECT *,

ROW_NUMBER() OVER(Order by Id ) AS RowNumber from tablename ) as b

where RowNumber between pageIndex-1*pageSize and pageIndex*pageSize

示例：

SELECT* FROM (

SELECT*,ROW_NUMBER() OVER (ORDER BY Id) AS RowNumber FROM Users ) as b

where RowNumber BETWEEN 0 and 3

**三、offset fetch next方式 （速度优于前两者，限制Sql2012以上可以使用）**

语法格式：

select * from tablename

order by Id offset pageIndex row fetch next pageSize row only

示例：

select * from Users  order by Id offset 2 row fetch next 5 row only

**四、一个比较好用的分页存储过程**

create PROCEDURE GetPageData

(

@TableName varchar(30),--表名称

@IDName varchar(20),--表主键名称

@PageIndex int,--当前页数

@PageSize int--每页大小

)

AS

IF @PageIndex > 0

BEGIN

set nocount on

DECLARE @PageLowerBound int,@StartID int,@sql nvarchar(225)

SET @PageLowerBound = @PageSize * (@PageIndex-1)

IF @PageLowerBound<1

SET @PageLowerBound=1

SET ROWCOUNT @PageLowerBound

SET @sql=N'SELECT @StartID = ['+@IDName+'] FROM '+@TableName+' ORDER BY '+@IDName

exec sp_executesql @sql,N'@StartID int output',@StartID output

SET ROWCOUNT 0

SET @sql='select top '+str(@PageSize) +' * from '+@TableName+' where ['+@IDName+']>='+ str(@StartID) +' ORDER BY ['+@IDName+'] '

EXEC(@sql)

set nocount off

END