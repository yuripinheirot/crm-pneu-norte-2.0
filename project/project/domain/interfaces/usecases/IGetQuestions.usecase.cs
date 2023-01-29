using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.domain.model;

namespace project.domain.interfaces.usecases
{    
    public interface IGetQuestion
    {
        QuestionModel getQuestion(string idQuestion);
    }
}
