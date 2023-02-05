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
using project.infra.db.firebird.config;
using project.infra.db.firebird.repository;

namespace specs.suport.factories.feature
{
    public class SalesRepositoryFactoryMock
    {
        public static SalesFirebirdRepository salesRepository = new SalesFirebirdRepository();
    }
}
