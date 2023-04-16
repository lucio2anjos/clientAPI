using Client_Management.Class;

namespace Client_Management.Model.Interface
{
    public interface IClientRepository
    {
        List<Client> GetAllClients();
        Client GetById(int id);
        bool InsertClient(Client client);
        bool SetClient(Client client);
        bool DeleteClient(int id);
    }
}
