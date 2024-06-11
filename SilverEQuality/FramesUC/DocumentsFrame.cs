using SilverEQuality.MessageBoxes;
using SilverEQuality_Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverEQuality.FramesUC
{
    public partial class DocumentsFrame : UserControl
    {
        public DocumentsFrame()
        {
            InitializeComponent();
        }

        private void buttonUploadPZ_Click(object sender, EventArgs e)
        {
            UpdateFile(1);
        }

        private void buttonUploadNorms_Click(object sender, EventArgs e)
        {
            UpdateFile(2);
        }

        private void UpdateFile(int numberOfDoc)
        {
            if (openFileDialogDocs.ShowDialog() != DialogResult.OK) return;

            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var documents = db.Documents.FirstOrDefault(x => x.IdDocument == numberOfDoc);
                var filePZ = File.ReadAllBytes(openFileDialogDocs.FileName);

                documents.FileDocument = filePZ;

                db.Documents.Update(documents);
                db.SaveChanges();

                CustomMessageBox success = new CustomMessageBox("Файл успешно загружен", false);
            }
        }

        private void DownloadFile(int numberOfDoc)
        {
            saveFileDialogDocs.Filter = "PDF documents (.pdf)|*.pdf";

            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                if (saveFileDialogDocs.ShowDialog() != DialogResult.OK || saveFileDialogDocs.FileName == "") return;

                string path = saveFileDialogDocs.FileName;

                FileInfo fi = new FileInfo(path);

                // Open the stream for writing.
                using (FileStream fs = fi.OpenWrite())
                {
                    var documentSave = db.Documents.FirstOrDefault(x => x.IdDocument == numberOfDoc);

                    Byte[] info = documentSave.FileDocument;

                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }


            }
        }

        private void buttonDownloadPZ_Click(object sender, EventArgs e)
        {
            DownloadFile(1);
        }

        private void buttonDownloadNorm_Click(object sender, EventArgs e)
        {
            DownloadFile(2);
        }
    }
}
