using project.domain.interfaces.Struct;
using project.domain.model;
using project.infra.db.mock.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.questions
{
    public class QuestionsData<QuestionsRepository> : IQuestionsData
        where QuestionsRepository : IQuestionsRepository
    {
        QuestionsRepository questionRepository;
        public QuestionsData(QuestionsRepository questionRepository)
        {
            this.questionRepository = questionRepository;
        }

        public virtual List<QuestionModel> getQuestions()
        {
            return questionRepository.getQuestions();
        }

        public virtual QuestionModel getQuestion(string idQuestion)
        {
            return questionRepository.getQuestion(idQuestion);
        }
    }
}
