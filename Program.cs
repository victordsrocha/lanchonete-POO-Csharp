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


        //valor global que define o numero do próximo pedido
        public static int numeroPedido = 0;

        //lista onde serão armazenados todos os objetos criados, facilitando a manipulação dos mesmos
        public static List<Pedido> listaPedidos = new List<Pedido>();
        public static List<Cliente> listaClientes = new List<Cliente>();
        public static List<Entregador> listaEntregadores = new List<Entregador>();

        //todos os itens de cardapio ficaram em listas com tipo ItemCardapio
        //percebi que isso não é necessário para esse contexto e acabou dificultando o código
        //não deu tempo de consertar
        public static List<ItemCardapio> listaLanche = new List<ItemCardapio>();
        public static List<ItemCardapio> listaRefeicao = new List<ItemCardapio>();
        public static List<ItemCardapio> listaBebida = new List<ItemCardapio>();
        public static List<ItemCardapio> listaSobremesa = new List<ItemCardapio>();

        [STAThread]
        static void Main() {
            //Clientes cadastrados
            listaClientes.Add(new Cliente(1, "Carl Sagan", "Rua Cosmos", "32645590", "Próximo ao observatório"));
            listaClientes.Add(new Cliente(2, "Alan Turing", "Rua Enigma", "36529976", "Próximo à base militar"));
            listaClientes.Add(new Cliente(3, "Machado de Assis", "Rua Dom Casmurro", "32879951", "Próximo à biblioteca"));
            listaClientes.Add(new Cliente(4, "Rainha Elizabeth", "palácio de buckingham", "31576683", "Próxima ao parlamento"));
            listaClientes.Add(new Cliente(5, "Seu Madruga", "Apartamento n.72 da vila", "32678841", "Próximo à venda"));

            //Entregadores cadastrados
            listaEntregadores.Add(new Entregador(1,"Joao Entregador", "ABC123"));
            listaEntregadores.Add(new Entregador(2, "Maria Entregadora", "XYZ987"));
            listaEntregadores.Add(new Entregador(3, "Juninho da Entrega", "NJS713"));

            //Produtos cadastrados
            listaLanche.Add(new cardapio.Lanche("pastel de queijo", 10.50, 101));
            listaLanche.Add(new cardapio.Lanche("pastel de carne", 12.50, 102));
            listaLanche.Add(new cardapio.Lanche("coxinha de frango", 6.00, 103));
            listaLanche.Add(new cardapio.Lanche("sanduíche de presunto", 5.00, 104));

            listaRefeicao.Add(new cardapio.Refeicao("espaguete carbonara", 21.50, 201));
            listaRefeicao.Add(new cardapio.Refeicao("espaguete bolonheza", 20.00, 202));

            listaBebida.Add(new cardapio.Bebida("lata de coca-cola", 4.50, 301, 20));
            listaBebida.Add(new cardapio.Bebida("lata de pepsi", 4.00, 302, 25));
            listaBebida.Add(new cardapio.Bebida("água sem gás", 2.00, 303, 10));

            listaSobremesa.Add(new cardapio.Sobremesa("pudim", 4.00, 401));
            listaSobremesa.Add(new cardapio.Sobremesa("brigadeiro", 3.00, 402));
            listaSobremesa.Add(new cardapio.Sobremesa("picolé", 2.50, 403));



            ////////////////
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Lanchonete.telas.Hunger());
        }
    }
}
