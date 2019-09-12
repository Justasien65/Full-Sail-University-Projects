﻿/*
* Created by Edward Welborn on 09/11/2019
* Class: Visual Framworks
* Description: Project CE04
* Copyright © 2019 Roy Welborn. All rights reserved
*
* List View Form
* Summary: This is where the list is displayed, as well as being able to click open a new user input form.
*/
using System;
using System.Windows.Forms;

namespace EdwardWelborn_CE04
{
    public partial class ListViewForm : Form
    {
        public ListViewForm()
        {
            InitializeComponent();
        }

        private void lvwCharacters_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            // This will open a new input form, add to the increment of open input forms on the main form
            // I would like to be able to open the new form where no form exists

            UserInputForm frmUserInputForm = new UserInputForm();

            frmUserInputForm.Show();
        }

        private void tspbtnClearData_Click(object sender, EventArgs e)
        {
            // This will clear the list, the list view box, and clear the data object counter on main form

        }
    }
}