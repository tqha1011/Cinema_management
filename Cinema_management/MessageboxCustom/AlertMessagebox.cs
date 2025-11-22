using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using Cinema_management.Properties;
using Cinema_management.MessageboxCustom;
using System.Runtime.Versioning;

namespace Cinema_management.MessagboxCustom
{
    public partial class AlertMessagebox : KryptonForm
    {
        public AlertMessagebox()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        public enum AlertType
        {
            Success,
            Error,
            Info
        }


        public void showAlert(string msg, AlertType type)
        {
            switch (type)
            {
                case AlertType.Success:
                    ptbIcon.Image = Resources.check;
                    this.StateCommon.Header.Back.Color1 = Color.SeaGreen;
                    this.StateCommon.Header.Back.Color2 = Color.SeaGreen;
                    btnConfirm.StateCommon.Back.Color1 = Color.SeaGreen;
                    btnConfirm.StateCommon.Back.Color2 = Color.SeaGreen;
                    btnConfirm.OverrideDefault.Back.Color1 = Color.SeaGreen;
                    btnConfirm.OverrideDefault.Back.Color2 = Color.SeaGreen;
                    break;
                case AlertType.Error:
                    ptbIcon.Image = Resources.error;
                    this.StateCommon.Header.Back.Color1 = Color.DarkRed;
                    this.StateCommon.Header.Back.Color2 = Color.DarkRed;
                    btnConfirm.StateCommon.Back.Color1 = Color.DarkRed;
                    btnConfirm.StateCommon.Back.Color2 = Color.DarkRed;
                    btnConfirm.OverrideDefault.Back.Color1 = Color.DarkRed;
                    btnConfirm.OverrideDefault.Back.Color2 = Color.DarkRed;
                    break;
                case AlertType.Info:
                    ptbIcon.Image = Resources.information;
                    this.StateCommon.Header.Back.Color1 = Color.RoyalBlue;
                    this.StateCommon.Header.Back.Color2 = Color.RoyalBlue;
                    btnConfirm.StateCommon.Back.Color1 = Color.RoyalBlue;
                    btnConfirm.StateCommon.Back.Color2 = Color.RoyalBlue;
                    btnConfirm.OverrideDefault.Back.Color1 = Color.RoyalBlue;
                    btnConfirm.OverrideDefault.Back.Color2 = Color.RoyalBlue;
                    break;
            }
            this.lblMessage.Text = msg;
            this.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlertMessagebox_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(366, 170);
        }
    }
}
