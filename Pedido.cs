using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete {
    class Pedido {

        public DateTime data { get; private set; }
        public bool situacao { get; set; }
        public Cliente cliente { get; private set; }
        public List<ItemPedido> listaItensPedidos { get; set; }
        public int codigo { get; private set; }
        public Cheque cheque { get; set; }


        public Pedido(Cliente cliente, DateTime dateTimePedido) {
            this.cliente = cliente;
            situacao = false;
            this.data = dateTimePedido;
            listaItensPedidos = new List<ItemPedido>();
            codigo = Auxiliar.defineCodigoPedido();
        }

        public double valorTotal() {
            double soma = 0.0;
            for (int i = 0; i < listaItensPedidos.Count; i++) {
                soma = soma + listaItensPedidos[i].subTotal();
            }
            return soma;
        }

        public override string ToString() {
            string s = "Pedido " + this.codigo + ":{0}";
            s = s + "Cliente: " + cliente.nome + " (cod.: " + cliente.codigo + "){0}";
            s = s + "Data: " + data + "{0}{0}";
            if (this.situacao) {
                s = s + "Situação: Entregue" +"{0}{0}";
            }
            else {
                s = s + "Situação: Pendente" + "{0}{0}";
            }
            for (int i = 0; i < listaItensPedidos.Count; i++) {
                s = s + listaItensPedidos[i].ToString() + "{0}{0}";
            }
            s = s + "valor total do pedido " + this.codigo + ": R$ " + valorTotal().ToString("F2");
            return s;
        }

    }
}
