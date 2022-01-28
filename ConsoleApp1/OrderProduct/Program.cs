using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            List<Product> products = new List<Product>(); 
            Specification specification = new Specification();

           

            List<int> productId = new List<int>();
            productId.Add(1);
            productId.Add(2);

            OrderProduct orderProduct = new MobizoneOrderV1( 123,productId);



            /*orderProduct.MakePayment(PaymentMode.CashOnDelivery, productId);*/
            ProductCatalogV1 pc = new ProductCatalogV1();
            //pc.GetProductByName("Samsung F41");
            pc.GetProduct();
            /*pc.GetProductById(1);*/
            /*pc.GetProductByName("Samsung");*/
            /*pc.SortByPriceAscenting();*/
            /*pc.SortByPricedescenting();*/
            //orderProduct.CustomerDetails(customer1);
        }
    }
}
