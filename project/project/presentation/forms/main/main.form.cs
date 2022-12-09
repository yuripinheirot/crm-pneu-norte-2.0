using project.domain.model;
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
        MainFunctions functions = new MainFunctions();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string module = tbxModule.Text == "SERVIÇOS" ? "order" : "sale";
            functions.renderQuestions(flpQuestions, module);
        }
    }
}
