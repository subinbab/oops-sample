using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct
{
    internal class MobizoneOrderV1 : OrderProduct
    {
        List<Product> products = new List<Product>();
        Specification specification = new Specification();
        Customer customer = new Customer();
        List<Customer> customerList = new List<Customer>();

        private int? _orderId;
        public MobizoneOrderV1(int customerId,List<int> productId):base(customerId,productId)
        { 
            customer.id = 123;
            customer.name = "John";
            customer.email = "john@gmail.com";

            customerList.Add(customer);
            var Random = new Random();
            _orderId =  Random.Next();
        }
        public override void DeliveryType(int type)
        {
            throw new NotImplementedException();
        }

        public override void MakePayment(PaymentMode paymentId,List<int> productId)
        {
            List<Product> displayProducts = new List<Product>();    
            GetProductData database = new GetProductData();
            products = database.GetProduct();
            PaymentMode mode = paymentId;
            int sum = 0;
            customer = customerList.FirstOrDefault(x => x.id.Equals(_customerId));
            foreach (int p in productId)
            {
                var product = products.FirstOrDefault(x => x.Id.Equals(p));
                if (product != null)
                {
                    displayProducts.Add(product);
                    sum = sum + product.price;
                }
                
            }
            switch (mode)
            {
                case PaymentMode.CashOnDelivery:
                    //cash on delivery:
                    Console.WriteLine("Order Id : " + _orderId);
                    Console.WriteLine(customer.name + " you paid as COD for " + sum + " rupees");
                    Console.WriteLine("You Ordered these products");
                    ProductCatalogV1.Display(displayProducts);
                    break;
            }
        }

        public override void MakeRefund(int paymentId)
        {
            throw new NotImplementedException();
        }
    }
}
