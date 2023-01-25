using System;
using System.Globalization;

namespace Exercicio_Seção_5 {
    internal class Conta {

        public int NumeroConta { get; private set; }
        public string Nome { get; set;}
        public double Saldo { get; private set; }
        
        public Conta (int numeroConta, string nome) {
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = 0;
        }

        public Conta(int numeroConta, string nome, double depositoInicial) : this(numeroConta, nome) {
            Deposito(depositoInicial);
        }

        public void Deposito(double deposito) {
            Saldo = Saldo + deposito;
        }

        public void Saque(double saque) {
            Saldo = Saldo - saque - 5;
        }

        public override string ToString() {
            return "Conta: " + NumeroConta + ", Titular: " + Nome + ", Saldo: $" + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
