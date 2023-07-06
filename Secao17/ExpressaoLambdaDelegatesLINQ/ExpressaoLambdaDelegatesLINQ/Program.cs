using ExpressaoLambdaDelegatesLINQ.Entities;
using ExpressaoLambdaDelegatesLINQ.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressaoLambdaDelegatesLINQ
{
    class Program
    {

        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /* Func (select) */

            static string NameUpper(Product p)
            {
                return p.Name.ToUpper();
            }

            //List<string> result = list.Select(NameUpper).ToList();

            //Func<Product, string> func = NameUpper;

            Func<Product, string> func = p=> p.Name.ToUpper();

            List<string> result = list.Select(func).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }


            /**/




            /* Action (ForEach) 

            static void UpdatePrice(Product p)
            {
                p.Price += p.Price * 0.1;
            }

            //list.ForEach(UpdatePrice);

            //Action<Product> act = UpdatePrice;

            Action<Product> act = p => { p.Price += p.Price * 0.1; };

            //list.ForEach(act);

            list.ForEach(p => {p.Price += p.Price * 0.1; });


            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            */




            /* Predicate (RemoveAll) 

            //list.RemoveAll(p => p.Price >= 100.0);

            list.RemoveAll(ProductTest); //Função ProductTest la embaixo

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            */




            /* Introdução a delegates

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op(a, b);

            */




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

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }



    }
}