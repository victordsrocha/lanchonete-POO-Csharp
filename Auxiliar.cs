﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete {
    class Auxiliar {

        //usado para atribuir codigo para novo produto criado
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

        //usado para definir codigo de novo cliente criado
        public static int defineCodigoCliente() {
            return Program.listaClientes.Count + 1;
        }

        //usado para definir codigo de novo pedido criado
        public static int defineCodigoPedido() {
            Program.numeroPedido += 1;
            return Program.numeroPedido;
        }

        //usado para definir codigo de novo entregador cadastrado
        public static int defineCodigoEntregador() {
            return Program.listaEntregadores.Count + 1;
        }

        //recebe codigo e retorna objeto cardapio correspondete
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

        //recebe codigo de uma bebida e retorna o estoque da mesma
        public static int identificaEstoque(int codigo) {
            int pos = Program.listaBebida.FindIndex(x => x.codigo == codigo);
            cardapio.Bebida B = (cardapio.Bebida)Program.listaBebida[pos];
            return B.estoque;
        }

        //recebe codigo de cliente e retorna o objeto Cliente correspondente
        public static Cliente identificaCliente(int codigo) {
            int pos = Program.listaClientes.FindIndex(x => x.codigo == codigo);
            Cliente C = Program.listaClientes[pos];
            return C;
        }

        //recebe codigo de pedido e retorna objeto Pedido correspondente
        public static Pedido identificaPedido(int codigo) {
            int pos = Program.listaPedidos.FindIndex(x => x.codigo == codigo);
            Pedido P = Program.listaPedidos[pos];
            return P;
        }

        //recebe codigo de pedido e retorna sua posição dentro da lista listaPedidos
        //não era necessário ter essa função
        //enquanto começava a criar esse codigo acreditava que era preciso alterar o objeto
        //manipulando-o dentro da lista
        //entendi que ao instanciar o mesmo novamente em outro local estarei apontando para o mesmo objeto
        //portanto poderia usar sempre a função anterior
        public static int identificaPosicaoPedido(int codigo) {
            int pos = Program.listaPedidos.FindIndex(x => x.codigo == codigo);
            return pos;
        }

        //retorna um datetime no formato dd/mm/yy
        public static string data(DateTime dateTime) {
            string dia = dateTime.Day + "/";
            string mes = dateTime.Month + "/";
            string ano = dateTime.Year + "";
            return dia + mes + ano;
        }

        //retorna um datetime no formato hh:mm:ss
        public static string hora(DateTime dateTime) {
            string hora = dateTime.Hour+":";
            string minutos = dateTime.Minute+":";
            string segundos = dateTime.Second + "";
            return hora + minutos + segundos;
        }

        //recebe codigo e retorna string categoria
        public static string identificaCategoria(int codigo) {
            if(codigo>=101 && codigo < 200) {
                return "lanche";
            }
            else if(codigo>=201 && codigo < 300) {
                return "refeição";
            }
            else if(codigo>=301 && codigo< 400) {
                return "bebida";
            }
            else if(codigo>=401 && codigo < 500) {
                return "sobremesa";
            }
            else {
                return "";
            }
        }
    }

}

