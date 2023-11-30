using Npgsql;
using System.Data.Entity;

namespace project.infra.db.postgres.config
{
    public partial class PgDbContext : DbContext
    {
        public PgDbContext(string connection) : base(new NpgsqlConnection(connection), true)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("crm");
            base.OnModelCreating(modelBuilder);

            setKeys_answers(modelBuilder);
            setKeys_questions(modelBuilder);
            setKeys_doblist(modelBuilder);
        }

    }
}
