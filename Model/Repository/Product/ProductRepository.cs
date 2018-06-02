using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository.Product
{
    using Entity.Product;
    using Service.Builder;

    public class ProductRepository : Repository
    {
        public Product Add(Product product)
        {
            this.Context.Product.Add(product);
            this.Context.SaveChanges();

            return product;
        }

        public List<Product> List()
        {
            // return this.Context.Product.ToList();
            return ProductBuilder.createList();
        }

        public int GetStock(String code)
        {
            List<Product> products = ProductBuilder.createList();
            return products.Where(product => product.Code == code).Select(product => product.Stock).First();
        }
    }
}
