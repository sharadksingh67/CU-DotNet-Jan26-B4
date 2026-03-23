using ConsoleAppMultiLayer.Models;

namespace ConsoleAppMultiLayer.Repositories
{
    internal interface IProductRepository
    {
        void AddProduct(Product product);
        public IEnumerable<Product> GetProducts();


    }
}
