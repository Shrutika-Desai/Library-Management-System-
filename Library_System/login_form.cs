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
    public partial class login_form : Form
    {
        dbcodeclass db;
        public login_form()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DataTable dt = db.GettableData("select * from Logintbl where Username = '" + cmbUser.Text + "' AND Password ='" + txtpass.Text + "'");
            if (dt.Rows[0]["Usertype"].ToString().Equals("Shrutika"))
            {
                Mainform m = new Mainform();
                m.Show();
                this.Hide();

                
            }
           /* else if (dt.Rows[0]["Usertype"].ToString().Equals("Shrutika"))
            {
                Mainform m = new Mainform();
                m.Show();


            }*/
            else
            {
                MessageBox.Show("Please enter valid Username and Password...");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new dbcodeclass();
            db.FillCombo(cmbUser, "select *from Logintbl", "Username", "Usertype");
            cmbUser.Focus();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }
        
        private void lbluserlogin_Click(object sender, EventArgs e)
        {

        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
