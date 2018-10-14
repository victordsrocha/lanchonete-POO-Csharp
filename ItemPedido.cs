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

            if(item is cardapio.Bebida) {
                cardapio.Bebida bebida = (cardapio.Bebida)item;
                bebida.estoque = bebida.estoque - this.qtd;
            }
        }

        public double subTotal() {
            return item.preco * qtd;
        }

        public override string ToString() {
            return "\t" + item.nome + ": ( " + qtd + " unidades)" +
                "{0}{0}" +
                "\t\tcódigo: " + item.codigo + "{0}" +
                "\t\tpreço unitário: R$ " + item.preco.ToString("F2") + "{0}" +
                "\t\tpreço " + qtd + " unidades: R$ " + subTotal().ToString("F2");
        }
    }
}
