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
    public partial class PartDetailFrm : Form
    {
        EntityState objState;
        PartBLL partBLL = new PartBLL();            
        Part part;
        public delegate void Refresh();
        public event Refresh myRefresh;


        public PartDetailFrm(EntityState entityState)
        {
            InitializeComponent();
            this.objState = entityState;           
            partBindingSource.AddNew();
            partBindingSource.MoveLast();
        }

        public PartDetailFrm(Part part, EntityState objState)
        {
            InitializeComponent();            
            this.objState = objState;
            partBindingSource.DataSource = part;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Part part = partBindingSource.Current as Part;            
            partBLL.Save(part, objState);
            myRefresh();
            ClearAll();
        }
        private void ClearAll()
        {
            if (chkContinue.Checked)
            {
                this.objState = EntityState.Added;
                partBindingSource.AddNew();
                partBindingSource.MoveLast();
            }
            else
            {
                this.Close();
            }
        }
    }
}
