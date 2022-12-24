using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.presentation.utils
{
    public class DefaultButtonOpenForms
    {
        public static bool handle(KeyEventArgs e)
        {
            return e.KeyCode == Keys.F2;
        }
    }
}
