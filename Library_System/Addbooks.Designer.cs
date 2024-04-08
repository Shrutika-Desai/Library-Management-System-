namespace Library_System
{
    partial class Addbooks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addbooks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblbookid = new System.Windows.Forms.Label();
            this.lblbookname = new System.Windows.Forms.Label();
            this.lblauthorname = new System.Windows.Forms.Label();
            this.lblbookpublication = new System.Windows.Forms.Label();
            this.lblbookprice = new System.Windows.Forms.Label();
            this.lblbookquantity = new System.Windows.Forms.Label();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.txtbookauthor = new System.Windows.Forms.TextBox();
            this.txtbookpublication = new System.Windows.Forms.TextBox();
            this.txtbookprice = new System.Windows.Forms.TextBox();
            this.txtbookquantity = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblAqty = new System.Windows.Forms.Label();
            this.txtAqty = new System.Windows.Forms.TextBox();
            this.errorname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorauthor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorpublication = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorprice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorquantity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorqt = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorauthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorpublication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorqt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 96);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(486, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 34);
            this.label8.TabIndex = 1;
            this.label8.Text = "Add Book";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(343, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblbookid
            // 
            this.lblbookid.AutoSize = true;
            this.lblbookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookid.Location = new System.Drawing.Point(389, 118);
            this.lblbookid.Name = "lblbookid";
            this.lblbookid.Size = new System.Drawing.Size(76, 20);
            this.lblbookid.TabIndex = 2;
            this.lblbookid.Text = "Book ID";
            // 
            // lblbookname
            // 
            this.lblbookname.AutoSize = true;
            this.lblbookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookname.Location = new System.Drawing.Point(389, 187);
            this.lblbookname.Name = "lblbookname";
            this.lblbookname.Size = new System.Drawing.Size(105, 20);
            this.lblbookname.TabIndex = 3;
            this.lblbookname.Text = "Book Name";
            // 
            // lblauthorname
            // 
            this.lblauthorname.AutoSize = true;
            this.lblauthorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblauthorname.Location = new System.Drawing.Point(389, 257);
            this.lblauthorname.Name = "lblauthorname";
            this.lblauthorname.Size = new System.Drawing.Size(166, 20);
            this.lblauthorname.TabIndex = 4;
            this.lblauthorname.Text = "Book Author Name";
            // 
            // lblbookpublication
            // 
            this.lblbookpublication.AutoSize = true;
            this.lblbookpublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookpublication.Location = new System.Drawing.Point(385, 336);
            this.lblbookpublication.Name = "lblbookpublication";
            this.lblbookpublication.Size = new System.Drawing.Size(150, 20);
            this.lblbookpublication.TabIndex = 5;
            this.lblbookpublication.Text = "Book Publication";
            // 
            // lblbookprice
            // 
            this.lblbookprice.AutoSize = true;
            this.lblbookprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookprice.Location = new System.Drawing.Point(389, 413);
            this.lblbookprice.Name = "lblbookprice";
            this.lblbookprice.Size = new System.Drawing.Size(101, 20);
            this.lblbookprice.TabIndex = 7;
            this.lblbookprice.Text = "Book Price";
            // 
            // lblbookquantity
            // 
            this.lblbookquantity.AutoSize = true;
            this.lblbookquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookquantity.Location = new System.Drawing.Point(385, 484);
            this.lblbookquantity.Name = "lblbookquantity";
            this.lblbookquantity.Size = new System.Drawing.Size(127, 20);
            this.lblbookquantity.TabIndex = 8;
            this.lblbookquantity.Text = "Book Quantity";
            // 
            // txtbookid
            // 
            this.txtbookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookid.Location = new System.Drawing.Point(587, 111);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.ReadOnly = true;
            this.txtbookid.Size = new System.Drawing.Size(207, 27);
            this.txtbookid.TabIndex = 9;
            // 
            // txtbookname
            // 
            this.txtbookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookname.Location = new System.Drawing.Point(587, 180);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(207, 27);
            this.txtbookname.TabIndex = 10;
            //this.txtbookname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbookname_KeyPress);
            this.txtbookname.Leave += new System.EventHandler(this.txtbookname_Leave);
            // 
            // txtbookauthor
            // 
            this.txtbookauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookauthor.Location = new System.Drawing.Point(587, 250);
            this.txtbookauthor.Name = "txtbookauthor";
            this.txtbookauthor.Size = new System.Drawing.Size(207, 27);
            this.txtbookauthor.TabIndex = 11;
           // this.txtbookauthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbookauthor_KeyPress);
            this.txtbookauthor.Leave += new System.EventHandler(this.txtbookauthor_Leave);
            // 
            // txtbookpublication
            // 
            this.txtbookpublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookpublication.Location = new System.Drawing.Point(587, 329);
            this.txtbookpublication.Name = "txtbookpublication";
            this.txtbookpublication.Size = new System.Drawing.Size(207, 27);
            this.txtbookpublication.TabIndex = 12;
           // this.txtbookpublication.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbookpublication_KeyPress);
            this.txtbookpublication.Leave += new System.EventHandler(this.txtbookpublication_Leave);
            // 
            // txtbookprice
            // 
            this.txtbookprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookprice.Location = new System.Drawing.Point(587, 410);
            this.txtbookprice.Name = "txtbookprice";
            this.txtbookprice.Size = new System.Drawing.Size(207, 27);
            this.txtbookprice.TabIndex = 13;
            this.txtbookprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbookprice_KeyPress);
            this.txtbookprice.Leave += new System.EventHandler(this.txtbookprice_Leave);
            // 
            // txtbookquantity
            // 
            this.txtbookquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookquantity.Location = new System.Drawing.Point(587, 484);
            this.txtbookquantity.Name = "txtbookquantity";
            this.txtbookquantity.Size = new System.Drawing.Size(207, 27);
            this.txtbookquantity.TabIndex = 15;
            this.txtbookquantity.TextChanged += new System.EventHandler(this.txtbookquantity_TextChanged);
            this.txtbookquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbookquantity_KeyPress);
            this.txtbookquantity.Leave += new System.EventHandler(this.txtbookquantity_Leave);
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(909, 257);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(121, 36);
            this.btnnew.TabIndex = 16;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(909, 413);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(121, 32);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lblAqty
            // 
            this.lblAqty.AutoSize = true;
            this.lblAqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAqty.Location = new System.Drawing.Point(385, 548);
            this.lblAqty.Name = "lblAqty";
            this.lblAqty.Size = new System.Drawing.Size(161, 20);
            this.lblAqty.TabIndex = 18;
            this.lblAqty.Text = "Available Quantity";
            // 
            // txtAqty
            // 
            this.txtAqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAqty.Location = new System.Drawing.Point(587, 554);
            this.txtAqty.Name = "txtAqty";
            this.txtAqty.Size = new System.Drawing.Size(207, 27);
            this.txtAqty.TabIndex = 19;
            this.txtAqty.TextChanged += new System.EventHandler(this.txtAqty_TextChanged);
            this.txtAqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAqty_KeyPress);
            this.txtAqty.Leave += new System.EventHandler(this.txtAqty_Leave);
            // 
            // errorname
            // 
            this.errorname.ContainerControl = this;
            // 
            // errorauthor
            // 
            this.errorauthor.ContainerControl = this;
            // 
            // errorpublication
            // 
            this.errorpublication.ContainerControl = this;
            // 
            // errorprice
            // 
            this.errorprice.ContainerControl = this;
            // 
            // errorquantity
            // 
            this.errorquantity.ContainerControl = this;
            // 
            // errorqt
            // 
            this.errorqt.ContainerControl = this;
            // 
            // Addbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1085, 593);
            this.Controls.Add(this.txtAqty);
            this.Controls.Add(this.lblAqty);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.txtbookquantity);
            this.Controls.Add(this.txtbookprice);
            this.Controls.Add(this.txtbookpublication);
            this.Controls.Add(this.txtbookauthor);
            this.Controls.Add(this.txtbookname);
            this.Controls.Add(this.txtbookid);
            this.Controls.Add(this.lblbookquantity);
            this.Controls.Add(this.lblbookprice);
            this.Controls.Add(this.lblbookpublication);
            this.Controls.Add(this.lblauthorname);
            this.Controls.Add(this.lblbookname);
            this.Controls.Add(this.lblbookid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Addbooks";
            this.Text = "Addbooks";
            this.Load += new System.EventHandler(this.Addbooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorauthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorpublication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorqt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblbookid;
        private System.Windows.Forms.Label lblbookname;
        private System.Windows.Forms.Label lblauthorname;
        private System.Windows.Forms.Label lblbookpublication;
        private System.Windows.Forms.Label lblbookprice;
        private System.Windows.Forms.Label lblbookquantity;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.TextBox txtbookauthor;
        private System.Windows.Forms.TextBox txtbookpublication;
        private System.Windows.Forms.TextBox txtbookprice;
        private System.Windows.Forms.TextBox txtbookquantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblAqty;
        private System.Windows.Forms.TextBox txtAqty;
        private System.Windows.Forms.ErrorProvider errorname;
        private System.Windows.Forms.ErrorProvider errorauthor;
        private System.Windows.Forms.ErrorProvider errorpublication;
        private System.Windows.Forms.ErrorProvider errorprice;
        private System.Windows.Forms.ErrorProvider errorquantity;
        private System.Windows.Forms.ErrorProvider errorqt;
    }
}