using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace ResizeImageFromFolder
{
    public partial class frmResize : DevExpress.XtraEditors.XtraForm
    {
        public frmResize()
        {
            InitializeComponent();
        }

        List<string> ListImages = new List<string>();
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        DirectoryInfo dir;
        FileInfo[] file;
        Image img;

        private void btnResize_Click(object sender, EventArgs e)
        {
            // Start BackgroundWorker
            prgPercentage.Visible = true;

            bgWorker.RunWorkerAsync();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            var args = e.Argument;

            e.Result = BackgroundProcessLogicMethod(bw, args);
        }

        private int BackgroundProcessLogicMethod(BackgroundWorker bw, object a)
        {
            int counter = 0;
            if (btneFrom.Text == string.Empty || btneTo.Text == string.Empty || txtWidth.Text == string.Empty)
            {
                MessageBox.Show("Συμπληρώστε ολα τα πεδία");

            }
            else
            {
                dir = new DirectoryInfo(btneFrom.Text);
                file = dir.GetFiles();
                FilterDirForImges(file);
                foreach (var item in ListImages)
                {
                    string dest_path = Path.Combine(btneTo.Text, Path.GetFileName(item));
                    //File.Copy(item.FullName,dest_path, true);
                    img = Image.FromFile(item);
                    double w = Convert.ToDouble(txtWidth.Text);
                    double h = img.Height * (w / img.Width);
                    var newImg = Resize(img, w, h);
                    newImg.Save(dest_path);
                    counter++;
                    int prc = Convert.ToInt16((double)(counter) / (double)(ListImages.Count) * 100);
                    bw.ReportProgress(prc);

                }

            }
            return counter;
        }

        public void FilterDirForImges(FileInfo[] file)
        {
            foreach (FileInfo item in file)
            {
                if (item.Extension.ToLower() == ".jpg" || item.Extension.ToLower() == ".jpeg" || item.Extension.ToLower() == ".gif" || item.Extension.ToLower() == ".png")
                {
                    ListImages.Add(item.FullName);
                }
            }
        }

        public Image Resize(Image image, double w, double h)
        {
            Bitmap bmp = new Bitmap((int)w, (int)h);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(image, 0, 0, (int)w, (int)h);
            graphic.Dispose();

            return bmp;
        }

        private delegate void UpdateProgressBarDel(int prc);
        private void UpdateProgressBar(int prc)
        {
            prgPercentage.EditValue = prc;
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (prgPercentage.InvokeRequired)
            {
                UpdateProgressBarDel del = new UpdateProgressBarDel(UpdateProgressBar);
                prgPercentage.Invoke(del, new object[] { e.ProgressPercentage });
            }
            else
                UpdateProgressBar(e.ProgressPercentage);
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            while (btneFrom.Text != string.Empty && btneTo.Text != string.Empty && txtWidth.Text != string.Empty)
            {
                //worker completed
                if (e.Error != null) MessageBox.Show(e.Error.Message);
                else
                {

                    this.txtHeight.Text = Convert.ToString(img.Height * (Convert.ToInt32(txtWidth.Text) / img.Width));
                    MessageBox.Show(e.Result.ToString() + " Images Resized and Saved");
                }

                break;
            }

        }

        private void btnResize_MouseOver(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        
    }
}