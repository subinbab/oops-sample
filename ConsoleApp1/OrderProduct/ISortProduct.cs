using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct
{
    internal interface ISortProduct
    {
        List<Product> SortByPriceAscenting();
        List<Product> SortByPricedescenting();
    }
}
