using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Classe {
    internal class Conversor_Moeda {

        public static double DolarParaReal (double cotacao, double dolar) {
            return (cotacao + (cotacao * 0.06)) * dolar;
        }


    }
}
