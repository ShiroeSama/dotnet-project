using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository.Command
{
    using Entity.Command;

    public class CommandRepository : Repository
    {
        public Command Add(Command command)
        {
            this.Context.Command.Add(command);
            this.Context.SaveChanges();

            return command;
        }
    }
}
