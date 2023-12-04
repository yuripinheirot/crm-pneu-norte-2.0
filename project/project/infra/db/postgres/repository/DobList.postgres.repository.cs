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
            // TODO: move this for DATA layer
            var existingItem = pg.doblist.FirstOrDefault(d =>
            d.dob == doblistModel.dob &&
            d.year == doblistModel.year &&
            d.idClient == doblistModel.idClient
            );

            if (existingItem != null)
            {
                existingItem.updatedAt = DateTime.Now;
                existingItem.observations = doblistModel.observations;
                existingItem.done = doblistModel.done;
                existingItem.year = doblistModel.year;
            }
            else
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
            }

            pg.SaveChanges();
        }
    }
}
