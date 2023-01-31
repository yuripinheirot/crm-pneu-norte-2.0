using Moq;
using project.business.usecases.answers;
using project.data.usecases.answers;
using project.data.usecases.questions;
using project.domain.interfaces.Struct;
using project.infra.db.postgres.config;
using project.infra.db.postgres.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specs.suport.factories.feature.answers
{
    public class AnswersRepositoryFactoryMock
    {
        public static Mock<PgDbContext> postgresMock = new Mock<PgDbContext>();
        public static AnswersPostgresRepository answerRepository = new AnswersPostgresRepository();
    }
}
