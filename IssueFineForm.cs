using System;
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
    public partial class IssueFineForm : Form
    {
        public IssueFineForm(string polliceOfficerId)
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

        private void issueFineButton_Click(object sender, EventArgs e)
        {
            // создание подключения
            System.Data.Odbc.OdbcConnection sqlConnection1 = violationTableAdapter1.Connection;
            System.Data.Odbc.OdbcCommand cmd = new System.Data.Odbc.OdbcCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            // сгенерировать уникальный номер нарушения (20 цифр)
            string newFineId = "";
            bool isUnic = false;

            while (!isUnic)
            {
                newFineId = new Random().Next(10000, 100000).ToString() + new Random().Next(10000, 100000).ToString();
                newFineId += new Random().Next(10000, 100000).ToString() + new Random().Next(10000, 100000).ToString();
                string checkFineIdQuery = "select * from is_there_violation('" + newFineId + "');";
                cmd.CommandText = checkFineIdQuery;
                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();
                isUnic = int.Parse(cmd.ExecuteScalar().ToString()) == 0 ? true : false;
                sqlConnection1.Close();
            }

            // проверка на существование гос номера
            string numberPlate = numberPlateValue.Text.ToLower();
            string checkNumberPlateQuery = "select * from is_there_car('" + numberPlate + "');";
            cmd.CommandText = checkNumberPlateQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            bool isThereCar = int.Parse(cmd.ExecuteScalar().ToString()) == 1 ? true : false;
            sqlConnection1.Close();
            if (!isThereCar)
            {
                messageLabel.ForeColor = Color.Red;
                messageLabel.Text = "Автомобиля с таким гос. номером не существует";
                return;
            }

            // проверка на существование вод. уд.
            string licenseId = licenseIdValue.Text;
            string checklicenseIdQuery = "select * from is_there_driver('" + licenseId + "');";
            cmd.CommandText = checklicenseIdQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            bool isThereDriver = int.Parse(cmd.ExecuteScalar().ToString()) == 1 ? true : false;
            sqlConnection1.Close();
            if (!isThereDriver)
            {
                messageLabel.ForeColor = Color.Red;
                messageLabel.Text = "Водителя с таким номером вод. уд. не существует";
                return;
            }

            // добавление нарушения
            string issueFineQuery = "select * from issueFine('" + newFineId + "', " + fineValue.SelectedValue + ", '" + numberPlate + "', '" + licenseId + "', '" + getPolliceOfficerId() + "', timestamp '" + dateValue.Text + "', '" + addressValue.Text + "');";
            cmd.CommandText = issueFineQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            messageLabel.ForeColor = Color.Green;
            messageLabel.Text = "Штраф выписан";
        }

        private void IssueFineForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finesDataSet.car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.finesDataSet.car);
            // TODO: This line of code loads data into the 'finesDataSet.driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.finesDataSet.driver);
            // TODO: This line of code loads data into the 'finesDataSet.fine' table. You can move, or remove it, as needed.
            this.fineTableAdapter.Fill(this.finesDataSet.fine);

        }
    }
}
