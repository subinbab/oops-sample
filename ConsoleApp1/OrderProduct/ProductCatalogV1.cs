using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct
{
    internal class ProductCatalogV1 : IGetProductUser , ISortProductUser
    {
        List<Product> _productList;
        Product _product;
        GetProductData _data;
        SortProductData _dataSort;
        public ProductCatalogV1()
        {
            _productList = new List<Product>();
             _data = new GetProductData();
            _dataSort = new SortProductData();
        }

        public void SortByPriceAscenting()
        {
            _productList = _dataSort.SortByPriceAscenting();
            Display(_productList);
        }

        public void SortByPricedescenting()
        {
            _productList = _dataSort.SortByPricedescenting();
            Display(_productList);
        }

        public void GetProduct()
        {
            _productList = _data.GetProduct();
            Display(_productList);
        }

        public void GetProductById(int id)
        {
            _product = _data.GetProduct(id);
            _productList.Add(_product);
            Display(_productList);
            _productList.Clear();
        }

        public void GetProductByName(string productName)
        {
            _productList = _data.GetProduct(productName);
            Display(_productList);
        }

        public static void Display(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine("Id   :" + product.Id);
                Console.WriteLine("Name     :"+product.Name);
                Console.WriteLine("Price    :"+product.price);
                Console.WriteLine("Ram  :"+product.specification.ram);
                Console.WriteLine("Battery  :"+product.specification.battery);
                Console.WriteLine("Display  :"+product.specification.display);
                Console.WriteLine("Processor    :"+product.specification.processor);
                Console.WriteLine("_______________________________________________");
            }
            
        }
    }
}
