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
    public partial class viewUser : Form
    {
        public viewUser()
        {
            InitializeComponent();
        }

        private void enrolltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void viewUser_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        int bid;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

            cmd.CommandText = "select * from NewStudent where stuid=" + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            snametxt.Text = ds.Tables[0].Rows[0][1].ToString();
            enrolltxt.Text = ds.Tables[0].Rows[0][2].ToString();
            deptxt.Text = ds.Tables[0].Rows[0][3].ToString();
            semtxt.Text = ds.Tables[0].Rows[0][4].ToString();
            contacttxt.Text = ds.Tables[0].Rows[0][5].ToString();
            emailtxt.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void stunametxt_TextChanged(object sender, EventArgs e)
        {
            if (stunametxt.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where enroll LIKE '" + stunametxt.Text + "%'";
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

                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            stunametxt.Clear();
        }

        private void updtbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated. Confirm?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string sname = snametxt.Text;
                string enroll = enrolltxt.Text;
                string dep = deptxt.Text;
                string sem = semtxt.Text;
                Int64 cont = Int64.Parse(contacttxt.Text);
                string email = emailtxt.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "update NewStudent set sName='" + sname + "',enroll='" + enroll + "',dep='" + dep + "',sem='" + sem + "',contact='" + cont + "',email='" + email + "'where stuid=" + rowid + "";
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
                cmd.CommandText = "delete from NewStudent where stuid=" + rowid + "";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


