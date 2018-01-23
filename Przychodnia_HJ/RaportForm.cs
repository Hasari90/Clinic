using Przychodnia_HJ.Logic;
using Przychodnia_HJ.PrzychodniaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia_HJ
{
    public partial class RaportForm : Form
    {
        public RaportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(saveFileDialog.FileName != "")
                {
                    CreateZipFile czf = new CreateZipFile(Path.GetDirectoryName(saveFileDialog.FileName), saveFileDialog.FileName);
                    LekarzeTableAdapter lekarze = new LekarzeTableAdapter();
                    czf.CreateZipFileFromDataTable(lekarze.GetData());
                }
            }
        }
    }
}
