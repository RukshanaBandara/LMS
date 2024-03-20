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

namespace LibraryMS
{
    public partial class addLecturer : Form
    {
        public addLecturer()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All unsaved changes will be lost?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lnametxt.Clear();
            lnumtxt.Clear();
            deptxt.Clear();
            contacttxt.Clear();
            emailtxt.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string lname = lnametxt.Text;
            string lnum = lnumtxt.Text;
            string dep = deptxt.Text;
            Int64 contact = Int64.Parse(contacttxt.Text);
            string email = emailtxt.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into Lecturer (lname,lnum,dep,contact,email) values ('" + lname + "','" + lnum + "','" + dep + "','" + contact + "','" + email + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addLecturer_Load(object sender, EventArgs e)
        {

        }
    }
}
