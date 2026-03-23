using ConsoleAppMultiLayer.Models;


namespace ConsoleAppMultiLayer.Services
{
    internal interface IProductServices
    {
        void AddProduct(Product product);
        public IEnumerable<Product> GetProducts();
    }
}
