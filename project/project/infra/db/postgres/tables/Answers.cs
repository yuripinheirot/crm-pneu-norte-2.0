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
        [Table("questions", Schema = "crm")]
        public class Questions
        {
            [Key]
            public string id { get; set; }
            [MaxLength(255), Required]
            public string description { get; set; }
            [MaxLength(255), Required]
            public string posSale { get; set; }
            [Required]
            public bool active { get; set; } = true;

            public ICollection<Answers> answers { get; set; }
        }
    }
}
