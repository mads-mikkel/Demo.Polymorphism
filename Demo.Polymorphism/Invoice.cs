using System.Collections.Generic;
using System.Linq;

namespace Demo.Polymorphism
{
    public class Invoice: IPayable
    {
        protected List<Product> products;

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public decimal GetPaymentAmount()
        {
            return products.Sum(p => p.Price);
        }
    }
}