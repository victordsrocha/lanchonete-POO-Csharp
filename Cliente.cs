using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete {
    class Cliente {

        public int codigo { get; private set; }
        public string nome { get; private set; }
        public string endereco { get; private set; }
        public string telefone { get; private set; }
        public string referencia { get; private set; }
        public bool ativo { get; set; }
        public int devolucoes { get; set; }

        public Cliente(int codigo, string nome, string endereco, string telefone, string referencia) {
            this.codigo = codigo;
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;
            this.referencia = referencia;
            this.ativo = true;
            devolucoes = 0;
        }

        
    }
}
