using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResizeImageFromFolder;

namespace Validations
{
    class ValidateCtrl
    {
        public static void ForTxtBox(TextBox txtBox)
        {
            if (txtBox.Text == String.Empty)
            {
                MessageBox.Show("Συμπληρώστε ολα τα πεδία");
            }
        }
        public static void ForTComboBox(ComboBox cb)
        {
            if (cb.Text == String.Empty)
            {
                MessageBox.Show("Συμπληρώστε ολα τα πεδία");
            }
        }
    }
}
