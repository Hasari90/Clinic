namespace Przychodnia_HJ
{
    partial class DeclarationForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deklaracjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaDataSet = new Przychodnia_HJ.PrzychodniaDataSet();
            this.deklaracjeTableAdapter = new Przychodnia_HJ.PrzychodniaDataSetTableAdapters.DeklaracjeTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacjentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLekarzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozytywnaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deklaracjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.idPacjentaDataGridViewTextBoxColumn,
            this.idLekarzaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.pozytywnaDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.deklaracjeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(855, 68);
            this.dataGridView1.TabIndex = 0;
            // 
            // deklaracjeBindingSource
            // 
            this.deklaracjeBindingSource.DataMember = "Deklaracje";
            this.deklaracjeBindingSource.DataSource = this.przychodniaDataSet;
            // 
            // przychodniaDataSet
            // 
            this.przychodniaDataSet.DataSetName = "PrzychodniaDataSet";
            this.przychodniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deklaracjeTableAdapter
            // 
            this.deklaracjeTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPacjentaDataGridViewTextBoxColumn
            // 
            this.idPacjentaDataGridViewTextBoxColumn.DataPropertyName = "Pacjent";
            this.idPacjentaDataGridViewTextBoxColumn.HeaderText = "Pacjent";
            this.idPacjentaDataGridViewTextBoxColumn.Name = "idPacjentaDataGridViewTextBoxColumn";
            this.idPacjentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idLekarzaDataGridViewTextBoxColumn
            // 
            this.idLekarzaDataGridViewTextBoxColumn.DataPropertyName = "Lekarz";
            this.idLekarzaDataGridViewTextBoxColumn.HeaderText = "Lekarz";
            this.idLekarzaDataGridViewTextBoxColumn.Name = "idLekarzaDataGridViewTextBoxColumn";
            this.idLekarzaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pozytywnaDataGridViewCheckBoxColumn
            // 
            this.pozytywnaDataGridViewCheckBoxColumn.DataPropertyName = "Pozytywna";
            this.pozytywnaDataGridViewCheckBoxColumn.HeaderText = "Pozytywna";
            this.pozytywnaDataGridViewCheckBoxColumn.Name = "pozytywnaDataGridViewCheckBoxColumn";
            this.pozytywnaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // DeclarationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 88);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeclarationForm";
            this.Text = "Deklaracja";
            this.Load += new System.EventHandler(this.DeclarationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deklaracjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PrzychodniaDataSet przychodniaDataSet;
        private System.Windows.Forms.BindingSource deklaracjeBindingSource;
        private PrzychodniaDataSetTableAdapters.DeklaracjeTableAdapter deklaracjeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacjentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLekarzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pozytywnaDataGridViewCheckBoxColumn;
    }
}