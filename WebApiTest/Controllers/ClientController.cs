using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
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
        [AcceptVerbs("GET")]
        public Client Get(int id)
        {
            return _repo.GetById(id);
        }

        // POST: api/Client
        [AcceptVerbs("POST")]
        public HttpResponseException Post(Client client)
        {
            if (client == null)
                return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest));
            _repo.Add(client);
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Created));
        }

        // PUT: api/Client/5
        [AcceptVerbs("PUT")]
        public void Put(int id, Client client)
        {
            client.Id = id;
            _repo.Update(client);
        }

        // PATCH: api/Client/5
        [AcceptVerbs("PATCH")]
        public void Patch(int id, Delta<Client> client)
        {
            var oldClient = _repo.GetById(id);
            _repo.Patch(client, oldClient);
        }

        // DELETE: api/Client/5
        [AcceptVerbs("DELETE")]
        public void Delete(int id)
        {
            _repo.Remove(_repo.GetById(id));
        }
    }
}
