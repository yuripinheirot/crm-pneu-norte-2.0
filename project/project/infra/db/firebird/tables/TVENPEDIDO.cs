using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace project.infra.db.firebird.config
{
    partial class FbDbContext
    {
        [Table("TVENPEDIDO")]
        public class TVENPEDIDO
        {
            [Key]
            public string EMPRESA { get; set; }
            [Key]
            public string CODIGO { get; set; }
            public string CLIENTE { get; set; }
            public string VENDEDOR { get; set; }
            public string TIPOPEDIDO { get; set; }
            public decimal VALORLIQUIDO { get; set; }
            public DateTime? DATAEFE { get; set; }

        }

        public DbSet<TVENPEDIDO> tvenpedido { get; set; }

        internal void setKeys_TVENPEDIDO(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TVENPEDIDO>().ToTable("TVENPEDIDO")
                .HasKey(x => new { x.EMPRESA, x.CODIGO });
        }
    }
}
