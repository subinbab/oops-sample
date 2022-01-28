using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct
{
    internal interface IGetProduct
    {
        List<Product> GetProduct();
        Product GetProduct(int id);
        List<Product> GetProduct(string productName);
    }
}
