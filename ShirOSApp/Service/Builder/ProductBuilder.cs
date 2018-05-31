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
        public static List<DetailProduitVM> ConvertProductListToDetailProductVMList(List<Product> products)
        {
            List<DetailProduitVM> list = new List<DetailProduitVM>();

            foreach (Product product in products)
            {
                list.Add(new DetailProduitVM(product));
            }

            return list;
        }
    }
}
