using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceApp
{
    public partial class ImportFrm : Form
    {
        public ImportFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog1.Filter = "Excel文件(*.xlsx)|*.xlsx|Excel文件(*.xls)|*.xls|Csv文件(*.csv)|*.csv|所有文件(*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FilterIndex = 3;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
               
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
