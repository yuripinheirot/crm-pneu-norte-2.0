using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.postgres.config
{
    public partial class PgDbContext : DbContext
    {
        public PgDbContext() : base(new FbConnection(Properties.Settings.Default.firebirdConnectionString), true)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

    }
}
