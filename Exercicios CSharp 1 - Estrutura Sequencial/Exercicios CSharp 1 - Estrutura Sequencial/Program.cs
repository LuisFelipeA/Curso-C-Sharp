using System;
using System.Globalization;

namespace exercicios {
    class EstruturaSequencial {
        static void Main(string[] args) {

            //Exercicio 1

            /*
            Console.Write("Digite valor 1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite valor 2: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine($"A soma de {n1} e {n2} é {soma}");


            //Exercicio 2

            Console.Write("Digite valor do raio de um circulo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine($"A area do circulo é: {area.ToString("F4", CultureInfo.InvariantCulture)}");


            //Exercicio 3

            Console.Write("Digite valor 1: ");
            int v1 = int.Parse(Console.ReadLine());

            Console.Write("Digite valor 2: ");
            int v2 = int.Parse(Console.ReadLine());

            Console.Write("Digite valor 3: ");
            int v3 = int.Parse(Console.ReadLine());

            Console.Write("Digite valor 4: ");
            int v4 = int.Parse(Console.ReadLine());

            int diferenca = (v1 * v2 - v3 * v4);

            Console.WriteLine($"Diferença = {diferenca}");
            

            //Exericio 4

            Console.Write("Digite o numero do funcionarios: ");
            int funcionario = int.Parse(Console.ReadLine());

            Console.Write("Digite as horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor por hora: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valor;

            Console.WriteLine($"Numero do funcionario: {funcionario}");
            Console.WriteLine($"Salario: R${salario.ToString("F2", CultureInfo.InvariantCulture)}");
            

            //Exercicio 5

            Console.Write("Digite o codigo da peça 1: ");
            int peca1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero de peças: ");
            int quantidade1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitario: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o codigo da peça 2: ");
            int peca2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero de peças: ");
            int quantidade2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitario: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = (valor1 * quantidade1) + (valor2 * quantidade2);

            Console.WriteLine($"Total a pagar: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            */

            //Exercicio 6

            Console.Write("Digite n1: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite n2: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite n3: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double triangulo = (a * c) / 2;
            double circulo = 3.14159 * Math.Pow(c, 2);
            double trapezio = ((a + b) * c) / 2;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a * b;

            Console.WriteLine($"Area triangulo: {triangulo.ToString("F3", CultureInfo.InvariantCulture)} m²");
            Console.WriteLine($"Area circulo: {circulo.ToString("F3", CultureInfo.InvariantCulture)} m²");
            Console.WriteLine($"Area trapezio: {trapezio.ToString("F3", CultureInfo.InvariantCulture)} m²");
            Console.WriteLine($"Area quadrado: {quadrado.ToString("F3", CultureInfo.InvariantCulture)} m²");
            Console.WriteLine($"Area retangulo: {retangulo.ToString("F3", CultureInfo.InvariantCulture)} m²");


        }
    }


}