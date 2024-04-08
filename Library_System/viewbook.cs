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
    public partial class viewbook : Form
    {
        dbcodeclass db = new dbcodeclass();
        public viewbook()
        {
            InitializeComponent();
        }

        private void viewbook_Load(object sender, EventArgs e)
        {
            db.FillGridData(dataGridView1, "Select * from Addbooktbl");
        }

        void cleardata()
        {
            txtbookid.Clear();
            txtbookname.Clear();
            txtbookauthor.Clear();
            txtbookpublication.Clear();
            txtbookprice.Clear();
            txtbookquantity.Clear();
            txtAqty.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                txtbookid.Text = dataGridView1.SelectedRows[0].Cells["Book_id"].Value.ToString();
                txtbookname.Text = dataGridView1.SelectedRows[0].Cells["Book_name"].Value.ToString();
                txtbookauthor.Text = dataGridView1.SelectedRows[0].Cells["Book_author_name"].Value.ToString();
                txtbookpublication.Text = dataGridView1.SelectedRows[0].Cells["Book_publication"].Value.ToString();
                //dtpbookpurchase.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["Book_purchase_date"].Value.ToString());
                txtbookprice.Text = dataGridView1.SelectedRows[0].Cells["Book_price"].Value.ToString();
                txtbookquantity.Text = dataGridView1.SelectedRows[0].Cells["Book_quantity"].Value.ToString();
                txtAqty.Text = dataGridView1.SelectedRows[0].Cells["Available_quantity"].Value.ToString();
                //dtpbookpurchase.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["Book_purchase_date"].Value.ToString());
            }
            catch { }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtbookid.Text == "" || txtbookname.Text == "")
            {
                MessageBox.Show("Missing Fields...");
            }
            db.ExecuteSqlQuery("Update Addbooktbl SET Book_name='" + txtbookname.Text + "',Book_author_name='" + txtbookauthor.Text + "',Book_publication='" + txtbookpublication.Text + "',Book_price='" + txtbookprice.Text + "',Book_quantity='" + txtbookquantity.Text + "'where Book_id=" + txtbookid.Text);
            db.FillGridData(dataGridView1, "Select * from Addbooktbl");

            MessageBox.Show("Data Updated Successfully...");

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete record", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteSqlQuery("Delete from Addbooktbl where Book_id =" + txtbookid.Text);
            }
            db.FillGridData(dataGridView1, "Select * from Addbooktbl");
            MessageBox.Show("Data Deleted Successfully....");
            cleardata();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtsearch.Text == "")
                {
                    db.FillGridData(dataGridView1, "Select * from Addbooktbl");
                    return;
                }
                if (cmbsearch.SelectedIndex == 0)
                {
                    db.FillGridData(dataGridView1, "Select * from Addbooktbl where Book_id=" + txtsearch.Text);
                }
                else if (cmbsearch.SelectedIndex == 1)
                {
                    db.FillGridData(dataGridView1, "Select * from Addbooktbl where Book_name like'" + txtsearch.Text + "%'");
                }
                else
                {
                    db.FillGridData(dataGridView1, "Select * from Addbooktbl where Book_author_name like'" + txtsearch.Text + "%'");
                }
            }
            catch { }
        }

        private void txtAqty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    