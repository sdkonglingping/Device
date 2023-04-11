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
    public partial class DeviceDetailFrm : Form
    {
        EntityState objState;
        DeviceBLL deviceBLL = new DeviceBLL();
        Device device;
        public delegate void Refresh();
        public event Refresh myRefresh;

        public DeviceDetailFrm()
        {
            InitializeComponent();
            
        }
        public DeviceDetailFrm(EntityState entityState)
        {
            InitializeComponent();
            this.objState = entityState;
            deviceBindingSource.AddNew();
            deviceBindingSource.MoveLast();
        }        

        public DeviceDetailFrm(Device device, EntityState entityState)
        {
            InitializeComponent();
            deviceBindingSource.DataSource = device;
            this.objState = entityState;
        }

        private void DeviceDetailFrm_Load(object sender, EventArgs e)
        {

            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            Device device = deviceBindingSource.Current as Device;
            device.StartDate = dtpStartDate.Text;           
            deviceBLL.Save(device,objState);            
            myRefresh();
            ClearAll();
            
            

        }
        private void ClearAll()
        {
            if (chkContinue.Checked)
            {
                this.objState = EntityState.Added;
                deviceBindingSource.AddNew();
                deviceBindingSource.MoveLast();
            }
            else
            {
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
