using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using InfraData.Entities;
using InfraData.Repositories;

namespace WebApiTest.Controllers
{
    public class ClientController : ApiController
    {
        private readonly ClientRepository _repo;

        public ClientController()
        {
            _repo = new ClientRepository();
        }

        // GET: api/Client
        [AcceptVerbs("GET")]
        public List<Client> Get()
        {
            return _repo.GetAll().ToList();
        }

        // GET: api/Client/5
        public Client Get(int id)
        {
            return _repo.GetById(id);
        }

        // POST: api/Client
        public void Post(Client client)
        {
            _repo.Add(client);
        }

        // PUT: api/Client/5
        public void Put(int id, Client client)
        {
            _repo.Update(client);
        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
            _repo.Remove(_repo.GetById(id));
        }
    }
}
