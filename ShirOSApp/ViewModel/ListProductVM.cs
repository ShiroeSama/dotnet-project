using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirOSApp.ViewModel
{
    using Common;
    using Model.Entity.Product;
    using Model.Repository.Product;
    using System.Collections.ObjectModel;
    using Service.Builder;

    public class ListProductVM : BaseVM
    {
        protected ProductRepository repository;
        protected ObservableCollection<DetailProduitVM> products = null;
        protected DetailProduitVM selectedProduct;
        
        public ListProductVM()
        {
            this.repository = new ProductRepository();
            List<Product> products = this.repository.List();

            this.products = new ObservableCollection<DetailProduitVM>(ProductBuilder.ConvertProductListToDetailProductVMList(products));

            if (this.products != null && this.products.Count > 0)
            {
                this.selectedProduct = this.products.First();
            }
        }
        
   
        public ObservableCollection<DetailProduitVM> Products
        {
            get { return this.products; }
            set
            {
                this.products = value;
                OnPropertyChanged("Products");
            }
        }

        public DetailProduitVM SelectedProduct
        {
            get { return this.selectedProduct; }
            set
            {
                this.selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }
    }
}
