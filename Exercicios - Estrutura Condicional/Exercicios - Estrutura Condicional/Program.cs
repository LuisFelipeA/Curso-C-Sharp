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

            */

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








        }
    }
}