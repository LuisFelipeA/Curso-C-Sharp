using ExpressaoLambdaDelegatesLINQ.Services;
using System;

namespace ExpressaoLambdaDelegatesLINQ
{
    internal class Program
    {

        delegate double BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {

            /* Introdução a delegates */

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Max;

            double result = op(a, b);

            Console.WriteLine(result);




            /*

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            */
        }
    }
}