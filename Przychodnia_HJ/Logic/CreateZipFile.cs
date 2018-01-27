using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia_HJ.Logic
{
    public class CreateZipFile
    {
        public string Path { get; private set; }
        public string FileName { get; private set; }

        public CreateZipFile(string path, string fileName)
        {
            Path = path;
            FileName = fileName;
        }

        public void CreateZipFileFromDataTable(DataTable dataTable)
        {
            if (!Directory.Exists(Path))
            {
                return;
            }

            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    dataTable.WriteXml(stream);
                    stream.Seek(0, SeekOrigin.Begin);

                    using (ZipOutputStream s = new ZipOutputStream(File.Create(FileName + ".zip")))
                    {
                        s.SetLevel(9);

                        var entry = new ZipEntry("Report.xml");

                        entry.DateTime = DateTime.Now;
                        s.PutNextEntry(entry);

                        StreamUtils.Copy(stream, s, new byte[4096]);

                        s.CloseEntry();
                        s.Finish();
                        s.Close();
                    }
                }
                MessageBox.Show("Pomyślnie zapisano plik na dysku");  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zapisywania pliku na dysku");
            }
        }
    }
}
