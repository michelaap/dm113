using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Products
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IProductsService
    {
        // Get all products
        [OperationContract]
        List<ProductData> ListProducts();

        // Get the details of a single product
        [OperationContract]
        ProductData GetProduct(string productCode);

        // Get the current stock for a product
        [OperationContract]
        int CurrentStock(string productCode);

        // Add stock for a product
        [OperationContract]
        bool AddStock(string productCode, decimal quantity);
    }


    // Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
    [DataContract]
    public class ProductData
    {
        [DataMember]
        public string Name;

        [DataMember]
        public string Code;

        [DataMember]
        public decimal Price;
    }
}
