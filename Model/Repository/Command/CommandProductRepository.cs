using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository.Command
{
    using Entity.Command;

    public class CommandProductRepository : Repository
    {
        public CommandProduct Add(CommandProduct commandProduct)
        {
            this.Context.CommandProduct.Add(commandProduct);
            this.Context.SaveChanges();

            return commandProduct;
        }
    }
}
