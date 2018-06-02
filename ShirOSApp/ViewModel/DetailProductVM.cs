using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirOSApp.ViewModel
{
    using Common;
    using Model.Entity.Product;

    public class DetailProductVM : BaseVM
    {
        protected Product product;
       
        public DetailProductVM(Product product)
        {
            this.product = product;
        }

        public string Label
        {
            get { return this.product.Label; }
            set { this.product.Label = value; }
        }

        public string Code
        {
            get { return this.product.Code; }
            set { this.product.Code = value; }
        }
    }
}
