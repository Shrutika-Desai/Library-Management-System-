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
    public partial class IssuebookRfrm : Form
    {
        dbcodeclass db = new dbcodeclass();
        public IssuebookRfrm()
        {
            InitializeComponent();
        }

        private void IssuebookRfrm_Load(object sender, EventArgs e)
        {
            Member("Select * from Issuebooktbl", db.cn);
        }
        public void Member(string sql, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "Issuebooktbl");

            Issuebook_Report ab = new Issuebook_Report();
            ab.SetDataSource(ds);
            crystalReportViewer1.ReportSource = ab;
        }
    }
}
