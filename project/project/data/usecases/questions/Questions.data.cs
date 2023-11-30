using project.domain.interfaces.Struct;
using project.domain.model.entities;
using System.Collections.Generic;
using project.infra.db.postgres.repository;

namespace project.data.usecases.questions
{
    public class QuestionsData : IQuestionsData
    {
        QuestionsPostgresRepository questionRepository;
        public QuestionsData(QuestionsPostgresRepository questionRepository)
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
