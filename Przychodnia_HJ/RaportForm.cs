using Przychodnia_HJ.Logic;
using Przychodnia_HJ.PrzychodniaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia_HJ
{
    public partial class RaportForm : Form
    {
        public RaportForm()
        {
            InitializeComponent();
            DeklaracjeTableAdapter deklaracjeTableAdapter = new DeklaracjeTableAdapter();
            dataGridView1.DataSource = deklaracjeTableAdapter.GetDataByReport(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["IdPacjenta"].Visible = false;
            dataGridView1.Columns["IdLekarza"].Visible = false;
            dataGridView1.Columns["Pozytywna"].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(saveFileDialog.FileName != "")
                {
                    CreateZipFile czf = new CreateZipFile(Path.GetDirectoryName(saveFileDialog.FileName), saveFileDialog.FileName);
                    DeklaracjeTableAdapter deklaracjeTableAdapter = new DeklaracjeTableAdapter();
                    DataTable dataTable = new DataTable("Deklaracja");
                    dataTable = deklaracjeTableAdapter.GetDataByReport(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
                    czf.CreateZipFileFromDataTable(dataTable);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DeklaracjeTableAdapter deklaracjeTableAdapter = new DeklaracjeTableAdapter();
            dataGridView1.DataSource = deklaracjeTableAdapter.GetDataByReport(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            dataGridView1.Refresh();
        }
    }
}
