using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete {
    class Entregador {
        
        public int codigo { get; set; }
        public string nome { get; set; }
        public string placaDoVeiculo { get; set; }
        public bool ocupado { get; set; }
        public int codigoPedidoEntrega { get; set; }
        public double comissao { get; set; }
        public List<Pedido> listaPedidosEntreguesHoje { get; set; }

        public Entregador(int codigo, string nome, string placaDoVeiculo) {
            ocupado = false;
            this.codigo = codigo;
            this.nome = nome;
            this.placaDoVeiculo = placaDoVeiculo;
            comissao = 0;
            listaPedidosEntreguesHoje = new List<Pedido>();
        }

        public override string ToString() {
            string s = "Entregador de código " + codigo + ":{0}{0}"
                + "\tnome: " + nome + "{0}"
                + "\tplaca: " + placaDoVeiculo + "{0}"
                + "\tcomissao: " + comissao.ToString("F2") + "{0}";

            if (this.ocupado) {
                s = s + "\tocupado = sim" + "{0}"
                    + "\tcodigo do pedido a ser entregue: " + codigoPedidoEntrega;
            }
            else {
                s = s + "\tocupado = não";
            }

            return s;

        }
    }
}
