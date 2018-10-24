using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardapio {
    class Sobremesa : Lanchonete.ItemCardapio {
        public string categoria { get; private set; }
        public Sobremesa(string nome, double preco, int codigo) : base(nome, preco, codigo) {
            this.categoria = "sobremesa";
        }

        
    }
}