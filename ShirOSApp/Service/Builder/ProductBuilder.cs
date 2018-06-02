using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirOSApp.Service.Builder
{
    using Model.Entity.Product;
    using ViewModel;

    public static class ProductBuilder
    {
        public static List<DetailProductVM> ConvertProductListToDetailProductVMList(List<Product> products)
        {
            List<DetailProductVM> list = new List<DetailProductVM>();

            foreach (Product product in products)
            {
                list.Add(new DetailProductVM(product));
            }

            return list;
        }
    }
}
