using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository.Product
{
    using Entity.Product;

    public class CategoryRepository : Repository
    {
        public Category Add(Category category)
        {
            this.Context.Category.Add(category);
            this.Context.SaveChanges();

            return category;
        }
    }
}
