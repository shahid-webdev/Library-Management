using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace Library_Management
{
    public partial class Book_Return : Form
    {
        public Book_Return()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("uid = sa;password = 2129 ; server = . ; database = library");
        private void Book_Return_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from bookissue where bookissueid = " + txtbookissueid.Text + "", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txtstudentid.Text = (ds.Tables[0].Rows[0][2]).ToString();
            txtclasses.Text = (ds.Tables[0].Rows[0][6]).ToString();
            txtbookid.Text = (ds.Tables[0].Rows[0][7]).ToString();
            txtTitle.Text = (ds.Tables[0].Rows[0][8]).ToString();
            txtauther.Text = (ds.Tables[0].Rows[0][9]).ToString();
            txtpublisher.Text = (ds.Tables[0].Rows[0][10]).ToString();
            txtdoi.Text = (ds.Tables[0].Rows[0][1]).ToString();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            txtauther.Text = "";
            txtbookid.Text = "";
            txtbookissueid.Text = "";
            txtclasses.Text = "";
            txtdoi.Text = "";
            txtpublisher.Text = "";
            txtstudentid.Text = "";
            txtTitle.Text = "";
            txtfine.Text = "";
            dateTimePicker1.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int bookissueid=Convert.ToInt32(txtbookissueid.Text);
            int stdid = Convert.ToInt32(txtstudentid.Text);
            string classes = txtclasses.Text;
            int bookid =Convert.ToInt32(txtbookid.Text);
            string title = txtTitle.Text;
            string author = txtauther.Text;
            string publisher = txtpublisher.Text;
            string doi = txtdoi.Text;
            string dor = dateTimePicker1.Text.ToString();
            int fine = Convert.ToInt32(txtfine.Text);
            SqlCommand cmd = new SqlCommand("insert into bookreturn (bookissueid, stdid,class,bookid,title,author,publisher,doi,dor,fine)  values(" + bookissueid + "," + stdid + ",'" + classes + "'," + bookid + ",'" + title + "','" + author + "','" + publisher + "','" + doi + "','" + dor + "'," + fine + ")", cn);
            cn.Open();
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Book Return successful .");
            }
            else
            {
                MessageBox.Show("Book Return  Not successful");
            }
            cn.Close();
            clear();
        }

        private void txtbookissueid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtfine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtstudentid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtclasses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbookid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtauther_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpublisher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
