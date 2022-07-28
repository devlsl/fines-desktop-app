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
    public partial class CarManageForm : Form
    {
        public CarManageForm(string polliceOfficerId)
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

        private void CarManageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finesDataSet.car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.finesDataSet.car);
            // TODO: This line of code loads data into the 'finesDataSet.driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.finesDataSet.driver);
            // TODO: This line of code loads data into the 'finesDataSet1.driver' table. You can move, or remove it, as needed.
            //this.driverTableAdapter.Fill(this.finesDataSet1.driver);
            // TODO: This line of code loads data into the 'finesDataSet.cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.finesDataSet.cars);

        }

        private void backToOfficerSignInFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PoliceOfficerMenuForm policeOfficerMenuForm = new PoliceOfficerMenuForm(getPolliceOfficerId());
            policeOfficerMenuForm.Show();
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            // валидация гос номера
            string numberPlate = numberPlateValue.Text.ToLower();
            bool isCorrect = Regex.IsMatch(numberPlate, @"^[авекмнорстух]{1}\d{3}[авекмнорстух]{2}\d{2,3}$");

            if (!isCorrect)
            {
                addMessageLabel.ForeColor = Color.Red;
                addMessageLabel.Text = "Некорректный гос. номер";
                return ;
            }

            // создание подключения
            System.Data.Odbc.OdbcConnection sqlConnection1 = carsTableAdapter.Connection;
            System.Data.Odbc.OdbcCommand cmd = new System.Data.Odbc.OdbcCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            // проверка на уникальность гос номера
            string checkNumberPlateQuery = "select * from is_there_car('" + numberPlate + "');";
            cmd.CommandText = checkNumberPlateQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            bool isThereCar = int.Parse(cmd.ExecuteScalar().ToString()) == 1 ? true : false;
            sqlConnection1.Close();
            if (isThereCar)
            {
                addMessageLabel.ForeColor = Color.Red;
                addMessageLabel.Text = "Такой гос. номер уже существует";
                return ;
            }

            // добавить в базу машину через функцию
            string addCarQuery = "select addCar('" + numberPlate + "', '" + licenseIdValue.Text + "', '" + makeValue.Text + "', '" + modelValue.Text + "', '" + colorValue.Text + "');"; 
            cmd.CommandText = addCarQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            carsTableAdapter.Fill(finesDataSet.cars); 
            numberPlateValue.Text = "";
            makeValue.Text = "";
            modelValue.Text = "";
            colorValue.Text = "";

            addMessageLabel.ForeColor = Color.Green;
            addMessageLabel.Text = "Автомобиль добавлен";
        }

        private void deleteCarButton_Click(object sender, EventArgs e)
        {
            // создание подключения
            System.Data.Odbc.OdbcConnection sqlConnection1 = carsTableAdapter.Connection;
            System.Data.Odbc.OdbcCommand cmd = new System.Data.Odbc.OdbcCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            // проверка на существование гос номера
            string numberPlate = numberPlateDeleteValue.Text.ToLower(); 
            string checkNumberPlateQuery = "select * from is_there_car('" + numberPlate + "');";
            cmd.CommandText = checkNumberPlateQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            bool isThereCar = int.Parse(cmd.ExecuteScalar().ToString()) == 1 ? true : false;
            sqlConnection1.Close();
            if (!isThereCar)
            {
                deleteMessageLabel.ForeColor = Color.Red;
                deleteMessageLabel.Text = "Автомобиля с таким гос. номером не существует";
                return;
            }

            // проверка на неоплаченные штрафы
            string checkUnpaidFinesQuery = "select * from is_there_unpaid_fines('" + numberPlate + "');";
            cmd.CommandText = checkUnpaidFinesQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            bool isThereUnpaidFines = int.Parse(cmd.ExecuteScalar().ToString()) == 1 ? true : false;
            sqlConnection1.Close();
            if (isThereUnpaidFines)
            {
                deleteMessageLabel.ForeColor = Color.Red;
                deleteMessageLabel.Text = "Есть неоплаченные штрафы";
                return;
            }

            // удалить штрафы из бд
            string deleteFinesQuery = "select * from deleteFinesForCar('" + numberPlate + "');";
            cmd.CommandText = deleteFinesQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            // удалить машину из бд
            string deleteCarQuery = "select * from deleteCar('" + numberPlate + "');";
            cmd.CommandText = deleteCarQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            carsTableAdapter.Fill(finesDataSet.cars); 

            deleteMessageLabel.ForeColor = Color.Green;
            deleteMessageLabel.Text = "Автомобиль удалён";
        }

        private void carsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedCellRawIndex = carsDataGridView.SelectedCells[0].RowIndex;
            numberPlateDeleteValue.Text = carsDataGridView.Rows[selectedCellRawIndex].Cells[3].Value.ToString();
        }
    }
}
