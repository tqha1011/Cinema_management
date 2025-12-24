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
using QRCoder;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Cinema_management.MessageboxCustom;
using Cinema_management.MessageboxCustom.Utils;
using System.Diagnostics;
using System.IO;

namespace Cinema_management.Ticket_Booking
{
    public partial class PaymentForm : KryptonForm
    {
        private string qrText;
        private int _time = 5; // thời gian đếm ngược
        // khai bao cac bien can thiet
        private string _date;
        private string _timeShow;
        private string _totalMoney;
        public PaymentForm(string text,string date,string timeShow,string money)
        {
            InitializeComponent();
            QuestPDF.Settings.License = LicenseType.Community;
            qrText = text;
            _date = date;
            _timeShow = timeShow;
            _totalMoney = money;
            timerDemNguoc.Interval = 1000; // 1 giây
            timerDemNguoc.Start();
        }

        private void CenterPanel()
        {
            // can giua tableQR trong form
            int x = (this.ClientSize.Width - tableQR.Width) / 2;
            int y = (this.ClientSize.Height - tableQR.Height) / 2;
            tableQR.Location = new Point(x, y);
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            // gan su kien de can giua panel khi resize form
            CenterPanel();
            generateQR();
        }

        private void generateQR()
        {
            try
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);
                ptbQR.Image = qrCodeImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã QR: " + ex.Message);

            }
        }

        private void timerDemNguoc_Tick(object sender, EventArgs e)
        {
            _time--;
            if (_time <= 0)
            {
                timerDemNguoc.Stop(); // dung timer sau khi dem nguoc 5s
                Alert.Show("Thanh toán thành công!", MessagboxCustom.AlertMessagebox.AlertType.Info);
                openPDF();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void openPDF()
        {
            try
            {
                string tempPath = Path.GetTempPath();
                string fileName = $"Bill_{DateTime.Now.Ticks}.pdf";
                string fullPath = Path.Combine(tempPath, fileName);
                var document = Document.Create(container =>
                {
                    // cu phap tao pdf theo questpdf
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A6);
                        page.Margin(1, Unit.Centimetre);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(12).FontFamily("Arial"));

                        // header
                        page.Header()
                            .Text("HÓA ĐƠN RẠP PHIM")
                            .SemiBold().FontSize(20).FontColor(Colors.Blue.Medium).AlignCenter();

                        // content
                        page.Content().PaddingVertical(1, Unit.Centimetre).Column(col =>
                        {
                            col.Spacing(10); // Khoảng cách giữa các dòng

                            col.Item().Text($"Ngày: " + _date);
                            col.Item().Text($"Giờ: " + _timeShow);
                            col.Item().Text($"Nội dung vé: {qrText}");

                            col.Item().LineHorizontal(1).LineColor(Colors.Grey.Medium); // Đường kẻ ngang

                            col.Item().Row(row =>
                            {
                                row.ConstantItem(100).Text("Tổng tiền:"); // Cột trái cố định 100
                                row.RelativeItem().Text(_totalMoney).Bold().FontSize(14); // Cột phải tự giãn
                            });

                            col.Item().Row(row =>
                            {
                                row.ConstantItem(100).Text("Trạng thái:");
                                row.RelativeItem().Text("ĐÃ THANH TOÁN").Bold().FontColor(Colors.Green.Medium);
                            });
                        });

                        // footer
                        page.Footer()
                            .AlignCenter()
                            .Text(x =>
                            {
                                x.Span("Cảm ơn quý khách đã sử dụng dịch vụ!");
                            });
                    });
                });
                document.GeneratePdf(fullPath);
                Process.Start(new ProcessStartInfo(fullPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở file PDF: " + ex.Message);
            }
        }
    }
}
