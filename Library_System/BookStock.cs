using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace Library_System
{
    public partial class BookStock : Form
    {
        dbcodeclass db = new dbcodeclass();
        public BookStock()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookStock_Load(object sender, EventArgs e)
        {
            db.FillGridData(dataGridView1, "Select Book_name,Book_author_name,Book_publication,Book_price,Book_quantity,Available_quantity from Addbooktbl");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            cmbSearch.Text = dataGridView1.SelectedCells[0].Value.ToString();
            db.FillGridData(dataGridView2, "select * from issuebooktbl where book_name='" + cmbSearch.Text + "'");

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtsearch.Text == "")
                {
                    db.FillGridData(dataGridView1, "Select * from Addbooktbl");
                    return;
                }
                if (cmbSearch.SelectedIndex == 0)
                {
                    db.FillGridData(dataGridView1, "Select * from Addbooktbl where Book_name like'" + txtsearch.Text+"%'");
                }
                else
                {
                    db.FillGridData(dataGridView1, "Select * from Addbooktbl where Book_author_name like'" + txtsearch.Text + "%'");
                }
            }
            catch { }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string i;
            i= dataGridView2.SelectedCells[5].Value.ToString();
            txtemail.Text = i.ToString();

        
            
        }

        private void btnemail_Click(object sender, EventArgs e)
        {
            try
            {

                SmtpClient sm = new SmtpClient("smtp.gmail.com", 587);
                sm.EnableSsl = true;
                sm.UseDefaultCredentials = false;

                sm.Credentials = new NetworkCredential("shrutikadesai286@gmail.com", "nkzhxcwtyxldiyqz");

                MailMessage mail = new MailMessage("shrutikadesai286@gmail.com", txtemail.Text, "Library Book Return Notice", textBox2.Text);
                mail.Priority = MailPriority.High;
                sm.EnableSsl = true;
                sm.Send(mail);
                MessageBox.Show("Mail Sent!");
            }
            catch (SmtpException ex)
            {
                throw new ApplicationException("SmtpException has occured:" + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
                   

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
