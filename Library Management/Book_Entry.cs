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
namespace Library_Management
{
    public partial class Book_Entry : Form
    {
        public Book_Entry()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("uid = sa;password = 2129 ; server = . ; database = library");
        private void Book_Entry_Load(object sender, EventArgs e)
        {
            maxid();
        }
        void maxid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(bookid) FROM book_entry", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txtbookid.Text = (Convert.ToUInt32(ds.Tables[0].Rows[0][0]) + 1).ToString();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string auther1 = txtauther1.Text;
            string auther2 = txtauther2.Text;
            string subject = cmbsub.Text;
            string publisher = cmdpublisher.Text;
            string price = txtprice.Text;
            SqlCommand cmd = new SqlCommand("insert into book_entry (title, auther1,auther2,subject,publisher,price)   values('" + title + "','" + auther1 + "','" + auther2 + "','" + subject + "','" + publisher + "','" + price + "')", cn);
            cn.Open();
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Record inserted.");
            }
            else
            {
                MessageBox.Show("Not Inserted");
            }
            cn.Close();
            clear();
            maxid();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            txtbookid.Text = "";
            txtauther1.Text = "";
            txtauther2.Text = "";
            txtprice.Text = "";
            txtTitle.Text = "";
            cmbsub.Text = "";
            cmdpublisher.Text = "";
        }

        private void txtbookid_KeyDown(object sender, KeyEventArgs e)
        {

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

        private void txtauther1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtauther2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
