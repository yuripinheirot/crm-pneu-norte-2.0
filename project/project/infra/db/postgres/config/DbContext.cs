using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.postgres.config
{
    public partial class PgDbContext : DbContext
    {
        public PgDbContext() : base(nameOrConnectionString: "postgres")
        {

        }

        public PgDbContext(string connection) : base(new NpgsqlConnection(connection), true)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);

            setKeys_answers(modelBuilder);
            setKeys_questions(modelBuilder);
        }

    }
}
