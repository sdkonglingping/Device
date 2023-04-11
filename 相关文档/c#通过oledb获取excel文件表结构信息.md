# c#通过oledb获取excel文件表结构信息

这个问题来自论坛提问，同理可以获得access等数据库的表结构信息。

```
using  System;
 namespace  ConsoleApplication11
 {
      class  Program
      {
          public   static   void  Main()
          {
             getExcelFileInfo( @" c:a.xls " );
         }
          private   static   void  getExcelFileInfo( string  Path)
          {
              string  strConn  =   " Provider=Microsoft.Jet.OLEDB.4.0; "   +   " Data Source= "   +  Path  +   " ; "   +   " Extended Properties=Excel 8.0; " ;
             System.Data.OleDb.OleDbConnection conn  =   new  System.Data.OleDb.OleDbConnection(strConn);
             conn.Open();
             System.Data.DataTable table  =  conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables,  null );
              foreach  (System.Data.DataRow drow  in  table.Rows)
          {
              string  TableName  =  drow[ " Table_Name " ].ToString();
             Console.WriteLine(TableName + " : " );
             System.Data.DataTable tableColumns  =  conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns,  new   object []  {  null ,  null , TableName , null } );
              foreach  (System.Data.DataRow drowColumns  in  tableColumns.Rows)
              {
                  string  ColumnName  =  drowColumns[ " Column_Name " ].ToString();
                 Console.WriteLine( " " + ColumnName);
             }
         }
         Console.ReadKey( true );
     }
 }
}
```



​         



