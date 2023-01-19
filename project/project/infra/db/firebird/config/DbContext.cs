using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.firebird.repository
{
    public class MyDbContext : DbContext
    {
        public class TVENPEDIDO
        {
            [Key]
            public string EMPRESA { get; set; }
            public string CODIGO { get; set; }
            public string CLIENTENOME { get; set; }
        }
        static FbConnection connection = new FbConnection(@"User=SYSDBA;Password=masterkey;Database=C:\Users\yurii\Downloads\ECODADOS.ECO;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;");
        public MyDbContext() : base(connection, true)
        {
            Console.WriteLine(connection.State);
        }

        public DbSet<TVENPEDIDO> tvenpedido { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TVENPEDIDO>().ToTable("TVENPEDIDO")
                .HasKey(x => new { x.EMPRESA, x.CODIGO });
        }

    }
}