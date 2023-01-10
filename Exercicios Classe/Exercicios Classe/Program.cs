using Exercicios_Classe;
using System;
using System.Globalization;

namespace Classes {
    class Program {
        static void Main(string[] args) {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados Pessoa 1:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados Pessoa 2:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade) {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            }
            else if (p2.Idade > p1.Idade) {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            }
            else {
                Console.WriteLine("As duas pessoas tem a mesma idade");
            }



        
        }

    }
}