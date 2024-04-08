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
    public partial class FineRfrm : Form
    {
        dbcodeclass db = new dbcodeclass();
        public FineRfrm()
        {
            InitializeComponent();
        }

        private void FineRfrm_Load(object sender, EventArgs e)
        {
            Member("Select * from Finetbl", db.cn);
        }
        public void Member(string sql, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "Finetbl");

            Fine_Report Amr = new Fine_Report();
            Amr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = Amr;
        }
    }
}
