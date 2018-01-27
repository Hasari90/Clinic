namespace Przychodnia_HJ
{
    partial class DoctorForm
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
            this.dgvDoctor = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imionaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPWZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lekarzeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaDataSet = new Przychodnia_HJ.PrzychodniaDataSet();
            this.lekarzeTableAdapter = new Przychodnia_HJ.PrzychodniaDataSetTableAdapters.LekarzeTableAdapter();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarzeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.AutoGenerateColumns = false;
            this.dgvDoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.imionaDataGridViewTextBoxColumn,
            this.tytulDataGridViewTextBoxColumn,
            this.nPWZDataGridViewTextBoxColumn,
            this.pESELDataGridViewTextBoxColumn});
            this.dgvDoctor.DataSource = this.lekarzeBindingSource;
            this.dgvDoctor.Location = new System.Drawing.Point(12, 74);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctor.Size = new System.Drawing.Size(996, 542);
            this.dgvDoctor.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // imionaDataGridViewTextBoxColumn
            // 
            this.imionaDataGridViewTextBoxColumn.DataPropertyName = "Imiona";
            this.imionaDataGridViewTextBoxColumn.HeaderText = "Imiona";
            this.imionaDataGridViewTextBoxColumn.Name = "imionaDataGridViewTextBoxColumn";
            // 
            // tytulDataGridViewTextBoxColumn
            // 
            this.tytulDataGridViewTextBoxColumn.DataPropertyName = "Tytul";
            this.tytulDataGridViewTextBoxColumn.HeaderText = "Tytul";
            this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
            // 
            // nPWZDataGridViewTextBoxColumn
            // 
            this.nPWZDataGridViewTextBoxColumn.DataPropertyName = "NPWZ";
            this.nPWZDataGridViewTextBoxColumn.HeaderText = "NPWZ";
            this.nPWZDataGridViewTextBoxColumn.Name = "nPWZDataGridViewTextBoxColumn";
            // 
            // pESELDataGridViewTextBoxColumn
            // 
            this.pESELDataGridViewTextBoxColumn.DataPropertyName = "PESEL";
            this.pESELDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.pESELDataGridViewTextBoxColumn.Name = "pESELDataGridViewTextBoxColumn";
            // 
            // lekarzeBindingSource
            // 
            this.lekarzeBindingSource.DataMember = "Lekarze";
            this.lekarzeBindingSource.DataSource = this.przychodniaDataSet;
            // 
            // przychodniaDataSet
            // 
            this.przychodniaDataSet.DataSetName = "PrzychodniaDataSet";
            this.przychodniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lekarzeTableAdapter
            // 
            this.lekarzeTableAdapter.ClearBeforeFill = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(13, 30);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(112, 23);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Zapisz Zmiany";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 628);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dgvDoctor);
            this.Name = "DoctorForm";
            this.Text = "Edycja lekarzy";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarzeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoctor;
        private PrzychodniaDataSet przychodniaDataSet;
        private System.Windows.Forms.BindingSource lekarzeBindingSource;
        private PrzychodniaDataSetTableAdapters.LekarzeTableAdapter lekarzeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imionaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPWZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button updateButton;
    }
}