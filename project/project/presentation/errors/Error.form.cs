using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.presentation.errors
{
    public partial class ErrorForm : Form
    {
        string title;
        string details;
        public ErrorForm(string title, string details)
        {
            InitializeComponent();
            this.title = title;
            this.details = details;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Error_Load(object sender, EventArgs e)
        {
            tbxTitle.Text = title;
            tbxDetails.Text = details;
            tbxTitle.Select(0,0);
            tbxDetails.Select(0,0);
            tbxDetails.Focus();
        }
    }
}
