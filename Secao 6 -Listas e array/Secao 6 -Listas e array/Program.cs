using System;
using System.Globalization;

namespace Secao_6__Listas_e_array {
    class Program {
        static void Main(string[] args) {
            /*
            Point p;
            p.x = 10;
            p.y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);


            double? x = null;
            double? y = 10.0;

            //mostra o valor da variavel ou valor default caso seja null
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //verifica se a variavel possui valor ou não
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue) {
                Console.WriteLine(x.Value);
            }
            else {
                Console.WriteLine("X is null");
            }
            if (y.HasValue) {
                Console.WriteLine(y.Value);
            }
            else {
                Console.WriteLine("Y is null");
            }

            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);*/
        

            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            for (int i = 0; i< n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i =0; i< n; i++) {
                sum += vect[i];
            }

            double avg = sum/ n;

            Console.WriteLine($"Altura Média: {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}