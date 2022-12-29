using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            
            //Saida de dados

/*
            char genero = 'M';
            int idade = 25;
            double saldo = 902034.344586;
            string nome = "Luis";

            Console.Write("Bom dia!");  //não quebra linha
            Console.WriteLine(nome);    //quebra linha
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine("----------------------");
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine("----------------------");
            Console.WriteLine("Olá " + nome);
            Console.WriteLine("Saldo: R$" + saldo.ToString("F2", CultureInfo.InvariantCulture)); //coloca o ponto para separar - tem que ter o 'using System.Globalization;' no começo

            Console.WriteLine("----------------------");

            //PlaceHolders
            Console.WriteLine("{0} tem {1} anos e saldo de {2:F2} reais", nome, idade, saldo);
            Console.WriteLine("----------------------");

            //Concatenação
            Console.WriteLine($"{nome} tem {idade} anos e saldo de {saldo:F2} reais");
            Console.WriteLine("----------------------");

            //Interpolação
            Console.WriteLine(nome + " tem " + idade + " anos e saldo de " + saldo.ToString("F2") + " reais");
*/

            //Exercicio de fixação - Saida de dados
            
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1} - Preço $ {preco1:F2}");
            Console.WriteLine($"{produto2} - Preço $ {preco2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");




            //Tipos de Dados  
            /*         

                        bool completo = false;
                        char genero = 'F';
                        char letra = '\u0041'; //codigo unicode
                        byte n1 = 126;
                        int n2 = 1000;
                        int n3 = 2147483647;
                        long n4 = 2147483648;
                        float n5 = 4.5f;
                        double n6 = 4.5;
                        string nome = "Maria";  //imutavel
                        object obj1 = "Luis Felipe";  //pode receber qualquer tipo de dado
                        object obj2 = 4.5;

                        Console.WriteLine(completo);
                        Console.WriteLine(genero);
                        Console.WriteLine(letra);
                        Console.WriteLine(n1);
                        Console.WriteLine(n2);
                        Console.WriteLine(n3);
                        Console.WriteLine(n4);
                        Console.WriteLine(n5);
                        Console.WriteLine(n6);
                        Console.WriteLine(nome);
                        Console.WriteLine(obj1);
                        Console.WriteLine(obj2);


                        int n7 = int.MinValue; //pega o valor minimo inteiro
                        int n8 = int.MaxValue; //pega o valor maximo inteiro - serve pra qualquer tipo de dado
                        decimal n9 = decimal.MaxValue; //serve pra qualquer tipo de dado

                        Console.WriteLine(n7);
                        Console.WriteLine(n8);
                        Console.WriteLine(n9);
            */
        }
    }
}