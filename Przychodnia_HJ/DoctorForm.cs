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
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
            LekarzeTableAdapter lekarze = new LekarzeTableAdapter();
            dgvDoctor.DataSource = lekarze.GetData();
        }
    }
}
