using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete {
    abstract class ItemCardapio {

        public string nome { get; protected set; }
        public double preco { get; protected set; }
        public int codigo { get; set; }
        //foi preciso criar esse string devido as listas usarem ItemCardapio como tipo
        public string categoria;

        public ItemCardapio(string nome, double preco, int codigo) {
            this.nome = nome;
            this.preco = preco;
            this.codigo = codigo;
        }

        public override string ToString() {
            return "\t" + nome + ":" +
                "{0}{0}" +
                "\t\tcódigo: " + codigo + "{0}" +
                "\t\tpreço: R$ " + preco.ToString("F2");
        }
    }
}
