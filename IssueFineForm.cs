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
    }
}
