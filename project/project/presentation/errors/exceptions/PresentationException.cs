using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.presentation.errors.exceptions
{
    public class PresentationException : Exception
    {
        public string title;
        public string description;
        public PresentationException(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
    }
}
