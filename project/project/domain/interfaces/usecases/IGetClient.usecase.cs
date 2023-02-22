using project.domain.model.entities;

namespace project.domain.interfaces.usecases
{
    public interface IGetClient
    {
        ClientModel getClient(string id);
    }
}
