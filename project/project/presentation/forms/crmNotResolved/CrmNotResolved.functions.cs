using project.domain.model;
using project.main.factories.business;
using project.presentation.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.presentation.forms.crmNotResolved
{
    public class CrmNotResolvedFunctions
    {
        public void loadAnswersNotResolvedOnDataGrid(DataGridView dgv)
        {
            var answersNotResolved = AnswersFactory.handle.getAnswersNotResolved();
            var dataSource = GridUtils.ToDataTable(answersNotResolved);

            dgv.DataSource = dataSource;
        }

        public AnswerModel getAnswersById(string id)
        {
            return AnswersFactory.handle.
        }
    }
}
