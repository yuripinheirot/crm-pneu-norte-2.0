using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.presentation.forms.main
{
    public partial class MainForm : Form
    {
        MainFunctions methods = new MainFunctions();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            methods.getAnswersFromForm();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
