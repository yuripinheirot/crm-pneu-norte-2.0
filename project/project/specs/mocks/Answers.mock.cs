using project.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.specs.mocks
{
    public class AnswersMock
    {
        public static List<AnswerModel> answers = new List<AnswerModel>()
        {
            new AnswerModel()
            {
                id = "5fc64741-6ebf-42c9-9ad0-b342f62ccaf0",
                answer = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                idClient = "00013",
                idQuestion = "1",
                idCompany = "02",
                idSale = "0000301",
                observation = "Lorem ipsum dolor",
                resolution = "consectetur adipiscing elit",
                status = "done",
                updatedAt = DateTime.Now,
                createdAt = DateTime.Now,
            },
            new AnswerModel()
            {
                id = "0828c41a-6d35-42d8-ab4a-1bac02c7ca26",
                answer = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                idClient = "00013",
                idQuestion = "2",
                idCompany = "02",
                idSale = "0000301",
                observation = "Lorem ipsum dolor",
                resolution = "consectetur adipiscing elit",
                status = "pending",
                updatedAt = DateTime.Now,
                createdAt = DateTime.Now,
            },
            new AnswerModel()
            {
                id = "0828c41a-6d35-42d8-ab4a-1bac02c7ca26",
                answer = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                idClient = "00013",
                idQuestion = "7",
                idCompany = "02",
                idSale = "0000301",
                observation = "Lorem ipsum dolor",
                resolution = "consectetur adipiscing elit",
                status = "done",
                updatedAt = DateTime.Now,
                createdAt = DateTime.Now,
            },
            new AnswerModel()
            {
                id = "86e04492-855c-4969-9185-bc23b488a845",
                answer = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                idClient = "00013",
                idQuestion = "7",
                idCompany = "02",
                idSale = "0000301",
                observation = "Lorem ipsum dolor",
                resolution = "consectetur adipiscing elit",
                status = "pending",
                updatedAt = DateTime.Now,
                createdAt = DateTime.Now,
            },
        };
    }
}
