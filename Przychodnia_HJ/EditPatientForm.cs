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
    public partial class EditPatientForm : Form
    {
        public static int ID;
        public EditPatientForm()
        {
            InitializeComponent();
            DeklaracjeTableAdapter deklaracjeTableAdapter = new DeklaracjeTableAdapter();
            WizytyTableAdapter wizytyTableAdapter = new WizytyTableAdapter();
            dataGridView2.DataSource = deklaracjeTableAdapter.GetDataByJoin();
            dataGridView3.DataSource = wizytyTableAdapter.GetDataByJoin();

            dataGridView2.Columns["ID"].Visible = false;
            dataGridView2.Columns["IdPacjenta"].Visible = false;
            dataGridView2.Columns["IdLekarza"].Visible = false;

            dataGridView3.Columns["ID"].Visible = false;
            dataGridView3.Columns["IdLekarza"].Visible = false;
            dataGridView3.Columns["IdPacjenta"].Visible = false;
            dataGridView3.Columns["KodICD"].Visible = false;


            comboBox1.DataSource = this.pacjenciTableAdapter.GetDataByCombo();
            comboBox1.DisplayMember = "Pacjent";
            comboBox1.ValueMember = "ID";
            comboBox2.DataSource = this.lekarzeTableAdapter.GetDataByCombo();
            comboBox2.DisplayMember = "Lekarz";
            comboBox2.ValueMember = "ID";
            comboBox3.DataSource = this.pacjenciTableAdapter.GetDataByCombo();
            comboBox3.DisplayMember = "Pacjent";
            comboBox3.ValueMember = "ID";
            comboBox4.DataSource = this.lekarzeTableAdapter.GetDataByCombo();
            comboBox4.DisplayMember = "Lekarz";
            comboBox4.ValueMember = "ID";
            comboBox5.DataSource = this.iCDTableAdapter.GetData();
            comboBox5.DisplayMember = "Nazwa";
            comboBox5.ValueMember = "ID";
        }

        private void EditPatientForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaDataSet1.ICD' . Możesz go przenieść lub usunąć.
            this.iCDTableAdapter.Fill(this.przychodniaDataSet.ICD);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaDataSet.Lekarze' . Możesz go przenieść lub usunąć.
            this.lekarzeTableAdapter.Fill(this.przychodniaDataSet.Lekarze);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaDataSet.Wizyty' . Możesz go przenieść lub usunąć.
            //this.wizytyTableAdapter.FillByJoin(this.przychodniaDataSet.Wizyty);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaDataSet.Deklaracje' . Możesz go przenieść lub usunąć.
            //this.deklaracjeTableAdapter.FillByJoin(this.przychodniaDataSet.Deklaracje);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaDataSet.Pacjenci' . Możesz go przenieść lub usunąć.
            this.pacjenciTableAdapter.Fill(this.przychodniaDataSet.Pacjenci);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow dgRow in dataGridView1.SelectedRows)
            {
                int.TryParse(dgRow.Cells[0].Value.ToString(), out ID);
                textBox1.Text = dgRow.Cells[1].Value.ToString();
                textBox2.Text = dgRow.Cells[2].Value.ToString();
                textBox3.Text = dgRow.Cells[3].Value.ToString();
                textBox4.Text = dgRow.Cells[4].Value.ToString();
                textBox5.Text = dgRow.Cells[5].Value.ToString();
                textBox6.Text = dgRow.Cells[6].Value.ToString();
                textBox7.Text = dgRow.Cells[7].Value.ToString();
                textBox8.Text = dgRow.Cells[8].Value.ToString();
                textBox9.Text = dgRow.Cells[9].Value.ToString();
                dateTimePicker1.Text = dgRow.Cells[10].Value.ToString();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            { 

            this.pacjenciTableAdapter.UpdateQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, dateTimePicker1.Value.Date, ID);

            ID = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            MessageBox.Show("Pacjent został pomyślne zapisany w bazie danych.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Błąd podczas zapisywania pacjenta do bazy danych.");
            }
            this.pacjenciTableAdapter.Fill(this.przychodniaDataSet.Pacjenci);
            dataGridView1.Refresh();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacjenciTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, dateTimePicker1.Value.Date);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();
                MessageBox.Show("Pacjent został pomyślne dodany do bazy danych.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Błąd podczas zapisywania pacjenta do bazy danych.");
            }

            this.pacjenciTableAdapter.Fill(this.przychodniaDataSet.Pacjenci);
            dataGridView1.Refresh();
        }

        private void insertDButton_Click(object sender, EventArgs e)
        {
            DeklaracjeTableAdapter deklaracjeTableAdapter = new DeklaracjeTableAdapter();
            try
            {
            
            deklaracjeTableAdapter.InsertQuery(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), dateTimePicker2.Value.Date, checkBox1.Checked);

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dateTimePicker2.Text = DateTime.Now.ToShortDateString();
            checkBox1.Checked = false;
            MessageBox.Show("Deklaracja została pomyślne dodana do bazy danych.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Błąd podczas zapisywania deklaracji do bazy danych.");
            }
            dataGridView2.DataSource = deklaracjeTableAdapter.GetDataByJoin();
            dataGridView2.Refresh();
        }

        private void insertWButton_Click(object sender, EventArgs e)
        {
            WizytyTableAdapter wizytyTableAdapter = new WizytyTableAdapter();
            try
            { 
            wizytyTableAdapter.InsertQuery(dateTimePicker3.Value.Date, Convert.ToInt32(comboBox3.SelectedValue), Convert.ToInt32(comboBox4.SelectedValue), Convert.ToInt32(comboBox5.SelectedValue), textBox10.Text);
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            dateTimePicker3.Text = DateTime.Now.ToShortDateString();
            MessageBox.Show("Wizyta została pomyślne dodana do bazy danych.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Błąd podczas zapisywania wizyty do bazy danych.");
            }
            dataGridView3.DataSource = wizytyTableAdapter.GetDataByJoin();
            dataGridView3.Refresh();
        }
    }
}
