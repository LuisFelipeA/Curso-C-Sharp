using Classes__Atributos__Metodos__Membros_e_Estaticos;
using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            //Classes

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            
            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            
            if (areaX > areaY) {
                Console.WriteLine("Maior área: X");
            }
            else {
                Console.WriteLine("Maior área: Y");
            }   

                /*
                //Estrutura Repetitiva (for)

                Console.Write("Quantos numeros ira digitar? ");
                int n = int.Parse(Console.ReadLine());

                int soma = 0;

                for (int i = 1; i <= n; i++) {
                    Console.Write($"Digite valor #{i}: ");
                    int valor = int.Parse(Console.ReadLine());
                    soma += valor;
                }

                Console.WriteLine($"Soma: {soma}");

                //Estrutura Repetitiva (While)

                /*
                            double raiz = 1;

                            while (raiz > 0) {

                                Console.Write("Digite um numero para ver a raiz quadrada [Ou um numero negativo para sair]: ");
                                raiz = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                                if (raiz > 0) {
                                    Console.WriteLine($"Raiz: {Math.Sqrt(raiz).ToString("F3", CultureInfo.InvariantCulture)}");
                                }
                                else {
                                    Console.WriteLine("Fim");
                                }
                            }
                */

                //Debugging
                /*

                            Teclas

                             * F9 - Marca/Desmarca breakingpoint (onde começa o debug)
                             * F5 - Inicia/Continua o debug
                             * F10 - Executa passo a passo (pula as funções)
                             * F11 - Executa passo a passo (entra nas funções)
                             * SHIFT + F11 - Sai do metodo em execução
                             * SHIFT + F5 - Para o debug

                            Janelas

                             * Watch - Expressões personalizadas
                             * Autos - Expressões detectadas pelo VS
                             * Locals - Variaveis Locais




                //Funções (sintaxe)

                            Console.WriteLine("Digite 3 numeros: ");
                            int n1 = int.Parse(Console.ReadLine());
                            int n2 = int.Parse(Console.ReadLine());
                            int n3 = int.Parse(Console.ReadLine());

                            int resultado = Maior(n1, n2, n3);  //Função no final da pagina

                            Console.WriteLine($"Maior: {resultado}");




                //Estrutura Condicional (if-else)


                            Console.Write("Qual a hora atual: ");
                            int hora = int.Parse(Console.ReadLine());

                            if (hora < 12) {
                                Console.WriteLine("Bom dia");
                            }
                            else if (hora < 18) {
                                Console.WriteLine("Boa tarde");
                            }
                            else {
                                Console.WriteLine("Boa noite");
                            }


                            Console.Write("Digite um numero inteiro: ");
                            int n1 = int.Parse(Console.ReadLine());

                            if (n1 % 2 == 0) {
                                Console.WriteLine($"O numero {n1} é par");
                            }
                            else {
                                Console.WriteLine($"O numero {n1} é impar");
                            }
                /*


                //Operadores Lógicos
                /*
                            bool e = 2 > 3 && 4 != 5;   //False
                            bool ou = 2 > 3 || 4 != 5;  //True
                            bool nao = !(2 > 3) && 4 != 5;  //True

                            Console.WriteLine(e);
                            Console.WriteLine(ou);
                            Console.WriteLine(nao);
                */


                //Operadores comparativos

                /*
                            > maior
                            < menor
                            >= maior ou igual
                            <= menor ou igual
                            == igual
                            != diferente
                */


                //Entrada de Dados

                /*
                            Console.Write("Nome: ");
                            string nome = Console.ReadLine();

                            Console.Write("Sexo: ");
                            char sexo = char.Parse(Console.ReadLine());

                            Console.Write("Idade: ");
                            int idade = int.Parse(Console.ReadLine());

                            Console.Write("Altura: ");
                            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.WriteLine($"Nome: {nome}, idade: {idade}, sexo: {sexo}, Altura: {altura}");

                            Console.WriteLine("Digite seu nome, idade e altura (mesma linha, separado por espaço)");
                            string[] dados = Console.ReadLine().Split(' ');

                            string nome2 = dados[0];
                            int idade2 = int.Parse(dados[1]);
                            double altura2 = double.Parse(dados[2]);

                            Console.WriteLine($"seu nome é {nome2}, tem {idade2} anos e {altura2.ToString("F2", CultureInfo.InvariantCulture)}m de altura!");

                            Console.Write("Seu nome: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine($"Ola, {nome}");
                            Console.WriteLine("-------------");

                            Console.Write("Digite algo 1: ");
                            string x = Console.ReadLine();
                            Console.Write("Digite algo 2: ");
                            string y = Console.ReadLine();
                            Console.Write("Digite algo 3: ");
                            string z = Console.ReadLine();
                            Console.WriteLine($"{x}, {y}, {z}");
                            Console.WriteLine("-------------");

                            Console.WriteLine("Testando comando Split");
                            Console.Write("Digite palavras separando por espaço: ");
                            string[] vet = Console.ReadLine().Split(' ');
                            string p1 = vet[0];
                            string p2 = vet[1];
                            string p3 = vet[2];

                            Console.WriteLine($"{p1}, {p2}, {p3}");
                */

                //Operadores aritméticos
                /*
                            int n1 = 3 + 4 * 2;
                            Console.WriteLine(n1);

                            int n2 = (3 + 4) * 2;
                            Console.WriteLine(n2);

                            int n3 = 17 % 3;
                            Console.WriteLine(n3);

                            double n4 = 10.0 / 8;       //tem que colocar o '.0' para entender que é um double
                            Console.WriteLine(n4);

                            double a = 1.0, b = -3.0, c = -4;

                            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

                            double resultado = (-b + Math.Sqrt(delta)) / (2.0 * a);

                            Console.WriteLine(resultado);
                */


                //Conversão implicita e casting

                /*
                            float x = 4.5f;
                            double y = x; //aceita normalmente

                            Console.WriteLine(y);
                            double a = 5.3;

                            float b = (float)a; //força a variavel para aceitar a outra
                            Console.WriteLine(b);

                            int c = (int)a; //força para aceitar o inteiro mesmo perdendo informação
                            Console.WriteLine(c);

                            int d = 5;
                            int e = 2;

                            double resultado = (double)d / e;
                            Console.WriteLine(resultado);
                */


                //Operadores de Atribuição
                /*
                            int a = 10;
                            Console.WriteLine(a);

                            int b = a++;
                            Console.WriteLine(b);

                            int c = ++a;
                            Console.WriteLine(c); 

                            a += 2;
                            Console.WriteLine(a);

                            a *= 3;
                            Console.WriteLine(a);

                            a++;
                            Console.WriteLine(a);

                            string s = "ABC";
                            Console.WriteLine(s);

                            s += "DEF";
                            Console.WriteLine(s);
                */



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
                /*
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
                */



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

        static int Maior(int a, int b, int c) {
            
            if (a > b && a > c) {
                return a;
            }
            else if (b > c) {
                return b;
            }
            else {
                return c;
            }

        }
    }
}