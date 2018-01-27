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
    public partial class PatientFormcs : Form
    {
        public static int ID;
        public PatientFormcs()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
                this.pacjenciTableAdapter.FillByWhere(this.przychodniaDataSet.Pacjenci, textBox1.Text, textBox2.Text);
            else
                this.pacjenciTableAdapter.Fill(this.przychodniaDataSet.Pacjenci);
            dataGridView1.Refresh();
        }

        private void PatientFormcs_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaDataSet.Pacjenci' . Możesz go przenieść lub usunąć.
            this.pacjenciTableAdapter.Fill(this.przychodniaDataSet.Pacjenci);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaDataSet.Deklaracje' . Możesz go przenieść lub usunąć.
            this.deklaracjeTableAdapter.Fill(this.przychodniaDataSet.Deklaracje);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow dgRow in dataGridView1.SelectedRows)
            {
                int.TryParse(dgRow.Cells[0].Value.ToString(),out ID);
                new DeclarationForm().ShowDialog();
            }
        }
    }
}
