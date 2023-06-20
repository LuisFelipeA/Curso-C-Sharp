using ExercicioHerancaPolimorfismo.Entities;
using System.ComponentModel;
using System.Globalization;
namespace ExercicioHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            Console.Write("Enter the number of product: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                string type = (Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    Product product = new UsedProduct(name, price, manufactureDate);
                    products.Add(product);
                }
                else  if (type == "i")
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product product = new ImportedProduct(name, price, customFee);
                    products.Add(product);
                }
                else
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                }
            }

            Console.WriteLine();

            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }


            /*
            Product p1 = new Product("TV", 200);
            Console.WriteLine(p1.PriceTag());


            Product p2 = new ImportedProduct("PC", 500, 20);
            Console.WriteLine(p2.PriceTag());

            Product p3 = new UsedProduct("Mouse", 10, DateTime.Parse("20/01/2011"));
            Console.WriteLine(p3.PriceTag());
            */
        }
    }
}