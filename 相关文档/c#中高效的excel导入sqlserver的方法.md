# c#中高效的excel导入sqlserver的方法

2017-10-01 1206举报

**简介：**

将oledb读取的excel数据快速插入的sqlserver中，很多人通过循环来拼接sql，这样做不但容易出错而且效率低下，最好的办法是使用bcp，也就是System.Data.SqlClient.SqlBulkCopy 类来实现。不但速度快，而且代码简单，下面测试代码导入一个6万多条数据的sheet，包括读取（全部读取比较慢）在我的开发环境中只需要10秒左右，而真正的导入过程只需要4.5秒。


using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsApplication2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

​    private void button1_Click(object sender, EventArgs e)
​    {
​      //测试，将excel中的sheet1导入到sqlserver中
​      string connString = "server=localhost;uid=sa;pwd=sqlgis;database=master";
​      System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
​      if (fd.ShowDialog() == DialogResult.OK)
​      {
​        TransferData(fd.FileName, "sheet1", connString);
​      }
​    }

​    public void TransferData(string excelFile, string sheetName, string connectionString)
​    {
​      DataSet ds = new DataSet();
​      try
​      {
​        //获取全部数据
​        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + excelFile + ";" + "Extended Properties=Excel 8.0;";
​        OleDbConnection conn = new OleDbConnection(strConn);
​        conn.Open();
​        string strExcel = "";
​        OleDbDataAdapter myCommand = null;
​        strExcel = string.Format("select * from [{0}$]", sheetName);
​        myCommand = new OleDbDataAdapter(strExcel, strConn);
​        myCommand.Fill(ds, sheetName);

​        //如果目标表不存在则创建
​        string strSql = string.Format("if object_id('{0}') is null create table {0}(", sheetName);
​        foreach (System.Data.DataColumn c in ds.Tables[0].Columns)
​        {
​          strSql += string.Format("[{0}] varchar(255),", c.ColumnName);
​        }
​        strSql = strSql.Trim(',') + ")";

​        using (System.Data.SqlClient.SqlConnection sqlconn = new System.Data.SqlClient.SqlConnection(connectionString))
​        {
​          sqlconn.Open();
​          System.Data.SqlClient.SqlCommand command = sqlconn.CreateCommand();
​          command.CommandText = strSql;
​          command.ExecuteNonQuery();
​          sqlconn.Close();
​        }
​        //用bcp导入数据
​        using (System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(connectionString))
​        {
​          bcp.SqlRowsCopied += new System.Data.SqlClient.SqlRowsCopiedEventHandler(bcp_SqlRowsCopied);
​          bcp.BatchSize = 100;//每次传输的行数
​          bcp.NotifyAfter = 100;//进度提示的行数
​          bcp.DestinationTableName = sheetName;//目标表
​          bcp.WriteToServer(ds.Tables[0]);
​        }
​      }
​      catch (Exception ex)
​      {
​        System.Windows.Forms.MessageBox.Show(ex.Message);
​      }

​    }

​    //进度显示
​    void bcp_SqlRowsCopied(object sender, System.Data.SqlClient.SqlRowsCopiedEventArgs e)
​    {
​      this.Text = e.RowsCopied.ToString();
​      this.Update();
​    }


  }
}

上面的TransferData基本可以直接使用，如果要考虑周全的话，可以用oledb来获取excel的表结构，并且加入ColumnMappings来设置对照字段，这样效果就完全可以做到和sqlserver的dts相同的效果了。