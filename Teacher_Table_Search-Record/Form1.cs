//Q2.Write a C# Program to create a teacher table(tid,tname,subject) insert the records max(5)Search record of the teacher whose name is “ ----“ and display the result:
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


namespace Teacher_Table_Search_Record
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

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd = new SqlCommand("select * from teacher where tname like '%" + textBox1.Text + "%'", con);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
            con.Close();

        }
    }
}

//SQL SERVER-
//create table teacher(tid int, tname varchar(20), subject varchar(30));
//insert into teacher values(1,'Rebecca','English');
//insert into teacher values(2,'Victoria','Science');
//insert into teacher values(3,'Helen','Geography');
//select* from teacher;