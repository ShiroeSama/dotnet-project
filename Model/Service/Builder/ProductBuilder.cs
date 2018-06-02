using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service.Builder
{
    using Model.Entity.Product;

    public class ProductBuilder
    {
        public static Product create(String code, String label, String description, int stock, Double price)
        {
            Product product = new Product();
            product.Code = code;
            product.Label = label;
            product.Description = description;
            product.Stock = stock;
            product.Price = price;

            return product;
        }

        public static List<Product> createList()
        {
            List<Product> products = new List<Product>();
            products.Add(create("SHOS01", "ShirOS Product 01", "Web Server", 10, 50.99));
            products.Add(create("SHOS02", "ShirOS Product 02", "Server", 4, 99.99));
            products.Add(create("SHOS03", "ShirOS Product 03", "Keyboard", 25, 85.99));
            products.Add(create("SHOS04", "ShirOS Product 04", "Mouse", 18, 48.99));

            return products;
        }
    }
}
