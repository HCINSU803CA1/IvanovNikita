using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string expression = textBox1.Text;
                char[] signs = { '+', '-', '*', '/' };
                string[] operands = expression.Split(signs);
                char sign = expression[operands[0].Length];
                int rezult = 0;
                switch (sign)
                {
                    case '+':
                        rezult = Int32.Parse(operands[0]) + Int32.Parse(operands[1]);
                        break;
                    case '-':
                        rezult = Int32.Parse(operands[0]) + Int32.Parse(operands[1]);
                        break;
                    case '*':
                        rezult = Int32.Parse(operands[0]) + Int32.Parse(operands[1]);
                        break;
                    case '/':
                        rezult = Int32.Parse(operands[0]) + Int32.Parse(operands[1]);
                        break;
                }
                textBox1.Text += "=" + rezult.ToString();
            }
        }

    }
}
