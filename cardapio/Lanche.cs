using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardapio {
    class Lanche : Lanchonete.ItemCardapio {


        public Lanche(string nome, double preco, int codigo) : base(nome, preco, codigo) {
            this.categoria = "lanche";
        }

    }
}
