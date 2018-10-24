using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardapio {
    class Bebida : Lanchonete.ItemCardapio {

        public int estoque { get; set; }

        public Bebida(string nome, double preco, int codigo, int qtd ) : base(nome, preco, codigo) {
            this.estoque = qtd;
            this.categoria = "bebida";
        }

        public override string ToString() {
            return base.ToString()
                + "{0}\t\tQuantidade em estoque: " + estoque;
        }
    }
}