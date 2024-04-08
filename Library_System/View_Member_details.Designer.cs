namespace Library_System
{
    partial class View_Member_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Member_details));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Member_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblmemberid = new System.Windows.Forms.Label();
            this.lblmembername = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblmembercontact = new System.Windows.Forms.Label();
            this.lblmembermail = new System.Windows.Forms.Label();
            this.txtmemberid = new System.Windows.Forms.TextBox();
            this.txtmembername = new System.Windows.Forms.TextBox();
            this.txtmembercontact = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtmemberemail = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblmembertype = new System.Windows.Forms.Label();
            this.cmbmembertype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Member_ID,
            this.Member_Type,
            this.Member_Name,
            this.Department,
            this.Member_Contact,
            this.Member_Email});
            this.dataGridView1.Location = new System.Drawing.Point(550, 85);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(370, 453);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Member_ID
            // 
            this.Member_ID.DataPropertyName = "Member_ID";
            this.Member_ID.HeaderText = "Member_ID";
            this.Member_ID.Name = "Member_ID";
            this.Member_ID.ReadOnly = true;
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
            // lblmemberid
            // 
            this.lblmemberid.AutoSize = true;
            this.lblmemberid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemberid.Location = new System.Drawing.Point(59, 26);
            this.lblmemberid.Name = "lblmemberid";
            this.lblmemberid.Size = new System.Drawing.Size(101, 20);
            this.lblmemberid.TabIndex = 1;
            this.lblmemberid.Text = "Member ID";
            // 
            // lblmembername
            // 
            this.lblmembername.AutoSize = true;
            this.lblmembername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmembername.Location = new System.Drawing.Point(59, 160);
            this.lblmembername.Name = "lblmembername";
            this.lblmembername.Size = new System.Drawing.Size(130, 20);
            this.lblmembername.TabIndex = 2;
            this.lblmembername.Text = "Member Name";
            this.lblmembername.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(59, 216);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(107, 20);
            this.lbldepartment.TabIndex = 3;
            this.lbldepartment.Text = "Department";
            // 
            // lblmembercontact
            // 
            this.lblmembercontact.AutoSize = true;
            this.lblmembercontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmembercontact.Location = new System.Drawing.Point(59, 282);
            this.lblmembercontact.Name = "lblmembercontact";
            this.lblmembercontact.Size = new System.Drawing.Size(147, 20);
            this.lblmembercontact.TabIndex = 5;
            this.lblmembercontact.Text = "Member Contact";
            // 
            // lblmembermail
            // 
            this.lblmembermail.AutoSize = true;
            this.lblmembermail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmembermail.Location = new System.Drawing.Point(60, 337);
            this.lblmembermail.Name = "lblmembermail";
            this.lblmembermail.Size = new System.Drawing.Size(129, 20);
            this.lblmembermail.TabIndex = 6;
            this.lblmembermail.Text = "Member Email";
            // 
            // txtmemberid
            // 
            this.txtmemberid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmemberid.Location = new System.Drawing.Point(262, 22);
            this.txtmemberid.Name = "txtmemberid";
            this.txtmemberid.ReadOnly = true;
            this.txtmemberid.Size = new System.Drawing.Size(203, 27);
            this.txtmemberid.TabIndex = 7;
            // 
            // txtmembername
            // 
            this.txtmembername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmembername.Location = new System.Drawing.Point(262, 153);
            this.txtmembername.Name = "txtmembername";
            this.txtmembername.Size = new System.Drawing.Size(203, 27);
            this.txtmembername.TabIndex = 8;
            this.txtmembername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtmembercontact
            // 
            this.txtmembercontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmembercontact.Location = new System.Drawing.Point(262, 282);
            this.txtmembercontact.Name = "txtmembercontact";
            this.txtmembercontact.Size = new System.Drawing.Size(203, 27);
            this.txtmembercontact.TabIndex = 9;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepartment.Location = new System.Drawing.Point(262, 209);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(203, 27);
            this.txtdepartment.TabIndex = 9;
            this.txtdepartment.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtmemberemail
            // 
            this.txtmemberemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmemberemail.Location = new System.Drawing.Point(262, 337);
            this.txtmemberemail.Name = "txtmemberemail";
            this.txtmemberemail.Size = new System.Drawing.Size(203, 27);
            this.txtmemberemail.TabIndex = 9;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(84, 470);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(102, 35);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(290, 467);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(102, 38);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search Member";
            // 
            // cmbsearch
            // 
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Items.AddRange(new object[] {
            "Member id",
            "Member Name"});
            this.cmbsearch.Location = new System.Drawing.Point(749, 19);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(121, 24);
            this.cmbsearch.TabIndex = 13;
            this.cmbsearch.SelectedIndexChanged += new System.EventHandler(this.cmbsearch_SelectedIndexChanged);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(714, 57);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(206, 22);
            this.txtsearch.TabIndex = 14;
            this.txtsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblmembertype
            // 
            this.lblmembertype.AutoSize = true;
            this.lblmembertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmembertype.Location = new System.Drawing.Point(59, 97);
            this.lblmembertype.Name = "lblmembertype";
            this.lblmembertype.Size = new System.Drawing.Size(126, 20);
            this.lblmembertype.TabIndex = 15;
            this.lblmembertype.Text = "Member_Type";
            // 
            // cmbmembertype
            // 
            this.cmbmembertype.FormattingEnabled = true;
            this.cmbmembertype.Location = new System.Drawing.Point(262, 97);
            this.cmbmembertype.Name = "cmbmembertype";
            this.cmbmembertype.Size = new System.Drawing.Size(203, 24);
            this.cmbmembertype.TabIndex = 16;
            // 
            // View_Member_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 540);
            this.Controls.Add(this.cmbmembertype);
            this.Controls.Add(this.lblmembertype);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.cmbsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtmemberemail);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtmembercontact);
            this.Controls.Add(this.txtmembername);
            this.Controls.Add(this.txtmemberid);
            this.Controls.Add(this.lblmembermail);
            this.Controls.Add(this.lblmembercontact);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblmembername);
            this.Controls.Add(this.lblmemberid);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "View_Member_details";
            this.Text = "View_Member_details";
            this.Load += new System.EventHandler(this.View_Member_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblmemberid;
        private System.Windows.Forms.Label lblmembername;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblmembercontact;
        private System.Windows.Forms.Label lblmembermail;
        private System.Windows.Forms.TextBox txtmemberid;
        private System.Windows.Forms.TextBox txtmembername;
        private System.Windows.Forms.TextBox txtmembercontact;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtmemberemail;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_Email;
        private System.Windows.Forms.Label lblmembertype;
        private System.Windows.Forms.ComboBox cmbmembertype;

    }
}