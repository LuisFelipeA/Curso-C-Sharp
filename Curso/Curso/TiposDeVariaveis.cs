using System;

namespace Course {
    class TiposDeVariaveis {
        static void Main(string[] args) {

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

        }
    }
}