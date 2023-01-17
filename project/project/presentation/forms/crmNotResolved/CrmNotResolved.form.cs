using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.presentation.forms.crmNotResolved
{
    public partial class CrmNotResolved : Form
    {
        CrmNotResolvedFunctions functions = new CrmNotResolvedFunctions();
        public CrmNotResolved()
        {
            InitializeComponent();
        }

        private void CrmNotResolved_Load(object sender, EventArgs e)
        {
            functions.loadAnswersNotResolvedOnDataGrid(dgvNotResolved);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNotResolved.RowCount == 0) return;

            var idAnswer = dgvNotResolved.CurrentRow.Cells["idAnswer"].Value.ToString();

            new CrmDetails(idAnswer).ShowDialog();
        }

        private void CrmNotResolved_Activated(object sender, EventArgs e)
        {
            functions.loadAnswersNotResolvedOnDataGrid(dgvNotResolved);
        }
    }
}
