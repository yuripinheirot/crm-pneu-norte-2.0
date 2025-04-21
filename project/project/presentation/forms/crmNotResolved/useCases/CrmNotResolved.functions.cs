using project.domain.model.entities;
using project.main.factories.business;
using project.presentation.protocols;
using project.presentation.utils;
using System.Windows.Forms;

namespace project.presentation.forms.crmNotResolved
{
    public class CrmNotResolvedFunctions
    {
        public void xloadAnswersNotResolvedOnDataGrid(DataGridView dgv)
        {
            var answersNotResolved = AnswersFactory.handle.getAnswersNotResolved();
            var dataSource = GridUtils.ToDataTable(answersNotResolved);

            dgv.DataSource = dataSource;
        }

        public AnswerDetails xgetAnswerDetailsDataView(string idAnswer)
        {
            return AnswersFactory.handle.getAnswerDetailsDataView(idAnswer);
        }

        public void xputAnswer(AnswerModel answer)
        {
            AnswersFactory.handle.putAnswer(answer);
        }
    }
}
