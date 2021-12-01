using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafy
{
    public partial class Form1 : Form
    {
        int jednotka = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        //http://sssi.cz/doc/soc/soc2016/soc_prochazka.pdf
            Graphics kp = e.Graphics;
            kp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen tužka = new Pen(Color.LightGray);
            int početČárek = 290 / jednotka;
            for (int index = 1; index < početČárek; index++)
            {
                kp.DrawLine(tužka, 300 + index * jednotka, 10, 300 + index * jednotka, 589);
                kp.DrawLine(tužka, 300 - index * jednotka, 10, 300 - index * jednotka, 589);
                kp.DrawLine(tužka, 10, 300 + index * jednotka, 589, 300 + index * jednotka);
                kp.DrawLine(tužka, 10, 300 - index * jednotka, 589, 300 - index * jednotka);
            }
            tužka.Color = Color.Black;
            kp.DrawLine(tužka, 10, 300, 589, 300);
            kp.DrawLine(tužka, 300, 10, 300, 589);
            kp.DrawString("0", new Font("Arial", 8), Brushes.Black, 290, 301);
            kp.DrawString("-10", new Font("Arial", 8), Brushes.Black,
            69 + jednotka, 302); //číslo -10 na X
            kp.DrawString("-5", new Font("Arial", 8), Brushes.Black,
            172 + jednotka, 302); //číslo -5 na X
            kp.DrawString("5", new Font("Arial", 8), Brushes.Black,
            375 + jednotka, 302); //číslo 5 na X
            kp.DrawString("10", new Font("Arial", 8), Brushes.Black,
            473 + jednotka, 302); //číslo 10 na X
            kp.DrawString("-10", new Font("Arial", 8), Brushes.Black, 278,
            513 - jednotka); //číslo -10 na Y
            kp.DrawString("-5", new Font("Arial", 8), Brushes.Black, 285,
            414 - jednotka); //číslo -5 na Y
            kp.DrawString("5", new Font("Arial", 8), Brushes.Black, 289,
            214 - jednotka); //číslo 5 na Y
            kp.DrawString("10", new Font("Arial", 8), Brushes.Black, 283,
            113 - jednotka); //číslo 10 na Y
            kp.DrawString("x", new Font("Arial", 8), Brushes.Black, 585, 301);
            kp.DrawString("y", new Font("Arial", 8), Brushes.Black, 289, 5);

        }
    }
}
