using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.data.usecases.answers;
using project.data.usecases.questions;
using project.domain.interfaces;
using project.domain.interfaces.Struct;
using project.domain.model;
using project.presentation.protocols;

  
namespace project.business.usecases.answers
{
    public class AnswersBusiness<AnswersData, QuestionsData> : IAnswersBusiness
        where AnswersData : IAnswersData
        where QuestionsData : IQuestionsData
    {
        AnswersData answersData;
        QuestionsData questionData;

        public AnswersBusiness(AnswersData answersData, QuestionsData questionData)
        {
            this.answersData = answersData;
            this.questionData = questionData;
        }

        public void addAnswersDTO(List<PostAnswerDTO> answers)
        {
            answers.ForEach(answer =>
            {
                var currentQuestion = questionData.getQuestion(answer.idQuestion);
                var status = currentQuestion.badAnswers.Contains(answer.answer) ? "pending" : "done";

                answer.status = status;
            });

            answersData.addAnswersDTO(answers);
        }

        public bool postAnswerAlreadyExists(string idCompany, string idSale)
        {
            return answersData.postAnswerAlreadyExists(idCompany, idSale);
        }

        public AnswerDetails getAnswerDetailsDataView(string idAnswer)
        {
            return answersData.getAnswerDetailsDataView(idAnswer);
        }

        public List<AnswerModel> getAnswers(AnswersFilters filters)
        {
            return answersData.getAnswers(filters);
        }

        public List<AnswerNotResolvedDataView> getAnswersNotResolved()
        {
            return answersData.getAnswersNotResolved();
        }

        public void putAnswer(AnswerModel answer)
        {
            answersData.putAnswer(answer);
        }
    }
}
