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
            //LekarzeTableAdapter lekarze = new LekarzeTableAdapter();
            //dgvDoctor.DataSource = lekarze.GetData();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaDataSet.Lekarze' . Możesz go przenieść lub usunąć.
            this.lekarzeTableAdapter.Fill(this.przychodniaDataSet.Lekarze);

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dgRow in dgvDoctor.Rows)
                {
                    if (dgRow.Cells[0].Value != null)
                    {
                        if (Convert.ToInt32(dgRow.Cells[0].Value.ToString()) < 0)
                            this.lekarzeTableAdapter.InsertQuery(dgRow.Cells[1].Value.ToString(), dgRow.Cells[2].Value.ToString(), dgRow.Cells[3].Value.ToString(), dgRow.Cells[4].Value.ToString(), dgRow.Cells[5].Value.ToString());
                        else
                            this.lekarzeTableAdapter.UpdateQuery(dgRow.Cells[1].Value.ToString(), dgRow.Cells[2].Value.ToString(), dgRow.Cells[3].Value.ToString(), dgRow.Cells[4].Value.ToString(), dgRow.Cells[5].Value.ToString(), Convert.ToInt32(dgRow.Cells[0].Value.ToString()));
                    }
                }
                MessageBox.Show("Zmiany zapisany w bazie danych.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Błąd podczas zapisywania zmian.");
            }
          
            this.lekarzeTableAdapter.Fill(this.przychodniaDataSet.Lekarze);
            dgvDoctor.Refresh();
        }
    }
}
