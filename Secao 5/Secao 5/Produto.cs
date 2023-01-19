using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores_this_sobrecarga_encapsulamento {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;
        
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public double ValorTotalEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return "Produto: " + Nome + "\r\nPreço: $" + Preco.ToString("F2",CultureInfo.InvariantCulture) + "\r\nQuantidade: " + Quantidade;

        }
    }
}
