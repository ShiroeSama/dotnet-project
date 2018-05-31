using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            // Init DB
            context.Client.ToList();

            context.Command.ToList();
            context.CommandProduct.ToList();
            context.Status.ToList();

            context.Category.ToList();
            context.LogProduct.ToList();
            context.Product.ToList();
        }
    }
}
