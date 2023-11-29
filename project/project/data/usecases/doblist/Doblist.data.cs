using project.domain.interfaces.Struct;
using project.domain.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.doblist
{

    public class DobList<QuestionsRepository> : IQuestionsData
where QuestionsRepository : IQuestionsRepository
    {
        QuestionsRepository questionRepository;
        public DobList(QuestionsRepository questionRepository)
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
