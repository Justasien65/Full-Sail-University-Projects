﻿namespace WelbornEdward_CE03
{
    partial class fmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDataView = new System.Windows.Forms.GroupBox();
            this.btnAddData = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkbStudent = new System.Windows.Forms.CheckBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.udAge = new System.Windows.Forms.NumericUpDown();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.llblFirstname = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.gbDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udAge)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.listToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(291, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseEnter += new System.EventHandler(this.exitToolStripMenuItem_MouseEnter);
            this.exitToolStripMenuItem.MouseLeave += new System.EventHandler(this.LeaveField_Event);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.listToolStripMenuItem.Text = "List";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayToolStripMenuItem.Text = "&Display";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            this.displayToolStripMenuItem.MouseEnter += new System.EventHandler(this.displayToolStripMenuItem_MouseEnter);
            this.displayToolStripMenuItem.MouseLeave += new System.EventHandler(this.LeaveField_Event);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            this.clearToolStripMenuItem.MouseEnter += new System.EventHandler(this.clearToolStripMenuItem_MouseEnter);
            this.clearToolStripMenuItem.MouseLeave += new System.EventHandler(this.LeaveField_Event);
            // 
            // gbDataView
            // 
            this.gbDataView.Controls.Add(this.btnAddData);
            this.gbDataView.Controls.Add(this.btnClear);
            this.gbDataView.Controls.Add(this.chkbStudent);
            this.gbDataView.Controls.Add(this.lblGender);
            this.gbDataView.Controls.Add(this.cmbGender);
            this.gbDataView.Controls.Add(this.tbLastName);
            this.gbDataView.Controls.Add(this.tbFirstName);
            this.gbDataView.Controls.Add(this.udAge);
            this.gbDataView.Controls.Add(this.lblAge);
            this.gbDataView.Controls.Add(this.lblLastName);
            this.gbDataView.Controls.Add(this.llblFirstname);
            this.gbDataView.Location = new System.Drawing.Point(10, 32);
            this.gbDataView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDataView.Name = "gbDataView";
            this.gbDataView.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDataView.Size = new System.Drawing.Size(268, 290);
            this.gbDataView.TabIndex = 1;
            this.gbDataView.TabStop = false;
            this.gbDataView.Text = "Data View";
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(136, 238);
            this.btnAddData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(97, 33);
            this.btnAddData.TabIndex = 9;
            this.btnAddData.Text = "Add Data to List";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(17, 238);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 33);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.ClearForm_Event);
            // 
            // chkbStudent
            // 
            this.chkbStudent.AutoSize = true;
            this.chkbStudent.Location = new System.Drawing.Point(96, 187);
            this.chkbStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkbStudent.Name = "chkbStudent";
            this.chkbStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkbStudent.Size = new System.Drawing.Size(69, 17);
            this.chkbStudent.TabIndex = 4;
            this.chkbStudent.Text = "?Student";
            this.chkbStudent.UseVisualStyleBackColor = true;
            this.chkbStudent.MouseEnter += new System.EventHandler(this.chkbStudent_MouseEnter);
            this.chkbStudent.MouseLeave += new System.EventHandler(this.LeaveField_Event);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(25, 153);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(95, 151);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(82, 21);
            this.cmbGender.TabIndex = 3;
            this.cmbGender.MouseEnter += new System.EventHandler(this.cmbGender_MouseEnter);
            this.cmbGender.MouseLeave += new System.EventHandler(this.LeaveField_Event);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(96, 78);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(139, 20);
            this.tbLastName.TabIndex = 1;
            this.tbLastName.MouseEnter += new System.EventHandler(this.tbLastName_MouseEnter);
            this.tbLastName.MouseLeave += new System.EventHandler(this.LeaveField_Event);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(96, 40);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(139, 20);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.MouseLeave += new System.EventHandler(this.LeaveField_Event);
            this.tbFirstName.MouseHover += new System.EventHandler(this.tbFirstName_MouseHover);
            // 
            // udAge
            // 
            this.udAge.Location = new System.Drawing.Point(96, 116);
            this.udAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.udAge.Name = "udAge";
            this.udAge.Size = new System.Drawing.Size(80, 20);
            this.udAge.TabIndex = 2;
            this.udAge.Enter += new System.EventHandler(this.udAge_Enter);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(25, 117);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(25, 81);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // llblFirstname
            // 
            this.llblFirstname.AutoSize = true;
            this.llblFirstname.Location = new System.Drawing.Point(25, 43);
            this.llblFirstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblFirstname.Name = "llblFirstname";
            this.llblFirstname.Size = new System.Drawing.Size(57, 13);
            this.llblFirstname.TabIndex = 0;
            this.llblFirstname.Text = "First Name";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 319);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip.Size = new System.Drawing.Size(291, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 341);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbDataView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CE03 Main Form";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbDataView.ResumeLayout(false);
            this.gbDataView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udAge)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbDataView;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label llblFirstname;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddData;
        public System.Windows.Forms.CheckBox chkbStudent;
        public System.Windows.Forms.ComboBox cmbGender;
        public System.Windows.Forms.TextBox tbLastName;
        public System.Windows.Forms.TextBox tbFirstName;
        public System.Windows.Forms.NumericUpDown udAge;
    }
}
