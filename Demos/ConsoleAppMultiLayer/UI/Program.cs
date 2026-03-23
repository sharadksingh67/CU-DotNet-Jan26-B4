using ConsoleAppMultiLayer.Models;
using ConsoleAppMultiLayer.Repositories;
using ConsoleAppMultiLayer.Services;

namespace ConsoleAppMultiLayer.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("File or List (1/2)");
            var repoOption = int.Parse( Console.ReadLine());

            var product = GetProduct();
            IProductRepository repo = null;

            if (repoOption == 1)
            {
                repo = new FileProductRepository();
            }
            else if (repoOption == 2)
            {
                repo = new ProductRepository();
            }

            IProductServices service = new ProductServices(repo);
            try
            {
                service.AddProduct(product);
                IEnumerable<Product> products = service.GetProducts();
                DisplayProducts(products);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        static Product GetProduct()
        {
            Product product = new Product
            {
                ProductId =101,
                 Name = "Chair",
                  Price = 1200
            };
            return product;
        }

        static void DisplayProducts(IEnumerable<Product> products)
        {
            foreach(Product product in products )
            {
                Console.WriteLine(product);
            }
        }
    }
}
