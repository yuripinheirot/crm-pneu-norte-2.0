using Npgsql;
using project.domain.interfaces.Struct;
using project.domain.model.entities;
using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace project.infra.db.postgres.repository
{
    public class DobListRepository : IDobListRepository
    {
        readonly PgDbContext pg;
        public DobListRepository(PgDbContext postgres)
        {
            pg = postgres;
        }

        public void insertDob(DobListModel doblistModel)
        {
            Console.WriteLine(doblistModel);

            pg.doblist.Add(new PgDbContext.DobList()
            {
                id = doblistModel.id,
                updatedAt = DateTime.Now,
                observations = doblistModel.observations,
                idClient = doblistModel.idClient,
                done = doblistModel.done,
                createdAt = doblistModel.createdAt,
                dob = doblistModel.dob,
            });

            pg.SaveChanges();
        }
    }
}
