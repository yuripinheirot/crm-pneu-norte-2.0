using project.presentation.errors;
using System;
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
            try
            {
                functions.loadAnswersNotResolvedOnDataGrid(dgvNotResolved);
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNotResolved.RowCount == 0) return;

                var idAnswer = dgvNotResolved.CurrentRow.Cells["idAnswer"].Value.ToString();

                new CrmDetails(idAnswer).ShowDialog();
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void CrmNotResolved_Activated(object sender, EventArgs e)
        {
            try
            {
                functions.loadAnswersNotResolvedOnDataGrid(dgvNotResolved);
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }
    }
}
