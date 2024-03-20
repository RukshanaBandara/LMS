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
    public partial class addBook : Form
    {
        public addBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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
            cmd.CommandText= "insert into NewBook (bName,bAuthor,bPub1,bpDate,bPrice,bQuan) values ('"+bname+ "','"+bauthor+ "','"+bpub+ "','"+pdate+ "','"+bprice+ "','"+bqty+"')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bnametxt.Clear();
            bauthortxt.Clear();
            bpubtxt.Clear();
            bpricetxt.Clear();
            bquantitytxt.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All unsaved changes will be lost?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addBook_Load(object sender, EventArgs e)
        {

        }

        private void bnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bauthortxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
