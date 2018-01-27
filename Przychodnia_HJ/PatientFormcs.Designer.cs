namespace Przychodnia_HJ
{
    partial class PatientFormcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imiona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubezpieczenie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ulica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrDomu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrMieszkania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataUrodzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacjenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaDataSet = new Przychodnia_HJ.PrzychodniaDataSet();
            this.deklaracjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deklaracjeTableAdapter = new Przychodnia_HJ.PrzychodniaDataSetTableAdapters.DeklaracjeTableAdapter();
            this.pacjenciTableAdapter = new Przychodnia_HJ.PrzychodniaDataSetTableAdapters.PacjenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deklaracjeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwisko";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(361, 32);
            this.textBox2.MaxLength = 11;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PESEL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.Nazwisko,
            this.Imiona,
            this.PESEL,
            this.Ubezpieczenie,
            this.Ulica,
            this.NrDomu,
            this.NrMieszkania,
            this.Miasto,
            this.Kod,
            this.DataUrodzenia});
            this.dataGridView1.DataSource = this.pacjenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 72);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 477);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Nazwisko
            // 
            this.Nazwisko.DataPropertyName = "Nazwisko";
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.ReadOnly = true;
            // 
            // Imiona
            // 
            this.Imiona.DataPropertyName = "Imiona";
            this.Imiona.HeaderText = "Imiona";
            this.Imiona.Name = "Imiona";
            this.Imiona.ReadOnly = true;
            // 
            // PESEL
            // 
            this.PESEL.DataPropertyName = "PESEL";
            this.PESEL.HeaderText = "PESEL";
            this.PESEL.Name = "PESEL";
            this.PESEL.ReadOnly = true;
            // 
            // Ubezpieczenie
            // 
            this.Ubezpieczenie.DataPropertyName = "Ubezpieczenie";
            this.Ubezpieczenie.HeaderText = "Ubezpieczenie";
            this.Ubezpieczenie.Name = "Ubezpieczenie";
            this.Ubezpieczenie.ReadOnly = true;
            // 
            // Ulica
            // 
            this.Ulica.DataPropertyName = "Ulica";
            this.Ulica.HeaderText = "Ulica";
            this.Ulica.Name = "Ulica";
            this.Ulica.ReadOnly = true;
            // 
            // NrDomu
            // 
            this.NrDomu.DataPropertyName = "NrDomu";
            this.NrDomu.HeaderText = "NrDomu";
            this.NrDomu.Name = "NrDomu";
            this.NrDomu.ReadOnly = true;
            // 
            // NrMieszkania
            // 
            this.NrMieszkania.DataPropertyName = "NrMieszkania";
            this.NrMieszkania.HeaderText = "NrMieszkania";
            this.NrMieszkania.Name = "NrMieszkania";
            this.NrMieszkania.ReadOnly = true;
            // 
            // Miasto
            // 
            this.Miasto.DataPropertyName = "Miasto";
            this.Miasto.HeaderText = "Miasto";
            this.Miasto.Name = "Miasto";
            this.Miasto.ReadOnly = true;
            // 
            // Kod
            // 
            this.Kod.DataPropertyName = "Kod";
            this.Kod.HeaderText = "Kod";
            this.Kod.Name = "Kod";
            this.Kod.ReadOnly = true;
            // 
            // DataUrodzenia
            // 
            this.DataUrodzenia.DataPropertyName = "DataUrodzenia";
            this.DataUrodzenia.HeaderText = "DataUrodzenia";
            this.DataUrodzenia.Name = "DataUrodzenia";
            this.DataUrodzenia.ReadOnly = true;
            // 
            // pacjenciBindingSource
            // 
            this.pacjenciBindingSource.DataMember = "Pacjenci";
            this.pacjenciBindingSource.DataSource = this.przychodniaDataSet;
            // 
            // przychodniaDataSet
            // 
            this.przychodniaDataSet.DataSetName = "PrzychodniaDataSet";
            this.przychodniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deklaracjeBindingSource
            // 
            this.deklaracjeBindingSource.DataMember = "Deklaracje";
            this.deklaracjeBindingSource.DataSource = this.przychodniaDataSet;
            // 
            // deklaracjeTableAdapter
            // 
            this.deklaracjeTableAdapter.ClearBeforeFill = true;
            // 
            // pacjenciTableAdapter
            // 
            this.pacjenciTableAdapter.ClearBeforeFill = true;
            // 
            // PatientFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "PatientFormcs";
            this.Text = "Wyszukaj pacjenta";
            this.Load += new System.EventHandler(this.PatientFormcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deklaracjeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PrzychodniaDataSet przychodniaDataSet;
        private System.Windows.Forms.BindingSource deklaracjeBindingSource;
        private PrzychodniaDataSetTableAdapters.DeklaracjeTableAdapter deklaracjeTableAdapter;
        private System.Windows.Forms.BindingSource pacjenciBindingSource;
        private PrzychodniaDataSetTableAdapters.PacjenciTableAdapter pacjenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imiona;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubezpieczenie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ulica;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrDomu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrMieszkania;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataUrodzenia;
    }
}