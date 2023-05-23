using System;
using System.Windows.Forms;

namespace Lab1_Question1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string operators = "";
        double firstNumber, secondNumber, total;



        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operators = "+";
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        //Minus
        private void button8_Click(object sender, EventArgs e)
        {
            operators = "-";
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        //Divid
        private void button12_Click(object sender, EventArgs e)
        {
            operators = "/";
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operators = "*";
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            total = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(textBox1.Text);

            if (operators == "*")
            {
                total = firstNumber * secondNumber;
            }
            else if (operators == "+")
            {
                total = firstNumber + secondNumber;
            }
            else if (operators == "/")
            {
                total = firstNumber / secondNumber;
            }
            else
            {
                total = firstNumber - secondNumber;
            }

            textBox1.Text = total.ToString();
        }

        //BTN 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }


    }
}

