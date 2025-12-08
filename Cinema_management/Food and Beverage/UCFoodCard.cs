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
using Cinema_management.Food_and_Beverage;

namespace Cinema_management
{
    public partial class UCFoodCard : UserControl
    {
        public Food foodData;
        public event EventHandler CardClick;
        private bool isSelected = false;

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                UpdateWhenClick();
            }
        }

        private void UpdateWhenClick()
        {
            if(isSelected)
            {
                kryptonGroup1.StateCommon.Border.Color1 = Color.Orange;
                kryptonGroup1.StateCommon.Border.Color2 = Color.OrangeRed;
                kryptonGroup1.StateCommon.Border.Width = 5;
                kryptonGroup1.StateCommon.Back.Color1 = Color.FromArgb(255,250,240);
                kryptonTableLayoutPanel1.StateCommon.Color1 = Color.FromArgb(255, 250, 240);
                kryptonTableLayoutPanel1.StateCommon.Color2 = Color.FromArgb(255, 250, 240);
            }
            else
            {
                kryptonGroup1.StateCommon.Border.Color1 = Color.FromArgb(255, 220, 141);
                kryptonGroup1.StateCommon.Border.Color2 = Color.FromArgb(255, 220, 141);
                kryptonGroup1.StateCommon.Border.Width = 5;
                kryptonGroup1.StateCommon.Back.Color1 = Color.White;
                kryptonTableLayoutPanel1.StateCommon.Color1 = Color.White;
                kryptonTableLayoutPanel1.StateCommon.Color2 = Color.White;
            }
        }

        public UCFoodCard()
        {
            InitializeComponent();
            this.Click += Control_Click;
            if (lblTenMon != null) lblTenMon.Click += Control_Click;
            if (lblGia != null) lblGia.Click += Control_Click;
            if (lblSoLuong != null) lblSoLuong.Click += Control_Click;
            if (ptbMonAn != null) ptbMonAn.Click += Control_Click;
            if(kryptonGroup1 != null) kryptonGroup1.Click += Control_Click;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            CardClick?.Invoke(this, EventArgs.Empty);
        }

        private void lbTenMon_Click(object sender, EventArgs e)
        {

        }

        public void SetCardData(Food food)
        {
            this.foodData = food;
            lblTenMon.Text = food.Name;
            lblGia.Text = food.Money.ToString("N0") + "đ";
            if(food.Quantity <= 0)
            {
                lblSoLuong.Text = "Hết hàng";
                lblSoLuong.ForeColor = Color.Red;
                this.Enabled = false; // lam mo card neu het hang   
            }
            else
            {
                lblSoLuong.Text = "SL: " + food.Quantity.ToString();
                this.Enabled = true;
                lblSoLuong.ForeColor = Color.Black;
            }
            LoadImage(food.imgFood);
        }

        private void LoadImage(string fileName)
        {
            if(ptbMonAn != null)
            {
                if(ptbMonAn.Image != null)
                {
                    ptbMonAn.Image.Dispose();
                }
                ptbMonAn.Image = null;
            }
            if (string.IsNullOrEmpty(fileName)) return;

            string imagePath = System.IO.Path.Combine(Application.StartupPath, "Poster", fileName);
            if(System.IO.File.Exists(imagePath))
            {
                using (Image img = Image.FromFile(imagePath))
                {
                    ptbMonAn.Image = new Bitmap(img);
                }
            }
        }
    }
}
