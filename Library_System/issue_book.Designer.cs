namespace Library_System
{
    partial class issue_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issue_book));
            this.txtmemberemail = new System.Windows.Forms.TextBox();
            this.txtmembercontact = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtmembername = new System.Windows.Forms.TextBox();
            this.txtmemberid = new System.Windows.Forms.TextBox();
            this.lblmemberemail = new System.Windows.Forms.Label();
            this.lblmembercontact = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblmembername = new System.Windows.Forms.Label();
            this.lblmemberid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbookname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpissue = new System.Windows.Forms.DateTimePicker();
            this.btnissue = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Member_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbstudent = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpdue = new System.Windows.Forms.DateTimePicker();
            this.lblmembertype = new System.Windows.Forms.Label();
            this.cmbmembertype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmemberemail
            // 
            this.txtmemberemail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmemberemail.Location = new System.Drawing.Point(597, 348);
            this.txtmemberemail.Name = "txtmemberemail";
            this.txtmemberemail.Size = new System.Drawing.Size(247, 22);
            this.txtmemberemail.TabIndex = 25;
            this.txtmemberemail.TextChanged += new System.EventHandler(this.txtmemberemail_TextChanged);
            // 
            // txtmembercontact
            // 
            this.txtmembercontact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmembercontact.Location = new System.Drawing.Point(597, 283);
            this.txtmembercontact.Name = "txtmembercontact";
            this.txtmembercontact.Size = new System.Drawing.Size(247, 22);
            this.txtmembercontact.TabIndex = 24;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdepartment.Location = new System.Drawing.Point(597, 212);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(244, 22);
            this.txtdepartment.TabIndex = 22;
            this.txtdepartment.TextChanged += new System.EventHandler(this.txtdepartment_TextChanged);
            // 
            // txtmembername
            // 
            this.txtmembername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmembername.Location = new System.Drawing.Point(597, 145);
            this.txtmembername.Name = "txtmembername";
            this.txtmembername.Size = new System.Drawing.Size(244, 22);
            this.txtmembername.TabIndex = 21;
            // 
            // txtmemberid
            // 
            this.txtmemberid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmemberid.Location = new System.Drawing.Point(597, 16);
            this.txtmemberid.Name = "txtmemberid";
            this.txtmemberid.Size = new System.Drawing.Size(244, 22);
            this.txtmemberid.TabIndex = 20;
            // 
            // lblmemberemail
            // 
            this.lblmemberemail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmemberemail.AutoSize = true;
            this.lblmemberemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemberemail.Location = new System.Drawing.Point(354, 352);
            this.lblmemberemail.Name = "lblmemberemail";
            this.lblmemberemail.Size = new System.Drawing.Size(182, 29);
            this.lblmemberemail.TabIndex = 19;
            this.lblmemberemail.Text = "Member Email";
            // 
            // lblmembercontact
            // 
            this.lblmembercontact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmembercontact.AutoSize = true;
            this.lblmembercontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmembercontact.Location = new System.Drawing.Point(354, 276);
            this.lblmembercontact.Name = "lblmembercontact";
            this.lblmembercontact.Size = new System.Drawing.Size(204, 29);
            this.lblmembercontact.TabIndex = 18;
            this.lblmembercontact.Text = "Member Contact";
            // 
            // lbldepartment
            // 
            this.lbldepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(355, 205);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(148, 29);
            this.lbldepartment.TabIndex = 16;
            this.lbldepartment.Text = "Department";
            this.lbldepartment.Click += new System.EventHandler(this.lbldepartment_Click);
            // 
            // lblmembername
            // 
            this.lblmembername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmembername.AutoSize = true;
            this.lblmembername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmembername.Location = new System.Drawing.Point(354, 138);
            this.lblmembername.Name = "lblmembername";
            this.lblmembername.Size = new System.Drawing.Size(185, 29);
            this.lblmembername.TabIndex = 15;
            this.lblmembername.Text = "Member Name";
            // 
            // lblmemberid
            // 
            this.lblmemberid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmemberid.AutoSize = true;
            this.lblmemberid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemberid.Location = new System.Drawing.Point(354, 9);
            this.lblmemberid.Name = "lblmemberid";
            this.lblmemberid.Size = new System.Drawing.Size(141, 29);
            this.lblmemberid.TabIndex = 14;
            this.lblmemberid.Text = "Member ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Book Name";
            // 
            // cmbbookname
            // 
            this.cmbbookname.FormattingEnabled = true;
            this.cmbbookname.Location = new System.Drawing.Point(597, 420);
            this.cmbbookname.Name = "cmbbookname";
            this.cmbbookname.Size = new System.Drawing.Size(224, 24);
            this.cmbbookname.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Book Issue Date";
            // 
            // dtpissue
            // 
            this.dtpissue.Checked = false;
            this.dtpissue.CustomFormat = "dd/MM/yyyy";
            this.dtpissue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpissue.Location = new System.Drawing.Point(597, 495);
            this.dtpissue.Name = "dtpissue";
            this.dtpissue.Size = new System.Drawing.Size(224, 22);
            this.dtpissue.TabIndex = 29;
            // 
            // btnissue
            // 
            this.btnissue.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnissue.Location = new System.Drawing.Point(597, 612);
            this.btnissue.Name = "btnissue";
            this.btnissue.Size = new System.Drawing.Size(207, 44);
            this.btnissue.TabIndex = 30;
            this.btnissue.Text = "Issue Book";
            this.btnissue.UseVisualStyleBackColor = true;
            this.btnissue.Click += new System.EventHandler(this.btnissue_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Member_id,
            this.Member_Type,
            this.Member_Name,
            this.Department,
            this.Member_Contact,
            this.Member_Email});
            this.dataGridView1.Location = new System.Drawing.Point(1, 193);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(333, 472);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Member_id
            // 
            this.Member_id.DataPropertyName = "Member_id";
            this.Member_id.HeaderText = "Member_id";
            this.Member_id.Name = "Member_id";
            this.Member_id.ReadOnly = true;
            // 
            // Member_Type
            // 
            this.Member_Type.DataPropertyName = "Member_Type";
            this.Member_Type.HeaderText = "Member_Type";
            this.Member_Type.Name = "Member_Type";
            this.Member_Type.ReadOnly = true;
            // 
            // Member_Name
            // 
            this.Member_Name.DataPropertyName = "Member_Name";
            this.Member_Name.HeaderText = "Member_Name";
            this.Member_Name.Name = "Member_Name";
            this.Member_Name.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // Member_Contact
            // 
            this.Member_Contact.DataPropertyName = "Member_Contact";
            this.Member_Contact.HeaderText = "Member_Contact";
            this.Member_Contact.Name = "Member_Contact";
            this.Member_Contact.ReadOnly = true;
            // 
            // Member_Email
            // 
            this.Member_Email.DataPropertyName = "Member_Email";
            this.Member_Email.HeaderText = "Member_Email";
            this.Member_Email.Name = "Member_Email";
            this.Member_Email.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Search Member";
            // 
            // cmbstudent
            // 
            this.cmbstudent.FormattingEnabled = true;
            this.cmbstudent.Items.AddRange(new object[] {
            "Member id",
            "member type"});
            this.cmbstudent.Location = new System.Drawing.Point(39, 79);
            this.cmbstudent.Name = "cmbstudent";
            this.cmbstudent.Size = new System.Drawing.Size(185, 24);
            this.cmbstudent.TabIndex = 33;
            this.cmbstudent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbstudent_MouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(39, 131);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 36);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Due Date";
            // 
            // dtpdue
            // 
            this.dtpdue.Checked = false;
            this.dtpdue.CustomFormat = "dd/MM/yyyy";
            this.dtpdue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdue.Location = new System.Drawing.Point(597, 565);
            this.dtpdue.Name = "dtpdue";
            this.dtpdue.Size = new System.Drawing.Size(221, 22);
            this.dtpdue.TabIndex = 36;
            // 
            // lblmembertype
            // 
            this.lblmembertype.AutoSize = true;
            this.lblmembertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmembertype.Location = new System.Drawing.Point(354, 72);
            this.lblmembertype.Name = "lblmembertype";
            this.lblmembertype.Size = new System.Drawing.Size(175, 29);
            this.lblmembertype.TabIndex = 37;
            this.lblmembertype.Text = "Member Type";
            // 
            // cmbmembertype
            // 
            this.cmbmembertype.FormattingEnabled = true;
            this.cmbmembertype.Location = new System.Drawing.Point(597, 77);
            this.cmbmembertype.Name = "cmbmembertype";
            this.cmbmembertype.Size = new System.Drawing.Size(244, 24);
            this.cmbmembertype.TabIndex = 38;
            // 
            // issue_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 677);
            this.Controls.Add(this.cmbmembertype);
            this.Controls.Add(this.lblmembertype);
            this.Controls.Add(this.dtpdue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbstudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnissue);
            this.Controls.Add(this.dtpissue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbbookname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmemberemail);
            this.Controls.Add(this.txtmembercontact);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtmembername);
            this.Controls.Add(this.txtmemberid);
            this.Controls.Add(this.lblmemberemail);
            this.Controls.Add(this.lblmembercontact);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblmembername);
            this.Controls.Add(this.lblmemberid);
            this.DoubleBuffered = true;
            this.Name = "issue_book";
            this.Text = "issue_book";
            this.Load += new System.EventHandler(this.issue_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmemberemail;
        private System.Windows.Forms.TextBox txtmembercontact;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtmembername;
        private System.Windows.Forms.TextBox txtmemberid;
        private System.Windows.Forms.Label lblmemberemail;
        private System.Windows.Forms.Label lblmembercontact;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblmembername;
        private System.Windows.Forms.Label lblmemberid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbookname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpissue;
        private System.Windows.Forms.Button btnissue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbstudent;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpdue;
        private System.Windows.Forms.Label lblmembertype;
        private System.Windows.Forms.ComboBox cmbmembertype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_Email;
    }
}