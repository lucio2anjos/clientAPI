using Client_Management.Class;
using Client_Management.Model.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Client_Management.View.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet]
        public List<Client> List()
        {
            var clients = _clientRepository.GetAllClients();
            return clients;
        }

        [HttpGet("{id}")]
        public Client GetById(int id)
        {
            var client = _clientRepository.GetById(id);
            return client;
        }

        [HttpPost]
        public bool Post([FromBody] Client client)
        {
            return _clientRepository.InsertClient(client);
        }

        [HttpPut]
        public bool Put([FromBody] Client client)
        {
            return _clientRepository.SetClient(client);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _clientRepository.DeleteClient(id);
        }
    }
}
