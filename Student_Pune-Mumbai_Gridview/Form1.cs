//Q3.Write a C# Program to create a table student(rno,name,city,class),insert records (max5) update the city of the students to ‘Pune’ from ‘Mumbai’ and display the records in GridView:
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
namespace Student_Pune_Mumbai_Gridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update student set city='Pune' where city='Mumbai'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated City successfully..!");
            con.Close();
            DisplayData();
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("select*from student", con);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}

//SQL SERVER-
//create table student(rno int, name varchar(30), city varchar(20),class varchar(10));
//insert into student values(1,'Ariana','Mumbai','GRADE 7');
//insert into student values(2,'Justin','Bangalore','GRADE 9');
//insert into student values(3,'Nick','Mumbai','GRADE 8');
//insert into student values(4,'Abel','Hyderabad','GRADE 9');