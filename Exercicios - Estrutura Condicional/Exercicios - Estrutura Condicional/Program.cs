using System;
using System.Globalization;

namespace exercicios {
    class EstruturaCondicional {
        static void Main(string[] args) {

            //Exercicio 1
            /*
                        Console.Write("Digite um numero inteiro: ");
                        int n1 = int.Parse(Console.ReadLine());

                        if (n1 > 0) {
                            Console.WriteLine("O numero digitado é positivo");
                        }
                        else if (n1 < 0) {
                            Console.WriteLine("O numero digitado é negativo");
                        }
                        else {
                            Console.WriteLine("O numero é zero");
                        }


            //Exercicio 2

                        Console.Write("Digite um numero inteiro: ");
                        int n2 = int.Parse(Console.ReadLine());

                        if (n2 % 2 == 0) {
                            Console.WriteLine("O numero digitado é par");
                        }
                        else {
                            Console.WriteLine("O numero é impar");
                        }

           
            //Exercicio 3

                        Console.Write("Digite um numero inteiro: ");
                        int n3 = int.Parse(Console.ReadLine());

                        Console.Write("Digite outro numero inteiro: ");
                        int n4 = int.Parse(Console.ReadLine());

                        if (n3 % n4 == 0) {
                            Console.WriteLine("São multiplos");
                        }
                        else if (n4 % n3 == 0) {
                            Console.WriteLine("São multiplos");
                        }
                        else {
                            Console.WriteLine("Não são multiplos");
                        }
            

            //Exercicio 4

                        Console.Write("Digite a hora inicial: ");
                        int inicial = int.Parse(Console.ReadLine());

                        Console.Write("Digite a hora final: ");
                        int final = int.Parse(Console.ReadLine());

                        if (inicial >= final) {
                            int hora = 24 - inicial + final;
                            Console.WriteLine($"O jogo durou {hora} hora(s)");
                        }
                        else {
                            int hora = final - inicial;
                            Console.WriteLine($"O jogo durou {hora} hora(s)");
                        }
            
            
            //Exercicio 5

                        Console.Write("Digite o Codigo: ");
                        int codigo = int.Parse(Console.ReadLine());

                        Console.Write("Digite a quantidade: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        double valor;
            
                        if (codigo == 1) {
                            valor = quantidade * 4.00;
                        }
                        else if (codigo == 2) {
                            valor = quantidade * 4.50;
                        }
                        else if (codigo == 3) {
                            valor = quantidade * 5.00;
                        }
                        else if (codigo == 4) {
                            valor = quantidade * 2.00;
                        }
                        else {
                            valor = quantidade * 1.50;
                        }

                        Console.WriteLine($"Total: R${valor.ToString("F2", CultureInfo.InvariantCulture)}");
            

            //Exercicio 6

                        Console.Write("Digite um valor: ");
                        double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        if (n1 >= 0 && n1 <= 25) {
                            Console.WriteLine("Intervalo [0,25]");
                        }
                        else if (n1 > 25 && n1 <= 50) {
                            Console.WriteLine("Intervalo [25,50]");
                        }
                        else if (n1 > 50 && n1 <= 75) {
                            Console.WriteLine("Intervalo [50,75]");
                        }
                        else if (n1 > 75 && n1 <= 100) {
                            Console.WriteLine("Intervalo [75,100]");
                        }
                        else {
                            Console.WriteLine("Fora de intervalo");
                        }
           
            
            //Exercicio 7

            Console.Write("Digite X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Digite Y: ");
            double y = double.Parse(Console.ReadLine());

            if (y == 0 && x != 0) {
                Console.WriteLine("Eixo X");
            }
            else if (x == 0 && y != 0) {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0) {
                if (y > 0) {
                    Console.WriteLine("Q1");
                }
                else {
                    Console.WriteLine("Q4");
                }
            }
            else if (x < 0) {
                if (y > 0) {
                    Console.WriteLine("Q2");
                }
                else {
                    Console.WriteLine("Q3");
                }
            }
            else {
                Console.WriteLine("Origem");
            }
            */

            //Exercicio 8

            Console.Write("Digite o salario: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;

            if (salario <= 2000) {
                imposto = 0;
            }
            else if (salario <= 3000) {
                imposto = (salario - 2000) * 0.08;
            }
            else if (salario <= 4500) {
                imposto = 1000 * 0.08 + ((salario - 3000) * 0.18);
            }
            else  {
                imposto = 1000 * 0.08 + 1500 * 0.18 + ((salario - 4500) * 0.28);
            }

            if (imposto == 0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}