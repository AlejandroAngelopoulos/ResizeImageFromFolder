using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResizeImageFromFolder;

namespace Form_Load_Methods
{
    public class FormLoadStaticMethods 
    {
        public static void AddImgExtenIntoComboBox(string[] exten, ComboBox comboBox)
        {
            for (int i = 0; i < exten.Length; i++)
                comboBox.Items.Add(exten[i]);
        }
    }
}
