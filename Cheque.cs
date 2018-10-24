using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete {

    class Cheque {

        public int numero { get; set; }
        public int conta { get; set; }
        public int agencia { get; set; }
        public string banco { get; set; }
        public Pedido pedido { get; set; }

        public Cheque(int numero, int conta, int agencia, string banco, Pedido pedido) {
            this.numero = numero;
            this.conta = conta;
            this.agencia = agencia;
            this.banco = banco;
            this.pedido = pedido;
        }
    }
}
