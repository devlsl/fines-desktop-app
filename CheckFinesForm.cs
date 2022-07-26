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
                new { Text = "Постановлению", Value = "%" },
                new { Text = "Гос. номеру", Value = "Оплачен" },
                new { Text = "", Value = "Не оплачен" }
            };
            searchSortCol.DataSource = searchSortColItems;
            searchSortCol.SelectedIndex = 0;

            // searchSortType
            searchSortType.DisplayMember = "Text";
            searchSortType.ValueMember = "Value";
            var searchSortTypeItems = new[] {
                new { Text = "Все", Value = "%" },
                new { Text = "Оплаченные", Value = "Оплачен" },
                new { Text = "Неоплаченные", Value = "Не оплачен" }
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









            string message = "";

            cmd.CommandText = "select * from car";
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();



            // searchFineType.SelectedValue - тип поиска
            Console.WriteLine() ;


            sqlConnection1.Close();
        }
    }
}
