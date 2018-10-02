using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete {
    class Cliente {

        public int codigo { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string referencia { get; set; }
        public bool ativo { get; set; }

        public Cliente(int codigo, string nome, string endereco, string telefone, string referencia) {
            this.codigo = codigo;
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;
            this.referencia = referencia;
            this.ativo = true;
        }

        public string status() {
            if (ativo) {
                return "ativo";
            }
            else {
                return "desativado";
            }
        }

        public override string ToString() {
            return "Cliente de código " + codigo + ":{0}{0}"
                + "\tnome: " + nome + "{0}"
                + "\ttelefone: " + telefone + "{0}"
                + "\tendereço: " + endereco + "{0}"
                + "\treferência: " + referencia + "{0}"
                + "\tstatus: " + status();

        }
    }
}
