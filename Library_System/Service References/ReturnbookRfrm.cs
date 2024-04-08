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
    public partial class ReturnbookRfrm : Form
    {
        dbcodeclass db = new dbcodeclass();
        public ReturnbookRfrm()
        {
            InitializeComponent();
        }

        private void ReturnbookRfrm_Load(object sender, EventArgs e)
        {
            Member("Select * from Returnbooktbl", db.cn);
        }
        public void Member(string sql, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "Returnbooktbl");

            Returnbook_Report Amr = new Returnbook_Report();
            Amr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = Amr;
        }
    }
}
