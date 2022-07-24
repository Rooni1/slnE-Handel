using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Handel.Models.Repository
{
    public interface IProductRepo
    {
        Product CreateProduct();
        List<Product> GetProducts();

        Product GetProduct(int id);
        Product DeleteProduct(int id);
        Product UpdateProduct(int id);
    }
}
