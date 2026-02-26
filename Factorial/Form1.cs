using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
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
            int a, fact, i;
            a = Convert.ToInt32(textBox1.Text);
            fact = 1;
            for (i = 1; i <= a; i++)
            {
                fact = fact * i;
            }
            textBox2.Text = "Factorial is:" + (fact);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num, count = 0;
            num = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2) textBox2.Text = "Prime Number";
            else
                textBox2.Text = "Not a Prime Number";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            string factors = "Factors of " + n + " are: ";
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    factors += i + " ";
                }
            }
            textBox2.Text = factors;
        }
    }
}

