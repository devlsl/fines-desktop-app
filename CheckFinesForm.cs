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
        }

        private void CheckFinesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finesDataSet.fines' table. You can move, or remove it, as needed.
            this.finesTableAdapter.Fill(this.finesDataSet.fines);

        }
    }
}
