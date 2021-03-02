using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = System.Convert.ToDouble(textBox1.Text);
            double num2 = System.Convert.ToDouble(textBox2.Text);
            String res = " ";
            switch(comboBox1.Text)
            {
                case "+":res = Convert.ToString(num1 + num2);
                    break;
                case "-":res = Convert.ToString(num1 - num2);
                    break;
                case "*":res = Convert.ToString(num1 * num2);
                    break;
                case "/": if (num2 == 0)
                    {
                        MessageBox.Show("除数不可以为0喔~");
                        break;
                    }
                    else
                    {
                        res = Convert.ToString(num1 / num2);
                        break;
                    }
            }
            MessageBox.Show("运算结果为" + res);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
