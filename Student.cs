using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEnrollment.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            //txtEmail.Clear();   

            txtEmail.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e, IWin32Window addStudent)
        {
            String enroll = txtEnrollment.Text;
            String dep = txtDepartment.Text;
            String sem = txtSemester.Text;
            String mobile =txtContact.Text;
            String email = txtEmail.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-7EODM8K\\SQLEXPRESS ; database=Elibrary;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            String name = txtName.Text;
            cmd.CommandText = "insert into NewStudent (sname ,enroll , dep , sem, contact, email ) values ('" + name + "','" + enroll + "','" +dep + "','" + sem + "','" + mobile + "')";
            cmd.BeginExecuteNonQuery();
            con.Close();

            MessageBox.Show (" Data Saved " , " Successfully! ",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
    }
}
