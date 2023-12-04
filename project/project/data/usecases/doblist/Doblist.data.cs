using project.domain.interfaces.Struct;
using project.domain.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.infra.db.postgres.repository;
using project.presentation.protocols;

namespace project.data.usecases.doblist
{

    public class DobListData : IDobListData
    {
        DobListRepository dobListRepository;

        public DobListData(DobListRepository dobListRepository)
        {
            this.dobListRepository = dobListRepository;
        }

        public List<DobListModel> getDobs(string dobDayMonth, int year)
        {
            return dobListRepository.getDobs(dobDayMonth, year);
        }

        public void insertDob(DobListDTO dto)
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

            dobListRepository.insertDob(dobListItem);
        }
    }

}
