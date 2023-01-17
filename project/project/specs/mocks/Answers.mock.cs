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
                id = "1",
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
                id = "2",
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
                id = "3",
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
                id = "4",
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
