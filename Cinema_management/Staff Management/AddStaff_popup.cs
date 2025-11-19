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

namespace Cinema_management.Staff_Management
{
    public partial class AddStaff_popup : KryptonForm
    {
        private int staffid = 0;
        public AddStaff_popup() : this(0)
        {
            
        }

        public AddStaff_popup(int id)
        {
            InitializeComponent();
            this.staffid = id;
        }

        private void addStaff1_Load(object sender, EventArgs e)
        {

        }

        private void addStaff1_Load_1(object sender, EventArgs e)
        {

        }

        private void AddStaff_popup_Load(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff(staffid);
            this.ClientSize = new Size(709, 806);
            panelChu.ClientSize = new Size(673, 770);
            addStaff.Dock = DockStyle.Fill;
            panelChu.Controls.Clear();
            panelChu.Controls.Add(addStaff);
        }
    }
}
