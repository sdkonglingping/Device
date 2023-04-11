# sqlserver 存储过程中拼接sql语句 动态执行



**简介：** ALTER PROC [dbo].[Student_Friend_Get] @startRowIndexId INT, @maxNumberRows INT, @schoolId INT, @gradeId INT, ...

```
ALTER PROC [dbo].[Student_Friend_Get]
        @startRowIndexId INT,
        @maxNumberRows  INT,
        @schoolId  INT,
        @gradeId  INT,
        @cId  INT,
        @keyWords NVARCHAR(100),
        @userName VARCHAR(50)
         AS
                BEGIN
                    DECLARE @sqlfilter  VARCHAR(max)
                    SET @sqlfilter = ' '
                    IF(@schoolId <> -1)
                                SET @sqlfilter = @sqlfilter + '   tableu.SchoolId =  ' + CAST(@schoolId AS VARCHAR(50)) + ' AND'
                        IF(@gradeId <> -1)
                                SET @sqlfilter =  @sqlfilter +  '  tableu.GradeId =  ' + CAST(@gradeId AS VARCHAR(50)) + ' AND'
                        IF(@cId <> -1)
                                SET @sqlfilter =  @sqlfilter +  '  tableu.ClassId =  ' + CAST(@cId AS VARCHAR(50)) + ' AND'
                        IF(@keyWords IS NOT NULL)
                                SET @sqlfilter =  @sqlfilter + '   tableu.TrueName like  ''%' + CAST(@keyWords AS VARCHAR(50))         + '%''  AND'
                         
                        DECLARE @beg INT,@end INT
                        SET @beg =  @startRowIndexId+1
                        SET @end =  @startRowIndexId + @maxNumberRows
                        SET @sqlfilter = @sqlfilter +  '  tableu.num  BETWEEN  ' +CAST( @beg AS VARCHAR(50)) + ' AND '+ CAST(@end  AS VARCHAR(50))
                         
                        DECLARE @sqlmain  VARCHAR(max)
                        SET @sqlmain = ' '
                        SET @sqlmain = @sqlmain  +  ' SELECT * FROM
                        (
                            SELECT ROW_NUMBER() OVER(ORDER BY cjs.UserName) AS num,CTA.TrueName, u.UserName, c.ClassName + '' (''+ CAST(YEAR(c.GradeUpdateTime) AS NVARCHAR(20))+''年)'' AS [ClassName],s.SchoolName,cjs.ApplyTime,g.GradeName,cjs.ApplyID,c.ClassId,g.GradeId,s.SchoolId
                                        FROM PE_C_StudentJoinClass AS cjs
                                        LEFT JOIN dbo.PE_SS_StudentClass AS c
                                        ON cjs.ClassId = c.ClassId
                                        LEFT JOIN dbo.PE_Users AS u
                                        ON u.UserName = cjs.UserName
                                        LEFT JOIN dbo.PE_SS_Grade g
                                        ON g.GradeId = c.GradeId
                                        LEFT JOIN dbo.PE_SS_School s
                                        ON s.SchoolId = g.SchoolId
                                        LEFT JOIN PE_Contacter CTA
                                        ON cjs.UserName = CTA.UserName
                                        WHERE ApplyID IN
                                        (
                                                SELECT  
                                                MAX(cs1.ApplyID) AS [ApplyID]
                                                FROM PE_C_StudentJoinClass AS cs1
                                                CROSS JOIN dbo.PE_C_StudentJoinClass AS cs2
                                                WHERE cs2.UserName = '''+ CAST(@userName  AS VARCHAR(50))+ ''' AND cs1.UserName != ''' + CAST(@userName  AS VARCHAR(50))+  ''' AND cs1.ClassId = cs2.ClassId AND cs1.Status = 1
                                                GROUP BY cs1.UserName
                                        )
                                ) AS tableu WHERE '
                                 
                                PRINT (@sqlmain + @sqlfilter)
                            EXEC (@sqlmain + @sqlfilter)
 
                END
 
 
GO
```