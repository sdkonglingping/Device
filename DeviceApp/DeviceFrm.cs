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
namespace DeviceApp
{
    public partial class DeviceFrm : Form
    {
        EntityState objState;
        public DeviceFrm()
        {
            InitializeComponent();

        }
        DeviceBLL deviceBLL = new DeviceBLL();

        private void DeviceFrm_Load(object sender, EventArgs e)
        {

            deviceBindingSource.DataSource = deviceBLL.GetAll();
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

        private void btnDeviceImport_Click(object sender, EventArgs e)
        {
            ImportFrm deviceImportFrm = new ImportFrm();
            deviceImportFrm.ShowDialog();
        }

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

        }

        private void btnPartsRelativeSelect_Click(object sender, EventArgs e)
        {
            DevicePartRelative dpFrm = new DevicePartRelative();
            dpFrm.ShowDialog();
        }
    }
}
