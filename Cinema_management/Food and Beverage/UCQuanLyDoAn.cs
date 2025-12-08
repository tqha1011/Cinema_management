using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema_management.Food_and_Beverage;

namespace Cinema_management
{
    public partial class UCQuanLyDoAn : UserControl
    {
        private FoodLogic foodLogic;
        private int selectedFoodId = 0;
        private UCFoodCard curSelectedCard = null;
        public UCQuanLyDoAn()
        {
            InitializeComponent();
            foodLogic = new FoodLogic();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            AddFood frm = new AddFood(0);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                LoadDanhSachDoAn();
            }
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UCQuanLyDoAn_Load(object sender, EventArgs e)
        {
            cbbLoc.ValueMember = "MALOAIDOAN";
            cbbLoc.DisplayMember = "TENLOAIDOAN";
            cbbLoc.DataSource = foodLogic.GetFoodTypes();
            LoadDanhSachDoAn();
        }

        private void LoadDanhSachDoAn()
        {
            List<Food> foods = foodLogic.GetFoodList();
            flowpanelFood.Controls.Clear();
            flowpanelFood.SuspendLayout();
            foreach (Food item in foods)
            {
                UCFoodCard card = new UCFoodCard();
                card.SetCardData(item);
                card.CardClick += Card_Click;
                card.Margin = new Padding(10);
                flowpanelFood.Controls.Add(card);
            }
            flowpanelFood.ResumeLayout();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            UCFoodCard selectedCard = sender as UCFoodCard;
            if(selectedCard != null)
            {
                if(curSelectedCard != null && curSelectedCard != selectedCard)
                {
                    curSelectedCard.IsSelected = false;
                }
                selectedCard.IsSelected = true;
                curSelectedCard = selectedCard;
                selectedFoodId = selectedCard.foodData.Id;
                AddFood frm = new AddFood(selectedFoodId);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    LoadDanhSachDoAn();
                }
            }
        }
    }
}
