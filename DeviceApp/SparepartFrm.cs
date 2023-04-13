using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace DeviceApp
{
    public partial class SparepartFrm : Form
    {
        PartBLL partBLL = new PartBLL();
        EntityState objState;
        public SparepartFrm()
        {
            InitializeComponent();
        }

        private void SparepartFrm_Load(object sender, EventArgs e)
        {
            partBindingSource.DataSource = partBLL.GetAll() ;
        }
        private void ReFreshForm()
        {
            SparepartFrm_Load(null, null);
        }
        private void btnPartAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            PartDetailFrm partDetailFrm = new PartDetailFrm(objState);
            partDetailFrm.myRefresh += new PartDetailFrm.Refresh(ReFreshForm);
            partDetailFrm.ShowDialog();
            objState = EntityState.Unchanged;
        }

        private void btnPartEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            using (PartDetailFrm pFrm = new PartDetailFrm(partBindingSource.Current as Part, objState))
            {
                pFrm.myRefresh += new PartDetailFrm.Refresh(ReFreshForm);
                pFrm.ShowDialog();

            }
            objState = EntityState.Unchanged;
        }

        private void btnPartDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MessageBox.Show("Are you sure want to delete this record", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                partBLL.Delete((partBindingSource.Current as Part).PId);
                partBindingSource.RemoveCurrent();
            }
            objState = EntityState.Unchanged;
        }
    }
}
