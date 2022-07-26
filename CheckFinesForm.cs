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
    public partial class CheckFinesForm : Form
    {
        public CheckFinesForm()
        {
            InitializeComponent();

            // searchFineType
            searchFineType.DisplayMember = "Text";
            searchFineType.ValueMember = "Value";
            var searchFineTypeItems = new[] {
                new { Text = "Постановление", Value = "id" },
                new { Text = "Гос.номер", Value = "car_number_plate" },
                new { Text = "Вод. уд.", Value = "driver_license_id" }
            };
            searchFineType.DataSource = searchFineTypeItems;
            searchFineType.SelectedIndex = 0;

            // searchFineStatus
            searchFineStatus.DisplayMember = "Text";
            searchFineStatus.ValueMember = "Value";
            var searchFineStatusItems = new[] {
                new { Text = "Все", Value = "%" },
                new { Text = "Оплаченные", Value = "Оплачен" },
                new { Text = "Неоплаченные", Value = "Не оплачен" }
            };
            searchFineStatus.DataSource = searchFineStatusItems;
            searchFineStatus.SelectedIndex = 0;

            // searchSortCol
            searchSortCol.DisplayMember = "Text";
            searchSortCol.ValueMember = "Value";
            var searchSortColItems = new[] {
                new { Text = "Постановлению", Value = "id" },
                new { Text = "Гос. номеру", Value = "car_number_plate" },
                new { Text = "Марке", Value = "make" },
                new { Text = "Модели", Value = "model" },
                new { Text = "Цвету", Value = "color" },
                new { Text = "Вод. уд.", Value = "driver_license_id" },
                new { Text = "Фамилии", Value = "surname" },
                new { Text = "Имени", Value = "name" },
                new { Text = "Отчеству", Value = "patronymic" },
                new { Text = "Дате", Value = "date" },
                new { Text = "Дате выписки", Value = "date_issue" },
                new { Text = "Адресу", Value = "address" },
                new { Text = "Статусу", Value = "status" },
                new { Text = "Штрафу", Value = "fine_name" },
                new { Text = "Размеру", Value = "amount" }
            };
            searchSortCol.DataSource = searchSortColItems;
            searchSortCol.SelectedIndex = 0;

            // searchSortType
            searchSortType.DisplayMember = "Text";
            searchSortType.ValueMember = "Value";
            var searchSortTypeItems = new[] {
                new { Text = "По возрастанию", Value = "asc" },
                new { Text = "По убыванию", Value = "desc" }
            };
            searchSortType.DataSource = searchSortTypeItems;
            searchSortType.SelectedIndex = 0;
        }

        private void CheckFinesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finesDataSet.fines' table. You can move, or remove it, as needed.
            this.finesTableAdapter.Fill(this.finesDataSet.fines);

        }

        private void searchFineButton_Click(object sender, EventArgs e)
        {
            System.Data.Odbc.OdbcConnection sqlConnection1 = finesTableAdapter.Connection;
            System.Data.Odbc.OdbcCommand cmd = new System.Data.Odbc.OdbcCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            /*string message = "";
            string searchFineTypeString = "";


            


            cmd.CommandText = "select * from car";
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();


            for (int i = 0; i < 4; i++)
            {
                System.Data.Odbc.OdbcDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("CustomerID={0}", reader.VisibleFieldCount);
                }
                reader.Close();
            }
            // reader.VisibleFieldCount - число столбцов 
            System.Data.Odbc.OdbcDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Console.WriteLine("CustomerID={0}", reader.VisibleFieldCount);
            reader.Close();*/








            int error = 0;
            string message = "";
            
            // проверка на существование машины, водителя, нарушения
            string checkForExistenceQuery = "select * from is_there_";
            switch (searchFineType.SelectedIndex)
            {
                case 0:
                    checkForExistenceQuery += "violation";
                    break;
                case 1:
                    checkForExistenceQuery += "car";
                    break;
                case 2:
                    checkForExistenceQuery += "driver";
                    break;
                default:
                    break;
            }
            checkForExistenceQuery += "('" + searchFineValue.Text + "');";
            // запрос
            cmd.CommandText = checkForExistenceQuery;
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            int reader = int.Parse(cmd.ExecuteScalar().ToString());
            if (reader == 0)
            {
                error = 1;
                message = "Данные не найдены";
            }
            sqlConnection1.Close();

            if (error == 1)
            {
                return ;
            }

            // Получение штрафов 

            string getFinesQuery = "select * from fines where " + searchFineType.SelectedValue + " like '" + searchFineValue.Text + "' AND status like '" + searchFineStatus.SelectedValue + "' order by " + searchSortCol.SelectedValue + " " + searchSortType.SelectedValue + ";";            
            cmd.CommandText = getFinesQuery;
            //cmd.Connection = sqlConnection1;
            sqlConnection1.Open();

            System.Data.Odbc.OdbcDataReader reader2 = cmd.ExecuteReader();
            //Console.WriteLine(getFinesQuery);
            finesDataGridView.DataSource = new object();

            DataTable newDataTable = new DataTable();
            newDataTable.Load(reader2);

            finesDataGridView.DataSource = newDataTable;

            //finesDataGridView.DataSource = reader2.GetSchemaTable();
            sqlConnection1.Close();
            
        }
    }
}
