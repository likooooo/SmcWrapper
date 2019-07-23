using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMC.Controller;
using SMC.Model.Controller;
using System.Windows.Forms;
namespace SMC.Wrapper
{
    public class SMC_Wrapper
    {

        readonly ComboBox cmbPorts;
        SMC_Controller_Model model;


        /**构造函数
         * **/
        public SMC_Wrapper(ComboBox cmbPorts)
        {
            string[] ports = SMCController.ScanSeraPort();
            foreach (string s in ports)
            {
                cmbPorts.Items.Add(s);
            }
            this.cmbPorts = cmbPorts;
            this.cmbPorts.TextChanged += new System.EventHandler(this.CmbPorts_TextChanged);
        }


        /**cmbBox的事件，一旦选择了之后，就初始化串口
         * **/
        private void CmbPorts_TextChanged(object sender, EventArgs e)
        {
            string port = cmbPorts.Text;
            if (!cmbPorts.Items.Contains(port)) return;
            byte comport = Convert.ToByte(port.Replace("COM", ""));
            model = new SMC_Controller_Model(comport);
            SMCController.Connect_Controller(model);
        }
    }
}
