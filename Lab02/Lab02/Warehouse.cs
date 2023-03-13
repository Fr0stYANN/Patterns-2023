using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{

    // Single Responsibility - class operates only with products in warehouse
    // Liskov Substitution Principle - by default in c#
    // Open-Closed can be extended by c# extension methods and inheritance
    public class Warehouse
    {
        private IList<Product> products = new List<Product>();

        public IList<Product> Products { get { return products; } }

        public Warehouse(IList<Product> products)
        {
            this.products = products;
        }

        public void AddProduct(Product product)
        {
            if (product != null)
                products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
    }
}
