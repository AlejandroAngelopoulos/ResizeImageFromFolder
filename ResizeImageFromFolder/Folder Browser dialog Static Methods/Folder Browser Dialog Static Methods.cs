using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResizeImageFromFolder;

namespace Folder_Browser_dialog_Static_Methods
{
    class Folder_Browser_Dialog_Static_Methods
    {
        public static void PutSelectedPathFromFolderBrowserDialogIntoTxtBoxCtl(FolderBrowserDialog fbd, TextBox txtB)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtB.Text = fbd.SelectedPath;
            }
        }
    }
}
