namespace Library_System
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addbooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewbookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentdetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewstudentdetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBoooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnsBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addbookReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuebookReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnbookReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fineReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.issueBoooksToolStripMenuItem,
            this.returnsBooksToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.exitToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addbooksToolStripMenuItem,
            this.viewbookToolStripMenuItem});
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(117, 36);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // addbooksToolStripMenuItem
            // 
            this.addbooksToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbooksToolStripMenuItem.Name = "addbooksToolStripMenuItem";
            this.addbooksToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.addbooksToolStripMenuItem.Text = "Addbooks";
            this.addbooksToolStripMenuItem.Click += new System.EventHandler(this.addbooksToolStripMenuItem_Click);
            // 
            // viewbookToolStripMenuItem
            // 
            this.viewbookToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbookToolStripMenuItem.Name = "viewbookToolStripMenuItem";
            this.viewbookToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.viewbookToolStripMenuItem.Text = "viewbook";
            this.viewbookToolStripMenuItem.Click += new System.EventHandler(this.viewbookToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentdetailsToolStripMenuItem,
            this.viewstudentdetailsToolStripMenuItem});
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentToolStripMenuItem.Image")));
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(143, 36);
            this.studentToolStripMenuItem.Text = "Member";
            // 
            // studentdetailsToolStripMenuItem
            // 
            this.studentdetailsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentdetailsToolStripMenuItem.Name = "studentdetailsToolStripMenuItem";
            this.studentdetailsToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.studentdetailsToolStripMenuItem.Text = "AddMember";
            this.studentdetailsToolStripMenuItem.Click += new System.EventHandler(this.studentdetailsToolStripMenuItem_Click);
            // 
            // viewstudentdetailsToolStripMenuItem
            // 
            this.viewstudentdetailsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewstudentdetailsToolStripMenuItem.Name = "viewstudentdetailsToolStripMenuItem";
            this.viewstudentdetailsToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.viewstudentdetailsToolStripMenuItem.Text = "View_Member_details";
            this.viewstudentdetailsToolStripMenuItem.Click += new System.EventHandler(this.viewstudentdetailsToolStripMenuItem_Click);
            // 
            // issueBoooksToolStripMenuItem
            // 
            this.issueBoooksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.issueBoooksToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBoooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueBoooksToolStripMenuItem.Image")));
            this.issueBoooksToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.issueBoooksToolStripMenuItem.Name = "issueBoooksToolStripMenuItem";
            this.issueBoooksToolStripMenuItem.Size = new System.Drawing.Size(205, 36);
            this.issueBoooksToolStripMenuItem.Text = "Issue_Boooks";
            this.issueBoooksToolStripMenuItem.Click += new System.EventHandler(this.issueBoooksToolStripMenuItem_Click);
            // 
            // returnsBooksToolStripMenuItem
            // 
            this.returnsBooksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.returnsBooksToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnsBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnsBooksToolStripMenuItem.Image")));
            this.returnsBooksToolStripMenuItem.Name = "returnsBooksToolStripMenuItem";
            this.returnsBooksToolStripMenuItem.Size = new System.Drawing.Size(227, 36);
            this.returnsBooksToolStripMenuItem.Text = "Returns_Books";
            this.returnsBooksToolStripMenuItem.Click += new System.EventHandler(this.returnsBooksToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 36);
            this.exitToolStripMenuItem.Text = "Book_Stock";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exitToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addbookReportToolStripMenuItem,
            this.addMemberReportToolStripMenuItem,
            this.issuebookReportToolStripMenuItem,
            this.returnbookReportToolStripMenuItem,
            this.fineReportToolStripMenuItem});
            this.exitToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem1.Image")));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(137, 36);
            this.exitToolStripMenuItem1.Text = "Reports";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exitToolStripMenuItem2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem2.Image")));
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(93, 36);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // addbookReportToolStripMenuItem
            // 
            this.addbookReportToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbookReportToolStripMenuItem.Name = "addbookReportToolStripMenuItem";
            this.addbookReportToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.addbookReportToolStripMenuItem.Text = "Addbook Report";
            this.addbookReportToolStripMenuItem.Click += new System.EventHandler(this.addbookReportToolStripMenuItem_Click);
            // 
            // addMemberReportToolStripMenuItem
            // 
            this.addMemberReportToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberReportToolStripMenuItem.Name = "addMemberReportToolStripMenuItem";
            this.addMemberReportToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.addMemberReportToolStripMenuItem.Text = "AddMember Report";
            this.addMemberReportToolStripMenuItem.Click += new System.EventHandler(this.addMemberReportToolStripMenuItem_Click);
            // 
            // issuebookReportToolStripMenuItem
            // 
            this.issuebookReportToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuebookReportToolStripMenuItem.Name = "issuebookReportToolStripMenuItem";
            this.issuebookReportToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.issuebookReportToolStripMenuItem.Text = "Issuebook Report";
            this.issuebookReportToolStripMenuItem.Click += new System.EventHandler(this.issuebookReportToolStripMenuItem_Click);
            // 
            // returnbookReportToolStripMenuItem
            // 
            this.returnbookReportToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbookReportToolStripMenuItem.Name = "returnbookReportToolStripMenuItem";
            this.returnbookReportToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.returnbookReportToolStripMenuItem.Text = "Returnbook Report";
            this.returnbookReportToolStripMenuItem.Click += new System.EventHandler(this.returnbookReportToolStripMenuItem_Click);
            // 
            // fineReportToolStripMenuItem
            // 
            this.fineReportToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineReportToolStripMenuItem.Name = "fineReportToolStripMenuItem";
            this.fineReportToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.fineReportToolStripMenuItem.Text = "Fine Report";
            this.fineReportToolStripMenuItem.Click += new System.EventHandler(this.fineReportToolStripMenuItem_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 569);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addbooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewbookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentdetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewstudentdetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBoooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnsBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addbookReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMemberReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuebookReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnbookReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fineReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;


    }
}