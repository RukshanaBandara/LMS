
namespace LibraryMS
{
    partial class viewBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.booknametxt = new System.Windows.Forms.TextBox();
            this.srchbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updtbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.cnclbtn = new System.Windows.Forms.Button();
            this.bauthortxt = new System.Windows.Forms.TextBox();
            this.bpubtxt = new System.Windows.Forms.TextBox();
            this.bpricetxt = new System.Windows.Forms.TextBox();
            this.bquantitytxt = new System.Windows.Forms.TextBox();
            this.bnametxt = new System.Windows.Forms.TextBox();
            this.bdatetxt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1540, 133);
            this.panel1.TabIndex = 0;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(1482, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(58, 42);
            this.btnclose.TabIndex = 18;
            this.btnclose.Text = "X";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(372, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informations of the Books";
            // 
            // booknametxt
            // 
            this.booknametxt.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booknametxt.Location = new System.Drawing.Point(1108, 150);
            this.booknametxt.Name = "booknametxt";
            this.booknametxt.Size = new System.Drawing.Size(388, 49);
            this.booknametxt.TabIndex = 2;
            this.booknametxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.booknametxt.TextChanged += new System.EventHandler(this.booknametxt_TextChanged);
            // 
            // srchbtn
            // 
            this.srchbtn.BackColor = System.Drawing.Color.Chocolate;
            this.srchbtn.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchbtn.ForeColor = System.Drawing.Color.Black;
            this.srchbtn.Location = new System.Drawing.Point(972, 220);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(155, 51);
            this.srchbtn.TabIndex = 3;
            this.srchbtn.Text = "Refresh";
            this.srchbtn.UseVisualStyleBackColor = false;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(580, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 484);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.updtbtn);
            this.panel2.Controls.Add(this.delbtn);
            this.panel2.Controls.Add(this.cnclbtn);
            this.panel2.Controls.Add(this.bauthortxt);
            this.panel2.Controls.Add(this.bpubtxt);
            this.panel2.Controls.Add(this.bpricetxt);
            this.panel2.Controls.Add(this.bquantitytxt);
            this.panel2.Controls.Add(this.bnametxt);
            this.panel2.Controls.Add(this.bdatetxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 531);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // updtbtn
            // 
            this.updtbtn.BackColor = System.Drawing.Color.Chocolate;
            this.updtbtn.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtbtn.ForeColor = System.Drawing.Color.Black;
            this.updtbtn.Location = new System.Drawing.Point(368, 425);
            this.updtbtn.Name = "updtbtn";
            this.updtbtn.Size = new System.Drawing.Size(141, 51);
            this.updtbtn.TabIndex = 6;
            this.updtbtn.Text = "Update";
            this.updtbtn.UseVisualStyleBackColor = false;
            this.updtbtn.Click += new System.EventHandler(this.updtbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.Color.Chocolate;
            this.delbtn.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.ForeColor = System.Drawing.Color.Black;
            this.delbtn.Location = new System.Drawing.Point(48, 425);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(122, 51);
            this.delbtn.TabIndex = 7;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = false;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // cnclbtn
            // 
            this.cnclbtn.BackColor = System.Drawing.Color.Chocolate;
            this.cnclbtn.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnclbtn.ForeColor = System.Drawing.Color.Black;
            this.cnclbtn.Location = new System.Drawing.Point(201, 425);
            this.cnclbtn.Name = "cnclbtn";
            this.cnclbtn.Size = new System.Drawing.Size(133, 51);
            this.cnclbtn.TabIndex = 8;
            this.cnclbtn.Text = "Cancel";
            this.cnclbtn.UseVisualStyleBackColor = false;
            this.cnclbtn.Click += new System.EventHandler(this.cnclbtn_Click);
            // 
            // bauthortxt
            // 
            this.bauthortxt.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bauthortxt.Location = new System.Drawing.Point(243, 101);
            this.bauthortxt.Name = "bauthortxt";
            this.bauthortxt.Size = new System.Drawing.Size(299, 38);
            this.bauthortxt.TabIndex = 18;
            // 
            // bpubtxt
            // 
            this.bpubtxt.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpubtxt.Location = new System.Drawing.Point(243, 158);
            this.bpubtxt.Name = "bpubtxt";
            this.bpubtxt.Size = new System.Drawing.Size(299, 38);
            this.bpubtxt.TabIndex = 17;
            // 
            // bpricetxt
            // 
            this.bpricetxt.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpricetxt.Location = new System.Drawing.Point(243, 272);
            this.bpricetxt.Name = "bpricetxt";
            this.bpricetxt.Size = new System.Drawing.Size(299, 38);
            this.bpricetxt.TabIndex = 16;
            // 
            // bquantitytxt
            // 
            this.bquantitytxt.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bquantitytxt.Location = new System.Drawing.Point(243, 332);
            this.bquantitytxt.Name = "bquantitytxt";
            this.bquantitytxt.Size = new System.Drawing.Size(299, 38);
            this.bquantitytxt.TabIndex = 15;
            // 
            // bnametxt
            // 
            this.bnametxt.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnametxt.Location = new System.Drawing.Point(243, 46);
            this.bnametxt.Name = "bnametxt";
            this.bnametxt.Size = new System.Drawing.Size(299, 38);
            this.bnametxt.TabIndex = 14;
            // 
            // bdatetxt
            // 
            this.bdatetxt.CalendarFont = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdatetxt.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdatetxt.Location = new System.Drawing.Point(243, 221);
            this.bdatetxt.Name = "bdatetxt";
            this.bdatetxt.Size = new System.Drawing.Size(299, 31);
            this.bdatetxt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Book Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Book Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Book Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Book Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Book Publication";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Purchase Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(743, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 34);
            this.label8.TabIndex = 19;
            this.label8.Text = " Name of the Book";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryMS.Properties.Resources.book3;
            this.pictureBox2.Location = new System.Drawing.Point(68, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // viewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 773);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.srchbtn);
            this.Controls.Add(this.booknametxt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewBooks";
            this.Load += new System.EventHandler(this.viewBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox booknametxt;
        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bauthortxt;
        private System.Windows.Forms.TextBox bpubtxt;
        private System.Windows.Forms.TextBox bpricetxt;
        private System.Windows.Forms.TextBox bquantitytxt;
        private System.Windows.Forms.TextBox bnametxt;
        private System.Windows.Forms.DateTimePicker bdatetxt;
        private System.Windows.Forms.Button updtbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button cnclbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}