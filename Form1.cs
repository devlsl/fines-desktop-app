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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckFinesForm checkFinesForm = new CheckFinesForm();
            checkFinesForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PoliceOfficerForm policeOfficerForm = new PoliceOfficerForm();
            policeOfficerForm.Show();
        }
    }
}
