﻿using Exercicios_Classe;
using System;
using System.Globalization;

namespace Classes {
    class Program {
        static void Main(string[] args) {

            //Exercicio 1
            /*
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
            


            //Exercicio 2
            
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();

            Console.WriteLine("Dados do Funcionario 1:");
            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Dados do Funcionario 2:");
            Console.Write("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double SalarioMedio = (func1.Salario + func2.Salario) / 2;

            Console.WriteLine($"Salario Medio: R${SalarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");
            */


            //Estoque

            Produto p1 = new Produto();

            Console.WriteLine("Dados do produto: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço: R$ ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: " + p1);

            Console.Write("Digite o numero de produtos a ser adcionado ao estoque: ");
            p1.AdcionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados do atualizado: " + p1);

            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            p1.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados do atualizado: " + p1);
        }

    }
}