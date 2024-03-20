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
    public partial class viewLecturer : Form
    {
        public viewLecturer()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void viewLecturer_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Lecturer";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        int bid;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());           
                }

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Lecturer where lnum=" + bid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                snametxt.Text = ds.Tables[0].Rows[0][1].ToString();
                enrolltxt.Text = ds.Tables[0].Rows[0][2].ToString();
                deptxt.Text = ds.Tables[0].Rows[0][3].ToString();
                contacttxt.Text = ds.Tables[0].Rows[0][5].ToString();
                emailtxt.Text = ds.Tables[0].Rows[0][6].ToString();
            }
        }

        private void lecnametxt_TextChanged(object sender, EventArgs e)
        {
            if (lecnametxt.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Lecturer where lnum LIKE '" + lecnametxt.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Lecturer";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            lecnametxt.Clear();
        }

        private void updtbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated. Confirm?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string sname = snametxt.Text;
                string enroll = enrolltxt.Text;
                string dep = deptxt.Text;
                Int64 cont = Int64.Parse(contacttxt.Text);
                string email = emailtxt.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "update Lecturer set lName='" + sname + "',lnum='" + enroll + "',dep='" + dep + "',contact='" + cont + "',email='" + email + "'where lecid=" + rowid + "";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Data will be Deleted. Confirm?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "delete from Lecturer where lecid=" + rowid + "";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cnclbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All unsaved daa will be lost?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void snametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
