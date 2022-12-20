using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.data.usecases.answers;
using project.data.usecases.questions;
using project.domain.model;
using project.domain.usecases;
using project.presentation.errors.exceptions;
using project.presentation.protocols;
using project.validations.crm;

namespace project.business.usecases.answers
{
    internal class AnswersBusiness : IPostAnswers, IGetAnswers, IGetAnswersNotResolved
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

        public List<AnswerModel> getAnswers(AnswersFilters filters)
        {
            return answersData.getAnswers(filters);
        }

        public List<AnswerNotResolvedDataView> getAnswersNotResolved()
        {
            return answersData.getAnswersNotResolved();
        }
    }
}
