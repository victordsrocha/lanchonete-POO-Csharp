using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete {
    class ItemPedido {
        public ItemCardapio item { get; set; }
        public int qtd { get; set; }

        public ItemPedido(ItemCardapio item, int qtd) {
            this.item = item;
            this.qtd = qtd;
        }

        public double subTotal() {
            return item.preco * qtd;
        }

    }
}
