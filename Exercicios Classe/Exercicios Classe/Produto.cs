using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Classe {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
        }

        public void AdcionarProdutos(int quantidade) {
            Quantidade = Quantidade+ quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade = (Quantidade - quantidade);
        }

        public override string ToString() {
            return "Nome: " + Nome + ", R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", Total: R$" + ValorTotalEmEstoque();
        }

    }
}
