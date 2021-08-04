using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_Load_Methods;
using Folder_Browser_dialog_Static_Methods;
using Validations;


namespace ResizeImageFromFolder
{
    public partial class Form1 : Form
    {
        List<string> ListImages = new List<string>();
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        DirectoryInfo dir;
        FileInfo[] file;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Folder_Browser_Dialog_Static_Methods.PutSelectedPathFromFolderBrowserDialogIntoTxtBoxCtl(fbd, txtSF);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Folder_Browser_Dialog_Static_Methods.PutSelectedPathFromFolderBrowserDialogIntoTxtBoxCtl(fbd, txtTF);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Start BackgroundWorker
            backgroundWorker1.RunWorkerAsync();


        }
        public Image Resize(Image image, double w, double h)
        {
            Bitmap bmp = new Bitmap((int)w, (int)h);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(image, 0, 0, (int)w, (int)h);
            graphic.Dispose();

            return bmp;
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            var args = e.Argument;

            e.Result = BackgroundProcessLogicMethod(bw, args);
        }

        private int BackgroundProcessLogicMethod(BackgroundWorker bw, object a)
        {
            int counter = 0;
            if (txtTF.Text == string.Empty || txtSF.Text == string.Empty || txtW.Text == string.Empty)
            {
                MessageBox.Show("Συμπληρώστε ολα τα πεδία");
            }
            else
            {
                string path = txtTF.Text + @"\" + "txtimg.txt";
                dir = new DirectoryInfo(txtSF.Text);
                file = dir.GetFiles();
                FilterDirForImges(file);
                foreach (var item in ListImages)
                {
                    string dest_path = Path.Combine(txtTF.Text, Path.GetFileName(item));
                    //File.Copy(item.FullName,dest_path, true);
                    Image img = Image.FromFile(item);
                    double w = Convert.ToDouble(txtW.Text);
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

        private delegate void UpdateProgressBarDel(int prc);
        private void UpdateProgressBar(int prc)
        {
            progressBarControl1.EditValue = prc;
        }

      
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (progressBarControl1.InvokeRequired)
            {
                UpdateProgressBarDel del = new UpdateProgressBarDel(UpdateProgressBar);
                progressBarControl1.Invoke(del, new object[] { e.ProgressPercentage });
            }
            else
                UpdateProgressBar(e.ProgressPercentage);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //worker completed
            if (e.Error != null) MessageBox.Show(e.Error.Message);
            else MessageBox.Show(e.Result.ToString() + " Images Resized and Saved");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSF.Select();
        }


    }
}
