//http://sssi.cz/doc/soc/soc2016/soc_prochazka.pdf
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Grafy
{
    public partial class Form1 : Form
    {
        int x = 0;
        int y = 0;
        int x1 = 0;
        int y1 = 0;
        int jednotka = 20;
        Point body1;
        Point body2;
        Point body12;
        bool mouseDown;
        Point lastLocation;
        bool lajna = false;
        bool simple = false;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedItem = "15";
            comboBox2.SelectedItem = "Černá (Default)";
            panel1.Refresh();
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            var color = Brushes.Blue;
            Graphics kp = e.Graphics;
            kp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen tužka = new Pen(Color.LightGray);
            int početČárek = 290 * 2 / jednotka;
            for (int i = 1; i < početČárek; i++)
            {
                kp.DrawLine(tužka, 300 + i * jednotka, -10, 300 + i * jednotka, 795);
                kp.DrawLine(tužka, 318 - i * jednotka, -10, 318 - i * jednotka, 795);
                kp.DrawLine(tužka, -10, 300 + i * jednotka, 795, 300 + i * jednotka);
                kp.DrawLine(tužka, -10, 318 - i * jednotka, 795, 318 - i * jednotka);
            }
            tužka.Color = Color.Black;
            kp.DrawLine(tužka, 0, 400, 790, 400);
            kp.DrawLine(tužka, 400, 0, 400, 790);
            kp.DrawString("X", new Font("Arial", 9), Brushes.Black, 781, 403); // písmeno X
            kp.DrawString("Y", new Font("Arial", 9), Brushes.Black, 387, 0); // písmeno Y
            #region
            color = Brushes.Black;
            switch (comboBox1.Text)
            {
                case "5":
                    kp.DrawString("0", new Font("Arial", 8), color, 402, 402);
                    kp.DrawString("-5", new Font("Arial", 8), color, 289, 403); //číslo -5 na X
                    kp.DrawString("5", new Font("Arial", 8), color, 496, 403); //číslo 5 na X
                    kp.DrawString("-5", new Font("Arial", 8), color, 382, 492); //číslo -5 na Y
                    kp.DrawString("5", new Font("Arial", 8), color, 387, 291); //číslo 5 na Y
                    break;
                case "10":
                    kp.DrawString("0", new Font("Arial", 8), color, 402, 402);
                    kp.DrawString("-10", new Font("Arial", 8), color, 189, 403); //číslo -10 na X
                    kp.DrawString("-5", new Font("Arial", 8), color, 289, 403); //číslo -5 na X
                    kp.DrawString("5", new Font("Arial", 8), color, 496, 403); //číslo 5 na X
                    kp.DrawString("10", new Font("Arial", 8), color, 593, 403); //číslo 10 na X
                    kp.DrawString("-10", new Font("Arial", 8), color, 378, 593); //číslo -10 na Y
                    kp.DrawString("-5", new Font("Arial", 8), color, 382, 492); //číslo -5 na Y
                    kp.DrawString("5", new Font("Arial", 8), color, 387, 291); //číslo 5 na Y
                    kp.DrawString("10", new Font("Arial", 8), color, 382, 191); //číslo 10 na Y
                    break;
                case "15":
                    kp.DrawString("0", new Font("Arial", 8), color, 402, 402);
                    kp.DrawString("-15", new Font("Arial", 8), color, 87, 403); //číslo -15 na X
                    kp.DrawString("-10", new Font("Arial", 8), color, 189, 403); //číslo -10 na X
                    kp.DrawString("-5", new Font("Arial", 8), color, 289, 403); //číslo -5 na X
                    kp.DrawString("5", new Font("Arial", 8), color, 496, 403); //číslo 5 na X
                    kp.DrawString("10", new Font("Arial", 8), color, 593, 403); //číslo 10 na X
                    kp.DrawString("15", new Font("Arial", 8), color, 693, 403); //číslo 15 na X
                    kp.DrawString("-15", new Font("Arial", 8), color, 378, 692); //číslo -15 na Y
                    kp.DrawString("-10", new Font("Arial", 8), color, 378, 593); //číslo -10 na Y
                    kp.DrawString("-5", new Font("Arial", 8), color, 382, 492); //číslo -5 na Y
                    kp.DrawString("5", new Font("Arial", 8), color, 387, 291); //číslo 5 na Y
                    kp.DrawString("10", new Font("Arial", 8), color, 382, 191); //číslo 10 na Y
                    kp.DrawString("15", new Font("Arial", 8), color, 382, 91); //číslo 15 na Y
                    break;
                default:
                    kp.DrawString("0", new Font("Arial", 8), color, 402, 402);
                    break;
            }
            #endregion
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lajna = true;
            simple = false;
            textBox5.Text = "";
            textBox6.Text = "";
            try
            {
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
                x1 = Convert.ToInt32(textBox3.Text);
                y1 = Convert.ToInt32(textBox4.Text);
            }
            catch
            {
            }
            int data1x = 400 + x * 20; //400 + x * 20
            int data1y = 400 + y * -20; //400 + y * -20
            int data2x = 400 + x1 * 20; //400 + x1 * 20
            int data2y = 400 + y1 * -20; //400 + y1 * -20
            Point bod1 = new Point(data1x, data1y);
            Point bod2 = new Point(data2x, data2y);
            body1 = bod1;
            body2 = bod2;
            panel1.Paint += new PaintEventHandler(panel1_draw);
            panel1.Refresh();
        }
        private void panel1_draw(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            Pen pen = new Pen(Color.Black);
            #region
            if (lajna)
            {
                switch (comboBox2.Text)
                {
                    case "Modrá":
                        pen = new Pen(Color.Blue);
                        if (checkBox1.Checked)
                        {
                            kp.DrawString("y", new Font("Arial", 9), Brushes.Blue, body1.X - 13, body1.Y - 13);
                            kp.DrawString("x", new Font("Arial", 9), Brushes.Blue, body2.X - 13, body2.Y - 13);
                        }
                        kp.DrawLine(pen, body1, body2);
                        break;
                    case "Červená":
                        pen = new Pen(Color.Red);
                        if (checkBox1.Checked)
                        {
                            kp.DrawString("y", new Font("Arial", 9), Brushes.Blue, body1.X - 13, body1.Y - 13);
                            kp.DrawString("x", new Font("Arial", 9), Brushes.Blue, body2.X - 13, body2.Y - 13);
                        }
                        kp.DrawLine(pen, body1, body2);
                        break;
                    case "Zelená":
                        pen = new Pen(Color.Green);
                        if (checkBox1.Checked)
                        {
                            kp.DrawString("y", new Font("Arial", 9), Brushes.Blue, body1.X - 13, body1.Y - 13);
                            kp.DrawString("x", new Font("Arial", 9), Brushes.Blue, body2.X - 13, body2.Y - 13);
                        }
                        kp.DrawLine(pen, body1, body2);
                        break;
                    default:
                        pen = new Pen(Color.Black);
                        if (checkBox1.Checked)
                        {
                            kp.DrawString("y", new Font("Arial", 9), Brushes.Blue, body1.X - 13, body1.Y - 13);
                            kp.DrawString("x", new Font("Arial", 9), Brushes.Blue, body2.X - 13, body2.Y - 13);
                        }
                        kp.DrawLine(pen, body1, body2);
                        break;
                }
            }
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            simple = true;
            lajna = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            try
            {
                x = Convert.ToInt32(textBox5.Text);
                y = Convert.ToInt32(textBox6.Text);
            }
            catch
            {
            }
            int data1x2 = 400 + x * 20; //400 + x * 20
            int data1y2 = 400 + y * -20; //400 + y * -20
            Point bod1 = new Point(data1x2, data1y2);
            body12 = bod1;
            panel1.Paint += new PaintEventHandler(CrossDraw);
            panel1.Refresh();
        }
        private void CrossDraw(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            Pen pen = new Pen(Color.Black);
            if (simple)
            {
                switch (comboBox2.Text)
                {
                    case "Modrá":
                        pen = new Pen(Color.Blue);
                        kp.DrawString("X", new Font("Arial", 11), Brushes.Blue, body12.X - 6, body12.Y - 8);
                        break;
                    case "Červená":
                        pen = new Pen(Color.Red);
                        kp.DrawString("X", new Font("Arial", 11), Brushes.Red, body12.X - 6, body12.Y - 8);
                        break;
                    case "Zelená":
                        pen = new Pen(Color.Green);
                        kp.DrawString("X", new Font("Arial", 11), Brushes.Green, body12.X - 6, body12.Y - 8);
                        break;
                    default:
                        pen = new Pen(Color.Black);
                        kp.DrawString("X", new Font("Arial", 11), Brushes.Black, body12.X - 6, body12.Y - 8);
                        break;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label16_Click(object sender, EventArgs e)
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

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            MinimizePanel.BackColor = Color.Silver;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            MinimizePanel.BackColor = Color.Gainsboro;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(25, 25);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(23, 23);
        }
    }
}
