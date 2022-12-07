using project.domain.model;
using project.domain.usecases;
using project.infra.db.mock.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.questions
{
    internal class QuestionsData : IGetQuestions
    {
        QuestionsDbMockRepository questionRepository;
        public QuestionsData(QuestionsDbMockRepository questionRepository)
        {
            this.questionRepository = questionRepository;
        }

        public List<Question> getQuestions()
        {
            return questionRepository.getQuestions();
        }
    }
}
