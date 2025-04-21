using project.domain.model.entities;
using project.infra.db.postgres.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.doblist
{
    internal class GetDobList
    {
        PgDbContext pg = new PgDbContext(Properties.Settings.Default.postgresConnectionString);

        public List<DobListModel> execute(string dob, int year)
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
    }
}
