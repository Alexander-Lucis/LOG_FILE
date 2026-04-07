//Q4.Write a C# SQL Program for the following:
//1.Create a Supplier table(sid, sname, phn, addr) Do the following operations.
//a.Insert the Record
//b.Update a record
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



namespace Supplier_Database_Insert_Update_Record
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
            SqlCommand cmd = new SqlCommand("insert into supplier values(@sid,@sname,@phn,@addr)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@sid", textBox1.Text);
            cmd.Parameters.AddWithValue("@sname", textBox2.Text);
            cmd.Parameters.AddWithValue("@phn", textBox3.Text);
            cmd.Parameters.AddWithValue("@addr", textBox4.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully..!");
            GetSupplierRecord();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetSupplierRecord();
        }
        private void GetSupplierRecord()
        {
            SqlCommand cmd = new SqlCommand("select*from supplier", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update supplier set sname=@sname,phn=@phn,addr=@addr where sid=@sid", con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@sid", textBox1.Text);
            cmd.Parameters.AddWithValue("@sname", textBox2.Text);
            cmd.Parameters.AddWithValue("@phn", textBox3.Text);
            cmd.Parameters.AddWithValue("@addr", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated successfully..!");
            con.Close();
            GetSupplierRecord();

        }
    }
}

//SQL SERVER-
//create table supplier(sid int, sname varchar(20), phn varchar(20), addr varchar(20))