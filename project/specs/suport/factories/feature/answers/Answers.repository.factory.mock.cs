using Moq;
using project.business.usecases.answers;
using project.data.usecases.answers;
using project.data.usecases.questions;
using project.domain.interfaces.Struct;
using project.infra.db.postgres.config;
using project.infra.db.postgres.repository;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specs.suport.factories.feature.answers
{
    public class AnswersRepositoryFactoryMock
    {
        //static string connectionSpecsPostgres = ConfigurationManager.ConnectionStrings["specs"].ToString();

        //public static Mock<PgDbContext> postgresMock = new Mock<PgDbContext>(connectionSpecsPostgres);
        public static PgDbContext postgresMock = new PgDbContext("server=localhost; port=5432; database=specs; user id=postgres; password=postgres;");
        //public static AnswersPostgresRepository answerRepository = new AnswersPostgresRepository(postgresMock.Object);
        public static AnswersPostgresRepository answerRepository = new AnswersPostgresRepository(postgresMock);
    }
}
