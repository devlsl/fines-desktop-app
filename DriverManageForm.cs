using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

        private void addDriverButton_Click(object sender, EventArgs e)
        {
            // создание подключения
            System.Data.Odbc.OdbcConnection sqlConnection1 = driverTableAdapter.Connection;
            System.Data.Odbc.OdbcCommand cmd = new System.Data.Odbc.OdbcCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            // сгенерировать уникальный номер ву (10 цифр)
            string newLicenseId = "";
            bool isUnic = false;

            while (!isUnic)
            {
                newLicenseId = new Random().Next(10000, 100000).ToString() + new Random().Next(10000, 100000).ToString();
                string checkLicenseIdQuery = "select * from is_there_driver('" + newLicenseId + "');";
                cmd.CommandText = checkLicenseIdQuery;
                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();
                isUnic = int.Parse(cmd.ExecuteScalar().ToString()) == 0 ? true : false;
                sqlConnection1.Close();
            }

            // добавить водителя
            string addDriverQuery = "select addDriver('" + newLicenseId + "', '" + surnameValue.Text + "', '" + nameValue.Text + "', '" + patronymicValue.Text + "');";
            cmd.CommandText = addDriverQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            driverTableAdapter.Fill(finesDataSet.driver);
            surnameValue.Text = "";
            nameValue.Text = "";
            patronymicValue.Text = "";
        }

        private void deleteDriverButton_Click(object sender, EventArgs e)
        {
            // создание подключения
            System.Data.Odbc.OdbcConnection sqlConnection1 = driverTableAdapter.Connection;
            System.Data.Odbc.OdbcCommand cmd = new System.Data.Odbc.OdbcCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            // проверка на корректность вод. уд.
            bool isCorrect = Regex.IsMatch(licenseIdValue.Text, @"^\d{10}$");
            if (!isCorrect)
            {
                deleteMessageLabel.ForeColor = Color.Red;
                deleteMessageLabel.Text = "Некорректный номер вод. уд.";
                return ;
            }

            // проверка на существование вод. уд.
            string checkLicenseIdQuery = "select * from is_there_driver('" + licenseIdValue.Text + "');";
            cmd.CommandText = checkLicenseIdQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            bool isThereDriver = int.Parse(cmd.ExecuteScalar().ToString()) == 1 ? true : false;
            sqlConnection1.Close();

            if (!isThereDriver)
            {
                deleteMessageLabel.ForeColor = Color.Red;
                deleteMessageLabel.Text = "Водителя с таким вод. уд. не существует";
                return ;
            }

            // проверить штрафы у водителя
            string checkFinesQuery = "select * from is_there_unpaid_fines_for_driver('" + licenseIdValue.Text + "');";
            cmd.CommandText = checkFinesQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            bool isThereUnoaidFines = int.Parse(cmd.ExecuteScalar().ToString()) == 1 ? true : false;
            sqlConnection1.Close();

            if (isThereUnoaidFines)
            {
                deleteMessageLabel.ForeColor = Color.Red;
                deleteMessageLabel.Text = "Есть неоплаченные штрафы";
                return ;
            }

            // удалить штрафы
            string deleteFinesQuery = "select * from deleteFinesForDriver('" + licenseIdValue.Text + "');";
            cmd.CommandText = deleteFinesQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            // удалить машины
            string deleteCarsQuery = "select * from deleteCarsForDriver('" + licenseIdValue.Text + "');";
            cmd.CommandText = deleteCarsQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            // удалить водителя
            string deleteDriverQuery = "select * from deleteDriver('" + licenseIdValue.Text + "');";
            cmd.CommandText = deleteDriverQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            driverTableAdapter.Fill(finesDataSet.driver);
            licenseIdValue.Text = "";

            deleteMessageLabel.ForeColor = Color.Green;
            deleteMessageLabel.Text = "Водитель удалён";
        }

        private void driverDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedCellRawIndex = driverDataGridView.SelectedCells[0].RowIndex;
            licenseIdValue.Text = driverDataGridView.Rows[selectedCellRawIndex].Cells[0].Value.ToString();
        }
    }
}
