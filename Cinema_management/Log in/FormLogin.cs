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
using Krypton.Toolkit;

namespace Cinema_management
{
    public partial class FormLogin : KryptonForm
    {
        private List<string> listPoster = new List<string>();
        private int currentPoster = 0;
        private Timer slidePoster = new Timer();
        public FormLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
            ShowUserControl(new UCLogin());
            SetSlidePoster();
        }

        public void ShowUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            grContain.Panel.Controls.Clear();
            grContain.Panel.Controls.Add(uc);
            uc.BringToFront();
            uc.Focus();
        }

        private void SetSlidePoster()
        {
            try
            {
                string folderPath = Path.Combine(Application.StartupPath, "Posters");
                if(Directory.Exists(folderPath))
                {
                    listPoster.AddRange(Directory.GetFiles(folderPath, "*.png").ToList());
                    listPoster.AddRange(Directory.GetFiles(folderPath, "*.jpg").ToList());
                    listPoster.AddRange(Directory.GetFiles(folderPath, "*.jpeg").ToList());
                    if (listPoster.Count > 0)
                    {
                        LoadPoster(0);
                        slidePoster.Interval = 5000; // 5 seconds
                        slidePoster.Tick += slidePoster_Tick;
                        slidePoster.Start();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Fail to load image");
            }
        }

        private void slidePoster_Tick(object sender, EventArgs e)
        {
            if(listPoster.Count == 0)
            {
                return;
            }
            currentPoster++;
            if(currentPoster >= listPoster.Count)
            {
                currentPoster = 0;
            }
            LoadPoster(currentPoster);
        }

        private void LoadPoster(int index)
        {
           pbPoster.ImageLocation = listPoster[index];
        }

        private void pbPoster_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
