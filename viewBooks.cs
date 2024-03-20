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
    public partial class viewBooks : Form
    {
        public viewBooks()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void viewBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook";
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
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook where bit="+bid+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            bnametxt.Text = ds.Tables[0].Rows[0][1].ToString();
            bauthortxt.Text = ds.Tables[0].Rows[0][2].ToString();
            bpubtxt.Text = ds.Tables[0].Rows[0][3].ToString();
            bdatetxt.Text = ds.Tables[0].Rows[0][4].ToString();
            bpricetxt.Text = ds.Tables[0].Rows[0][5].ToString();
            bquantitytxt.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void booknametxt_TextChanged(object sender, EventArgs e)
        {
            if (booknametxt.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook where bName LIKE '" + booknametxt.Text + "%'";
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

                cmd.CommandText = "select * from NewBook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }                      
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            booknametxt.Clear();
        }

        private void updtbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated. Confirm?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string bname = bnametxt.Text;
                string bauthor = bauthortxt.Text;
                string bpub = bpubtxt.Text;
                string pdate = bdatetxt.Text;
                Int64 bprice = Int64.Parse(bpricetxt.Text);
                Int32 bqty = Int32.Parse(bquantitytxt.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "update NewBook set bName='" + bname + "',bAuthor='" + bauthor + "',bPub1='" + bpub + "',bPDate='" + pdate + "',bPrice='" + bprice + "',bQuan='" + bqty + "'where bit=" + rowid + "";
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
                cmd.CommandText = "delete from NewBook where bit=" + rowid + "";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
