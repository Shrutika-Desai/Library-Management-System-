using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_System.Reports
{
    public partial class AddmemberRfrm : Form
    {
        dbcodeclass db = new dbcodeclass();
        public AddmemberRfrm()
        {
            InitializeComponent();
        }

        private void AddmemberRfrm_Load(object sender, EventArgs e)
        {
            Member("Select * from Membertbl", db.cn);
        }
        public void Member(string sql, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "Membertbl");

            Addmember_Report Amr = new Addmember_Report();
            Amr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = Amr;
        }
    }
}
