namespace Library_Management
{
    partial class MDI_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDataEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDataModificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentEntryDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookModificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fineReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(446, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 110);
            this.label1.TabIndex = 7;
            this.label1.Text = "Library Management \r\nSystem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.bookInformationToolStripMenuItem,
            this.bookTransactionToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDataEntryToolStripMenuItem,
            this.studentDataModificationToolStripMenuItem,
            this.studentEntryDeleteToolStripMenuItem,
            this.studentSearchToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // studentDataEntryToolStripMenuItem
            // 
            this.studentDataEntryToolStripMenuItem.Name = "studentDataEntryToolStripMenuItem";
            this.studentDataEntryToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.studentDataEntryToolStripMenuItem.Text = "Student Data Entry";
            this.studentDataEntryToolStripMenuItem.Click += new System.EventHandler(this.studentDataEntryToolStripMenuItem_Click);
            // 
            // studentDataModificationToolStripMenuItem
            // 
            this.studentDataModificationToolStripMenuItem.Name = "studentDataModificationToolStripMenuItem";
            this.studentDataModificationToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.studentDataModificationToolStripMenuItem.Text = "Student Data Modification";
            this.studentDataModificationToolStripMenuItem.Click += new System.EventHandler(this.studentDataModificationToolStripMenuItem_Click);
            // 
            // studentEntryDeleteToolStripMenuItem
            // 
            this.studentEntryDeleteToolStripMenuItem.Name = "studentEntryDeleteToolStripMenuItem";
            this.studentEntryDeleteToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.studentEntryDeleteToolStripMenuItem.Text = "Student Entry Delete";
            this.studentEntryDeleteToolStripMenuItem.Click += new System.EventHandler(this.studentEntryDeleteToolStripMenuItem_Click);
            // 
            // studentSearchToolStripMenuItem
            // 
            this.studentSearchToolStripMenuItem.Name = "studentSearchToolStripMenuItem";
            this.studentSearchToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.studentSearchToolStripMenuItem.Text = "Student Search";
            this.studentSearchToolStripMenuItem.Click += new System.EventHandler(this.studentSearchToolStripMenuItem_Click);
            // 
            // bookInformationToolStripMenuItem
            // 
            this.bookInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookEntryToolStripMenuItem,
            this.bookModificationToolStripMenuItem,
            this.bookSearchToolStripMenuItem});
            this.bookInformationToolStripMenuItem.Name = "bookInformationToolStripMenuItem";
            this.bookInformationToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.bookInformationToolStripMenuItem.Text = "Book Information";
            // 
            // bookEntryToolStripMenuItem
            // 
            this.bookEntryToolStripMenuItem.Name = "bookEntryToolStripMenuItem";
            this.bookEntryToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.bookEntryToolStripMenuItem.Text = "Book Entry";
            this.bookEntryToolStripMenuItem.Click += new System.EventHandler(this.bookEntryToolStripMenuItem_Click);
            // 
            // bookModificationToolStripMenuItem
            // 
            this.bookModificationToolStripMenuItem.Name = "bookModificationToolStripMenuItem";
            this.bookModificationToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.bookModificationToolStripMenuItem.Text = "Book Modification";
            this.bookModificationToolStripMenuItem.Click += new System.EventHandler(this.bookModificationToolStripMenuItem_Click);
            // 
            // bookSearchToolStripMenuItem
            // 
            this.bookSearchToolStripMenuItem.Name = "bookSearchToolStripMenuItem";
            this.bookSearchToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.bookSearchToolStripMenuItem.Text = "Book Search";
            this.bookSearchToolStripMenuItem.Click += new System.EventHandler(this.bookSearchToolStripMenuItem_Click);
            // 
            // bookTransactionToolStripMenuItem
            // 
            this.bookTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookIssueToolStripMenuItem,
            this.bookReturnToolStripMenuItem});
            this.bookTransactionToolStripMenuItem.Name = "bookTransactionToolStripMenuItem";
            this.bookTransactionToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.bookTransactionToolStripMenuItem.Text = "Book Transaction";
            // 
            // bookIssueToolStripMenuItem
            // 
            this.bookIssueToolStripMenuItem.Name = "bookIssueToolStripMenuItem";
            this.bookIssueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bookIssueToolStripMenuItem.Text = "Book Issue";
            this.bookIssueToolStripMenuItem.Click += new System.EventHandler(this.bookIssueToolStripMenuItem_Click);
            // 
            // bookReturnToolStripMenuItem
            // 
            this.bookReturnToolStripMenuItem.Name = "bookReturnToolStripMenuItem";
            this.bookReturnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bookReturnToolStripMenuItem.Text = "Book Return";
            this.bookReturnToolStripMenuItem.Click += new System.EventHandler(this.bookReturnToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fineReportToolStripMenuItem,
            this.bookReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // fineReportToolStripMenuItem
            // 
            this.fineReportToolStripMenuItem.Name = "fineReportToolStripMenuItem";
            this.fineReportToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fineReportToolStripMenuItem.Text = "Student Report";
            this.fineReportToolStripMenuItem.Click += new System.EventHandler(this.fineReportToolStripMenuItem_Click);
            // 
            // bookReportToolStripMenuItem
            // 
            this.bookReportToolStripMenuItem.Name = "bookReportToolStripMenuItem";
            this.bookReportToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.bookReportToolStripMenuItem.Text = "Book Report";
            this.bookReportToolStripMenuItem.Click += new System.EventHandler(this.bookReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MDI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = global::Library_Management.Properties.Resources.library;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Library Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDataEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDataModificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentEntryDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookModificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fineReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}