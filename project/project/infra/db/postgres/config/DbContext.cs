﻿using FirebirdSql.Data.FirebirdClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);

            setKeys_answers(modelBuilder);
            setKeys_questions(modelBuilder);

            //modelBuilder.Entity<Questions>()
            //    .Property(e => e.answers)
            //    .HasColumnName("answers")
            //    .HasConversion(new ArrayConverter());
            //modelBuilder.Entity<Questions>()
            //    .Property(e => e.badAnswers)
            //    .HasColumnName("badanswers")
            //    .HasConversion(new ArrayConverter());
        }

    }
}