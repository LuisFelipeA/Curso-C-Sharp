using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Classe {
    class Funcionario {

        public string Nome;
        public double Salario;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double aumento) {
            SalarioBruto = SalarioBruto + SalarioBruto * aumento/100;
        }

        public override string ToString() {
            return "Funcionario: " + Nome + ", $" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
