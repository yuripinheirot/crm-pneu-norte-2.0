using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.postgres.config
{
    public partial class PgDbContext
    {
        [Table("answers", Schema = "crm")]
        public class Answers
        {
            [Key, Column(Order = 0)]
            public int id { get; set; }
            public int idQuestion { get; set; }
            [MaxLength(7)]
            public string idSale { get; set; }
            [MaxLength(5)]
            public string idClient { get; set; }
            public string status { get; set; }
            [MaxLength(255)]
            public string answer { get; set; }
            [MaxLength(255)]
            public string observation { get; set; }
            [MaxLength(255)]
            public string resolution { get; set; }
            public DateTime createddAt { get; set; }
            public DateTime updatedAt { get; set; }
            [MaxLength(2)]
            public string idCompany { get; set; }

            [ForeignKey("idQuestion")]
            public Answers perguntas { get; set; }

        }
    }
}
