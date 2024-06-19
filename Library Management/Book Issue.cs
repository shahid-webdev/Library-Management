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
    public partial class Book_Issue : Form
    {
        public Book_Issue()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("uid = sa;password = 2129 ; server = . ; database = library");
        private void label7_Click(object sender, EventArgs e)
        {
            
        }
        void maxid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(bookissueid) FROM bookissue", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txtbookissueid.Text = (Convert.ToUInt32(ds.Tables[0].Rows[0][0]) + 1).ToString();
        }
        private void btnsearchstd_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from student_entry where stdid = " + txtstudentid.Text + "", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txtfname.Text = (ds.Tables[0].Rows[0][2]).ToString();
            txtmname.Text = (ds.Tables[0].Rows[0][3]).ToString();
            txtlname.Text = (ds.Tables[0].Rows[0][4]).ToString();
            txtclasses.Text = (ds.Tables[0].Rows[0][6]).ToString();
        }

        private void btnsearchbook_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT *  FROM book_entry where bookid = '" + txtbookid.Text + "'", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txtTitle.Text = ds.Tables[0].Rows[0][1].ToString();
            txtauther.Text = ds.Tables[0].Rows[0][2].ToString();
            txtpublisher.Text = ds.Tables[0].Rows[0][5].ToString();
           
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
            maxid();
        }
        void clear()
        {
            txtbookid.Text = "";
            txtauther.Text = "";
            txtbookissueid.Text = "";
            txtclasses.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtpublisher.Text = "";
            txtstudentid.Text = "";
            txtTitle.Text = "";
        }

        private void Book_Issue_Load(object sender, EventArgs e)
        {
            maxid();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            string doi = dateTimePicker1.Text;
            string stdid=txtstudentid.Text;
            string fname=txtfname.Text;
            string mname=txtmname.Text;
            string lname=txtlname.Text;
            string classes=txtclasses.Text;
            string bookid=txtbookid.Text;
            string title=txtTitle.Text;
            string author=txtauther.Text;
            string publisher = txtpublisher.Text;

            SqlCommand cmd = new SqlCommand("insert into bookissue (doi, stdid,fname,mname,lname,classes,bookid,title,author,publisher)  values('" + doi + "'," + stdid + ",'" + fname + "','" + mname + "','" + lname + "','" + classes + "'," + bookid + ",'" + title + "','" + author + "','" + publisher + "')", cn);
            cn.Open();
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Book Issue successful .");
            }
            else
            {
                MessageBox.Show("Book Issue  Not successful");
            }
            cn.Close();
            clear();
            maxid();
        }

        private void txtstudentid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtmname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtclasses_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtclasses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbookid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbookid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

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
    }
}
