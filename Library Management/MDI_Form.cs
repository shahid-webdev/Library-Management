using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class MDI_Form : Form
    {
        public MDI_Form()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentDataEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Entry s = new Student_Entry();
            s.Show();
        }

        private void studentDataModificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_modification sm = new Student_modification();
            sm.Show();
        }

        private void studentEntryDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Delete sd = new Student_Delete();
            sd.Show();
        }

        private void studentSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Search ss = new Student_Search();
            ss.Show();
        }

        private void bookEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Entry be = new Book_Entry();
            be.Show();
        }

        private void bookModificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Modify bm = new Book_Modify();
            bm.Show();
        }

        private void bookSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Search bs = new Book_Search();
            bs.Show();
        }

        private void bookIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Issue bi = new Book_Issue();
            bi.Show();
        }

        private void bookReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Return be = new Book_Return();
            be.Show();
        }

        private void fineReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Report sr = new Student_Report();
            sr.Show();
        }

        private void bookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Report br = new Book_Report();
            br.Show();
        }
    }
}
