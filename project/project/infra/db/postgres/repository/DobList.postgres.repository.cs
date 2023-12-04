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

        public List<DobListModel> getDobs(string dob, int year)
        {
            return 
                pg.doblist
                .Where((doblist) => doblist.year == year && doblist.dob == dob)
                .Select(n => new DobListModel()
                {
                    createdAt = n.createdAt,
                    dob = n.dob,
                    year = n.year,  
                    done = n.done,
                    id = n.id,
                    idClient = n.idClient,
                    observations = n.observations,
                    updatedAt = n.updatedAt 
                })
                .ToList();
        }

        public void insertDob(DobListModel doblistModel)
        {
            pg.doblist.Add(new PgDbContext.DobList()
            {
                id = doblistModel.id,
                updatedAt = DateTime.Now,
                observations = doblistModel.observations,
                idClient = doblistModel.idClient,
                dob = doblistModel.dob,
                done = doblistModel.done,
                createdAt = doblistModel.createdAt,
                year = doblistModel.year,
            });

            pg.SaveChanges();
        }
    }
}
