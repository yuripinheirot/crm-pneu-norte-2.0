using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.model
{
    internal class Question
    {
        public int id { get; set; }
        public string description { get; set; }
        public string module { get; set; }
        public bool active { get; set; } = true;
    }
}
