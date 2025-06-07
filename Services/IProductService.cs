using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;


namespace Services
{
    internal class IProductService
    {
        void SaveProduct(Product p);
        void DeleteProduct(Product p);
        void UpdateProduct(Product p);
        List<Product> GetProducts();
        Product GetProductById();

    }
}
