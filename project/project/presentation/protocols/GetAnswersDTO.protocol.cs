﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.presentation.protocols
{
    internal class GetAnswersDTO
    {
        public DateTime initialDate { get; set; }
        public DateTime finalDate { get; set; }
        public string idQuestion { get; set; }
    }
}