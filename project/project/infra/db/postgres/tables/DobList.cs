using project.domain.interfaces.entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace project.infra.db.postgres.config
{
    public partial class PgDbContext
    {
        [Table("crm.doblist")]
        public class DobList : IDobListEntity
        {
            [Key, Column(Order = 0)]
            public string id { get; set; }

            [Column(name: "id_client")]
            public string idClient { get; set; }

            [MaxLength(255)]
            public string observations { get; set; }
            [MaxLength(5)]
            public string dob { get; set; }

            public bool done { get; set; }

            public int year { get; set; }

            [Column(name: "updated_at")]
            public DateTime updatedAt { get; set; }

            [Column(name: "created_at")]
            public DateTime createdAt { get; set; }
        }

        public DbSet<DobList> doblist { get; set; }

        internal void setKeys_doblist(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DobList>().ToTable("doblist")
                .HasKey(x => x.id);
        }
    }
}
