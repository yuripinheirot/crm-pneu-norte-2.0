using project.presentation.errors;
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
    public partial class ObservationAnswer : Form
    {
        Dictionary<string, string> observationsAnswers;
        string idQuestion;
        public ObservationAnswer(Dictionary<string, string> observationsAnswers, string idQuestion)
        {
            InitializeComponent();
            this.observationsAnswers = observationsAnswers;
            this.idQuestion = idQuestion;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                observationsAnswers[idQuestion] = tbxObservation.Text;
                Close();
            }
            catch (Exception error)
            {
                ThrowCustomException.Throw(error);
            }
        }

        private void ObservationAnswer_Load(object sender, EventArgs e)
        {
            if (observationsAnswers.ContainsKey(idQuestion))
            {
                tbxObservation.Text = observationsAnswers[idQuestion];
            }
        }
    }
}
