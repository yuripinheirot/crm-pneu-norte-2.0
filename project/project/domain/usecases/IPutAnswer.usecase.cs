using project.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.usecases
{
    public interface IPutAnswer
    {
        void putAnswer(AnswerModel answer);
    }
}
