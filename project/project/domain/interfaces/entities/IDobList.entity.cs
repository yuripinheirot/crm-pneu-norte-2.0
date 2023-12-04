using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.interfaces.entities
{
    public interface IDobListEntity
    {
        string id { get; set; }
        string idClient { get; set; }
        string observations { get; set; }
        bool done { get; set; }
        string dob { get; set; }
        int year { get; set; }
        DateTime updatedAt { get; set; }
        DateTime createdAt { get; set; }
    }
}
