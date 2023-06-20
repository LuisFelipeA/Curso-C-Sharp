using HerancaPolimorfismo.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Exercicio */

            Console.Write("Enter the number of employess: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> listEmployees = new List<Employee>();

            for (int i = 1; i <= n;i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                string outsourced = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == "y")
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);

                    listEmployees.Add(employee);
                }
                else
                {
                    Employee employee = new Employee(name, hours, valuePerHour);

                    listEmployees.Add(employee);
                }
            }

            Console.WriteLine();

            Console.WriteLine("PAYMENTS:");

            foreach(Employee emp in listEmployees)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }


            /*Sobreposição, palavras virtual, override e base

            Account acc1 = new Account(1, "Luis", 500.0);
            Account acc2 = new SavingsAccount(2, "Maria", 500.0, 0.01);

            acc1.WithDraw(10);
            acc2.WithDraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            */

            /*Upcasting e Downcasting

            Account acc = new Account(1,"Joe",0.0);
            BusinessAccount bacc = new BusinessAccount(2, "Maria", 0.0, 500.0);

            //Upcasting

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(3, "Tommy", 10.0, 200.0);
            Account acc3 = new SavingsAccount(4, "Luis", 123000, 80000);

            //Downcasting

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc6 = (SavingsAccount)acc3;
                acc6.UpdateBalance();
                Console.WriteLine("Update!");
            }

            */


            /* Herança
            BusinessAccount account = new BusinessAccount(1, "Luis", 1273450.15, 100000.00);
            
            Console.WriteLine(account.Balance);

            account.Deposit(300000);

            Console.WriteLine(account.Balance);

            account.WithDraw(23000);

            Console.WriteLine(account.Balance);

            account.Loan(110000);  //passando do limite

            Console.WriteLine(account.Balance);

            account.Loan(95000);

            Console.WriteLine(account.Balance);
            */
        }
    }
}