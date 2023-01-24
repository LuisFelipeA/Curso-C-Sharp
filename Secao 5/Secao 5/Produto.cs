using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores_this_sobrecarga_encapsulamento {
    internal class Produto {

        private string _nome;
        private double _preco;
        private int _quantidade;
        
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }



        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        public double GetPreco() {
            return _preco;
        }

        public int GetQuantidade() {
            return _quantidade;
        }

        public Produto(string nome, double preco) {
            _nome = nome;
            _preco = preco;
            _quantidade = 0;
        }


        public double ValorTotalEstoque() {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }

        public override string ToString() {
            return "Produto: " + _nome + "\r\nPreço: $" + _preco.ToString("F2",CultureInfo.InvariantCulture) + "\r\nQuantidade: " + _quantidade;

        }
    }
}
