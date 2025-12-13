using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_management
{
    public partial class UCOrderFoodCard : UserControl
    {
        public event EventHandler OnSelect;

        public int MaDoan { get; set; }
        public string TenDoan { get; set; }
        public decimal GiaTien { get; set; }
        public int  LoaiDoan { get; set; } // 1: COMBO; 2: ĐỒ ĂN; 3: ĐỒ UỐNG  để lọc

        public UCOrderFoodCard()
        {
            InitializeComponent();

            this.Click += (s, e) => OnSelect?.Invoke(this, e);
            picPoster.Click += (s, e) => OnSelect?.Invoke(this, e);
            lblTenMon.Click += (s, e) => OnSelect?.Invoke(this, e);
        }

        public void SetData(int id, string name, decimal price, Image img, int loai)
        {
            MaDoan = id;
            TenDoan = name;
            GiaTien = price;
            LoaiDoan = loai;

            lblTenMon.Text = name;
            lblGia.Text = price.ToString("N0") + " VND";
            if (img != null)
                picPoster.Image = img;
        }
    }
}
