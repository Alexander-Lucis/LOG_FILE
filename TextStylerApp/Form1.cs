using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TextStylerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                textBox2.Font = new Font(textBox2.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                label5.Font = new Font(label5.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic);
                textBox2.Font = new Font(textBox2.Font, FontStyle.Bold | FontStyle.Italic);
                label5.Font = new Font(label5.Font, FontStyle.Bold | FontStyle.Italic);
            }
            else if (checkBox1.Checked == true && checkBox3.Checked == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Underline);
                textBox2.Font = new Font(textBox2.Font, FontStyle.Bold | FontStyle.Underline);
                label5.Font = new Font(label5.Font, FontStyle.Bold | FontStyle.Underline);
            }
            else if (checkBox2.Checked == true && checkBox3.Checked == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic | FontStyle.Underline);
                textBox2.Font = new Font(textBox2.Font, FontStyle.Italic | FontStyle.Underline);
                label5.Font = new Font(label5.Font, FontStyle.Italic | FontStyle.Underline);
            }
            else if (checkBox2.Checked == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
                textBox2.Font = new Font(textBox2.Font, FontStyle.Italic);
                label5.Font = new Font(label5.Font, FontStyle.Italic);
            }
            else if (checkBox1.Checked == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                textBox2.Font = new Font(textBox2.Font, FontStyle.Bold);
                label5.Font = new Font(label5.Font, FontStyle.Bold);
            }
            else if (checkBox3.Checked == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
                textBox2.Font = new Font(textBox2.Font, FontStyle.Underline);
                label5.Font = new Font(label5.Font, FontStyle.Underline);
            }
            label5.Text = textBox2.Text + " " + textBox1.Text;

        }
    }
}
