using Przychodnia_HJ.Logic;
using Przychodnia_HJ.PrzychodniaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia_HJ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DoctorForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RaportForm().ShowDialog();
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            new EditPatientForm().ShowDialog();
        }

        private void declarationButton_Click(object sender, EventArgs e)
        {
            new PatientFormcs().ShowDialog();
        }

        private void visitsButton_Click(object sender, EventArgs e)
        {
            new VisitsForm().ShowDialog();
        }
    }
}
