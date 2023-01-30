using Moq;
using project.business.usecases.answers;
using project.data.usecases.answers;
using project.data.usecases.questions;
using project.domain.interfaces.Struct;
using project.infra.db.postgres.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specs.suport.factories
{
    public class AnswersDataFactoryMock
    {
        public static Mock<AnswersPostgresRepository> answerRepositoryMock = new Mock<AnswersPostgresRepository>();
        public static AnswersData<IAnswersRepository> answersData = new AnswersData<IAnswersRepository>(answerRepositoryMock.Object);
    }
}
