using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace project.infra.db.postgres.config
{
    public partial class PgDbContext
    {
        [Table("crm.questions")]
        public class Questions
        {
            [Key]
            public string id { get; set; }

            [MaxLength(255), Required]
            public string description { get; set; }

            [MaxLength(255), Required]
            [Column("pos_sale")]
            public string posSale { get; set; }

            [Required]
            public bool active { get; set; } = true;

            [Column("answers")]
            public string answersArray { get; set; }
            [Column("bad_answers")]
            public string badAnswersArray { get; set; }
            public List<string> answers => answersArray.Replace("{", "").Replace("}", "").Split(',').ToList();
            public List<string> badAnswers => badAnswersArray.Replace("{", "").Replace("}", "").Split(',').ToList();
        }

        public DbSet<Questions> questions { get; set; }

        internal void setKeys_questions(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Questions>().ToTable("questions")
                .HasKey(x => x.id);
        }
    }
}
