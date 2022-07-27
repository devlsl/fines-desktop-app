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
    public partial class PoliceOfficerForm : Form
    {
        public PoliceOfficerForm()
        {
            InitializeComponent();

        }

        private void PoliceOfficerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finesDataSet.police_officer' table. You can move, or remove it, as needed.
            this.police_officerTableAdapter.Fill(this.finesDataSet.police_officer);

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PoliceOfficerMenuForm policeOfficerMenuForm = new PoliceOfficerMenuForm(policeOfficerId.Text);
            policeOfficerMenuForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
