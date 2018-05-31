using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository.Client
{
    using Entity.Client;

    public class ClientRepository : Repository
    {
        public Client Add(Client client)
        {
            this.Context.Client.Add(client);
            this.Context.SaveChanges();

            return client;
        }
    }
}
