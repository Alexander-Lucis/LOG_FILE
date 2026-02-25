using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text; 
            float a = float.Parse(textBox2.Text); 
            float b = float.Parse(textBox3.Text); 
            float c = float.Parse(textBox4.Text); 
            float t = (a + b + c) / 300; 
            float p = t * 100;
            label6.Text = "Name is: " + n; 
            label7.Text = "Percentage is: " + p; 
            if (p >= 85) 
            { 
                label5.Text = "Grade is A"; 
            } 
            else if ((p >= 85) && (p >= 50)) 
            { 
                label5.Text = "Grade is B"; 
            } 
            else 
            { 
                label5.Text = "Grade is C"; 
            }
        }
    }
}
