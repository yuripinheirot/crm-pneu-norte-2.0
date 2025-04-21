using project.data.usecases.answers;
using project.main.factories.business;
using project.presentation.errors;
using project.presentation.utils;
using System;
using System.Windows.Forms;

namespace project.presentation.forms.crmNotResolved
{
    public partial class CrmNotResolved : Form
    {
        GetAnswersNotResolved getAnswersNotResolved = new GetAnswersNotResolved();

        public CrmNotResolved()
        {
            InitializeComponent();
        }

        private void LoadCrmNotResolved()
        {
            try
            {
                var answersNotResolved = getAnswersNotResolved.execute();
                var dataSource = GridUtils.ToDataTable(answersNotResolved);

                dgvNotResolved.DataSource = dataSource;
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void CrmNotResolved_Load(object sender, EventArgs e)
        {
            LoadCrmNotResolved();
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
            LoadCrmNotResolved();
        }
    }
}
