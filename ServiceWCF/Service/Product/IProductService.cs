using System;
using System.Collections.Generic;
using Model.Entity.Command;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceWCF.Service.Product
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IProductService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
                ResponseFormat = WebMessageFormat.Json,
                RequestFormat = WebMessageFormat.Json,
                UriTemplate = "listProducts")]
        List<Model.Entity.Product.Product> ListProducts();

        [OperationContract]
        [WebInvoke(Method = "GET",
                ResponseFormat = WebMessageFormat.Json,
                RequestFormat = WebMessageFormat.Json,
                UriTemplate = "listCommands")]
        List<Command> ListCommands();

        [OperationContract]
        [WebInvoke(Method = "GET",
                ResponseFormat = WebMessageFormat.Json,
                RequestFormat = WebMessageFormat.Json,
                UriTemplate = "getStockProdect?code={code}")]
        int GetStock(String code);
    }
}
