using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayLey
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        int n = 10;
        double length = 100;
        double per1 = 0.6;
        double per2 = 0.7;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        Pen pen = Pens.Blue;


        public Form1()
        {
            InitializeComponent();
        }

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void button_draw_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            else graphics.Clear(Form1.DefaultBackColor);
            drawCayleyTree(n, 250, 500, length, -Math.PI / 2);
        }

        private void textBox_n_TextChanged(object sender, EventArgs e)
        {
            int newN;
            Int32.TryParse(textBox_n.Text, out newN);
            if (n > 0) n = newN;
        }

        private void textBox_leng_TextChanged(object sender, EventArgs e)
        {
            double newLeng;
            Double.TryParse(textBox_leng.Text, out newLeng);
            if (newLeng > 0) length = newLeng;
        }
        private void textBox_per1_TextChanged(object sender, EventArgs e)
        {
            double newPer1;
            Double.TryParse(textBox_per1.Text, out newPer1);
            if (newPer1 > 0 && newPer1 < 1) per1 = newPer1;
        }
        private void textBox_per2_TextChanged(object sender, EventArgs e)
        {
            double newPer2;
            Double.TryParse(textBox_per2.Text, out newPer2);
            if (newPer2 > 0 && newPer2 < 1) per2 = newPer2;
        }
        private void textBox_th1_TextChanged(object sender, EventArgs e)
        {
            double newTh1;
            Double.TryParse(textBox_th1.Text, out newTh1);
            th1 = newTh1 * Math.PI / 180;
        }
        private void textBox_th2_TextChanged(object sender, EventArgs e)
        {
            double newTh2;
            Double.TryParse(textBox_th2.Text, out newTh2);
            th1 = newTh2 * Math.PI / 180;
        }
        private void comboBox_pen_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen = (Pen)comboBox_pen.SelectedItem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
