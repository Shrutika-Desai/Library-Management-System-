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
    public partial class Fineform : Form
    {
        dbcodeclass db = new dbcodeclass();
        public Fineform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int days = Int16.Parse(txtdaysdelayed.Text);
            double fine = Double.Parse(txtfine.Text);
            double total = fine * days;
            txttotalfine.Text = total.ToString("#.00");
            
        }

        private void Fineform_Load(object sender, EventArgs e)
        {
            db.FillGridData(dataGridView1, "Select M_id,M_Type,M_Name from Issuebooktbl");
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();
        }
        void Griddisplay()
        {
            try
            {
                txtmid.Text = dataGridView1.SelectedRows[0].Cells["M_id"].Value.ToString();
                cmbmtype.Text = dataGridView1.SelectedRows[0].Cells["M_Type"].Value.ToString();
                txtmname.Text = dataGridView1.SelectedRows[0].Cells["M_Name"].Value.ToString();
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.ExecuteSqlQuery("Insert into Finetbl(M_id,M_Type,M_Name,Days_Delayed,Total_Fine)Values('" + txtmid.Text + "','" + cmbmtype.Text + "','" + txtmname.Text + "','" + txtdaysdelayed.Text + "','" + txttotalfine.Text + "')");
            MessageBox.Show("Data inserted Successfully...");
        }
    }
}
