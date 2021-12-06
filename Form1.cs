//http://sssi.cz/doc/soc/soc2016/soc_prochazka.pdf
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Grafy
{
    public partial class Form1 : Form
    {
        int jednotka = 20;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            switch (comboBox2.Text)
            {
                case "Modrá":
                    color = Brushes.Blue;
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
                    break;
                case "Červená":
                    color = Brushes.Red;
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
                    break;
                case "Zelená":
                    color = Brushes.Green;
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
                    break;
                default:
                    color = Brushes.Blue;
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
            panel1.Paint += new PaintEventHandler(panel1_draw);
            panel1.Refresh();
        }
        private void panel1_draw(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point picovina = panel1.PointToClient(Cursor.Position);
            label1.Text = picovina.ToString();
        }
        private void kokot()
        {
            //panel1.size
        }
    }
}
