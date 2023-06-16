using ExercicioEnumeracaoComposicao.Entities;
using ExercicioEnumeracaoComposicao.Entities.Enums;
using System.Globalization;
using System.Xml.Linq;

namespace ExercicioEnumeracaoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(clientName, clientEmail, clientBirthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int qtdItems = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            for (int i = 1; i <= qtdItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(nameProduct, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrdemItem ordemItem = new OrdemItem(quantity, price, product);

                order.AddItem(ordemItem);
            }

            Console.WriteLine();
            Console.WriteLine("Order sumary:");
            Console.WriteLine(order);


        }
    }
}
