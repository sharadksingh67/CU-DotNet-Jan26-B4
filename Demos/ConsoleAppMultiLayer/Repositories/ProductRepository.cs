using ConsoleAppMultiLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMultiLayer.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        // In-Memory DB
        private static List<Product> Products = new List<Product>();
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return Products;
        }
    }
}
