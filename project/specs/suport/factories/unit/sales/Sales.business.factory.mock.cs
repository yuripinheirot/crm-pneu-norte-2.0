using Moq;
using project.business.usecases.answers;
using project.business.usecases.questions;
using project.business.usecases.sales;
using project.data.usecases.answers;
using project.data.usecases.questions;
using project.data.usecases.sales;
using project.domain.interfaces.Struct;
using project.infra.db.firebird.config;
using project.infra.db.firebird.repository;
using project.infra.db.postgres.config;
using project.infra.db.postgres.repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specs.suport.factories.unit.business
{
    public class SalesBusinessFactoryMock
    {
        public static Mock<SalesFirebirdRepository> salesRepository = new Mock<SalesFirebirdRepository>();
        public static Mock<SalesData<ISalesRepository>> salesDataMock = new Mock<SalesData<ISalesRepository>>(salesRepository.Object);

        public static SalesBusiness<ISalesData> salesBusiness = new SalesBusiness<ISalesData>(salesDataMock.Object);
    }
}
