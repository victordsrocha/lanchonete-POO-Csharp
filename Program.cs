using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lanchonete.telas;

namespace Lanchonete {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static int numeroPedido = 0;
        public static List<Pedido> listaPedidos = new List<Pedido>();
        public static List<Cliente> listaClientes = new List<Cliente>();
        public static List<Entregador> listaEntregadores = new List<Entregador>();
        public static List<ItemCardapio> listaLanche = new List<ItemCardapio>();
        public static List<ItemCardapio> listaRefeicao = new List<ItemCardapio>();
        public static List<ItemCardapio> listaBebida = new List<ItemCardapio>();
        public static List<ItemCardapio> listaSobremesa = new List<ItemCardapio>();

        [STAThread]
        static void Main() {
            //Clientes cadastrados
            listaClientes.Add(new Cliente(1, "Victor Rocha", "Rua Joao Regino", "32712248", "Próximo ao Shopping X"));
            listaClientes.Add(new Cliente(2, "Mabel Coruja", "Rua das Corujas", "12345678", "Próximo à biblioteca"));

            //Entregadores cadastrados
            listaEntregadores.Add(new Entregador(1,"Joao Entregador", "abc123"));

            //Produtos cadastrados
            listaLanche.Add(new cardapio.Lanche("pastel de queijo", 10.50, 101));
            listaLanche.Add(new cardapio.Lanche("pastel de carne", 12.50, 102));
            listaLanche.Add(new cardapio.Lanche("pastel de chocolate", 15.50, 103));
            listaLanche.Add(new cardapio.Lanche("coxinha de frango", 6.00, 104));

            listaRefeicao.Add(new cardapio.Refeicao("arroz e peixe", 21.50, 201));
            listaRefeicao.Add(new cardapio.Refeicao("arroz e carne", 20.00, 202));

            listaBebida.Add(new cardapio.Bebida("lata de coca-cola", 4.50, 301, 20));
            listaBebida.Add(new cardapio.Bebida("lata de pepsi", 4.00, 302, 25));

            listaSobremesa.Add(new cardapio.Sobremesa("pudim", 4.00, 401));
            listaSobremesa.Add(new cardapio.Sobremesa("brigadeiro", 3.00, 402));



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Lanchonete.telas.Hunger());
        }
    }
}
