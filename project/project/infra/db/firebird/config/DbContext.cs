using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.firebird.config
{
    public partial class FbDbContext : DbContext
    {
        public FbDbContext() : base(new FbConnection(Properties.Settings.Default.firebirdConnectionString), true)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            setKeys_TVENPEDIDO(modelBuilder);
            setKeys_TRECCLIENTEGERAL(modelBuilder);
            setKeys_TVENVENDEDOR(modelBuilder);
            setKeys_TRECPFISICA(modelBuilder);
        }

    }
}