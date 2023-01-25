using Exercicio_Seção_5;
using System;
using System.Globalization;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {

            Conta conta1;

            Console.Write("Digite o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Havera deposito inicial: (s/n) ");
            char depositoInicial = char.Parse(Console.ReadLine());
            
            

            if (depositoInicial == 's' || depositoInicial == 'S' ) {
                Console.Write("Digite o deposito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta1 = new Conta(conta, nome, saldo);
            }
            else {
                conta1 = new Conta(conta, nome);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta1);

            Console.Write("Digite o valor do deposito: ");
            conta1.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta1);
            
            Console.Write("Digite o valor do saque: ");
            conta1.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta1);


        }
    }
}