using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("English");
            comboBox1.Items.Add("Maths");
            comboBox1.Items.Add("Hindi");
            comboBox1.Items.Add("Marathi");
            comboBox1.Items.Add("Geography");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Name");
                return;

            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please Enter Rollno");
                return;

            }
            if (!int.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Rollno Must be Numeric");
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("please select subject");
                return;
            }
            if (dateTimePicker1.Value >= DateTime.Now)
            {
                MessageBox.Show("Please Enter valid DOB");
            }
            MessageBox.Show("Register SuccessFull");
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
