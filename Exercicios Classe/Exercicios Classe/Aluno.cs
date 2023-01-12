using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Classe {
    class Aluno {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public string Status() {
            if (NotaFinal() >= 60) {
                return "Aprovado";
            }
            else {
                return "Reprovado \r\nFaltaram " + (60-NotaFinal()).ToString("F2", CultureInfo.InvariantCulture) + " Pontos";
            }
        }
    }
}
