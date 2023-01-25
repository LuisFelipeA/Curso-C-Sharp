using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Seção_5 {
    internal class Conta {

        private int _numeroConta;
        public string Nome { get; set;}
        public double Saldo { get; private set; }
        
        public Conta (int numeroConta, string nome) {
            _numeroConta = numeroConta;
            Nome = nome;
            Saldo = 0;
        }

        public void Deposito(double deposito) {
            Saldo = Saldo + deposito;
        }

        public void Saque(double saque) {
            Saldo = Saldo - saque - 5;
        }

        public override string ToString() {
            return "Conta: " + _numeroConta + ", Titular: " + Nome + ", Saldo: $" + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
