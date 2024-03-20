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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update IRBook set book_return_date= '" + dateTimePicker1.Text + "'where std_enroll='" + txtEnterEnroll + "'and id =" + rowid + "";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Return succesfull.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //ReturnBook_Load(this_null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
			
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtEnterEnroll.Clear();
        }

        private void txtEnterEnroll_TextChanged(object sender, EventArgs e)
        {
            if (txtEnterEnroll.Text == "")
            {
                dataGridView1.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnterEnroll.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        String bname;
        String bdate;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible=true;
			if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null);
			{
			rowid=Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			bname=dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
			bdate=dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
			}
			txtBookName.Text=bname;
			txtBookIssueDate.Text=bdate;
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F3SVGIU\\SQLEXPRESS; database = Lib1; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from IRBook where std_enroll='" + txtEnterEnroll.Text + "'and book_return_date IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
