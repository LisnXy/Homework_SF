using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Printer
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        public Pen pen = new Pen(Color.Blue,1);
        int th1 = 20,th2 = 30;
        double per1 = 0.6, per2 = 0.7;
        int depth = 10;
        int lenth = 20;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = depth;
            numericUpDown2.Value = lenth;
            numericUpDown3.Value = (decimal)per2;
            numericUpDown4.Value = (decimal)per1;
            numericUpDown5.Value = th2;
            numericUpDown6.Value = th1;
            pictureBox1.BackColor = pen.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = panel1.CreateGraphics();
            graphics.Clear(Color.White);
            drawCayleyTree(depth, 200,300, lenth, -Math.PI / 2);
        }
          

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            per2 = (double)numericUpDown3.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            depth = (int)numericUpDown1.Value;
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.ShowDialog();
            pictureBox1.BackColor = colorDialog1.Color;
            pen.Color = colorDialog1.Color;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            lenth = (int)numericUpDown2.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            per1 = (double)numericUpDown4.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            th2 = (int)numericUpDown5.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            th1 = (int)numericUpDown6.Value;
        }

   

        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = x0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + (double)(th1 / 180 * Math.PI ));
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - (double)(th2 / 180 * Math.PI ));
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }
    }
}
