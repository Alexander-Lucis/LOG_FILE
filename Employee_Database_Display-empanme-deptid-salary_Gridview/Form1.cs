//Q6.Write a C# SQL Program to display all the empname and deptId of the employee from the database.Using SQL source control and bind it to GridView.Database fields are (DeptID, DeptName, EmpName, Salary).
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

namespace Employee_Database_Display_empanme_deptid_salary_Gridview
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
            SqlCommand cmd = new SqlCommand("select deptId,DeptName from employee", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            dataGridView1.DataSource = dt;


        }
    }
}

//SQL SERVER-
//create table employee(deptId int, DeptName varchar(20), EmpName varchar(20), Salary int);
//insert into employee values(1,'Web Devlp','Sarah',20000);
//insert into employee values(2,'Analyst','Swaleha',2000);
//insert into employee values(3,'Manager','Falak',200000);
//insert into employee values(4,'CEO','Tehzeeb',200);
//select* from employee;