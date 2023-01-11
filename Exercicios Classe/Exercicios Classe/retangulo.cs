using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Classe {
    class retangulo {

        public double Altura;
        public double Base;

        public double Area() {
            return Base * Altura;
        }
    
        public double Perimetro() {
            return 2 * (Base + Altura);
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(Base,2) + Math.Pow(Altura, 2));
        }
    
    }
}
