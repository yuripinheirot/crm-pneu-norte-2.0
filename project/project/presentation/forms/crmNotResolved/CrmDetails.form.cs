using project.domain.model.entities;
using project.main.factories.business;
using project.presentation.errors;
using project.presentation.errors.exceptions;
using project.data.usecases.answers;
using project.presentation.protocols;
using project.presentation.utils;
using System;
using System.Windows.Forms;

namespace project.presentation.forms.crmNotResolved
{
    public partial class CrmDetails : Form
    {
        CreateAnswer createAnswer = new CreateAnswer();
        GetAnswerDetailsDataView getAnswerDetailsDataView = new GetAnswerDetailsDataView();
        readonly AnswerDetails currentAnswer;

        bool admin = Properties.Settings.Default.ADMIN;
        string idAnswer;

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
            currentAnswer = getAnswerDetailsDataView.execute(idAnswer);
            this.idAnswer = idAnswer;
        }

        private void CrmDetails_Load(object sender, EventArgs e)
        {
            try
            {
                loadFields();
                if (!admin)
                {
                    cbxStatus.Enabled = false;
                }
            }
            catch (Exception error)
            {
                ThrowCustomException.Throw(error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerModel answer = new AnswerModel()
                {
                    id = idAnswer,
                    status = cbxStatus.Text,
                    resolution = tbxResolution.Text
                };

                createAnswer.execute(answer);
                Close();
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }
    }
}
