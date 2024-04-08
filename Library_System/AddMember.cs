using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Configuration;
using System.Data.Common;


namespace Library_System
{
    public partial class AddMember : Form
    {
        dbcodeclass db = new dbcodeclass();
       
        public AddMember()
        {
            InitializeComponent();
        }
        
        void EnabledFalse()
        {
            btnsave.Enabled = false;

        }
        void cleardata()
        {
            txtmemberid.Clear();
            txtmembername.Clear();
            txtdepartment.Clear();
            txtmembercontact.Clear();
            txtmemberemail.Clear();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            GetmaxID();
            btnsave.Enabled = true;
        }

        void GetmaxID()
        {
            txtmemberid.Text = db.GetAutoID("Select Max (Member_ID)from Membertbl").ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
            db.ExecuteSqlQuery("Insert into Membertbl(Member_ID,Member_Type,Member_Name,Department,Member_Contact,Member_Email)values('" + txtmemberid.Text + "','"+cmbmembertype.Text+"','" + txtmembername.Text + "','" + txtdepartment.Text + "','" + txtmembercontact.Text + "','" + txtmemberemail.Text + "')");
            EnabledFalse();
            cleardata();
            MessageBox.Show("Record inserted Successfully...");

        }

        private void txtstudentcontact_Validating(object sender, CancelEventArgs e)
        {
            
        }

        

        private void txtstudentemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblstudentname_Click(object sender, EventArgs e)
        {

        }

       

        private void Member_details_Load(object sender, EventArgs e)
        {
            btnNew.Focus();
            EnabledFalse();
        }

        private void txtmembername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmembername.Text) == true)
            {
                txtmembername.Focus();
                errorProvider1.SetError(this.txtmembername, "please fill the name");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void txtdepartment_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdepartment.Text) == true)
            {
                txtdepartment.Focus();
                errorProvider2.SetError(this.txtdepartment, "please fill the department");
            }
            else
            {
                errorProvider2.Clear();
            }

        }

      

        private void cmbmembertype_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbmembertype.Text) == true)
            {
                cmbmembertype.Focus();
                errorProvider5.SetError(this.cmbmembertype, "please select item from the combobox");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

       

        private void txtmembercontact_Validating(object sender, CancelEventArgs e)
        {
            Regex ex = new Regex("^[1-9]{10}");
            bool isValid = ex.IsMatch(txtmembercontact.Text);
            if (!isValid)
            {
                txtmembercontact.Focus();
                errorcontact.SetError(this.txtmembercontact, "Please enter valid number ");
            }
            else
            {
                errorcontact.Clear();
            }

        }

     /*  private void txtmembername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

       private void txtdepartment_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
           {
               e.Handled = true;
           }
       }*/

       private void txtmemberemail_Leave(object sender, EventArgs e)
       {
           if (string.IsNullOrEmpty(txtmemberemail.Text) == true)
           {
               txtmemberemail.Focus();
               errorEmail.SetError(this.txtmemberemail, "please enter email");
           }
           else
           {
               errorEmail.Clear();
           }
       }

      /* private void txtmemberemail_Validated(object sender, EventArgs e)
       {
           Regex ex1 = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
           if (!ex1.IsMatch(txtmemberemail.Text))
           {
               errorEmail.SetError(this.txtmemberemail, "Invalid Email!");
           }
           else
           {
               errorEmail.Clear();
           }
       }*/
    }
}
