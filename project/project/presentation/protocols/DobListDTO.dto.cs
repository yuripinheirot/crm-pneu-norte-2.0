using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.presentation.protocols
{
    public class DobListDTO
    {
        public string idClient { get; set; }
        public string observations { get; set; }
        public bool done { get; set; }
        public DateTime dob { get; set; }
    }
}
