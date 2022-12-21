using project.presentation.errors;
using project.presentation.errors.exceptions;
using project.presentation.protocols;
using project.presentation.utils;
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
    public partial class CrmDetails : Form
    {
        CrmNotResolvedFunctions functions = new CrmNotResolvedFunctions();
        AnswerDetails currentAnswer;

        void loadFields()
        {
            if (currentAnswer == null)
            {
                Close();
                throw new PresentationException("Erro!", "Falha ao carregar CRM");
            }

            tbxIdSale.Text = currentAnswer.idSale;
            tbxIdCompany.Text = currentAnswer.idCompany;
            tbxClient.Text = currentAnswer.client;
            tbxSeller.Text = currentAnswer.seller;
            tbxAnswer.Text = currentAnswer.answer;
            cbxStatus.Text = TextUtils.translateStatusAnswerPresentation(currentAnswer.status);
            tbxQuestion.Text = currentAnswer.descriptionQuestion;
            tbxObservation.Text = currentAnswer.observation;
            tbxResolution.Text = currentAnswer.resolution;
        }

        public CrmDetails(string idAnswer)
        {
            InitializeComponent();
            currentAnswer = functions.getAnswerDetailsDataView(idAnswer);
        }

        private void CrmDetails_Load(object sender, EventArgs e)
        {
            try
            {
                loadFields();
            }
            catch (Exception error)
            {
                ThrowCustomException.Throw(error);
            }
        }
    }
}
