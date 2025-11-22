using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema_management;
using Cinema_management.MessagboxCustom;

namespace Cinema_management.MessageboxCustom.Utils  // thu vien utils chua cac tien ich ho tro
{
    public static class Alert
    {
        public static void Show(string message, AlertMessagebox.AlertType type) // phuong thuc static de khong can khoi tao doi tuong
        {
            using(AlertMessagebox alert = new AlertMessagebox()) // su dung using de giai phong tai nguyen sau khi su dung
            {
                alert.showAlert(message, type); // goi phuong thuc showAlert de hien thi hop thoai
            }
        }

        public static DialogResult ShowWarning(string message) // phuong thuc static de hien thi hop thoai canh bao
        {
            using(Warning warning = new Warning(message)) // su dung using de giai phong tai nguyen sau khi su dung
            { 
                return warning.ShowDialog(); // tra ve ket qua cua hop thoai
            }
        }
    }
}
