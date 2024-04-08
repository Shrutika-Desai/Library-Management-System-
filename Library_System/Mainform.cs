using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library_System.Reports;


namespace Library_System
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void addbooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addbooks A = new Addbooks();
            A.Show();
         
            
        }

        private void viewbookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewbook v = new viewbook();
            v.Show();


        }

        private void studentdetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember S = new AddMember();
            S.Show();
            

        }

        private void viewstudentdetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Member_details vsd = new View_Member_details();
            vsd.Show();
           
        }

       

       

        private void issueBoooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issue_book IB = new issue_book();
            IB.Show();
           
        }

        

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void returnsBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBooks RB = new ReturnBooks();
            RB.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookStock BS = new BookStock();

            BS.Show();
        }

        private void fineformToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addbookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddbookRfrm book = new AddbookRfrm();
            book.Show();
        }

        private void addMemberReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddmemberRfrm m = new AddmemberRfrm();
            m.Show();
        }

        private void issuebookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssuebookRfrm ab = new IssuebookRfrm();
            ab.Show();
        }

        private void returnbookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnbookRfrm rb = new ReturnbookRfrm();
            rb.Show();
        }

        private void fineReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FineRfrm fine = new FineRfrm();
            fine.Show();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();





        } 
    }
}
