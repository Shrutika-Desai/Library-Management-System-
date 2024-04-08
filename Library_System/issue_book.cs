using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_System
{
    public partial class issue_book : Form
    {
        dbcodeclass db = new dbcodeclass();
        public issue_book()
        {
            InitializeComponent();
        }

        private void issue_book_Load(object sender, EventArgs e)
        {
            db.FillCombo(cmbbookname, "Select * from Addbooktbl", "Book_name", "Book_id");
            db.FillGridData(dataGridView1, "Select * from Membertbl");
          }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtSearch.Text == "")
                {
                    db.FillGridData(dataGridView1, "Select * from Membertbl ");
                    return;
                }
                if (cmbstudent.SelectedIndex == 0)
                {
                    db.FillGridData(dataGridView1, "Select * from Membertbl where Member_ID=" + txtSearch.Text);
                }
                else
                {
                    db.FillGridData(dataGridView1, "Select * from Membertbl where Member_Type like'" + txtSearch.Text + "%'");
                }
            }
            catch { }
        }

        private void cmbstudent_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {   
            Griddisplay();

        }
        void Griddisplay()
        {
            try
            {
                txtmemberid.Text = dataGridView1.SelectedRows[0].Cells["Member_id"].Value.ToString();
                cmbmembertype.Text = dataGridView1.SelectedRows[0].Cells["Member_type"].Value.ToString();
                txtmembername.Text = dataGridView1.SelectedRows[0].Cells["Member_name"].Value.ToString();
                txtdepartment.Text = dataGridView1.SelectedRows[0].Cells["Department"].Value.ToString();
                txtmembercontact.Text = dataGridView1.SelectedRows[0].Cells["Member_contact"].Value.ToString();
                txtmemberemail.Text = dataGridView1.SelectedRows[0].Cells["Member_email"].Value.ToString();
               // cmbbookname.Text = dataGridView1.SelectedRows[5].Cells["book_name"].Value.ToString();
              //  dtpissue.Value = DateTime.Parse(dataGridView1.SelectedRows[6].Cells["book_issue_date"].Value.ToString());
               // dtpdue.Value = DateTime.Parse(dataGridView1.SelectedRows[7].Cells["Due_date"].Value.ToString());
            }
            catch { }
        }
        private void btnissue_Click(object sender, EventArgs e)
        {

            db.ExecuteSqlQuery("insert into Issuebooktbl(M_id,M_Type,M_Name,Department,M_Contact,M_Email,Book_Name,Book_Issue_Date,Due_Date)values('" + txtmemberid.Text + "','" +cmbmembertype.Text+ "','" + txtmembername.Text + "','" + txtdepartment.Text + "','" + txtmembercontact.Text + "','" + txtmemberemail.Text + "','" + cmbbookname.Text + "','" + dtpissue.Value.ToString() + "','" + dtpdue.Value.ToString() + "')");
           MessageBox.Show("book issued successfully");
           db.ExecuteSqlQuery("update Addbooktbl set Available_quantity=Available_quantity-1 where book_name='" + cmbbookname.Text+"'");
        }

        private void lbldepartment_Click(object sender, EventArgs e)
        {

        }

        private void txtdepartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmemberemail_TextChanged(object sender, EventArgs e)
        {

        }

       


        
    }
}
