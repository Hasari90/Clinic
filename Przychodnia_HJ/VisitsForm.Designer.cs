namespace Przychodnia_HJ
{
    partial class VisitsForm
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
            this.dgvVisits = new System.Windows.Forms.DataGridView();
            this.iCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaDataSet = new Przychodnia_HJ.PrzychodniaDataSet();
            this.wizytyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacjenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lekarzeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wizytyTableAdapter = new Przychodnia_HJ.PrzychodniaDataSetTableAdapters.WizytyTableAdapter();
            this.iCDTableAdapter = new Przychodnia_HJ.PrzychodniaDataSetTableAdapters.ICDTableAdapter();
            this.pacjenciTableAdapter = new Przychodnia_HJ.PrzychodniaDataSetTableAdapters.PacjenciTableAdapter();
            this.lekarzeTableAdapter = new Przychodnia_HJ.PrzychodniaDataSetTableAdapters.LekarzeTableAdapter();
            this.updateButton = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pacjent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lekarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodICD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizytyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarzeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisits
            // 
            this.dgvVisits.AllowUserToAddRows = false;
            this.dgvVisits.AllowUserToDeleteRows = false;
            this.dgvVisits.AutoGenerateColumns = false;
            this.dgvVisits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.Pacjent,
            this.Lekarz,
            this.KodICD,
            this.opisDataGridViewTextBoxColumn});
            this.dgvVisits.DataSource = this.wizytyBindingSource;
            this.dgvVisits.Location = new System.Drawing.Point(13, 52);
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisits.Size = new System.Drawing.Size(959, 497);
            this.dgvVisits.TabIndex = 0;
            // 
            // iCDBindingSource
            // 
            this.iCDBindingSource.DataMember = "ICD";
            this.iCDBindingSource.DataSource = this.przychodniaDataSet;
            // 
            // przychodniaDataSet
            // 
            this.przychodniaDataSet.DataSetName = "PrzychodniaDataSet";
            this.przychodniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wizytyBindingSource
            // 
            this.wizytyBindingSource.DataMember = "Wizyty";
            this.wizytyBindingSource.DataSource = this.przychodniaDataSet;
            // 
            // pacjenciBindingSource
            // 
            this.pacjenciBindingSource.DataMember = "Pacjenci";
            this.pacjenciBindingSource.DataSource = this.przychodniaDataSet;
            // 
            // lekarzeBindingSource
            // 
            this.lekarzeBindingSource.DataMember = "Lekarze";
            this.lekarzeBindingSource.DataSource = this.przychodniaDataSet;
            // 
            // wizytyTableAdapter
            // 
            this.wizytyTableAdapter.ClearBeforeFill = true;
            // 
            // iCDTableAdapter
            // 
            this.iCDTableAdapter.ClearBeforeFill = true;
            // 
            // pacjenciTableAdapter
            // 
            this.pacjenciTableAdapter.ClearBeforeFill = true;
            // 
            // lekarzeTableAdapter
            // 
            this.lekarzeTableAdapter.ClearBeforeFill = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(13, 12);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(112, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Zapisz Zmiany";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Pacjent
            // 
            this.Pacjent.DataPropertyName = "Pacjent";
            this.Pacjent.HeaderText = "Pacjent";
            this.Pacjent.Name = "Pacjent";
            this.Pacjent.ReadOnly = true;
            // 
            // Lekarz
            // 
            this.Lekarz.DataPropertyName = "Lekarz";
            this.Lekarz.HeaderText = "Lekarz";
            this.Lekarz.Name = "Lekarz";
            this.Lekarz.ReadOnly = true;
            // 
            // KodICD
            // 
            this.KodICD.DataPropertyName = "KodICD";
            this.KodICD.DataSource = this.iCDBindingSource;
            this.KodICD.DisplayMember = "Nazwa";
            this.KodICD.HeaderText = "KodICD";
            this.KodICD.Name = "KodICD";
            this.KodICD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.KodICD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.KodICD.ValueMember = "ID";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VisitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dgvVisits);
            this.Name = "VisitsForm";
            this.Text = "Wizyty";
            this.Load += new System.EventHandler(this.VisitsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizytyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarzeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisits;
        private PrzychodniaDataSet przychodniaDataSet;
        private System.Windows.Forms.BindingSource wizytyBindingSource;
        private PrzychodniaDataSetTableAdapters.WizytyTableAdapter wizytyTableAdapter;
        private System.Windows.Forms.BindingSource iCDBindingSource;
        private PrzychodniaDataSetTableAdapters.ICDTableAdapter iCDTableAdapter;
        private System.Windows.Forms.BindingSource pacjenciBindingSource;
        private System.Windows.Forms.BindingSource lekarzeBindingSource;
        private PrzychodniaDataSetTableAdapters.PacjenciTableAdapter pacjenciTableAdapter;
        private PrzychodniaDataSetTableAdapters.LekarzeTableAdapter lekarzeTableAdapter;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacjentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLekarzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn kodICDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pacjent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lekarz;
        private System.Windows.Forms.DataGridViewComboBoxColumn KodICD;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
    }
}