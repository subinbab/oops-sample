using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct
{
    internal class SortProductData : ISortProduct
    {
        List<Product> products;
        GetProductData _data;
        public SortProductData()
        {
            _data = new GetProductData();
        }
        public List<Product> SortByPriceAscenting()
        {
            products = _data.GetProduct();
            return products.OrderBy(p=>p.price).ToList();
        }

        public List<Product> SortByPricedescenting()
        {
            products = _data.GetProduct();
            return products.OrderByDescending(p => p.price).ToList();
        }
    }
}
