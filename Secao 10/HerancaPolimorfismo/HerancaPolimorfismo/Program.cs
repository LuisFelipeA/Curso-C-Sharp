using HerancaPolimorfismo.Entities;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}