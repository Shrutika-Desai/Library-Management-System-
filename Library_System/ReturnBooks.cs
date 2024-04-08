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
    public partial class ReturnBooks : Form
    {
        dbcodeclass db = new dbcodeclass();
        public ReturnBooks()
        {
            InitializeComponent();
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            db.FillCombo(cmbmtype, "Select * from Membertbl", "Member_Type", "Member_ID");
            db.FillCombo(cmbbookname, "Select * from Addbooktbl", "Book_name", "Book_id");
            //db.ExecuteSqlQuery("Select Due_Date from Issuebooktbl where Due_Date='"+dateTimePicker1.Value.ToString()+"'");
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if(searchtxt.Text == "")
                {
                    db.FillGridData(dataGridView1, "Select * from Issuebooktbl");
                    return;
                }
                if (searchcmb.SelectedIndex == 0)
                {
                    db.FillGridData(dataGridView1, "Select * from  Issuebooktbl where M_id=" + searchtxt.Text);
                } 
                else
                {
                    db.FillGridData(dataGridView1, "Select * from  Issuebooktbl where M_Type like'" + searchtxt.Text + "%'");
                }
            }
            catch { }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();
        }
        void Griddisplay()
        {
            try
            {

                txtmid.Text = dataGridView1.SelectedRows[0].Cells["M_ID"].Value.ToString();
                cmbmtype.Text = dataGridView1.SelectedRows[0].Cells["M_Type"].Value.ToString();
                txtmname.Text = dataGridView1.SelectedRows[0].Cells["M_Name"].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["Due_Date"].Value.ToString());
                txtdepartment.Text = dataGridView1.SelectedRows[0].Cells["Department"].Value.ToString();
                txtmcontact.Text = dataGridView1.SelectedRows[0].Cells["M_Contact"].Value.ToString();
                txtmemail.Text = dataGridView1.SelectedRows[0].Cells["M_Email"].Value.ToString();
                cmbbookname.Text = dataGridView1.SelectedRows[0].Cells["book_name"].Value.ToString();
                fine();
            }
            catch { }
        }
        void fine()
        {
            if (dateTimePicker1 != dtpreturn)
            {
                btnFine.BackColor = Color.Red;
                btnFine.Focus();
            }
            else
            {
                MessageBox.Show("There is no fine");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            db.ExecuteSqlQuery("insert into Returnbooktbl(M_id,M_type,M_name,Dept,M_contact,M_email,Book_name,Book_Return_Date)values('" + txtmid.Text + "','" + cmbmtype.Text + "','" + txtmname.Text + "','" + txtdepartment.Text + "','" + txtmcontact.Text + "','" + txtmemail.Text + "','" + cmbbookname.Text + "','" + dtpreturn.Value.ToString() + "')");
            db.ExecuteSqlQuery("update Addbooktbl set Available_quantity=Available_quantity+1 where book_name='" + cmbbookname.Text + "'");
            MessageBox.Show("Book return Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fineform F = new Fineform();
            F.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete record", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteSqlQuery("Delete from Issuebooktbl where M_id='" + txtmid.Text + "'");
                MessageBox.Show("record deleted successfully");
            }
        }

       
       
    }
}

