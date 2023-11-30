using project.business.usecases.doblist;
using project.business.usecases.sales;
using project.data.usecases.doblist;
using project.data.usecases.sales;
using project.infra.db.firebird.repository;
using project.infra.db.postgres.config;
using project.infra.db.postgres.repository;

namespace project.main.factories.business
{
    public class DobListFactory
    {
        static PgDbContext postgres = new PgDbContext(Properties.Settings.Default.postgresConnectionString);
        private static DobListRepository dobListRepository = new DobListRepository(postgres);
        private static DobListData dobListData = new DobListData(dobListRepository);

        public static DoblistBusiness handle = new DoblistBusiness(dobListData);
    }
}
