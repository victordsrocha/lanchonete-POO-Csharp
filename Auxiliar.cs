using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete {
    class Auxiliar {

        public static int defineCodigoProduto(string categoria) {
            if (categoria == "lanche") {
                return Program.listaLanche.Count + 101;
            }
            else if (categoria == "refeicao") {
                return Program.listaRefeicao.Count + 201;
            }
            else if (categoria == "bebida") {
                return Program.listaBebida.Count + 301;
            }
            else if (categoria == "sobremesa") {
                return Program.listaSobremesa.Count + 401;
            }
            else {
                return 0;
            }
        }

        public static int defineCodigoCliente() {
            return Program.listaClientes.Count + 1;
        }

        public static int defineCodigoPedido() {
            Program.numeroPedido += 1;
            return Program.numeroPedido;
        }

        public static int defineCodigoEntregador() {
            return Program.listaEntregadores.Count + 1;
        }

        public static ItemCardapio identificaItem(int codigo) {
            if (codigo > 100 && codigo < 200) {
                int pos = Program.listaLanche.FindIndex(x => x.codigo == codigo);
                return Program.listaLanche[pos];
            }
            else if (codigo > 200 && codigo < 300) {
                int pos = Program.listaRefeicao.FindIndex(x => x.codigo == codigo);
                return Program.listaRefeicao[pos];
            }
            else if (codigo > 300 && codigo < 400) {
                int pos = Program.listaBebida.FindIndex(x => x.codigo == codigo);
                return Program.listaBebida[pos];
            }
            else if (codigo > 400 && codigo < 500) {
                int pos = Program.listaSobremesa.FindIndex(x => x.codigo == codigo);
                return Program.listaSobremesa[pos];
            }
            return null;
        }

        public static int identificaEstoque(int codigo) {
            int pos = Program.listaBebida.FindIndex(x => x.codigo == codigo);
            cardapio.Bebida B = (cardapio.Bebida)Program.listaBebida[pos];
            return B.estoque;
        }

        public static Cliente identificaCliente(int codigo) {
            int pos = Program.listaClientes.FindIndex(x => x.codigo == codigo);
            Cliente C = Program.listaClientes[pos];
            return C;
        }

        public static Pedido identificaPedido(int codigo) {
            int pos = Program.listaPedidos.FindIndex(x => x.codigo == codigo);
            Pedido P = Program.listaPedidos[pos];
            return P;
        }

    }

}

