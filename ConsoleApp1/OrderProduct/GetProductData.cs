using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct
{
    public  class GetProductData : IGetProduct
    {
        private List<Product> Products;
        private Specification specification = new Specification();
        private Product product = new Product();
        public GetProductData()
        {
            Products = new List<Product>();

        }

        public List<Product> GetProduct()
        {
            specification.battery = 5000;
            specification.ram = 3;
            specification.display = "IPS LCD";
            specification.memory = "64GB";
            specification.processor = "snapdragon 450";
            Products.Add(new Product { Id = 1, Name = "Samsung A51", price = 12499, specification = specification });
            Products.Add(new Product { Id = 2, Name = "Samsung F41", price = 12499, specification = specification });
            Products.Add(new Product { Id = 3, Name = "Oppo F51", price = 49500, specification = specification });
            Products.Add(new Product { Id = 4, Name = "Xiaomi Mi Note 9 Pro", price = 14999, specification = specification });
            Products.Add(new Product { Id = 5, Name = "Nokia 5", price = 8999, specification = specification });

            return Products;
        }
        public Product GetProduct(int id)
        {
            Products = GetProduct();
            return Products[id];
        }
        public List<Product> GetProduct(string productName)
        {
            List<Product> _productList = GetProduct();
            foreach (Product p in _productList)
            {
                if (p.Name.Contains(productName))
                {
                    Products.Add(p);
                }
                Products = null;
            }
            return Products;
        }
    }
}
