using ConsoleAppMultiLayer.Models;
using ConsoleAppMultiLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMultiLayer.Services
{
    internal class ProductServices : IProductServices
    {
        private IProductRepository _repository { get; set; }
        public ProductServices(IProductRepository repository)
        {
            _repository = repository;
        }

        IProductRepository repository = new ProductRepository();
        public void AddProduct(Product product)
        {
            if (string.IsNullOrEmpty(product.Name))
            {
                throw new ArgumentException("Name should be provided");
            }
            if (product.Price <= 0 || product.Price > 100000)
            {
                throw new ArgumentException("Price should be Range =1-100000");
            }
            repository.AddProduct(product);

        }
        public IEnumerable<Product> GetProducts()
        {
            return repository.GetProducts();
        }
    }
}
