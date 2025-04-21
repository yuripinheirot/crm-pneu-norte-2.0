using project.domain.model.entities;
using project.infra.db.postgres.config;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.doblist
{
    internal class CreateDob
    {
        PgDbContext pg = new PgDbContext(Properties.Settings.Default.postgresConnectionString);

        private void insertDob(DobListModel doblistModel)
        {
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

        public void execute(DobListDTO dto)
        {
            var dobListItem = new DobListModel()
            {
                id = Guid.NewGuid().ToString(),
                year = DateTime.Now.Year,
                done = dto.done,
                dob = dto.dob.Trim(),
                idClient = dto.idClient,
                observations = dto.observations,
                createdAt = DateTime.Now,
                updatedAt = DateTime.Now
            };

            insertDob(dobListItem);
        }
    }
}
