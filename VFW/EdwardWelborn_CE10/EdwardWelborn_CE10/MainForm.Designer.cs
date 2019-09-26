﻿namespace EdwardWelborn_CE10
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataInformation_groupbox = new System.Windows.Forms.GroupBox();
            this.vehicldID_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.vehicleID_label = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.class_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.model_label = new System.Windows.Forms.Label();
            this.make_label = new System.Windows.Forms.Label();
            this.class_textBox = new System.Windows.Forms.TextBox();
            this.model_textBox = new System.Windows.Forms.TextBox();
            this.make_textBox = new System.Windows.Forms.TextBox();
            this.year_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dataSelector_listView = new System.Windows.Forms.ListView();
            this.large_imageList = new System.Windows.Forms.ImageList(this.components);
            this.small_imageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.dataInformation_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicldID_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconsToolStripMenuItem,
            this.smallIconsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // largeIconsToolStripMenuItem
            // 
            this.largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
            this.largeIconsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.largeIconsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.largeIconsToolStripMenuItem.Text = "Large Icons";
            this.largeIconsToolStripMenuItem.Click += new System.EventHandler(this.largeIconsToolStripMenuItem_Click);
            // 
            // smallIconsToolStripMenuItem
            // 
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            this.smallIconsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.smallIconsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smallIconsToolStripMenuItem.Text = "Small Icons";
            this.smallIconsToolStripMenuItem.Click += new System.EventHandler(this.smallIconsToolStripMenuItem_Click);
            // 
            // dataInformation_groupbox
            // 
            this.dataInformation_groupbox.Controls.Add(this.vehicldID_numericUpDown);
            this.dataInformation_groupbox.Controls.Add(this.vehicleID_label);
            this.dataInformation_groupbox.Controls.Add(this.update_button);
            this.dataInformation_groupbox.Controls.Add(this.cancel_button);
            this.dataInformation_groupbox.Controls.Add(this.class_label);
            this.dataInformation_groupbox.Controls.Add(this.year_label);
            this.dataInformation_groupbox.Controls.Add(this.model_label);
            this.dataInformation_groupbox.Controls.Add(this.make_label);
            this.dataInformation_groupbox.Controls.Add(this.class_textBox);
            this.dataInformation_groupbox.Controls.Add(this.model_textBox);
            this.dataInformation_groupbox.Controls.Add(this.make_textBox);
            this.dataInformation_groupbox.Controls.Add(this.year_numericUpDown);
            this.dataInformation_groupbox.Controls.Add(this.dataSelector_listView);
            this.dataInformation_groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataInformation_groupbox.Location = new System.Drawing.Point(0, 24);
            this.dataInformation_groupbox.Name = "dataInformation_groupbox";
            this.dataInformation_groupbox.Size = new System.Drawing.Size(538, 253);
            this.dataInformation_groupbox.TabIndex = 1;
            this.dataInformation_groupbox.TabStop = false;
            this.dataInformation_groupbox.Text = "Vehicle Information";
            // 
            // vehicldID_numericUpDown
            // 
            this.vehicldID_numericUpDown.Location = new System.Drawing.Point(87, 32);
            this.vehicldID_numericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.vehicldID_numericUpDown.Name = "vehicldID_numericUpDown";
            this.vehicldID_numericUpDown.Size = new System.Drawing.Size(152, 20);
            this.vehicldID_numericUpDown.TabIndex = 11;
            // 
            // vehicleID_label
            // 
            this.vehicleID_label.AutoSize = true;
            this.vehicleID_label.Location = new System.Drawing.Point(23, 35);
            this.vehicleID_label.Name = "vehicleID_label";
            this.vehicleID_label.Size = new System.Drawing.Size(56, 13);
            this.vehicleID_label.TabIndex = 10;
            this.vehicleID_label.Text = "Vehicle ID";
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(162, 219);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 9;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(55, 219);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Location = new System.Drawing.Point(23, 186);
            this.class_label.Name = "class_label";
            this.class_label.Size = new System.Drawing.Size(59, 13);
            this.class_label.TabIndex = 7;
            this.class_label.Text = "Class Type";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(23, 150);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(29, 13);
            this.year_label.TabIndex = 6;
            this.year_label.Text = "Year";
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Location = new System.Drawing.Point(23, 106);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(36, 13);
            this.model_label.TabIndex = 5;
            this.model_label.Text = "Model";
            // 
            // make_label
            // 
            this.make_label.AutoSize = true;
            this.make_label.Location = new System.Drawing.Point(23, 71);
            this.make_label.Name = "make_label";
            this.make_label.Size = new System.Drawing.Size(34, 13);
            this.make_label.TabIndex = 2;
            this.make_label.Text = "Make";
            // 
            // class_textBox
            // 
            this.class_textBox.Location = new System.Drawing.Point(87, 183);
            this.class_textBox.Name = "class_textBox";
            this.class_textBox.Size = new System.Drawing.Size(152, 20);
            this.class_textBox.TabIndex = 4;
            // 
            // model_textBox
            // 
            this.model_textBox.Location = new System.Drawing.Point(87, 106);
            this.model_textBox.Name = "model_textBox";
            this.model_textBox.Size = new System.Drawing.Size(152, 20);
            this.model_textBox.TabIndex = 3;
            // 
            // make_textBox
            // 
            this.make_textBox.Location = new System.Drawing.Point(87, 67);
            this.make_textBox.Name = "make_textBox";
            this.make_textBox.Size = new System.Drawing.Size(152, 20);
            this.make_textBox.TabIndex = 2;
            // 
            // year_numericUpDown
            // 
            this.year_numericUpDown.Location = new System.Drawing.Point(87, 146);
            this.year_numericUpDown.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.year_numericUpDown.Name = "year_numericUpDown";
            this.year_numericUpDown.Size = new System.Drawing.Size(152, 20);
            this.year_numericUpDown.TabIndex = 1;
            // 
            // dataSelector_listView
            // 
            this.dataSelector_listView.FullRowSelect = true;
            this.dataSelector_listView.HideSelection = false;
            this.dataSelector_listView.LabelWrap = false;
            this.dataSelector_listView.LargeImageList = this.large_imageList;
            this.dataSelector_listView.Location = new System.Drawing.Point(264, 31);
            this.dataSelector_listView.MultiSelect = false;
            this.dataSelector_listView.Name = "dataSelector_listView";
            this.dataSelector_listView.Size = new System.Drawing.Size(262, 212);
            this.dataSelector_listView.SmallImageList = this.small_imageList;
            this.dataSelector_listView.TabIndex = 0;
            this.dataSelector_listView.UseCompatibleStateImageBehavior = false;
            this.dataSelector_listView.DoubleClick += new System.EventHandler(this.dataSelector_listView_DoubleClick);
            // 
            // large_imageList
            // 
            this.large_imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("large_imageList.ImageStream")));
            this.large_imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.large_imageList.Images.SetKeyName(0, "iconfinder_SUV_285812.png");
            // 
            // small_imageList
            // 
            this.small_imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("small_imageList.ImageStream")));
            this.small_imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.small_imageList.Images.SetKeyName(0, "iconfinder_sedan_285810.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 277);
            this.Controls.Add(this.dataInformation_groupbox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "CE10 MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.dataInformation_groupbox.ResumeLayout(false);
            this.dataInformation_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicldID_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox dataInformation_groupbox;
        private System.Windows.Forms.ListView dataSelector_listView;
        private System.Windows.Forms.TextBox class_textBox;
        private System.Windows.Forms.TextBox model_textBox;
        private System.Windows.Forms.TextBox make_textBox;
        private System.Windows.Forms.NumericUpDown year_numericUpDown;
        private System.Windows.Forms.Label class_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.Label make_label;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconsToolStripMenuItem;
        private System.Windows.Forms.ImageList large_imageList;
        private System.Windows.Forms.ImageList small_imageList;
        private System.Windows.Forms.NumericUpDown vehicldID_numericUpDown;
        private System.Windows.Forms.Label vehicleID_label;
    }
}
