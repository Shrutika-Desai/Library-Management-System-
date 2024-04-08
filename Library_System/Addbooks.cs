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
    public partial class Addbooks : Form
    {
        dbcodeclass db = new dbcodeclass();
        public Addbooks()
        {
            InitializeComponent();
        }

        private void Addbooks_Load(object sender, EventArgs e)
        {
            btnnew.Focus();
            EnabledFalse();

        }
        void EnabledFalse()
        {
            btnsave.Enabled = false;
            
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

        private void btnnew_Click(object sender, EventArgs e)
        {
            GetmaxID();
            btnsave.Enabled = true;

        }
        void GetmaxID()
        {
            txtbookid.Text = db.GetAutoID("Select Max (Book_id)from Addbooktbl").ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbookid.Text == "" || txtbookname.Text == "")
            {
                MessageBox.Show("Missing Fields...");
            }
            db.ExecuteSqlQuery("Insert into Addbooktbl(Book_id,Book_name,Book_author_name,Book_publication,Book_price,Book_quantity,Available_quantity)values('" + txtbookid.Text + "','" + txtbookname.Text + "','" + txtbookauthor.Text + "','" + txtbookpublication.Text + "','" + txtbookprice.Text + "','" + txtbookquantity.Text + "','"+txtAqty.Text+"')");
            EnabledFalse();
            cleardata();
            MessageBox.Show("Record inserted Successfully...");
        }

        private void txtAqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbookquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbookname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbookname.Text) == true)
            {
                txtbookname.Focus();
                errorname.SetError(this.txtbookname, "please fill the book name");
            }
            else
            {
                errorname.Clear();
            }
        }

        private void txtbookauthor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbookauthor.Text) == true)
            {
                txtbookauthor.Focus();
                errorauthor.SetError(this.txtbookauthor, "please fill the Author name");
            }
            else
            {
                errorauthor.Clear();
            }
        }

        private void txtbookpublication_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbookpublication.Text) == true)
            {
                txtbookpublication.Focus();
                errorpublication.SetError(this.txtbookpublication, "please fill the publication name");
            }
            else
            {
                errorpublication.Clear();
            }
        }

        private void txtbookprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtbookquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtAqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtbookprice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbookprice.Text) == true)
            {
                txtbookprice.Focus();
                errorprice.SetError(this.txtbookprice, "please fill the price");
            }
            else
            {
                errorprice.Clear();
            }
        }

        private void txtbookquantity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbookquantity.Text) == true)
            {
                txtbookquantity.Focus();
                errorquantity.SetError(this.txtbookquantity, "please fill the Book Quantity");
            }
            else
            {
                errorquantity.Clear();
            }
        }

        private void txtAqty_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAqty.Text) == true)
            {
                txtAqty.Focus();
                errorqt.SetError(this.txtAqty, "please fill the Available Quantity");
            }
            else
            {
                errorqt.Clear();
            }
        }

       /* private void txtbookname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtbookauthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtbookpublication_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }*/
    }
}
