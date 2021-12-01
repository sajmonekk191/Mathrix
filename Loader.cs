using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Threading;

namespace Grafy
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Visible = true;
            this.BringToFront();
            loadlbl.Location = new System.Drawing.Point(125, 208);
            proclbl.Text = "3 %";
            loadlbl.Text = "Vyhledávání Aktualizace ...";
            Wait(1500);
            using (WebClient webClient = new WebClient())
            {
                if (!webClient.DownloadString("https://pastebin.com/5LXUPYx7").Contains("Update1"))
                {
                    if (MessageBox.Show("K dispozici je nová aktualizace !", "Mathrix", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        Process.Start(new ProcessStartInfo("http://81.162.196.29/Mathrix") { UseShellExecute = true });
                    }
                }
            }
            loadlbl.Location = new System.Drawing.Point(145, 208);
            proclbl.Text = "42 %";
            loadlbl.Text = "Načítání Textur ...";
            Wait(1000);
            pictureBox1.Location = new System.Drawing.Point(120, 24);
            pictureBox1.Image = Properties.Resources.LogoM;
            proclbl.Text = "86 %";
            loadlbl.Text = "Načítání Aplikace ...";
            Wait(2500);
            loadlbl.Location = new System.Drawing.Point(176, 208);
            proclbl.Text = "100 %";
            loadlbl.Text = "Hotovo !";
            Wait(1000);
            Main main = new Main();
            this.ShowInTaskbar = false;
            this.Size = new System.Drawing.Size(0, 0);
            main.Show();
            this.Hide();
        }
        public void Wait(int time)
        {
            Thread thread = new Thread(delegate ()
            {
                Thread.Sleep(time);
            });
            thread.Start();
            while (thread.IsAlive)
                Application.DoEvents();
        }
    }
}
