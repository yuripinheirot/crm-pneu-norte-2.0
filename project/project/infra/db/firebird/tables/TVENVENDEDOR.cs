using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace project.infra.db.firebird.config
{
    partial class FbDbContext
    {
        [Table("TVENVENDEDOR")]
        public class TVENVENDEDOR
        {
            [Key]
            public string EMPRESA { get; set; }
            [Key]
            public string CODIGO { get; set; }
            public string NOME { get; set; }

        }

        public DbSet<TVENVENDEDOR> tvenvendedor { get; set; }

        internal void setKeys_TVENVENDEDOR(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TVENVENDEDOR>().ToTable("TVENVENDEDOR")
                .HasKey(x => new { x.EMPRESA, x.CODIGO });
        }
    }
}
