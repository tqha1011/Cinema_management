using Cinema_management.Staff_Management;
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
    public partial class UCStaffs : UserControl
    {
        private StaffLogic staffLogic;
        private BindingSource staffBindingSource = new BindingSource(); // khoi tao binding source de luu tru danh sach nhan vien
        public UCStaffs()
        {
            InitializeComponent();
        }
        // Ham load danh sach nhan vien
        private void LoadStaffs()
        {
            DataTable dt = staffLogic.ShowListStaff();
            staffBindingSource.DataSource = dt; // dung BindingSource de luu tru danh sach nhan vien, giup tang toc truy xuat tim kiem va loc du lieu
            dgvMM.DataSource = staffBindingSource;
        }
        private void UCStaffs_Load(object sender, EventArgs e)
        {
            staffLogic = new StaffLogic();
            LoadStaffs(); 
        }

        private void UCStaffs_VisibleChanged(object sender, EventArgs e)
        {
            dgvMM.ClearSelection(); // xoa dong dc chon mac dinh khi datagridview duoc tai len
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff_popup addStaffPopup = new AddStaff_popup();
            addStaffPopup.ShowDialog(this); // Hien thi Usercontrol AddStaff trong mot popup
            LoadStaffs(); // Tai lai danh sach nhan vien sau khi them moi
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if(dgvMM.CurrentRow == null)
            {
                MessageBox.Show("Hay chon 1 staff de xoa");
                return;
            }
            try
            {
                int id = Convert.ToInt32(dgvMM.CurrentRow.Cells["ID"].Value); // lay MANV cua dong hien tai
                string name = dgvMM.CurrentRow.Cells["StaffName"].Value.ToString(); // lay ten cua dong hien tai
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên " + name + " ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) // neu xac nhan xoa
                {
                    if (staffLogic.DeleteStaff(id)) // xoa thanh cong
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStaffs();
                    }
                    else // xoa that bai
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(NullReferenceException)  // xu ly loi null neu chua chon staff nao de xoa
            {
                MessageBox.Show("Du lieu nhan vien khong hop le");
            }
            catch(Exception ex) // xu ly cac loi khac
            {
                MessageBox.Show("Da xay ra loi: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (dgvMM.CurrentRow == null)
            {
                MessageBox.Show("Hay chon 1 staff de cap nhat");
                return;
            }
            else
            {
                int id = Convert.ToInt32(dgvMM.CurrentRow.Cells["ID"].Value); // lay MANV cua dong hien tai
                AddStaff_popup addStaffPopup = new AddStaff_popup(id);
                addStaffPopup.ShowDialog(this); // Hien thi Usercontrol AddStaff trong mot popup
                LoadStaffs(); // Tai lai danh sach nhan vien sau khi cap nhat
            }
        }

        private void pictureBoxFind_Click(object sender, EventArgs e)
        {
            string seacrh_name = txbSearchStaff.Text;
            if(seacrh_name == "")
            {
                LoadStaffs(); // neu khong co tu khoa tim kiem thi tai lai danh sach nhan vien
            }
            else
            {
                dgvMM.DataSource = staffLogic.SearchStaff(seacrh_name); // tim kiem nhan vien theo ten
            }
        }

        private void txbSearchStaff_TextChanged(object sender, EventArgs e)
        {
            string search_name = txbSearchStaff.Text.Trim(); // tao bien luu tu khoa nguoi dung nhap
            if(string.IsNullOrEmpty(search_name))
            {
                staffBindingSource.RemoveFilter(); // neu khong co tu khoa thi xoa bieu thuc loc
            }
            else
            {
                string column = "Full Name";
                string escaped = search_name.Replace("'", "''");
                string filter_expression = string.Format("[{0}] LIKE '%{1}%'", column, escaped);
                staffBindingSource.Filter = filter_expression; // ap dung bieu thuc loc len BindingSource
            }
        }
    }
}
