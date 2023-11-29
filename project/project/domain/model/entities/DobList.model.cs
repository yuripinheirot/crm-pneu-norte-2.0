using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.model.entities
{
    internal class DobListModel
    {
        public string id { get; set; }
        public string idClient { get; set; }
        public string observations { get; set; }
        public bool done { get; set; }
        public DateTime dob { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime createdAt { get; set; }
    }
}
