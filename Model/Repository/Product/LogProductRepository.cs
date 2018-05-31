using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository.Product
{
    using Entity.Product;

    public class LogProductRepository : Repository
    {
        public LogProduct Add(LogProduct logProduct)
        {
            this.Context.LogProduct.Add(logProduct);
            this.Context.SaveChanges();

            return logProduct;
        }
    }
}
