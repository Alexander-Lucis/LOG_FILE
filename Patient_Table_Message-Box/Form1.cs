//Q7.Write a C# SQL Program to create a table PATIENT(PID,Pname,Contact,Disease). Insert five records into table and display appropriate message in message box.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Patient_Table_Message_Box
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
            SqlCommand cmd = new SqlCommand("select*from cust", con);
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
                SqlCommand cmd = new SqlCommand("insert into Patient values(@id,@name,@email)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
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
//create table Patient(pid int, pname varchar(20), cont varchar(20), disease varchar(20));
//insert into Patient values(1,'Sarah','9876541230','Food Poison');
//insert into Patient values(2,'Tehzeeb','9878841230','Depression');
//insert into Patient values(3,'Swaleha','9976541230','Migrain');