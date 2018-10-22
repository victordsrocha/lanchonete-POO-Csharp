using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete {
    class Pedido {

        public DateTime dateTimePedido { get; set; }
        public bool situacao { get; set; }
        public Cliente clientePedido { get; set; }
        public List<ItemPedido> itens { get; set; }
        public int codigo { get; set; }


        public Pedido(Cliente cliente, DateTime dateTimePedido) {
            this.clientePedido = cliente;
            situacao = false;
            this.dateTimePedido = dateTimePedido;
            itens = new List<ItemPedido>();
            codigo = Auxiliar.defineCodigoPedido();
        }

        public double valorTotal() {
            double soma = 0.0;
            for (int i = 0; i < itens.Count; i++) {
                soma = soma + itens[i].subTotal();
            }
            return soma;
        }

        public override string ToString() {
            string s = "Pedido " + this.codigo + ":{0}";
            s = s + "Cliente: " + clientePedido.nome + " (cod.: " + clientePedido.codigo + "){0}";
            s = s + "Data: " + dateTimePedido + "{0}{0}";
            if (this.situacao) {
                s = s + "Situação: Entregue" +"{0}{0}";
            }
            else {
                s = s + "Situação: Pendente" + "{0}{0}";
            }
            for (int i = 0; i < itens.Count; i++) {
                s = s + itens[i].ToString() + "{0}{0}";
            }
            s = s + "valor total do pedido " + this.codigo + ": R$ " + valorTotal().ToString("F2");
            return s;
        }

    }
}
