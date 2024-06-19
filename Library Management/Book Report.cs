using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace Library_Management
{
    public partial class Book_Report : Form
    {
        public Book_Report()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("uid = sa;password = 2129 ; server = . ; database = library");
        private DataTable populate(DataTable dt)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from book_entry ", cn);

            da.Fill(dt);

            return dt;
        }
        private void Book_Report_Load(object sender, EventArgs e)
        {

            DataTable dtt = new DataTable();
            dtt = populate(dtt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rpts = new ReportDataSource("DataSet1", dtt);
            reportViewer1.LocalReport.DataSources.Add(rpts);
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
