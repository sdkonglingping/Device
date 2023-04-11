using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Configuration;

namespace DAL
{
    public class DBHelper
    {        
              
        public static string ConnectionString
        {   
            
            get
            {
               
                return ConfigurationManager.ConnectionStrings["SQLConnString"].ConnectionString;

            }
            //get
            //{
            //    XmlDocument xDoc = new XmlDocument();
            //    xDoc.Load(Application.StartupPath + "\\Config.xml");
            //    XmlNode xmlRoot = xDoc.DocumentElement;
            //    //根据节点顺序逐步读取
            //    //读取第一个name节点
            //    return xmlRoot.SelectSingleNode("connectionStrings/connectionString").InnerText;

            //}

        }        
    }
}
