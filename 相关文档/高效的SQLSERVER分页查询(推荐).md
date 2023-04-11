# 高效的SQLSERVER分页查询(推荐)

2014-11-02 4030举报

**简介：** 原文:高效的SQLSERVER分页查询(推荐) Sqlserver数据库分页查询一直是Sqlserver的短板，闲来无事，想出几种方法，假设有表ARTICLE,字段ID、YEAR...(其他省略)，数据53210条(客户真实数据，量不大)，分页查询每页30条，查询第1500页（即第45001-450...





Sqlserver数据库分页查询一直是Sqlserver的短板，闲来无事，想出几种方法，假设有表ARTICLE,字段ID、YEAR...(其他省略)，数据53210条(客户真实数据，量不大)，分页查询每页30条，查询第1500页（即第45001-45030条数据），字段ID聚集索引，YEAR无索引，Sqlserver版本：2008R2

**第一种方案、最简单、普通的方法：**



```
SELECT TOP 30 * FROM ARTICLE WHERE ID NOT IN(SELECT TOP 45000 ID FROM ARTICLE ORDER BY YEAR DESC, ID DESC) ORDER BY YEAR DESC,ID DESC  
```

 

 

   平均查询100次所需时间：45s

**第二种方案：**



```
SELECT * FROM (　　SELECT TOP 30 * FROM (SELECT TOP 45030 * FROM ARTICLE ORDER BY YEAR DESC, ID DESC) f ORDER BY f.YEAR ASC, f.ID DESC) s ORDER BY s.YEAR DESC,s.ID DESC  
```

 

   平均查询100次所需时间：138S

**第三种方案：**



```
SELECT * FROM ARTICLE w1, 
(
    SELECT TOP 30 ID FROM 
    (
        SELECT TOP 50030 ID, YEAR FROM ARTICLE ORDER BY YEAR DESC, ID DESC
    ) w ORDER BY w.YEAR ASC, w.ID ASC
) w2 WHERE w1.ID = w2.ID ORDER BY w1.YEAR DESC, w1.ID DESC
```

   平均查询100次所需时间：21S

**第四种方案：**



```
SELECT * FROM ARTICLE w1 
    WHERE ID in 
        (
            SELECT top 30 ID FROM 
            (
                SELECT top 45030 ID, YEAR FROM ARTICLE ORDER BY YEAR DESC, ID DESC
            ) w ORDER BY w.YEAR ASC, w.ID ASC
        ) 
    ORDER BY w1.YEAR DESC, w1.ID DESC
```

   平均查询100次所需时间：20S

**第五种方案：**



```
SELECT w2.n, w1.* FROM ARTICLE w1, (　　SELECT TOP 50030 row_number() OVER (ORDER BY YEAR DESC, ID DESC) n, ID FROM ARTICLE ) w2 WHERE w1.ID = w2.ID AND w2.n > 50000 ORDER BY w2.n ASC  
```

   平均查询100次所需时间：15S

查询第1000-1030条记录

**第一种方案：**



```
SELECT TOP 30 * FROM ARTICLE WHERE ID NOT IN(SELECT TOP 1000 ID FROM ARTICLE ORDER BY YEAR DESC, ID DESC) ORDER BY YEAR DESC,ID DESC  
```

 

   平均查询100次所需时间：80s

**第二种方案：**



```
SELECT * FROM  ( 　　SELECT TOP 30 * FROM (SELECT TOP 1030 * FROM ARTICLE ORDER BY YEAR DESC, ID DESC) f ORDER BY f.YEAR ASC, f.ID DESC) s ORDER BY s.YEAR DESC,s.ID DESC  
```

  平均查询100次所需时间：30S

**第三种方案：**



```
SELECT * FROM ARTICLE w1, 
(
    SELECT TOP 30 ID FROM 
    (
        SELECT TOP 1030 ID, YEAR FROM ARTICLE ORDER BY YEAR DESC, ID DESC
    ) w ORDER BY w.YEAR ASC, w.ID ASC
) w2 WHERE w1.ID = w2.ID ORDER BY w1.YEAR DESC, w1.ID DESC
```

   平均查询100次所需时间：12S

**第四种方案：**



```
SELECT * FROM ARTICLE w1 
    WHERE ID in 
        (
            SELECT top 30 ID FROM 
            (
                SELECT top 1030 ID, YEAR FROM ARTICLE ORDER BY YEAR DESC, ID DESC
            ) w ORDER BY w.YEAR ASC, w.ID ASC
        ) 
    ORDER BY w1.YEAR DESC, w1.ID DESC
```

   平均查询100次所需时间：13S

**第五种方案：**



```
SELECT w2.n, w1.* FROM ARTICLE w1,( 　　SELECT TOP 1030 row_number() OVER (ORDER BY YEAR DESC, ID DESC) n, ID FROM ARTICLE) w2 WHERE w1.ID = w2.ID AND w2.n > 1000 ORDER BY w2.n ASC  
```

平均查询100次所需时间：14S

   由此可见在查询页数靠前时，效率3>4>5>2>1，页码靠后时5>4>3>1>2，再根据用户习惯，一般用户的检索只看最前面几页，因此选择3 4 5方案均可，若综合考虑方案5是最好的选择，但是要注意SQL2000不支持row_number()函数，由于时间和条件的限制没有做更深入、范围更广的测试，有兴趣的可以仔细研究下。

**以下是根据第四种方案编写的一个分页存储过程：**



```
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sys_Page_v2]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[sys_Page_v2]
GO
 

CREATE PROCEDURE [dbo].[sys_Page_v2]
@PCount int output,    --总页数输出
@RCount int output,    --总记录数输出
@sys_Table nvarchar(100),    --查询表名
@sys_Key varchar(50),        --主键
@sys_Fields nvarchar(500),    --查询字段
@sys_Where nvarchar(3000),    --查询条件
@sys_Order nvarchar(100),    --排序字段
@sys_Begin int,        --开始位置
@sys_PageIndex int,        --当前页数
@sys_PageSize int        --页大小
AS

SET NOCOUNT ON
SET ANSI_WARNINGS ON

IF @sys_PageSize < 0 OR @sys_PageIndex < 0
BEGIN        
RETURN
END

DECLARE @new_where1 NVARCHAR(3000)
DECLARE @new_order1 NVARCHAR(100)
DECLARE @new_order2 NVARCHAR(100)
DECLARE @Sql NVARCHAR(4000)
DECLARE @SqlCount NVARCHAR(4000)

DECLARE @Top int

if(@sys_Begin <=0)
    set @sys_Begin=0
else
    set @sys_Begin=@sys_Begin-1

IF ISNULL(@sys_Where,'') = ''
    SET @new_where1 = ' '
ELSE
    SET @new_where1 = ' WHERE ' + @sys_Where

IF ISNULL(@sys_Order,'') <> '' 
BEGIN
    SET @new_order1 = ' ORDER BY ' + Replace(@sys_Order,'desc','')
    SET @new_order1 = Replace(@new_order1,'asc','desc')

    SET @new_order2 = ' ORDER BY ' + @sys_Order
END
ELSE
BEGIN
    SET @new_order1 = ' ORDER BY ID DESC'
    SET @new_order2 = ' ORDER BY ID ASC'
END

SET @SqlCount = 'SELECT @RCount=COUNT(1),@PCount=CEILING((COUNT(1)+0.0)/'
            + CAST(@sys_PageSize AS NVARCHAR)+') FROM ' + @sys_Table + @new_where1

EXEC SP_EXECUTESQL @SqlCount,N'@RCount INT OUTPUT,@PCount INT OUTPUT',
               @RCount OUTPUT,@PCount OUTPUT

IF @sys_PageIndex > CEILING((@RCount+0.0)/@sys_PageSize)    --如果输入的当前页数大于实际总页数,则把实际总页数赋值给当前页数
BEGIN
    SET @sys_PageIndex =  CEILING((@RCount+0.0)/@sys_PageSize)
END

set @sql = 'select '+ @sys_fields +' from ' + @sys_Table + ' w1 '
    + ' where '+ @sys_Key +' in ('
        +'select top '+ ltrim(str(@sys_PageSize)) +' ' + @sys_Key + ' from '
        +'('
            +'select top ' + ltrim(STR(@sys_PageSize * @sys_PageIndex + @sys_Begin)) + ' ' + @sys_Key + ' FROM ' 
        + @sys_Table + @new_where1 + @new_order2 
        +') w ' + @new_order1
    +') ' + @new_order2

print(@sql)

Exec(@sql)

GO
```

 