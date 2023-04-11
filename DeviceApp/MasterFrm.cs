using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;



namespace DeviceApp
{
    public partial class MasterFrm : Form
    {
        public MasterFrm()
        {
            InitializeComponent();
            
        }

        private void 删除数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 设备添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceDetailFrm deviceDetail = new DeviceDetailFrm();
            deviceDetail.ShowDialog();
        }

        private void 设备管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();         
            newForm.ShowForm<DeviceFrm>(spl.Panel2,this);
        }

        private void 配件列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();
            newForm.ShowForm<SparepartFrm>(spl.Panel2, this);
        }

        private void 维护记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();
            newForm.ShowForm<MaintenanceFrm>(spl.Panel2, this);
        }

        private void 工具清单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();
            newForm.ShowForm<ToolFrm>(spl.Panel2, this);
        }

        private void 文件列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();
            newForm.ShowForm<DocumentFrm>(spl.Panel2, this);
        }

        private void 图片列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();
            newForm.ShowForm<AlbumFrm>(spl.Panel2, this);
        }

        private void systemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupFrm setupFrm = new SetupFrm();
            setupFrm.ShowDialog();
        }
    }
}
