﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con =new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7EODM8K\\SQLEXPRESS ; database=Elibrary;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from loginTable where username = '" + txtUsername.Text + "' and pass = '" + txtPassword.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count !=0)   
            {
                this.Hide();
                Dashboard dsa = new Dashboard();
                dsa.Show();

            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
