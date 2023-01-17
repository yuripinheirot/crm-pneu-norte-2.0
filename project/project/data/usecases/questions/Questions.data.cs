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
    public class QuestionsData : IGetQuestions, IGetQuestion
    {
        QuestionsMockRepository questionRepository;
        public QuestionsData(QuestionsMockRepository questionRepository)
        {
            this.questionRepository = questionRepository;
        }

        public List<QuestionModel> getQuestions()
        {
            return questionRepository.getQuestions();
        }

        public virtual QuestionModel getQuestion(string idQuestion)
        {
            return questionRepository.getQuestion(idQuestion);
        }
    }
}
