using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Grafy
{
    public partial class Main : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public Main()
        {
            InitializeComponent();
            MinimizePanel.BackColor = Color.Gainsboro;
            ExitPanel.BackColor = Color.FromArgb(121, 9, 9);
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            ExitPanel.BackColor = Color.FromArgb(208, 38, 38);
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitPanel.BackColor = Color.FromArgb(121, 9, 9);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MinimizePanel.BackColor = Color.Silver;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            MinimizePanel.BackColor = Color.Gainsboro;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Program slouží jako učební pomůcka\n a hlavně pro mě jako procvičení programování v jazyce C# :D\n Budu ještě dodělávat balíčky s aktualizacema pro určité předměty..\n Dev. Šimon Novák", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 matika = new Form1();
            matika.Show();
            this.Hide();
        }
    }
}
