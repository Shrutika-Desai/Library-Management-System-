using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_System
{
    public partial class View_Member_details : Form
    {
        dbcodeclass db = new dbcodeclass();
        public View_Member_details()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void cleardata()
        {
            txtmemberid.Clear();
            txtmembername.Clear();
            txtdepartment.Clear();
            txtmembercontact.Clear();
            txtmemberemail.Clear();

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
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
                txtmemberid.Text = dataGridView1.SelectedRows[0].Cells["Member_ID"].Value.ToString();
                cmbmembertype.Text= dataGridView1.SelectedRows[0].Cells["Member_type"].Value.ToString();
                txtmembername.Text = dataGridView1.SelectedRows[0].Cells["Member_Name"].Value.ToString();
                txtdepartment.Text = dataGridView1.SelectedRows[0].Cells["Department"].Value.ToString();
                txtmembercontact.Text = dataGridView1.SelectedRows[0].Cells["Member_Contact"].Value.ToString();
                txtmemberemail.Text = dataGridView1.SelectedRows[0].Cells["Member_Email"].Value.ToString();
            }
            catch { }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtmemberid.Text == "" || txtmembername.Text == "")
            {
                MessageBox.Show("Missing Fields...");
            }
            db.ExecuteSqlQuery("Update Membertbl set Member_Type='"+cmbmembertype.Text+"', Member_Name='" + txtmembername.Text + "',Department='" + txtdepartment.Text + "',Member_Contact='" + txtmembercontact.Text + "',Member_Email='" + txtmemberemail.Text + "'where Member_ID=" + txtmemberid.Text);
            db.FillGridData(dataGridView1, "Select * from Membertbl");

            MessageBox.Show("Data Updated Successfully...");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to delete record", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteSqlQuery("Delete from Membertbl where Member_ID =" + txtmemberid.Text);
            }
            db.FillGridData(dataGridView1, "Select * from Membertbl");
            MessageBox.Show("Data Deleted Successfully....");
            cleardata();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtsearch.Text == "")
                {
                    db.FillGridData(dataGridView1, "Select * from Membertbl");
                    return;
                }
                if (cmbsearch.SelectedIndex == 0)
                {
                    db.FillGridData(dataGridView1, "Select * from Membertbl where Member_ID=" + txtsearch.Text);
                }
                else
                {
                    db.FillGridData(dataGridView1, "Select * from Membertbl where Member_Name like'" + txtsearch.Text + "%'");
                }
            }
            catch { }
        }

        private void cmbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void View_Member_details_Load(object sender, EventArgs e)
        {
            db.FillGridData(dataGridView1, "Select * from Membertbl");
        }
    }
}
