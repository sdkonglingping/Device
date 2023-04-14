using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;
using System.Data.OleDb;

namespace DeviceApp
{
    public partial class DeviceFrm : Form
    {
        EntityState objState;
        string[] filter;
        decimal qty, totalQty;
        decimal pages;
        decimal currentPage=1;

        public DeviceFrm()
        {
            InitializeComponent();
            filter = new string[] { "%", "%", "%", "%", "%", "%" };
            getFilterString();

        }
        DeviceBLL deviceBLL = new DeviceBLL();

        private void DeviceFrm_Load(object sender, EventArgs e)
        {
            getPagesAndCurrentPage();
            
            deviceBindingSource.DataSource = deviceBLL.GetAll(filter).Take(Convert.ToInt32( qty));
        }
        

        private void ReFreshForm()
        {
            DeviceFrm_Load(null,null);
        }

       

        private void btnDeviceAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            DeviceDetailFrm deviceDetail = new DeviceDetailFrm(objState);
            deviceDetail.myRefresh += new DeviceDetailFrm.Refresh(ReFreshForm);
            deviceDetail.ShowDialog();
            objState = EntityState.Unchanged;
        }

        private void btnDeviceEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            using (DeviceDetailFrm dFrm = new DeviceDetailFrm(deviceBindingSource.Current as Device, objState))
            {
                dFrm.myRefresh += new DeviceDetailFrm.Refresh(ReFreshForm);
                dFrm.ShowDialog();
                
            }
            objState = EntityState.Unchanged;


            
        }
        #region
        private void btnDeviceImport_Click(object sender, EventArgs e)
        {
            string connString = "server = (local); uid = sa; pwd = 123; database = eledb";
            System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                TransferData(fd.FileName, "tbl_device1", connString);
            }
        }
        public void TransferData(string excelFile, string sheetName, string connectionString)
        {
            DataSet ds = new DataSet();
            try
            {
                //获取全部数据     
                string strConn = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + excelFile + ";" + "Extended Properties = Excel 8.0;";
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                string strExcel = "";
                OleDbDataAdapter myCommand = null;
                strExcel = string.Format("select * from [{0}$]", sheetName);
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                myCommand.Fill(ds, sheetName);

                //如果目标表不存在则创建,excel文件的第一行为列标题,从第二行开始全部都是数据记录     
                string strSql = string.Format("if not exists(select * from sysobjects where name = '{0}') create table {0}(", sheetName);   //以sheetName为表名     

                foreach (System.Data.DataColumn c in ds.Tables[0].Columns)
                {
                    strSql += string.Format("[{0}] varchar(255),", c.ColumnName);
                }
                strSql = strSql.Trim(',') + ")";

                using (System.Data.SqlClient.SqlConnection sqlconn = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    sqlconn.Open();
                    System.Data.SqlClient.SqlCommand command = sqlconn.CreateCommand();
                    command.CommandText = strSql;
                    command.ExecuteNonQuery();
                    sqlconn.Close();
                }
                //用bcp导入数据        
                //excel文件中列的顺序必须和数据表的列顺序一致，因为数据导入时，是从excel文件的
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

                #endregion
                private void btnDeviceDel_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MessageBox.Show("Are you sure want to delete this record", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                               
                deviceBLL.Delete((deviceBindingSource.Current as Device).DId);                
                deviceBindingSource.RemoveCurrent();
            }
            objState = EntityState.Unchanged;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getFilterString();
            deviceBindingSource.DataSource = deviceBLL.GetAll(filter);
            
        }
        private void getFilterString()
        {
            filter[0] = string.IsNullOrEmpty(cmbDept.Text) ? "%" : cmbDept.Text;
            filter[1] = string.IsNullOrEmpty(cmbArea.Text) ? "%" : cmbArea.Text;
            filter[2] = string.IsNullOrEmpty(txtName.Text) ? "%" : txtName.Text;
            filter[3] = string.IsNullOrEmpty(txtModel.Text) ? "%" : txtModel.Text;
            filter[4] = string.IsNullOrEmpty(txtKKS.Text) ? "%" : txtKKS.Text;
            filter[5] = string.IsNullOrEmpty(cmbStatus.Text) ? "%" : cmbStatus.Text;
        }
        private void btnPartsRelativeSelect_Click(object sender, EventArgs e)
        {
            DevicePartRelative dpFrm = new DevicePartRelative();
            dpFrm.ShowDialog();
        }

        private void cmbQty_SelectedValueChanged(object sender, EventArgs e)
        {
            getPagesAndCurrentPage();
            deviceBindingSource.DataSource = deviceBLL.GetAll(filter).Take(Convert.ToInt32( qty));
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtCurrentPage.Text)>1)
            {
                currentPage = currentPage - 1;
                getPagesAndCurrentPage();
                deviceBindingSource.DataSource = deviceBLL.GetAll(filter).Skip(Convert.ToInt32( currentPage-1)*Convert.ToInt32(cmbQty.Text)).Take(Convert.ToInt32(qty));
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCurrentPage.Text) <pages)
            {
                currentPage = currentPage + 1;
                getPagesAndCurrentPage();
                deviceBindingSource.DataSource = deviceBLL.GetAll(filter).Skip(Convert.ToInt32(currentPage - 1)*Convert.ToInt32(cmbQty.Text)).Take(Convert.ToInt32(qty));
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            getPagesAndCurrentPage();
            deviceBindingSource.DataSource = deviceBLL.GetAll(filter).Take(Convert.ToInt32(qty));
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            
            getPagesAndCurrentPage();
            currentPage = pages;
            deviceBindingSource.DataSource = deviceBLL.GetAll(filter).Skip(Convert.ToInt32(pages - 1) * Convert.ToInt32(cmbQty.Text)).Take(Convert.ToInt32(qty));
            txtCurrentPage.Text = pages.ToString();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            currentPage = Convert.ToInt32(txtCurrentPage.Text);
            getPagesAndCurrentPage();
            
            deviceBindingSource.DataSource = deviceBLL.GetAll(filter).Skip((Convert.ToInt32(txtCurrentPage.Text)-1) * Convert.ToInt32(cmbQty.Text)).Take(Convert.ToInt32(qty));
            //txtCurrentPage.Text = pages.ToString();
        }

        private void getPagesAndCurrentPage()
        {

            totalQty = deviceBLL.GetAll(filter).Count();
            qty = Convert.ToInt32(cmbQty.Text);
            pages =Math.Ceiling(Convert.ToDecimal( totalQty/qty));
            txtCurrentPage.Text = currentPage.ToString();
            lblPages.Text = pages.ToString();
        }
    }
}
