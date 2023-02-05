using Moq;
using project.business.usecases.answers;
using project.business.usecases.questions;
using project.data.usecases.answers;
using project.data.usecases.questions;
using project.domain.interfaces.Struct;
using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.infra.db.postgres.repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specs.suport.factories.unit
{
    public class QuestionsDataFactoryMock
    {
        static readonly string connectionSpecsPostgres = ConfigurationManager.ConnectionStrings["specs"].ToString();
        public static PgDbContext postgresMock = new PgDbContext(connectionSpecsPostgres);
        public static FbDbContext firebirdMock = new FbDbContext();

        public static Mock<QuestionsPostgresRepository> questionRepositoryMock = new Mock<QuestionsPostgresRepository>(postgresMock);
        public static QuestionsData<IQuestionsRepository> questionsData = new QuestionsData<IQuestionsRepository>(questionRepositoryMock.Object);
    }
}
