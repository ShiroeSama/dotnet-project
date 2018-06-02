using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model.Entity.Command;
using Model.Repository.Product;
using Model.Repository.Command;

namespace ServiceWCF.Service.Product
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ProductService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ProductService.svc ou ProductService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ProductService : IProductService
    {
        public int GetStock(string code)
        {
            ProductRepository repository = new ProductRepository();
            return repository.GetStock(code);
        }

        public List<Command> ListCommands()
        {
            CommandRepository repository = new CommandRepository();
            return repository.List();
        }

        public List<Model.Entity.Product.Product> ListProducts()
        {
            ProductRepository repository = new ProductRepository();
            return repository.List();
        }
    }
}
