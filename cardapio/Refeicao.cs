using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardapio {
    class Refeicao : Lanchonete.ItemCardapio {
        public string categoria { get; private set; }
        public Refeicao(string nome, double preco, int codigo) : base(nome, preco, codigo) {
            this.categoria = "refeicao";
        }

        
    }
}