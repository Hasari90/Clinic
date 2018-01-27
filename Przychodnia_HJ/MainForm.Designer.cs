namespace Przychodnia_HJ
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.doctorButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.patientButton = new System.Windows.Forms.Button();
            this.declarationButton = new System.Windows.Forms.Button();
            this.visitsButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorButton
            // 
            this.doctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.doctorButton.Image = ((System.Drawing.Image)(resources.GetObject("doctorButton.Image")));
            this.doctorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorButton.Location = new System.Drawing.Point(3, 3);
            this.doctorButton.Name = "doctorButton";
            this.doctorButton.Size = new System.Drawing.Size(250, 60);
            this.doctorButton.TabIndex = 0;
            this.doctorButton.Text = "Lekarze";
            this.doctorButton.UseVisualStyleBackColor = true;
            this.doctorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportButton
            // 
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reportButton.Image = ((System.Drawing.Image)(resources.GetObject("reportButton.Image")));
            this.reportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportButton.Location = new System.Drawing.Point(3, 69);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(250, 60);
            this.reportButton.TabIndex = 1;
            this.reportButton.Text = "Raport";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.doctorButton);
            this.flowLayoutPanel1.Controls.Add(this.reportButton);
            this.flowLayoutPanel1.Controls.Add(this.patientButton);
            this.flowLayoutPanel1.Controls.Add(this.declarationButton);
            this.flowLayoutPanel1.Controls.Add(this.visitsButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(256, 332);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // patientButton
            // 
            this.patientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patientButton.Image = ((System.Drawing.Image)(resources.GetObject("patientButton.Image")));
            this.patientButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientButton.Location = new System.Drawing.Point(3, 135);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(250, 60);
            this.patientButton.TabIndex = 2;
            this.patientButton.Text = "Edytuj dane pacjenta";
            this.patientButton.UseVisualStyleBackColor = true;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // declarationButton
            // 
            this.declarationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.declarationButton.Image = ((System.Drawing.Image)(resources.GetObject("declarationButton.Image")));
            this.declarationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.declarationButton.Location = new System.Drawing.Point(3, 201);
            this.declarationButton.Name = "declarationButton";
            this.declarationButton.Size = new System.Drawing.Size(250, 60);
            this.declarationButton.TabIndex = 3;
            this.declarationButton.Text = "Wyszukaj pacjenta";
            this.declarationButton.UseVisualStyleBackColor = true;
            this.declarationButton.Click += new System.EventHandler(this.declarationButton_Click);
            // 
            // visitsButton
            // 
            this.visitsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.visitsButton.Image = ((System.Drawing.Image)(resources.GetObject("visitsButton.Image")));
            this.visitsButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.visitsButton.Location = new System.Drawing.Point(3, 267);
            this.visitsButton.Name = "visitsButton";
            this.visitsButton.Size = new System.Drawing.Size(250, 60);
            this.visitsButton.TabIndex = 4;
            this.visitsButton.Text = "Wizyty";
            this.visitsButton.UseVisualStyleBackColor = true;
            this.visitsButton.Click += new System.EventHandler(this.visitsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 351);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Przychodnia";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doctorButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button declarationButton;
        private System.Windows.Forms.Button visitsButton;
    }
}

