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
        public List<Pedido> pedidos { get; set; }

        public Entregador(int codigo, string nome, string placaDoVeiculo) {
            this.codigo = codigo;
            this.nome = nome;
            this.placaDoVeiculo = placaDoVeiculo;
            pedidos = new List<Pedido>();
        }

        public override string ToString() {
            return "Entregador de código " + codigo + ":{0}{0}"
                + "\tnome: " + nome + "{0}"
                + "\tplaca: " + placaDoVeiculo;

        }
    }
}
