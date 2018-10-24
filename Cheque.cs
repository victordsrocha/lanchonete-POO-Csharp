using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete {

    class Cheque {

        public int numero { get; private set; }
        public int conta { get; private set; }
        public int agencia { get; private set; }
        public string banco { get; private set; }
        public Pedido pedido { get; private set; }

        public Cheque(int numero, int conta, int agencia, string banco, Pedido pedido) {
            this.numero = numero;
            this.conta = conta;
            this.agencia = agencia;
            this.banco = banco;
            this.pedido = pedido;
        }
    }
}
