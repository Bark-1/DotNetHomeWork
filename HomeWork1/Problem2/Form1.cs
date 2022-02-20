using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem2
{
    public partial class Form1 : Form
    {
        double Num1 = 0;
        double Num2 = 0;
        string Op="N";
        bool IsValid = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //判断输入的字符串可否转换为数字
            if (double.TryParse(textBox1.Text,out Num1))
            {
                IsValid = true;
            }
            else
            {
                IsValid = false;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            //判断输入的字符串可否转换为数字
            if (double.TryParse(textBox2.Text, out Num2))
            {
                IsValid = true;
            }
            else
            {
                IsValid = false;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Op = comboBox1.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                switch (Op)
                {
                    case "+":
                        label2.Text = Convert.ToString(Num1 + Num2);
                        break;
                    case "-":
                        label2.Text = Convert.ToString(Num1 - Num2);
                        break;
                    case "*":
                        label2.Text = Convert.ToString(Num1 * Num2);
                        break;
                    case "/":
                        if (Num2 == 0) label2.Text = "Wrong";
                        else label2.Text = Convert.ToString(Num1 / Num2);
                        break;
                    case "%":
                        if (Num2 == 0) label2.Text = "Wrong";
                        else label2.Text = Convert.ToString(Num1 % Num2);
                        break;
                    default:
                        label2.Text = "Result";
                        break;
                }
            }
            else
            {
                label2.Text = "Wrong Num";
            }
            
        }
    }
}
