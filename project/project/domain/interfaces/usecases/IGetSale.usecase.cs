using project.domain.model.entities;

namespace project.domain.interfaces.usecases
{
    public interface IGetSale
    {
        SaleModel getSale(string idCompany, string idSale);
    }
}
