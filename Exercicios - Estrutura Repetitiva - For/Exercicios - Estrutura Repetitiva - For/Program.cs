using System;

namespace exercicios {
    class EstruturaFor {
        static void Main(string[] args) {

            //Exercicio 1
            /*
            Console.Write("Digite um numero: ");
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n1; i++) {
                if (i % 2 == 1) {
                    Console.WriteLine(i);                
                }
            }


            //Exercicio 2

            Console.Write("Quantos numeros ira digitar? ");
            int n2 = int.Parse(Console.ReadLine());

            int contIn = 0;
            int contOut = 0;

            for (int i = 1; i <= n2; i++) {
                Console.Write($"Digite valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());

                if (valor >= 10 && valor <= 20) { 
                    contIn++;
                }
                else {
                    contOut++;
                }
            }

            Console.WriteLine($"{contIn} in");
            Console.WriteLine($"{contOut} out");
            */


            //Exercicio 3
            /*
            Console.Write("Quantos numeros ira digitar? ");
            int n3 = int.Parse(Console.ReadLine());

            for (int i =0; i < n3; i++) {

            }
            //mp = (a * 2 + b * 3 + c * 5) / 10
            
             */

            //Exercicio 4
            /*
            Console.Write("Digite un numero: ");
            int n4 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n4; i++) {
                Console.Write("Digite um numero: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Digite outro numero: ");
                double b = double.Parse(Console.ReadLine());

                if ( a == 0) {
                    Console.WriteLine("Divisão Impossivel");
                }
                else if (b == 0) {
                    Console.WriteLine(0.0);
                }
                else {
                    double divisao = a / b;
                    Console.WriteLine(divisao);
                }
            }
            


            //Exercicio 5
            
            Console.Write("Digite un numero: ");
            int n5 = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for (int i = 1; i <= n5; i++) {
                fatorial = fatorial * i;
            }

            Console.WriteLine($"Fatorial: {fatorial}");
            


            //Exercicio 6

            Console.Write("Digite un numero: ");
            int n6 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n6; i++) {
                if (n6 % i == 0) {
                    Console.WriteLine(i);
                }
            }
            */


            //Exercicio 07

            Console.Write("Digite un numero: ");
            int n6 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n6; i++) {
                Console.Write($"{i} ");
                Console.Write($"{Math.Pow(i, 2)} ");
                Console.WriteLine(Math.Pow(i, 3));
            }





        }
    }
}