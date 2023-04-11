```
CREATE PROCEDURE [dbo].[GetNameById]
 ``@studentid varchar(8),
 ``@studentname nvarchar(50) OUTPUT
AS
BEGIN
 ``SELECT @studentname=studentname FROM student
 ``WHERE studentid=@studentid
 ``if` `@@Error<>0
 ``RETURN -1
 ``else
 ``RETURN 0
END
```

 

```
using` `(SqlConnection conn = ``new` `SqlConnection(connStr))
{
 ``try
 ``{
  ``SqlCommand cmd = ``new` `SqlCommand(``"GetNameById"``, conn);
  ``cmd.CommandType = CommandType.StoredProcedure;
  ``cmd.Parameters.AddWithValue(``"@studentid"``, ``"09888888"``);　　``//给输入参数赋值
  ``SqlParameter parOutput =cmd.Parameters.Add(``"@studentname"``, SqlDbType.NVarChar, 50);　　``//定义输出参数
  ``parOutput.Direction = ParameterDirection.Output;　　``//参数类型为Output
  ``SqlParameter parReturn = ``new` `SqlParameter(``"@return"``, SqlDbType.Int);
  ``parReturn.Direction = ParameterDirection.ReturnValue; 　　``//参数类型为ReturnValue
  ``cmd.Parameters.Add(parReturn);
  ``conn.Open();
  ``cmd.ExecuteNonQuery();
  ``MessageBox.Show(parOutput.Value.ToString()); ``//显示输出参数的值
  ``MessageBox.Show(parReturn.Value.ToString());　　``//显示返回值
 ``}
 ``catch` `(System.Exception ex)
 ``{
  ``MessageBox.Show(ex.Message);
 ``}
}
```

```
Create PROCEDURE AddOrderTran
 ``@country nvarchar(100),
 ``@adds nvarchar(100),
 ``@ynames nvarchar(100),
 ``@pids nvarchar(100),
 ``@cellp nvarchar(100),
 ``@cphone nvarchar(100),
 ``@amounts nvarchar(100),
 ``@cartnumber nvarchar(100)
as
 ``Declare @id ``int
 ``BEGIN TRANSACTION
  ``insert ``into` `Orders(Order_Country,Order_Adress,Order_UserName,Order_PostID,Cells,Order_Phone,Total_pay,CartNumber,IsPay)
   ``values (@country,@adds,@ynames,@pids,@cellp,@cphone,@amounts,@cartnumber,``'0'``)
  ``Select @id=@@identity
  ``insert ``into` `Orders_Item (OrderNumber,ProductsID,Products_Color,Products_Price,Order_Qty,Item_Total)
   ``select` `@id,Carts_Item.ProductsID,Carts_Item.Products_Color,Carts_Item.Products_Price,Carts_Item.Item_Qty,Carts_Item.Total_Pay
   ``from` `Carts_Item ``where` `Carts_Item.CartNumber=@cartnumber
  ``delete Carts_Item ``where` `CartNumber=@cartnumber
  ``IF @@error <> 0 --发生错误
  ``BEGIN
   ``ROLLBACK TRANSACTION
   ``RETURN 0
  ``END
  ``ELSE
  ``BEGIN
   ``COMMIT TRANSACTION
   ``RETURN @id --执行成功
 ``END
```

 

```
#region 执行存储过程
SqlParameter[] param = ``new` `SqlParameter[]
{
  ``new` `SqlParameter(``"@country"``,country),
  ``new` `SqlParameter(``"@adds"``,adds),
  ``new` `SqlParameter(``"@ynames"``,ynames),
  ``new` `SqlParameter(``"@pids"``, pids),
  ``new` `SqlParameter(``"@cellp"``,cellp),
  ``new` `SqlParameter(``"@cphone"``, cphone),
  ``new` `SqlParameter(``"@amounts"``,amounts),
  ``new` `SqlParameter(``"@cartnumber"``,cartnumber),
  ``new` `SqlParameter(``"@return"``,SqlDbType.Int)
};
param[8].Direction = ParameterDirection.ReturnValue;
MSCL.SqlHelper.RunProcedure(``"AddOrderTran"``, param);
object` `obj = param[8].Value; ``//接受返回值
//string connStr = System.Configuration.ConfigurationManager.AppSettings["ConStr"].ToString();
//using (SqlConnection conn = new SqlConnection(connStr))
//{
// conn.Open();
// SqlCommand cmd = new SqlCommand("AddOrderTran", conn);
// cmd.CommandType = CommandType.StoredProcedure;
// SqlParameter para1 = new SqlParameter("@country", country);
// para1.Direction = ParameterDirection.Input; //参数方向 为输入参数
// cmd.Parameters.Add(para1);
// SqlParameter para2 = new SqlParameter("@adds", adds);
// para2.Direction = ParameterDirection.Input;
// cmd.Parameters.Add(para2);
// SqlParameter para3 = new SqlParameter("@ynames", ynames);
// para3.Direction = ParameterDirection.Input;
// cmd.Parameters.Add(para3);
// SqlParameter para4 = new SqlParameter("@pids", pids);
// para4.Direction = ParameterDirection.Input;
// cmd.Parameters.Add(para4);
// SqlParameter para5 = new SqlParameter("@cellp", cellp);
// para5.Direction = ParameterDirection.Input;
// cmd.Parameters.Add(para5);
// SqlParameter para6 = new SqlParameter("@cphone", cphone);
// para6.Direction = ParameterDirection.Input;
// cmd.Parameters.Add(para6);
// SqlParameter para7 = new SqlParameter("@amounts", amounts);
// para7.Direction = ParameterDirection.Input;
// cmd.Parameters.Add(para7);
// SqlParameter para8 = new SqlParameter("@cartnumber", cartnumber);
// para8.Direction = ParameterDirection.Input;
// cmd.Parameters.Add(para8);
// SqlParameter paraReturn = new SqlParameter("@return", SqlDbType.Int);
// paraReturn.Direction = ParameterDirection.ReturnValue; //参数方向 为返回参数
// cmd.Parameters.Add(paraReturn);
// cmd.ExecuteNonQuery();
// object obj = paraReturn;
// if (obj.ToString() == "0")
// {
//  //存储过程执行失败
// }
// else
// {
//  //成功
// }
//}
//#endregion
```

本文的数据库用的是sql server自带数据Northwind

1.只返回单一记录集的存储过程

```
SqlConnection sqlconn = ``new` `SqlConnection(conn);
SqlCommand cmd = ``new` `SqlCommand();
// 设置sql连接
cmd.Connection = sqlconn;
// 如果执行语句
cmd.CommandText = ``"Categoriestest1"``;
// 指定执行语句为存储过程
cmd.CommandType = CommandType.StoredProcedure;
SqlDataAdapter dp = ``new` `SqlDataAdapter(cmd);
DataSet ds = ``new` `DataSet();
// 填充dataset
dp.Fill(ds);
// 以下是显示效果
GridView1.DataSource = ds;
GridView1.DataBind();
```

 

```
CREATE PROCEDURE Categoriestest1
 ``AS
 ``select` `*
 ``from` `Categories
 ``GO
```

2. 没有输入输出的存储过程

```
SqlConnection sqlconn = ``new` `SqlConnection(conn);
SqlCommand cmd = ``new` `SqlCommand();
cmd.Connection = sqlconn;
cmd.CommandText = ``"Categoriestest2"``;
cmd.CommandType = CommandType.StoredProcedure;
sqlconn.Open();
// 执行并显示影响行数
Label1.Text = cmd.ExecuteNonQuery().ToString();
sqlconn.Close();
```

 

```
CREATE PROCEDURE Categoriestest2 AS
 ``insert ``into` `dbo.Categories
 ``(CategoryName,[Description],[Picture])
 ``values (``'test1'``,``'test1'``,``null``)
 ``GO
```

3. 有返回值的存储过程

   ```
   SqlConnection sqlconn = ``new` `SqlConnection(conn);
   SqlCommand cmd = ``new` `SqlCommand();
   cmd.Connection = sqlconn;
   cmd.CommandText = ``"Categoriestest3"``;
   cmd.CommandType = CommandType.StoredProcedure;
   // 创建参数
   IDataParameter[] parameters = {
      ``new` `SqlParameter(``"rval"``, SqlDbType.Int,4)
     ``};
   // 将参数类型设置为 返回值类型
   parameters[0].Direction = ParameterDirection.ReturnValue;
   // 添加参数
   cmd.Parameters.Add(parameters[0]);
   sqlconn.Open();
   // 执行存储过程并返回影响的行数
   Label1.Text = cmd.ExecuteNonQuery().ToString();
   sqlconn.Close();
   // 显示影响的行数和返回值
   Label1.Text += ``"-"` `+ parameters[0].Value.ToString() ;
   ```

    

    

   ```
   CREATE PROCEDURE Categoriestest3
    ``AS
    ``insert ``into` `dbo.Categories
    ``(CategoryName,[Description],[Picture])
    ``values (``'test1'``,``'test1'``,``null``)
    ``return` `@@rowcount
    ``GO
   ```

4. 有输入参数和输出参数的存储过程　

```
SqlConnection sqlconn = ``new` `SqlConnection(conn);
SqlCommand cmd = ``new` `SqlCommand();
cmd.Connection = sqlconn;
cmd.CommandText = ``"Categoriestest4"``;
cmd.CommandType = CommandType.StoredProcedure;
// 创建参数
IDataParameter[] parameters = {
   ``new` `SqlParameter(``"@Id"``, SqlDbType.Int,4) ,
   ``new` `SqlParameter(``"@CategoryName"``, SqlDbType.NVarChar,15) ,
  ``};
// 设置参数类型
parameters[0].Direction = ParameterDirection.Output; ``// 设置为输出参数
parameters[1].Value = ``"testCategoryName"``;
// 添加参数
cmd.Parameters.Add(parameters[0]);
cmd.Parameters.Add(parameters[1]);
sqlconn.Open();
// 执行存储过程并返回影响的行数
Label1.Text = cmd.ExecuteNonQuery().ToString();
sqlconn.Close();
// 显示影响的行数和输出参数
Label1.Text += ``"-"` `+ parameters[0].Value.ToString() ;
```

 

```
CREATE PROCEDURE Categoriestest4
 ``@id ``int` `output,
 ``@CategoryName nvarchar(15)
 ``AS
 ``insert ``into` `dbo.Categories
 ``(CategoryName,[Description],[Picture])
 ``values (@CategoryName,``'test1'``,``null``)
 ``set` `@id = @@IDENTITY
 ``GO
```

5. 同时具有返回值、输入参数、输出参数的存储过程　　

```
SqlConnection sqlconn = ``new` `SqlConnection(conn);
SqlCommand cmd = ``new` `SqlCommand();
cmd.Connection = sqlconn;
cmd.CommandText = ``"Categoriestest5"``;
cmd.CommandType = CommandType.StoredProcedure;
// 创建参数
IDataParameter[] parameters = {
   ``new` `SqlParameter(``"@Id"``, SqlDbType.Int,4) ,
   ``new` `SqlParameter(``"@CategoryName"``, SqlDbType.NVarChar,15) ,
   ``new` `SqlParameter(``"rval"``, SqlDbType.Int,4)
  ``};
// 设置参数类型
parameters[0].Direction = ParameterDirection.Output;  ``// 设置为输出参数
parameters[1].Value = ``"testCategoryName"``;     ``// 给输入参数赋值
parameters[2].Direction = ParameterDirection.ReturnValue; ``// 设置为返回值
// 添加参数
cmd.Parameters.Add(parameters[0]);
cmd.Parameters.Add(parameters[1]);
cmd.Parameters.Add(parameters[2]);
sqlconn.Open();
// 执行存储过程并返回影响的行数
Label1.Text = cmd.ExecuteNonQuery().ToString();
sqlconn.Close();
// 显示影响的行数，输出参数和返回值
Label1.Text += ``"-"` `+ parameters[0].Value.ToString() + ``"-"` `+ parameters[2].Value.ToString();
```

 

 

```
CREATE PROCEDURE Categoriestest5
 ``@id ``int` `output,
 ``@CategoryName nvarchar(15)
 ``AS
 ``insert ``into` `dbo.Categories
 ``(CategoryName,[Description],[Picture])
 ``values (@CategoryName,``'test1'``,``null``)
 ``set` `@id = @@IDENTITY
 ``return` `@@rowcount
 ``GO
```

6. 同时返回参数和记录集的存储过程　

```
SqlConnection sqlconn = ``new` `SqlConnection(conn);
SqlCommand cmd = ``new` `SqlCommand();
cmd.Connection = sqlconn;
cmd.CommandText = ``"Categoriestest6"``;
cmd.CommandType = CommandType.StoredProcedure;
// 创建参数
IDataParameter[] parameters = {
   ``new` `SqlParameter(``"@Id"``, SqlDbType.Int,4) ,
   ``new` `SqlParameter(``"@CategoryName"``, SqlDbType.NVarChar,15) ,
   ``new` `SqlParameter(``"rval"``, SqlDbType.Int,4)     ``// 返回值
 ``};
// 设置参数类型
parameters[0].Direction = ParameterDirection.Output;  ``// 设置为输出参数
parameters[1].Value = ``"testCategoryName"``;     ``// 给输入参数赋值
parameters[2].Direction = ParameterDirection.ReturnValue; ``// 设置为返回值
// 添加参数
cmd.Parameters.Add(parameters[0]);
cmd.Parameters.Add(parameters[1]);
cmd.Parameters.Add(parameters[2]);
SqlDataAdapter dp = ``new` `SqlDataAdapter(cmd);
DataSet ds = ``new` `DataSet();
// 填充dataset
dp.Fill(ds);
// 显示结果集
GridView1.DataSource = ds.Tables[0];
GridView1.DataBind();
Label1.Text = ``""``;
// 显示输出参数和返回值
Label1.Text += parameters[0].Value.ToString() + ``"-"` `+ parameters[2].Value.ToString();
```

 

 

```
CREATE PROCEDURE Categoriestest6
 ``@id ``int` `output,
 ``@CategoryName nvarchar(15)
 ``AS
 ``insert ``into` `dbo.Categories
 ``(CategoryName,[Description],[Picture])
 ``values (@CategoryName,``'test1'``,``null``)
 ``set` `@id = @@IDENTITY
 ``select` `* ``from` `Categories
 ``return` `@@rowcount
 ``GO
```

7. 返回多个记录集的存储过程　

```
SqlConnection sqlconn = ``new` `SqlConnection(conn);
SqlCommand cmd = ``new` `SqlCommand();
cmd.Connection = sqlconn;
cmd.CommandText = ``"Categoriestest7"``;
cmd.CommandType = CommandType.StoredProcedure;
SqlDataAdapter dp = ``new` `SqlDataAdapter(cmd);
DataSet ds = ``new` `DataSet();
// 填充dataset
dp.Fill(ds);
// 显示结果集1
GridView1.DataSource = ds.Tables[0];
GridView1.DataBind();
// 显示结果集2
GridView2.DataSource = ds.Tables[1];
GridView2.DataBind();
```

 

```
CREATE PROCEDURE Categoriestest7
 ``AS
 ``select` `* ``from` `Categories
 ``select` `* ``from` `Categories
 ``GO
```