﻿using project.domain.interfaces.usecases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.interfaces.Struct
{
    public interface IAnswersBusiness : IPostAnswers, IGetAnswers, IGetAnswersNotResolved, IGetAnswerDetails, IPutAnswer, IPostAnswerAlreadyExists
    {
    }
}