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
    public partial class AddbookRfrm : Form
    {
        dbcodeclass db = new dbcodeclass();
        public AddbookRfrm()
        {
            InitializeComponent();
        }

        private void AddbookRfrm_Load(object sender, EventArgs e)
        {
            Member("Select * from Addbooktbl", db.cn);
        }
        public void Member(string sql, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "Addbooktbl");

            Addbook_Report ab= new Addbook_Report();
            ab.SetDataSource(ds);
            crystalReportViewer1.ReportSource = ab;
        }
    }
}
