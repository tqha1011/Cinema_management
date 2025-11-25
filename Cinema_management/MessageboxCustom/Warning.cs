using Cinema_management.Properties;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_management.MessageboxCustom
{
    public partial class Warning : KryptonForm
    {
        public Warning(string message)
        {
            InitializeComponent();
            this.TopMost = true;
            ptbWarning.Image = Resources.warning;
            lblmsg.Text = message;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void Warning_Load(object sender, EventArgs e)
        {

        }
    }
}
