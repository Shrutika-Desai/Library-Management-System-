namespace Library_System
{
    partial class viewbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewbook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_author_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_publication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAqty = new System.Windows.Forms.TextBox();
            this.lblAqty = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtbookquantity = new System.Windows.Forms.TextBox();
            this.txtbookprice = new System.Windows.Forms.TextBox();
            this.txtbookpublication = new System.Windows.Forms.TextBox();
            this.txtbookauthor = new System.Windows.Forms.TextBox();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.lblbookquantity = new System.Windows.Forms.Label();
            this.lblbookprice = new System.Windows.Forms.Label();
            this.lblbookpublication = new System.Windows.Forms.Label();
            this.lblauthorname = new System.Windows.Forms.Label();
            this.lblbookname = new System.Windows.Forms.Label();
            this.lblbookid = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 100);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(528, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Book";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_id,
            this.Book_name,
            this.Book_author_name,
            this.Book_publication,
            this.Book_price,
            this.Book_quantity,
            this.Available_quantity});
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 326);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Book_id
            // 
            this.Book_id.DataPropertyName = "Book_id";
            this.Book_id.HeaderText = "Book_id";
            this.Book_id.Name = "Book_id";
            this.Book_id.ReadOnly = true;
            // 
            // Book_name
            // 
            this.Book_name.DataPropertyName = "Book_name";
            this.Book_name.HeaderText = "Book_name";
            this.Book_name.Name = "Book_name";
            this.Book_name.ReadOnly = true;
            // 
            // Book_author_name
            // 
            this.Book_author_name.DataPropertyName = "Book_author_name";
            this.Book_author_name.HeaderText = "Book_author_name";
            this.Book_author_name.Name = "Book_author_name";
            this.Book_author_name.ReadOnly = true;
            // 
            // Book_publication
            // 
            this.Book_publication.DataPropertyName = "Book_publication";
            this.Book_publication.HeaderText = "Book_publication";
            this.Book_publication.Name = "Book_publication";
            this.Book_publication.ReadOnly = true;
            // 
            // Book_price
            // 
            this.Book_price.DataPropertyName = "Book_price";
            this.Book_price.HeaderText = "Book_price";
            this.Book_price.Name = "Book_price";
            this.Book_price.ReadOnly = true;
            // 
            // Book_quantity
            // 
            this.Book_quantity.DataPropertyName = "Book_quantity";
            this.Book_quantity.HeaderText = "Book_quantity";
            this.Book_quantity.Name = "Book_quantity";
            this.Book_quantity.ReadOnly = true;
            // 
            // Available_quantity
            // 
            this.Available_quantity.DataPropertyName = "Available_quantity";
            this.Available_quantity.HeaderText = "Available_quantity";
            this.Available_quantity.Name = "Available_quantity";
            this.Available_quantity.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.txtAqty);
            this.panel2.Controls.Add(this.lblAqty);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.txtbookquantity);
            this.panel2.Controls.Add(this.txtbookprice);
            this.panel2.Controls.Add(this.txtbookpublication);
            this.panel2.Controls.Add(this.txtbookauthor);
            this.panel2.Controls.Add(this.txtbookname);
            this.panel2.Controls.Add(this.txtbookid);
            this.panel2.Controls.Add(this.lblbookquantity);
            this.panel2.Controls.Add(this.lblbookprice);
            this.panel2.Controls.Add(this.lblbookpublication);
            this.panel2.Controls.Add(this.lblauthorname);
            this.panel2.Controls.Add(this.lblbookname);
            this.panel2.Controls.Add(this.lblbookid);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 229);
            this.panel2.TabIndex = 4;
            // 
            // txtAqty
            // 
            this.txtAqty.Location = new System.Drawing.Point(557, 173);
            this.txtAqty.Name = "txtAqty";
            this.txtAqty.Size = new System.Drawing.Size(100, 22);
            this.txtAqty.TabIndex = 18;
            this.txtAqty.TextChanged += new System.EventHandler(this.txtAqty_TextChanged);
            // 
            // lblAqty
            // 
            this.lblAqty.AutoSize = true;
            this.lblAqty.Location = new System.Drawing.Point(393, 178);
            this.lblAqty.Name = "lblAqty";
            this.lblAqty.Size = new System.Drawing.Size(137, 17);
            this.lblAqty.TabIndex = 17;
            this.lblAqty.Text = "Available quantity";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(882, 112);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(102, 43);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(753, 112);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(98, 43);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtbookquantity
            // 
            this.txtbookquantity.Location = new System.Drawing.Point(557, 112);
            this.txtbookquantity.Name = "txtbookquantity";
            this.txtbookquantity.Size = new System.Drawing.Size(100, 22);
            this.txtbookquantity.TabIndex = 12;
            // 
            // txtbookprice
            // 
            this.txtbookprice.Location = new System.Drawing.Point(557, 49);
            this.txtbookprice.Name = "txtbookprice";
            this.txtbookprice.Size = new System.Drawing.Size(100, 22);
            this.txtbookprice.TabIndex = 11;
            // 
            // txtbookpublication
            // 
            this.txtbookpublication.Location = new System.Drawing.Point(164, 194);
            this.txtbookpublication.Name = "txtbookpublication";
            this.txtbookpublication.Size = new System.Drawing.Size(189, 22);
            this.txtbookpublication.TabIndex = 10;
            // 
            // txtbookauthor
            // 
            this.txtbookauthor.Location = new System.Drawing.Point(164, 138);
            this.txtbookauthor.Name = "txtbookauthor";
            this.txtbookauthor.Size = new System.Drawing.Size(189, 22);
            this.txtbookauthor.TabIndex = 9;
            // 
            // txtbookname
            // 
            this.txtbookname.Location = new System.Drawing.Point(164, 76);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(189, 22);
            this.txtbookname.TabIndex = 8;
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(164, 28);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.ReadOnly = true;
            this.txtbookid.Size = new System.Drawing.Size(189, 22);
            this.txtbookid.TabIndex = 7;
            // 
            // lblbookquantity
            // 
            this.lblbookquantity.AutoSize = true;
            this.lblbookquantity.Location = new System.Drawing.Point(393, 112);
            this.lblbookquantity.Name = "lblbookquantity";
            this.lblbookquantity.Size = new System.Drawing.Size(110, 17);
            this.lblbookquantity.TabIndex = 6;
            this.lblbookquantity.Text = "Book Quantity";
            // 
            // lblbookprice
            // 
            this.lblbookprice.AutoSize = true;
            this.lblbookprice.Location = new System.Drawing.Point(393, 52);
            this.lblbookprice.Name = "lblbookprice";
            this.lblbookprice.Size = new System.Drawing.Size(86, 17);
            this.lblbookprice.TabIndex = 5;
            this.lblbookprice.Text = "Book Price";
            // 
            // lblbookpublication
            // 
            this.lblbookpublication.AutoSize = true;
            this.lblbookpublication.Location = new System.Drawing.Point(27, 197);
            this.lblbookpublication.Name = "lblbookpublication";
            this.lblbookpublication.Size = new System.Drawing.Size(129, 17);
            this.lblbookpublication.TabIndex = 3;
            this.lblbookpublication.Text = "Book Publication";
            // 
            // lblauthorname
            // 
            this.lblauthorname.AutoSize = true;
            this.lblauthorname.Location = new System.Drawing.Point(13, 138);
            this.lblauthorname.Name = "lblauthorname";
            this.lblauthorname.Size = new System.Drawing.Size(143, 17);
            this.lblauthorname.TabIndex = 2;
            this.lblauthorname.Text = "Book Author Name";
            // 
            // lblbookname
            // 
            this.lblbookname.AutoSize = true;
            this.lblbookname.Location = new System.Drawing.Point(50, 76);
            this.lblbookname.Name = "lblbookname";
            this.lblbookname.Size = new System.Drawing.Size(90, 17);
            this.lblbookname.TabIndex = 1;
            this.lblbookname.Text = "Book Name";
            // 
            // lblbookid
            // 
            this.lblbookid.AutoSize = true;
            this.lblbookid.Location = new System.Drawing.Point(59, 26);
            this.lblbookid.Name = "lblbookid";
            this.lblbookid.Size = new System.Drawing.Size(64, 17);
            this.lblbookid.TabIndex = 0;
            this.lblbookid.Text = "Book ID";
            this.lblbookid.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Location = new System.Drawing.Point(867, 119);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(134, 38);
            this.btnrefresh.TabIndex = 6;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(305, 132);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(104, 18);
            this.lblname.TabIndex = 7;
            this.lblname.Text = "Search book";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(629, 128);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(201, 22);
            this.txtsearch.TabIndex = 8;
            this.txtsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbsearch
            // 
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Items.AddRange(new object[] {
            "Book id",
            "Book name",
            "Book author"});
            this.cmbsearch.Location = new System.Drawing.Point(441, 126);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(171, 24);
            this.cmbsearch.TabIndex = 9;
            // 
            // viewbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1085, 534);
            this.Controls.Add(this.cmbsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "viewbook";
            this.Text = "viewbook";
            this.Load += new System.EventHandler(this.viewbook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtbookquantity;
        private System.Windows.Forms.TextBox txtbookprice;
        private System.Windows.Forms.TextBox txtbookpublication;
        private System.Windows.Forms.TextBox txtbookauthor;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.Label lblbookquantity;
        private System.Windows.Forms.Label lblbookprice;
        private System.Windows.Forms.Label lblbookpublication;
        private System.Windows.Forms.Label lblauthorname;
        private System.Windows.Forms.Label lblbookname;
        private System.Windows.Forms.Label lblbookid;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.TextBox txtAqty;
        private System.Windows.Forms.Label lblAqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_author_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_publication;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available_quantity;

    }
}