using ExercicioMetodosAbstratos.Entities;
using System.Globalization;

namespace ExercicioMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax players: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax player #{i} data:");
                
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();

            double sumTax = 0.0;

            foreach (TaxPayer player in taxPayers)
            {
                Console.WriteLine($"{player.Name}: $ {player.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                sumTax += player.Tax();
            }

            Console.WriteLine();

            Console.WriteLine($"TOTAL TAXES: $ {sumTax.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}