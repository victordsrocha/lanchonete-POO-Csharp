using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete {
    class Pedido {

        public DateTime data { get; set; }
        public bool situacao { get; set; }
        public Cliente clientePedido { get; set; }
        public List<ItemPedido> itens { get; set; }


        public Pedido(Cliente cliente, int dia, int mes, int ano) {
            this.clientePedido = cliente;
            situacao = false;
            data = new DateTime(ano, mes, dia);
            itens = new List<ItemPedido>();
        }

        public double valorTotal() {
            double soma = 0.0;
            for (int i = 0; i < itens.Count; i++) {
                soma = soma + itens[i].subTotal();
            }
            return soma;
        }

    }
}
