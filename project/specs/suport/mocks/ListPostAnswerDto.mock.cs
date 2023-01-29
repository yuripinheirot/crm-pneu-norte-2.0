using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specs.suport.mocks
{
    public class ListPostAnswerDtoMock
    {
        public static List<PostAnswerDTO> listPostAnswersDTO = new List<PostAnswerDTO>()
            {
                new PostAnswerDTO()
                {
                    answer = "yes",
                    idClient = "00013",
                    idQuestion = "1",
                    idCompany = "02",
                    idSale = "0000301",
                    observation = "Lorem ipsum dolor",
                    updatedAt = DateTime.Now,
                },
                new PostAnswerDTO()
                {
                    answer = "no",
                    idClient = "00013",
                    idQuestion = "2",
                    idCompany = "02",
                    idSale = "0000301",
                    observation = "Lorem ipsum dolor",
                    updatedAt = DateTime.Now,
                },
            };
    }
}
