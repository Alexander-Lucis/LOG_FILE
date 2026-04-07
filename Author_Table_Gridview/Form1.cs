//Q5.Write a C# SQL Program to create Author table(aid,aname,bookname).Insert the records (max5). Delete a record of author who has written “__(bookname)” and display remaining records in the dataGridView.
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

namespace Author_Table_Gridview
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
            GetBookRecord();
        }
        private void GetBookRecord()
        {
            SqlCommand cmd = new SqlCommand("select*from Author", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Delete from Author where bkname=@bkname", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@bkname", textBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully..!");
            GetBookRecord();


        }
    }
}

//SQL SERVER-
//create table Author(aid int, aname varchar(20), bkname varchar(20));
//insert into Author values(1,'Colleen Hoover','Ugly Love');
//insert into Author values(2,'Paulo Coelho','Alchemist');
//insert into Author values(3,'Ana Huang','Twisted Games');
//insert into Author values(4,'H.D Carlton','Haunting Adeline');
//insert into Author values(5,'Jane Austen','Pride and Prejudice');
//select* from Author;