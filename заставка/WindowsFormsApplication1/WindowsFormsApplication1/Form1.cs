using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        int a = 100;
        int b = 100;
        int c = 300;
        int d = 300;
        int g = 100;
        int f = 500;
        bool wa = true;
        bool wb = true;
        bool wc = true;
        bool wd = true;
        bool wg = true;
        bool wf = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawEllipse(new Pen(Brushes.Black,100), a, b, 100, 100);
            base.OnPaint(e);
            e.Graphics.DrawEllipse(new Pen(Brushes.Green, 150), c, d, 150, 150);
            base.OnPaint(e);
            e.Graphics.DrawEllipse(new Pen(Brushes.Red, 125), g, f, 125, 125);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region Black
            if (wa == true)
            {
                a=a+5;
            }
            else
            {
                a=a-5;
            }
            if (wb == true)
            {
                b=b+5;
            }
            else
            {
                b=b-5;
            }
            if (b <= 50)
            {
                wb = true;
            }
            if (b >= Height-100)
            {
                wb = false;
            }
            if (a >= Width-80)
            {
                wa = false;
            }
            if (a <= 50)
            {
                wa = true;
            }
            Refresh();
            #endregion

            #region Green
            if (wc == true)
            {
                c=c+5;
            }
            else
            {
                c=c-5;
            }
            if (wd == true)
            {
                d=d+5;
            }
            else
            {
                d=d-5;
            }
            if (d <= 50)
            {
                wd = true;
            }
            if (d >= Height-50)
            {
                wd = false;
            }
            if (c >= Width-80)
            {
                wc = false;
            }
            if (c <= 50)
            {
                wc = true;
            }
            Refresh();
            #endregion

            #region red
            if (wg == true)
            {
                g+=5;
            }
            else
            {
                g-=5;
            }
            if (wf == true)
            {
                f+=5;
            }
            else
            {
                f-=5;
            }
            if (f <= 50)
            {
                wf = true;
            }
            if (f >= Height - 100)
            {
                wf = false;
            }
            if (g >= Width - 80)
            {
                wg = false;
            }
            if (g <= 50)
            {
                wg = true;
            }
            Refresh();
            #endregion

        }
    }
}
