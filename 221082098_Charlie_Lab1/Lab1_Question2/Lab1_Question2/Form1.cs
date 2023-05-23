using System;
using System.Windows.Forms;

namespace Lab1_Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            float balance = float.Parse(textBox2.Text);
            float newBalance = balance * 1.25f;
            float monthlyPayment = 0f;

            listBox1.Items.Add("Payment         New Balance");
            while (newBalance > 15f)
            {
                listBox1.Items.Add("R " + Math.Round(monthlyPayment, 2) + "      R " + Math.Round(newBalance, 2));
                monthlyPayment = newBalance * 0.12f;
                newBalance -= monthlyPayment;

            }
            listBox1.Items.Add("Pay " + Math.Round(newBalance, 2) + " in full.");

        }

        //Clear button

        private void btn21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.Items.Clear();
        }

        //Exit button

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
