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
    public partial class Student_Entry : Form
    {
        public Student_Entry()
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
        string doe = "";
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void clear()
        {
            txtfname.Text = "";
            txtlname.Text = "";
            txtmname.Text = "";
            txtmobno.Text = "";
            txtstudentid.Text = "";
            dateTimePicker1.Text = "";
            cmbclass.Text = "";
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            clear();
            maxid();
        }

        private void Student_Entry_Load(object sender, EventArgs e)
        {
            maxid();
        }
        void maxid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(stdid) FROM student_entry", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            txtstudentid.Text = (Convert.ToUInt32(ds.Tables[0].Rows[0][0]) + 1).ToString();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
          //  if (txtaddress.Text == "" && txtfname.Text == "" && txtmname.Text == "" && txtlname.Text == ""&& txtaddress.Text=="" && txt)
            fname = txtfname.Text;
            lname = txtlname.Text;
            mname = txtmname.Text;
            address = txtaddress.Text;
            classes = cmbclass.Text;
            mobno = txtmobno.Text;
            doe = dateTimePicker1.Text;
            SqlCommand cmd = new SqlCommand("insert into student_entry (doe, fname,mname,lname,address,class,mobno)   values('" + doe + "','" + fname + "','" + mname + "','" + lname + "','" + address + "','" + classes + "','" + mobno + "')", cn);
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
