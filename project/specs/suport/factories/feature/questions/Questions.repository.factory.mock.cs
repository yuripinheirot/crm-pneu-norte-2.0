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

namespace specs.suport.factories.feature.questions
{
    public class QuestionsRepositoryFactoryMock
    {
        static string connectionSpecsPostgres = ConfigurationManager.ConnectionStrings["specs"].ToString();
        public static PgDbContext postgresMock = new PgDbContext(connectionSpecsPostgres);
        
        public static QuestionsPostgresRepository questionRepository = new QuestionsPostgresRepository(postgresMock);
    }
}
