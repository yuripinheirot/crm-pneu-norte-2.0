using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace project.infra.db.firebird.config
{
    partial class FbDbContext
    {
        [Table("TRECPFISICA")]
        public class TRECPFISICA
        {
            [Key]
            public string CODIGO { get; set; }
            public DateTime? DATANASC { get; set; }
        }

        public DbSet<TRECPFISICA> trecpfisica { get; set; }

        private void setKeys_TRECPFISICA(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TRECPFISICA>().ToTable("TRECPFISICA")
                    .HasKey(x => x.CODIGO);
        }
    }
}
