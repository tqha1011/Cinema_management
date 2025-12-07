using Cinema_management.Food_and_Beverage;
using Cinema_management.MessageboxCustom.Utils;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_management
{
    public partial class AddFood : KryptonForm
    {
        private int foodID = 0;
        private FoodLogic foodLogic;
        private string selectedImagePath = "";
        private string currentImageFileName = "";
        public AddFood(int ID)
        {
            InitializeComponent();
            foodLogic = new FoodLogic();
            foodID = ID;
            if(ID == 0)
            {
                btnDelete.Enabled = false;
                btnDelete.Visible = false;
            }
        }

        // su kien nut delete
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Food deleteFood = foodLogic.GetDetails(foodID);
            if(foodLogic.DeleteFood(foodID))
            {
                Alert.Show($"Xóa món {deleteFood.Name} thành công",MessagboxCustom.AlertMessagebox.AlertType.Success);
                this.Close();
            }
            else
            {
                Alert.Show($"Xóa món {deleteFood.Name} thất bại", MessagboxCustom.AlertMessagebox.AlertType.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string finalFileName = currentImageFileName;
            if(!string.IsNullOrEmpty(selectedImagePath))
            {
                // Luu anh vao thu muc Images/FoodImages
                string namePath = Path.GetFileName(selectedImagePath);

                // luu anh voi dinh dang them ngay thang nam vao ten de tranh trung lap
                // vi du : bapcai.jpg -> bapcai_20230915123045.jpg
                string nameFilePicture = $"{Path.GetFileNameWithoutExtension(namePath)}_{DateTime.Now.Ticks}{Path.GetExtension(namePath)}";
                string desFolder = Path.Combine(Application.StartupPath, "Poster");
                if (!System.IO.Directory.Exists(desFolder))
                {
                    System.IO.Directory.CreateDirectory(desFolder);
                }
                string savePath = Path.Combine(desFolder, nameFilePicture);
                try
                {
                    File.Copy(selectedImagePath, savePath, true);
                    finalFileName = nameFilePicture;
                }
                catch(Exception ex)
                {
                    Alert.Show("Lưu ảnh thất bại: " + ex.Message, MessagboxCustom.AlertMessagebox.AlertType.Error);
                    return;
                }
            }
            bool success = false;
            Food newFood = new Food();
            newFood.Name = txtNameFood.Text;
            newFood.Money = decimal.Parse(txtPrice.Text);
            newFood.Quantity = int.Parse(txtAmount.Text);
            newFood.Type = (int)cboType.SelectedValue;
            newFood.imgFood = finalFileName;
            // Them moi
            if (foodID == 0)
            {
                success = foodLogic.AddFood(newFood);
            }
            else
            {
                // Cap nhat
                newFood.Id = foodID;
                success = foodLogic.UpdateFood(newFood, foodID);
            }
            if (success)
            {
                Alert.Show("Lưu thông tin đồ ăn thành công!", MessagboxCustom.AlertMessagebox.AlertType.Success);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Alert.Show("Lưu thông tin đồ ăn thất bại!", MessagboxCustom.AlertMessagebox.AlertType.Error);
            }
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            // Load loai do an vao combobox
            cboType.DisplayMember = "TENLOAIDOAN";
            cboType.ValueMember = "MALOAIDOAN";
            cboType.DataSource = foodLogic.GetFoodTypes();
            // Neu la cap nhat thi load thong tin do an len form
            if (foodID != 0)
            {
                Food existingFood = foodLogic.GetDetails(foodID);
                if (existingFood != null)
                {
                    txtNameFood.Text = existingFood.Name;
                    txtPrice.Text = existingFood.Money.ToString();
                    txtAmount.Text = existingFood.Quantity.ToString();
                    cboType.SelectedValue = existingFood.Type;
                    // Load anh
                    if (!string.IsNullOrEmpty(existingFood.imgFood))
                    {
                        string imagePath = Path.Combine(Application.StartupPath, "Poster", existingFood.imgFood);
                        if (File.Exists(imagePath))
                        {
                            using(Image img = Image.FromFile(imagePath))
                            {
                                ptbDoAn.Image = new Bitmap(img);
                            }
                        }
                    }
                }
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                using(Image img = Image.FromFile(selectedImagePath))
                {
                    ptbDoAn.Image = new Bitmap(img);
                }
            }
        }
    }
}
