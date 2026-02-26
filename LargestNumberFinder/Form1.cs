using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LargestNumberFinder
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
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            if (a > b && a > c)
            {
                label4.Text = "The Largest of three number is: " + a;
            }
            else if (b > a && b > c)
            {
                label4.Text = "The Largest of three number is: " + b;
            }
            else
            {
                label4.Text = "The Largest of three number is: " + c;
            }
        }
    }
}
