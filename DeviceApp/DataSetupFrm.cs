using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DeviceApp
{
    public partial class DataSetupFrm : Form
    {
        public DataSetupFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //xml文件路径            
            string xmlPath = Application.StartupPath + "\\config.xml";
            //XmlDocument读取xml文件
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);

            //获取xml根节点
            XmlNode xmlRoot = xmlDoc.DocumentElement;
            //根据节点顺序逐步读取
            //读取第一个ConnStr节点
            string ConnStr;
            ConnStr = xmlRoot.SelectSingleNode("connectionStrings/ConnStr").InnerText;

            //输出：张三
            textBox1.Text = ConnStr;



        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            //xml文件路径            
            string xmlPath = Application.StartupPath + "\\config.xml";
            //XmlDocument读取xml文件
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);

            //获取xml根节点
            XmlNode xmlRoot = xmlDoc.DocumentElement;
            //根据节点顺序逐步读取
            //读取第一个ConnStr节点
            xmlRoot.SelectSingleNode("connectionStrings/ConnStr").InnerText = textBox1.Text;

            //输出：张三
            xmlDoc.Save("config.xml");
        }
    }
}
