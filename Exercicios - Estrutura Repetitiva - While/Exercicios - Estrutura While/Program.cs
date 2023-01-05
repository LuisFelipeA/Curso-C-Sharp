using System;

namespace exercicios {
    class EstruturaWhile {
        static void Main(string[] args) {

            //Exercicio 1
                        
            int senhaCorreta = 2002;
                        
            Console.Write("Digite a senha: ");
            int senhaDigitada = int.Parse(Console.ReadLine());

            while (senhaDigitada != senhaCorreta) {
                if (senhaDigitada != 2002) {
                    Console.WriteLine("Senha incorreta!");
                    Console.Write("Digite novamente: ");
                    senhaDigitada = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Acesso permitido!");
            

            //Exercicio 2
            
            double x;
            double y;

            Console.Write("Digite a cordenada X: ");
            x = double.Parse(Console.ReadLine());
            
            Console.Write("Digite a cordenada Y: ");
            y = double.Parse(Console.ReadLine());

            while (x != 0 && y != 0) {
                if (x > 0) {
                    if (y > 0) {
                        Console.WriteLine("Primeiro");
                    }
                    else {
                        Console.WriteLine("Quarto");
                    }
                }
                else {
                    if (y > 0) {
                        Console.WriteLine("Segundo");
                    }
                    else {
                        Console.WriteLine("Terceiro");
                    }
                }

                Console.Write("Digite a cordenada X: ");
                x = double.Parse(Console.ReadLine());

                Console.Write("Digite a cordenada Y: ");
                y = double.Parse(Console.ReadLine());
            }
            

            //Exercicio 3

            int contAlcool = 0;
            int contGasolina = 0;
            int contDiesel = 0;

            Console.Write("Digite o codigo do combustivel [Ou 4 para sair]: ");
            int codigo = int.Parse(Console.ReadLine());

            while (codigo != 4) {
                if (codigo == 1) {
                    contAlcool++;
                }
                else if (codigo == 2) {
                    contGasolina++;
                }
                else if (codigo == 3) {
                    contDiesel++;
                }
                else {
                    Console.WriteLine("Código Invalido");
                }
                Console.Write("Digite o codigo do combustivel [Ou 4 para sair]: ");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("--------------");
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine($"Alcool: {contAlcool}");
            Console.WriteLine($"Gasolina: {contGasolina}");
            Console.WriteLine($"Diesel: {contDiesel}");
            Console.WriteLine("--------------");


        }
    }
}