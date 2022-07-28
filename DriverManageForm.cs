﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinesDesktopApp
{
    public partial class DriverManageForm : Form
    {
        public DriverManageForm(string polliceOfficerId)
        {
            InitializeComponent();

            setPolliceOfficerId(polliceOfficerId);
        }

        private string polliceOfficerId = "";
        public void setPolliceOfficerId(string polliceOfficerId)
        {
            this.polliceOfficerId = polliceOfficerId;
        }

        public string getPolliceOfficerId()
        {
            return this.polliceOfficerId;
        }

        private void backToOfficerSignInFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PoliceOfficerMenuForm policeOfficerMenuForm = new PoliceOfficerMenuForm(getPolliceOfficerId());
            policeOfficerMenuForm.Show();
        }

        private void DriverManageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finesDataSet.driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.finesDataSet.driver);
        }
    }
}
