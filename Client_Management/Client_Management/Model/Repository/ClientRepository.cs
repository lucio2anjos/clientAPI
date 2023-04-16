using Client_Management.Class;
using Client_Management.Model.Context;
using Client_Management.Model.Interface;

namespace Client_Management.Model.Repository
{
    public class ClientRepository : IClientRepository
    {
        /* public ClientRepository()
        {
            using (var context = new ProjectContext())
            {
                context.Clients.Add(
                    new Client
                    {
                        Id = 1,
                        Nome = "Marcos Alberto"
                    }
                );

                context.Clients.Add(
                    new Client 
                    {
                        Id = 2,
                        Nome = "Ricardo Barbosa"
                    }
                );

                context.Clients.Add(
                    new Client
                    {
                        Id = 2,
                        Nome = "Arthur de Oliveira"
                    }
                );

                context.SaveChanges();
            }
        } */

        public List<Client> GetAllClients()
        {
            using (var context = new ProjectContext())
            {
                var clients = context.Clients.ToList();

                return clients;
            }
        }

        public Client GetById(int id)
        {
            using (var context = new ProjectContext())
            {
                var client = context.Clients.SingleOrDefault(x => x.Id == id);

                return client;
            }
        }

        public bool InsertClient(Client client)
        {
            using (var context = new ProjectContext())
            {
                try
                {
                    context.Clients.Add(client);

                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool SetClient(Client client)
        {
            using (var context = new ProjectContext())
            {
                try
                {
                    var exisitingClient = context.Clients.FirstOrDefault(x => x.Id == client.Id);

                    if (exisitingClient != null)
                    {
                        context.Entry(exisitingClient).CurrentValues.SetValues(client);
                        context.SaveChanges();

                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool DeleteClient(int id)
        {
            using (var context = new ProjectContext())
            {
                try
                {
                    var client = context.Clients.FirstOrDefault(x => x.Id == id);

                    if (client != null)
                    {
                        context.Remove(client);
                        context.SaveChanges();

                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
