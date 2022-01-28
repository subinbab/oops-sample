using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public Specification specification { get; set; }
        public int price { get; set; }
    }
}
