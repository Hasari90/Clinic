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
    public partial class VisitsForm : Form
    {
        public VisitsForm()
        {
            InitializeComponent();
        }

        private void VisitsForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaDataSet.Lekarze' . Możesz go przenieść lub usunąć.
            this.lekarzeTableAdapter.Fill(this.przychodniaDataSet.Lekarze);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaDataSet.Pacjenci' . Możesz go przenieść lub usunąć.
            this.pacjenciTableAdapter.Fill(this.przychodniaDataSet.Pacjenci);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaDataSet.ICD' . Możesz go przenieść lub usunąć.
            this.iCDTableAdapter.Fill(this.przychodniaDataSet.ICD);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaDataSet.Wizyty' . Możesz go przenieść lub usunąć.
            this.wizytyTableAdapter.Fill(this.przychodniaDataSet.Wizyty);

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgRow in dgvVisits.Rows)
            {
                if (dgRow.Cells[0].Value != null)
                {
                    if (Convert.ToInt32(dgRow.Cells[0].Value.ToString()) > 0)
                        this.wizytyTableAdapter.UpdateQuery(Convert.ToInt32(dgRow.Cells[4].Value.ToString()), Convert.ToInt32(dgRow.Cells[0].Value.ToString()));
                }
            }
            this.wizytyTableAdapter.Fill(this.przychodniaDataSet.Wizyty);
            dgvVisits.Refresh();
        }
    }
}
