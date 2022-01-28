using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct
{
    internal abstract class OrderProduct
    {
        protected int _customerId;
        private int? _addressId;
        private List<Product> _products = null;
        protected Customer customer = null;
        private List<int> _productId;
        protected List<Customer> customerList = null;
        public OrderProduct(int customerId,List<int> productId)
        {
            _customerId = customerId;
            _productId = productId;
        }
        public List<Product> Products()
        {
            return _products;
        }
        public virtual void CustomerDetails(Customer cs)
        {
            customer = cs;
            Console.WriteLine("You are using Mobizone version 1");
            Console.WriteLine(customer.name);
            Console.WriteLine(customer.email);
        }
        public abstract void MakePayment(PaymentMode paymentId,List<int> productId);
        public abstract void MakeRefund(int paymentId);
        public abstract void DeliveryType(int type);
    }
}
