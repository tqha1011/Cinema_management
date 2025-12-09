using Cinema_management.Food_and_Beverage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_management
{
    public partial class UCQuanLyDoAn : UserControl
    {
        private FoodLogic foodLogic;
        private int selectedFoodId = 0;
        private UCFoodCard curSelectedCard = null;

        // List này dùng để backup các Control đang hiển thị
        // Giúp tìm kiếm nhanh mà không cần tạo mới Control
        private List<UCFoodCard> foodCardList = new List<UCFoodCard>();

        public UCQuanLyDoAn()
        {
            InitializeComponent();
            foodLogic = new FoodLogic();
            SetDoubleBuffered(flowpanelFood);
            this.DoubleBuffered = true;
        }

        public static void SetDoubleBuffered(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, control, new object[] { true });
        }

        private void RenderFoodList(List<Food> dataCache)
        {
            flowpanelFood.Visible = false;
            flowpanelFood.SuspendLayout();

            foreach (Control c in flowpanelFood.Controls) c.Dispose();
            flowpanelFood.Controls.Clear();
            foodCardList.Clear();

            // Tạo mới
            foreach (Food item in dataCache)
            {
                UCFoodCard card = new UCFoodCard();
                card.SetCardData(item);
                card.CardClick += Card_Click;
                card.Margin = new Padding(10);

                // Lưu vào danh sách backup
                foodCardList.Add(card);
            }

            // Add 1 lần vào Panel
            flowpanelFood.Controls.AddRange(foodCardList.ToArray());

            flowpanelFood.ResumeLayout();
            flowpanelFood.Visible = true;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            AddFood frm = new AddFood(0);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                ReloadCurrentCategory();
            }
        }

        // Hàm phụ trợ để load lại dữ liệu dựa trên ComboBox đang chọn
        private void ReloadCurrentCategory()
        {
            if (cbbLoc.SelectedValue != null && int.TryParse(cbbLoc.SelectedValue.ToString(), out int currentTypeId))
            {
                LoadFoodData(currentTypeId);
            }
        }

        private void cbbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadCurrentCategory();
        }

        private void UCQuanLyDoAn_Load(object sender, EventArgs e)
        {
            DataTable dt = foodLogic.GetFoodTypes();
            DataRow dr = dt.NewRow();
            dr["MALOAIDOAN"] = 0;
            dr["TENLOAIDOAN"] = "Tất cả";
            dt.Rows.InsertAt(dr, 0);
            cbbLoc.DataSource = dt;
            cbbLoc.ValueMember = "MALOAIDOAN";
            cbbLoc.DisplayMember = "TENLOAIDOAN";
            cbbLoc.SelectedIndex = 0;
        }

        private async void LoadFoodData(int foodTypeId)
        {
            List<Food> foods = await Task.Run(() =>
            {
                if (foodTypeId == 0)
                    return foodLogic.GetFoodList();
                else
                    return foodLogic.GetFoodByType(foodTypeId);
            });
            RenderFoodList(foods);
        }

        private void Card_Click(object sender, EventArgs e)
        {
            UCFoodCard selectedCard = sender as UCFoodCard;
            if (selectedCard != null)
            {
                // Kiểm tra IsDisposed để tránh Crash
                if (curSelectedCard != null && !curSelectedCard.IsDisposed && curSelectedCard != selectedCard)
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
                    ReloadCurrentCategory();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            flowpanelFood.SuspendLayout();

            int count = 0;

            if (string.IsNullOrEmpty(keyword))
            {
                // truong hop khong tim kiem
                for (int i = 0; i < foodCardList.Count; i++)
                {
                    var card = foodCardList[i];
                    if (!card.Visible) card.Visible = true;
                    flowpanelFood.Controls.SetChildIndex(card, i);
                }
            }
            else
            {
                // truong hop co tim kiem
                foreach (var card in foodCardList)
                {
                    if (card.IsDisposed) continue;

                    bool isMatch = card.foodData.Name.ToLower().Contains(keyword);

                    if (isMatch)
                    {
                        if (!card.Visible) card.Visible = true;

                        flowpanelFood.Controls.SetChildIndex(card, count);
                        count++;
                    }
                    else
                    {
                        if (card.Visible) card.Visible = false;
                    }
                }
            }
            flowpanelFood.ResumeLayout();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e) { }
    }
}