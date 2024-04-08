namespace Library_System
{
    partial class Fineform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fineform));
            this.label1 = new System.Windows.Forms.Label();
            this.lbldaysdelayed = new System.Windows.Forms.Label();
            this.lblfine = new System.Windows.Forms.Label();
            this.lbltotalfine = new System.Windows.Forms.Label();
            this.txtdaysdelayed = new System.Windows.Forms.TextBox();
            this.txtfine = new System.Windows.Forms.TextBox();
            this.txttotalfine = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblmid = new System.Windows.Forms.Label();
            this.lblmtype = new System.Windows.Forms.Label();
            this.lblmname = new System.Windows.Forms.Label();
            this.cmbmtype = new System.Windows.Forms.ComboBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtmid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.M_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fine Calculator";
            // 
            // lbldaysdelayed
            // 
            this.lbldaysdelayed.AutoSize = true;
            this.lbldaysdelayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldaysdelayed.Location = new System.Drawing.Point(392, 334);
            this.lbldaysdelayed.Name = "lbldaysdelayed";
            this.lbldaysdelayed.Size = new System.Drawing.Size(146, 25);
            this.lbldaysdelayed.TabIndex = 1;
            this.lbldaysdelayed.Text = "Days Delayed";
            // 
            // lblfine
            // 
            this.lblfine.AutoSize = true;
            this.lblfine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfine.Location = new System.Drawing.Point(392, 410);
            this.lblfine.Name = "lblfine";
            this.lblfine.Size = new System.Drawing.Size(137, 25);
            this.lblfine.TabIndex = 2;
            this.lblfine.Text = "Fine Per Day";
            // 
            // lbltotalfine
            // 
            this.lbltotalfine.AutoSize = true;
            this.lbltotalfine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalfine.Location = new System.Drawing.Point(392, 482);
            this.lbltotalfine.Name = "lbltotalfine";
            this.lbltotalfine.Size = new System.Drawing.Size(109, 25);
            this.lbltotalfine.TabIndex = 3;
            this.lbltotalfine.Text = "Total Fine";
            // 
            // txtdaysdelayed
            // 
            this.txtdaysdelayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdaysdelayed.Location = new System.Drawing.Point(581, 334);
            this.txtdaysdelayed.Multiline = true;
            this.txtdaysdelayed.Name = "txtdaysdelayed";
            this.txtdaysdelayed.Size = new System.Drawing.Size(240, 36);
            this.txtdaysdelayed.TabIndex = 4;
            this.txtdaysdelayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtfine
            // 
            this.txtfine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfine.Location = new System.Drawing.Point(581, 400);
            this.txtfine.Multiline = true;
            this.txtfine.Name = "txtfine";
            this.txtfine.ReadOnly = true;
            this.txtfine.Size = new System.Drawing.Size(240, 38);
            this.txtfine.TabIndex = 5;
            this.txtfine.Text = "2.00";
            this.txtfine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txttotalfine
            // 
            this.txttotalfine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalfine.Location = new System.Drawing.Point(581, 480);
            this.txttotalfine.Multiline = true;
            this.txttotalfine.Name = "txttotalfine";
            this.txttotalfine.ReadOnly = true;
            this.txttotalfine.Size = new System.Drawing.Size(240, 37);
            this.txttotalfine.TabIndex = 6;
            this.txttotalfine.Text = "0.00";
            this.txttotalfine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(417, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblmid
            // 
            this.lblmid.AutoSize = true;
            this.lblmid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmid.Location = new System.Drawing.Point(392, 134);
            this.lblmid.Name = "lblmid";
            this.lblmid.Size = new System.Drawing.Size(117, 25);
            this.lblmid.TabIndex = 8;
            this.lblmid.Text = "Member ID";
            // 
            // lblmtype
            // 
            this.lblmtype.AutoSize = true;
            this.lblmtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmtype.Location = new System.Drawing.Point(392, 204);
            this.lblmtype.Name = "lblmtype";
            this.lblmtype.Size = new System.Drawing.Size(145, 25);
            this.lblmtype.TabIndex = 9;
            this.lblmtype.Text = "Member Type";
            // 
            // lblmname
            // 
            this.lblmname.AutoSize = true;
            this.lblmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmname.Location = new System.Drawing.Point(392, 271);
            this.lblmname.Name = "lblmname";
            this.lblmname.Size = new System.Drawing.Size(152, 25);
            this.lblmname.TabIndex = 10;
            this.lblmname.Text = "Member Name";
            // 
            // cmbmtype
            // 
            this.cmbmtype.FormattingEnabled = true;
            this.cmbmtype.Location = new System.Drawing.Point(581, 204);
            this.cmbmtype.Name = "cmbmtype";
            this.cmbmtype.Size = new System.Drawing.Size(240, 24);
            this.cmbmtype.TabIndex = 11;
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(581, 261);
            this.txtmname.Multiline = true;
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(240, 35);
            this.txtmname.TabIndex = 12;
            // 
            // txtmid
            // 
            this.txtmid.Location = new System.Drawing.Point(581, 134);
            this.txtmid.Multiline = true;
            this.txtmid.Name = "txtmid";
            this.txtmid.Size = new System.Drawing.Size(240, 38);
            this.txtmid.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M_id,
            this.M_Type,
            this.M_Name});
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(355, 531);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // M_id
            // 
            this.M_id.DataPropertyName = "M_id";
            this.M_id.HeaderText = "Member_id";
            this.M_id.Name = "M_id";
            // 
            // M_Type
            // 
            this.M_Type.DataPropertyName = "M_Type";
            this.M_Type.HeaderText = "Member_Type";
            this.M_Type.Name = "M_Type";
            // 
            // M_Name
            // 
            this.M_Name.DataPropertyName = "M_Name";
            this.M_Name.HeaderText = "Member_Name";
            this.M_Name.Name = "M_Name";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(722, 571);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 37);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Fineform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 666);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtmid);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.cmbmtype);
            this.Controls.Add(this.lblmname);
            this.Controls.Add(this.lblmtype);
            this.Controls.Add(this.lblmid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttotalfine);
            this.Controls.Add(this.txtfine);
            this.Controls.Add(this.txtdaysdelayed);
            this.Controls.Add(this.lbltotalfine);
            this.Controls.Add(this.lblfine);
            this.Controls.Add(this.lbldaysdelayed);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Fineform";
            this.Text = "Fineform";
            this.Load += new System.EventHandler(this.Fineform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldaysdelayed;
        private System.Windows.Forms.Label lblfine;
        private System.Windows.Forms.Label lbltotalfine;
        private System.Windows.Forms.TextBox txtdaysdelayed;
        private System.Windows.Forms.TextBox txtfine;
        private System.Windows.Forms.TextBox txttotalfine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblmid;
        private System.Windows.Forms.Label lblmtype;
        private System.Windows.Forms.Label lblmname;
        private System.Windows.Forms.ComboBox cmbmtype;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.TextBox txtmid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Name;
    }
}