using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace project.infra.db.firebird.config
{
    partial class FbDbContext
    {
        [Table("TRECCLIENTEGERAL")]
        public class TRECCLIENTEGERAL
        {
            [Key]
            public string CODIGO { get; set; }
            public string NOME { get; set; }
            public string CPFCNPJ { get; set; }
        }

        public DbSet<TRECCLIENTEGERAL> trecclientegeral { get; set; }

        private void setKeys_TRECCLIENTEGERAL(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TRECCLIENTEGERAL>().ToTable("TRECCLIENTEGERAL")
                    .HasKey(x => x.CODIGO);
        }
    }
}
