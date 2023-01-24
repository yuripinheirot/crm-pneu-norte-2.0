using project.domain.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.postgres.config
{
    public partial class PgDbContext
    {
        [Table("answers", Schema = "public")]
        public class Answers : IAnswerModel
        {
            [Key, Column(Order = 0)]
            public string id { get; set; }
            [Column(name: "id_question")]
            public string idQuestion { get; set; }
            [MaxLength(7)]
            [Column(name: "id_sale")]
            public string idSale { get; set; }
            [MaxLength(5)]
            [Column(name: "id_client")]
            public string idClient { get; set; }
            public string status { get; set; }
            [MaxLength(255)]
            public string answer { get; set; }
            [MaxLength(255)]
            public string observation { get; set; }
            [MaxLength(255)]
            public string resolution { get; set; }
            [Column(name: "created_at")]
            public DateTime createdAt { get; set; }
            [Column(name: "updated_at")]
            public DateTime updatedAt { get; set; }
            [MaxLength(2)]
            [Column(name: "id_company")]
            public string idCompany { get; set; }

            //[ForeignKey("idQuestion")]
            //public Answers perguntas { get; set; }

        }

        public DbSet<Answers> answers { get; set; }

        internal void setKeys_answers(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answers>().ToTable("answers")
                .HasKey(x => x.id);
        }
    }
}
