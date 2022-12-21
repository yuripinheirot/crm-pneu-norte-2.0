using project.domain.model;
using project.domain.usecases;
using project.infra.db.mock.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.questions
{
    internal class QuestionsData : IGetQuestions
    {
        QuestionsRepository questionRepository;
        public QuestionsData(QuestionsRepository questionRepository)
        {
            this.questionRepository = questionRepository;
        }

        public List<QuestionModel> getQuestions()
        {
            return questionRepository.getQuestions();
        }

        public QuestionModel getQuestion(string idQuestion)
        {
            return questionRepository.getQuestion(idQuestion);
        }
    }
}
