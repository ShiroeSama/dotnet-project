using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository.Command
{
    using Entity.Command;

    public class StatusRepository : Repository
    {
        public Status Add(Status status)
        {
            this.Context.Status.Add(status);
            this.Context.SaveChanges();

            return status;
        }
    }
}
