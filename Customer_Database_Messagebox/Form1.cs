//Q8.Write a C# SQL Program to accept the details of customer(cname,contact,email).Store it into the database with proper validation and display appropriate message by using MessageBox.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Customer_Database_Messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"");
        private void Form1_Load(object sender, EventArgs e)
        {
            GetRecord();
        }
        private void GetRecord()
        {
            SqlCommand cmd = new SqlCommand("select*from Customer", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty)
            {
                MessageBox.Show("Please enter all the details.", "Failed");

            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into Customer values(@name,@contact,@email)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@contact", textBox2.Text);
                cmd.Parameters.AddWithValue("@email", textBox3.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully..!");
                GetRecord();
            }


        }
    }
}

//SQL SERVER-
//create table Customer(name varchar(20), contact varchar(10), email varchar(20));