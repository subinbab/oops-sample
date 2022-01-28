using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct
{
    internal interface IGetProductUser
    {
        void GetProduct();
        void GetProductById(int id);
        void GetProductByName(string productName);
    }
}
