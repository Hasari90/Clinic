﻿using System;
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

    public partial class DeclarationForm : Form
    {
        public DeclarationForm()
        {
            InitializeComponent();
        }

        private void DeclarationForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przychodniaDataSet.Deklaracje' . Możesz go przenieść lub usunąć.
            this.deklaracjeTableAdapter.TOP1Query(this.przychodniaDataSet.Deklaracje,PatientFormcs.ID);
        }
    }
}
