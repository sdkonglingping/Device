using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public class ShowNewForm
    {
        #region 判断窗体是否加载，如已加载激活并显示能前端，如未加载，实例并显示到前端
        //使用方法：如在MainFrm里打开Maintenance
        //ShowNewForm newMFrm = new ShowNewForm();
        //MaintenanceFrm mFrm = new MaintenanceFrm();
        //newMFrm.ShowForm<MaintenanceFrm>(splMain.Panel2,this);如果打开子窗口，第二个参数为this，否则不填写
        /// <summary>
        /// 打开MDI子窗口并附加到MDI主窗口中，如果MDI主窗口中已经存在相同类型的子窗口，则直接激活
        /// </summary>
        /// <typeparam name="T">MDI子窗体类型</typeparam>
        /// <param name="mdiParent">MDI主窗体引用</param>
        /// <returns>当前创建或得到的MDI子窗体类型实例的引用</returns>
        public T ShowForm<T>(SplitterPanel panel, Form mdiParent = null) where T : Form, new()
        {

            /*调用方法
             * ShowForm<DeviceFrm>(panel,this);MDI窗口调用
             * ShowForm<DeviceFrm>(panel);普通窗体调用
             */
            foreach (Form subForm in Application.OpenForms)
            {

                if (subForm.GetType().Equals(typeof(T)))
                {
                    subForm.Activate();
                    subForm.BringToFront();
                    return subForm as T;
                }
            }
            T newForm = new T();
            if (mdiParent != null)
            {
                newForm.MdiParent = mdiParent;
                //this.splMain.Panel2.Controls.Add(newForm);
                panel.Controls.Add(newForm);
            }
            newForm.Show();
            newForm.Dock = DockStyle.Fill;
            newForm.BringToFront();
            return newForm;
        }

        #endregion
    }
}
