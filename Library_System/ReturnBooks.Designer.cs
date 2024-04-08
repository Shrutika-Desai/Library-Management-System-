namespace Library_System
{
    partial class ReturnBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBooks));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchcmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtmcontact = new System.Windows.Forms.TextBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtmemail = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtmid = new System.Windows.Forms.TextBox();
            this.cmbmtype = new System.Windows.Forms.ComboBox();
            this.lblmembercontact = new System.Windows.Forms.Label();
            this.lblmembername = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblmembertype = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblmemberid = new System.Windows.Forms.Label();
            this.btnFine = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpreturn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbookname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.M_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(991, 705);
            this.webBrowser1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 511);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.searchtxt);
            this.panel2.Controls.Add(this.searchcmb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 188);
            this.panel2.TabIndex = 2;
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(42, 117);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(121, 22);
            this.searchtxt.TabIndex = 2;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // searchcmb
            // 
            this.searchcmb.FormattingEnabled = true;
            this.searchcmb.Items.AddRange(new object[] {
            "Member ID",
            "Member Type"});
            this.searchcmb.Location = new System.Drawing.Point(42, 61);
            this.searchcmb.Name = "searchcmb";
            this.searchcmb.Size = new System.Drawing.Size(121, 24);
            this.searchcmb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Member";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.btndelete);
            this.panel3.Controls.Add(this.txtmcontact);
            this.panel3.Controls.Add(this.txtmname);
            this.panel3.Controls.Add(this.txtmemail);
            this.panel3.Controls.Add(this.txtdepartment);
            this.panel3.Controls.Add(this.txtmid);
            this.panel3.Controls.Add(this.cmbmtype);
            this.panel3.Controls.Add(this.lblmembercontact);
            this.panel3.Controls.Add(this.lblmembername);
            this.panel3.Controls.Add(this.lblemail);
            this.panel3.Controls.Add(this.lblmembertype);
            this.panel3.Controls.Add(this.lbldepartment);
            this.panel3.Controls.Add(this.lblmemberid);
            this.panel3.Controls.Add(this.btnFine);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.dtpreturn);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmbbookname);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(308, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 417);
            this.panel3.TabIndex = 3;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(300, 345);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(91, 42);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtmcontact
            // 
            this.txtmcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmcontact.Location = new System.Drawing.Point(522, 80);
            this.txtmcontact.Name = "txtmcontact";
            this.txtmcontact.Size = new System.Drawing.Size(137, 27);
            this.txtmcontact.TabIndex = 20;
            // 
            // txtmname
            // 
            this.txtmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmname.Location = new System.Drawing.Point(170, 140);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(121, 27);
            this.txtmname.TabIndex = 19;
            // 
            // txtmemail
            // 
            this.txtmemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmemail.Location = new System.Drawing.Point(522, 143);
            this.txtmemail.Name = "txtmemail";
            this.txtmemail.Size = new System.Drawing.Size(137, 27);
            this.txtmemail.TabIndex = 18;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepartment.Location = new System.Drawing.Point(522, 17);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(137, 27);
            this.txtdepartment.TabIndex = 17;
            // 
            // txtmid
            // 
            this.txtmid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmid.Location = new System.Drawing.Point(170, 17);
            this.txtmid.Name = "txtmid";
            this.txtmid.Size = new System.Drawing.Size(121, 27);
            this.txtmid.TabIndex = 15;
            // 
            // cmbmtype
            // 
            this.cmbmtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmtype.FormattingEnabled = true;
            this.cmbmtype.Location = new System.Drawing.Point(170, 72);
            this.cmbmtype.Name = "cmbmtype";
            this.cmbmtype.Size = new System.Drawing.Size(121, 28);
            this.cmbmtype.TabIndex = 14;
            // 
            // lblmembercontact
            // 
            this.lblmembercontact.AutoSize = true;
            this.lblmembercontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmembercontact.Location = new System.Drawing.Point(334, 80);
            this.lblmembercontact.Name = "lblmembercontact";
            this.lblmembercontact.Size = new System.Drawing.Size(147, 20);
            this.lblmembercontact.TabIndex = 13;
            this.lblmembercontact.Text = "Member Contact";
            // 
            // lblmembername
            // 
            this.lblmembername.AutoSize = true;
            this.lblmembername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmembername.Location = new System.Drawing.Point(24, 140);
            this.lblmembername.Name = "lblmembername";
            this.lblmembername.Size = new System.Drawing.Size(130, 20);
            this.lblmembername.TabIndex = 12;
            this.lblmembername.Text = "Member Name";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(334, 143);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(129, 20);
            this.lblemail.TabIndex = 11;
            this.lblemail.Text = "Member Email";
            // 
            // lblmembertype
            // 
            this.lblmembertype.AutoSize = true;
            this.lblmembertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmembertype.Location = new System.Drawing.Point(24, 72);
            this.lblmembertype.Name = "lblmembertype";
            this.lblmembertype.Size = new System.Drawing.Size(122, 20);
            this.lblmembertype.TabIndex = 10;
            this.lblmembertype.Text = "Member Type";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(334, 20);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(107, 20);
            this.lbldepartment.TabIndex = 9;
            this.lbldepartment.Text = "Department";
            // 
            // lblmemberid
            // 
            this.lblmemberid.AutoSize = true;
            this.lblmemberid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemberid.Location = new System.Drawing.Point(24, 17);
            this.lblmemberid.Name = "lblmemberid";
            this.lblmemberid.Size = new System.Drawing.Size(97, 20);
            this.lblmemberid.TabIndex = 8;
            this.lblmemberid.Text = "Member id";
            // 
            // btnFine
            // 
            this.btnFine.BackColor = System.Drawing.Color.White;
            this.btnFine.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFine.ForeColor = System.Drawing.Color.Black;
            this.btnFine.Location = new System.Drawing.Point(502, 345);
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(96, 42);
            this.btnFine.TabIndex = 7;
            this.btnFine.Text = "Fine";
            this.btnFine.UseVisualStyleBackColor = false;
            this.btnFine.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(53, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Return Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpreturn
            // 
            this.dtpreturn.CustomFormat = "dd/MM/yyyy";
            this.dtpreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpreturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpreturn.Location = new System.Drawing.Point(522, 202);
            this.dtpreturn.Name = "dtpreturn";
            this.dtpreturn.Size = new System.Drawing.Size(158, 27);
            this.dtpreturn.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Return Book Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 209);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Due Date";
            // 
            // cmbbookname
            // 
            this.cmbbookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbookname.FormattingEnabled = true;
            this.cmbbookname.Location = new System.Drawing.Point(311, 280);
            this.cmbbookname.Name = "cmbbookname";
            this.cmbbookname.Size = new System.Drawing.Size(200, 28);
            this.cmbbookname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M_id,
            this.M_Type,
            this.M_Name,
            this.Department,
            this.M_Contact,
            this.M_Email});
            this.dataGridView1.Location = new System.Drawing.Point(308, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(683, 282);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // M_id
            // 
            this.M_id.DataPropertyName = "M_id";
            this.M_id.HeaderText = "M_id";
            this.M_id.Name = "M_id";
            this.M_id.ReadOnly = true;
            // 
            // M_Type
            // 
            this.M_Type.DataPropertyName = "M_Type";
            this.M_Type.HeaderText = "M_Type";
            this.M_Type.Name = "M_Type";
            this.M_Type.ReadOnly = true;
            // 
            // M_Name
            // 
            this.M_Name.DataPropertyName = "M_Name";
            this.M_Name.HeaderText = "M_Name";
            this.M_Name.Name = "M_Name";
            this.M_Name.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // M_Contact
            // 
            this.M_Contact.DataPropertyName = "M_Contact";
            this.M_Contact.HeaderText = "M_Contact";
            this.M_Contact.Name = "M_Contact";
            this.M_Contact.ReadOnly = true;
            // 
            // M_Email
            // 
            this.M_Email.DataPropertyName = "M_Email";
            this.M_Email.HeaderText = "M_Email";
            this.M_Email.Name = "M_Email";
            this.M_Email.ReadOnly = true;
            // 
            // ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 705);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "ReturnBooks";
            this.Text = "ReturnBooks";
            this.Load += new System.EventHandler(this.ReturnBooks_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.ComboBox searchcmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpreturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbookname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFine;
        private System.Windows.Forms.TextBox txtmcontact;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.TextBox txtmemail;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtmid;
        private System.Windows.Forms.ComboBox cmbmtype;
        private System.Windows.Forms.Label lblmembercontact;
        private System.Windows.Forms.Label lblmembername;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblmembertype;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblmemberid;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Email;
        private System.Windows.Forms.Button btndelete;
    }
}