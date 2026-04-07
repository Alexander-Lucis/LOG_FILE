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

namespace VegetableListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Cauliflower ");
            listBox1.Items.Add("Brocolli ");
            listBox1.Items.Add("Carrot ");
            listBox1.Items.Add("Beetroot ");
            listBox1.Items.Add("Cucumber ");
            listBox1.Items.Add("Bellpeppers ");
            listBox1.Items.Add("Spinach ");
            listBox1.Items.Add("Chick Peas ");
            listBox1.Items.Add("Tomatoes ");
            listBox1.Items.Add("Potatoes ");
            listBox1.Items.Add("Lettuce ");
            listBox1.Items.Add("Zucchini ");
            listBox1.SelectionMode = SelectionMode.MultiSimple;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Selected veggies are: ";
            foreach (var item in listBox1.SelectedItems)
            {
                label2.Text += item.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
