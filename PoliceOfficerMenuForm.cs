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
    public partial class PoliceOfficerMenuForm : Form
    {
        public PoliceOfficerMenuForm(string polliceOfficerId)
        {
            InitializeComponent();

            // инициализация айди авторизованного сотрудника 
            setPolliceOfficerId(polliceOfficerId);

            // Приветствие с именем сотрудника
            string policeOfficerIdQuery = "select getPoliceOfficerNameAndPatronymic('" + polliceOfficerId + "');";
;           System.Data.Odbc.OdbcConnection sqlConnection1 = police_officerTableAdapter1.Connection;
            System.Data.Odbc.OdbcCommand cmd = new System.Data.Odbc.OdbcCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = policeOfficerIdQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            string nameAndPatronymic = cmd.ExecuteScalar().ToString();
            greetLabel.Text += nameAndPatronymic;

            // Центрирование по вертикали приветствия
            greetLabel.Location = new Point((this.Width) / 2 - (greetLabel.Width) / 2, greetLabel.Location.Y);

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PoliceOfficerForm policeOfficerForm = new PoliceOfficerForm();
            policeOfficerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarManageForm carManageForm = new CarManageForm(getPolliceOfficerId());
            carManageForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverManageForm driverManageForm = new DriverManageForm(getPolliceOfficerId());
            driverManageForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            IssueFineForm issueFineForm = new IssueFineForm(getPolliceOfficerId());
            issueFineForm.Show();
        }
    }
}
