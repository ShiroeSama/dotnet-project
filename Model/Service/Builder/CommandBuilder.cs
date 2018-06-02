using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service.Builder
{
    using Model.Entity.Command;

    public class CommandBuilder
    {
        public static Command create(String observation)
        {
            Command command = new Command();
            command.Observation = observation;

            return command;
        }

        public static List<Command> createList()
        {
            List<Command> commands = new List<Command>();
            commands.Add(create("command 1 observation"));
            commands.Add(create("command 2 observation"));
            commands.Add(create("command 3 observation"));
            commands.Add(create("command 4 observation"));

            return commands;
        }
    }
}
