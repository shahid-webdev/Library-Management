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
    public partial class Book_Modify : Form
    {
        public Book_Modify()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("uid = sa;password = 2129 ; server = . ; database = library");

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
            txtbookid.Text = "";
            txtauther1.Text = "";
            txtauther2.Text = "";
            txtprice.Text = "";
            txtTitle.Text = "";
            cmbsub.Text = "";
            cmdpublisher.Text = "";
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT *  FROM book_entry where bookid = '" + txtbookid.Text + "'", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txtTitle.Text = ds.Tables[0].Rows[0][1].ToString();
            txtauther1.Text = ds.Tables[0].Rows[0][2].ToString();
            txtauther2.Text = ds.Tables[0].Rows[0][3].ToString();
            cmbsub.Text = ds.Tables[0].Rows[0][4].ToString();
            cmdpublisher.Text = ds.Tables[0].Rows[0][5].ToString();
            txtprice.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string auther1 = txtauther1.Text;
            string auther2 = txtauther2.Text;
            string subject = cmbsub.Text;
            string publisher = cmdpublisher.Text;
            string price = txtprice.Text;

            SqlCommand cmd = new SqlCommand("update  book_entry SET title='" + title + "',auther1='" + auther1 + "',auther2='" + auther2 + "',subject='" + subject + "',publisher='" + publisher + "',price='" + price + "' where bookid='" + txtbookid.Text + "'", cn);
            cn.Open();
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Modify Successful .");
            }
            else
            {
                MessageBox.Show("Modify   Not Successful");
            }
            cn.Close();
            clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string auther1 = txtauther1.Text;
            string auther2 = txtauther2.Text;
            string subject = cmbsub.Text;
            string publisher = cmdpublisher.Text;
            string price = txtprice.Text;

            SqlCommand cmd = new SqlCommand("delete  from  book_entry  where bookid='" + txtbookid.Text + "'", cn);
            cn.Open();
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Delete Successful .");
            }
            else
            {
                MessageBox.Show("Delete   Not Successful");
            }
            cn.Close();
            clear();
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

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

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
