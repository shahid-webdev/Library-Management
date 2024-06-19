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
    public partial class Student_modification : Form
    {
        public Student_modification()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("uid = sa;password = 2129 ; server = . ; database = library");
        string fname = "";
        string mname = "";
        string lname = "";
        string address = "";
        string classes = "";
        string mobno = "";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT *  FROM student_entry where stdid = '" + txtstudentid.Text + "'", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txtfname.Text = ds.Tables[0].Rows[0][2].ToString();
            txtmname.Text = ds.Tables[0].Rows[0][3].ToString();
            txtlname.Text = ds.Tables[0].Rows[0][4].ToString();
            txtaddress.Text = ds.Tables[0].Rows[0][5].ToString();
            cmbclass.Text = ds.Tables[0].Rows[0][6].ToString();
            txtmobno.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            txtfname.Text = "";
            txtmname.Text = "";
            txtlname.Text = "";
            txtaddress.Text = "";
            cmbclass.Text = "";
            txtmobno.Text = "";
            txtstudentid.Text = "";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            fname = txtfname.Text;
            lname = txtlname.Text;
            mname = txtmname.Text;
            address = txtaddress.Text;
            classes = cmbclass.Text;
            mobno = txtmobno.Text;

            SqlCommand cmd = new SqlCommand("update  student_entry SET fname='" + fname + "',mname='" + mname + "',lname='" + lname + "',address='" + address + "',class='" + classes + "',mobno='" + mobno + "' where stdid='" + txtstudentid.Text + "'", cn);
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

        private void txtaddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtmobno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
