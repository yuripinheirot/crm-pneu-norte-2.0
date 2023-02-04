using Moq;
using project.business.usecases.answers;
using project.data.usecases.answers;
using project.data.usecases.questions;
using project.domain.interfaces.Struct;
using project.infra.db.postgres.config;
using project.infra.db.postgres.repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specs.suport.factories.unit.answers
{
    public class AnswersDataFactoryMock
    {
        static string connectionSpecsPostgres = ConfigurationManager.ConnectionStrings["specs"].ToString();
        public static PgDbContext postgresMock = new PgDbContext(connectionSpecsPostgres);

        public static Mock<AnswersPostgresRepository> answerRepositoryMock = new Mock<AnswersPostgresRepository>(postgresMock);
        public static AnswersData<IAnswersRepository> answersData = new AnswersData<IAnswersRepository>(answerRepositoryMock.Object);
    }
}
