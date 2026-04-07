//Q1.Write a C# Program to accept the details from Employee(eid,ename,salary) and store it in the database and then display it in the
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


namespace Employee_Database_Gridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CS7JKRJ\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }
        private void GetStudentsRecord()
        {
            SqlCommand cmd = new SqlCommand("select*from emp", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into emp values(@eid,@ename,@salary)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@eid", textBox1.Text);
            cmd.Parameters.AddWithValue("@ename", textBox2.Text);
            cmd.Parameters.AddWithValue("@salary", textBox3.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully..!");
            GetStudentsRecord();
        }


    }
}

//SQL SERVER-
//USE master;
//create table emp(eid int, ename varchar(20), salary int);
//insert into emp values(1,'Rohan',75000);
//select* from emp;