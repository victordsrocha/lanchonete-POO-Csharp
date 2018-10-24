using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete.telas {
    public partial class Hunger : Form {
        public Hunger() {
            InitializeComponent();
        }

        //carrega tela principal
        private void Hunger_Load(object sender, EventArgs e) {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy  -  HH:mm";
        }

        //cadastro de novo lanche
        private void lancheToolStripMenuItem_Click(object sender, EventArgs e) {
            CadastroProduto novaJanela = new CadastroProduto("lanche");
            novaJanela.ShowDialog();
        }

        //cadastro de novo refeicao
        private void refeicaoToolStripMenuItem_Click(object sender, EventArgs e) {
            CadastroProduto novaJanela = new CadastroProduto("refeicao");
            novaJanela.ShowDialog();
        }

        //cadastro de novo bebida
        private void bebidaToolStripMenuItem_Click(object sender, EventArgs e) {
            CadastroProduto novaJanela = new CadastroProduto("bebida");
            novaJanela.ShowDialog();
        }

        //cadastro de novo sobremesa
        private void sobremesaToolStripMenuItem_Click(object sender, EventArgs e) {
            CadastroProduto novaJanela = new CadastroProduto("sobremesa");
            novaJanela.ShowDialog();
        }

        //mostrar cardapio
        private void completoToolStripMenuItem_Click(object sender, EventArgs e) {
            /*
            CardapioCompleto novaJanela = new CardapioCompleto();
            novaJanela.ShowDialog();
            */
            CardapioCompletoList janelaCardapioCompletoList = new CardapioCompletoList();
            janelaCardapioCompletoList.ShowDialog();
        }

        //abrir janela de cadastro de novo cliente
        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e) {
            CadastroCliente janelaCadastroCliente = new CadastroCliente();
            janelaCadastroCliente.ShowDialog();
        }

        //abrir janela para mostrar clientes
        private void mostrarClientesToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarClienteList janelaMostrarCliente = new MostrarClienteList();
            janelaMostrarCliente.ShowDialog();
        }

        //abrir janela para cadastro de entregador
        private void cadastrarEntregadorToolStripMenuItem_Click(object sender, EventArgs e) {
            CadastroEntregador janelaCadastroEntregador = new CadastroEntregador();
            janelaCadastroEntregador.ShowDialog();
        }

        //abrir janela para mostrar entregadores
        private void mostrarEntregadoresToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarEntregadores janelaMostrarEntregadores = new MostrarEntregadores();
            janelaMostrarEntregadores.ShowDialog();
        }

        //abre janela para incluir itens no pedido
        private void CadastroItemPedidoButton_Click(object sender, EventArgs e) {
            int pos = Auxiliar.identificaPosicaoPedido(int.Parse(codigoPedidoTextBox.Text));
            CadastroItemPedido janelaCadastroItemPedido = new CadastroItemPedido(pos);
            janelaCadastroItemPedido.ShowDialog();
        }

        //inicia um novo pedido
        private void iniciarPedidoButton_Click(object sender, EventArgs e) {
            //verifica se codigo de cliente é coerente
            try {
                int codigoIniciado = int.Parse(codigoClienteTextBox.Text);
                if (codigoIniciado <= Program.listaClientes.Count && codigoIniciado >= 1) {
                    //verifica se cliente esta ativo
                    if (Program.listaClientes[codigoIniciado - 1].ativo) {

                        //armazena informações datetime do momento em que foi criado o pedido
                        dateTimePicker1.Value = DateTime.Now;
                        dateTimePicker1.Refresh();
                        int ano = dateTimePicker1.Value.Year;
                        int mes = dateTimePicker1.Value.Month;
                        int dia = dateTimePicker1.Value.Day;
                        int hora = dateTimePicker1.Value.Hour;
                        int minuto = dateTimePicker1.Value.Minute;
                        int segundo = dateTimePicker1.Value.Second;
                        DateTime datetimeIniciado = new DateTime(ano, mes, dia, hora, minuto, segundo);

                        //instancia do cliente deste pedido
                        Cliente clientePedidoIniciado = Auxiliar.identificaCliente(codigoIniciado);

                        //construtor pedido
                        Pedido pedidoIniciado = new Pedido(clientePedidoIniciado, datetimeIniciado);
                        //armazena pedido na lista de pedidos
                        Program.listaPedidos.Add(pedidoIniciado);
                        //mostra codigo do pedido na janela principal
                        codigoPedidoTextBox.Text = Convert.ToString(pedidoIniciado.codigo);

                        //liberando botoes de edição do pedido
                        CadastrarItensPedidoTextButton.Enabled = true;
                        visualizarPedidoTextButton.Enabled = true;
                        atualizaValorTextButton.Enabled = true;
                        ConfirmarPedidoButton.Enabled = true;
                        cancelarPedidoTextButton.Enabled = true;

                        //bloqueando botoes de inicio de pedido
                        iniciarPedidoButton.Enabled = false;
                        codigoClienteTextBox.Enabled = false;
                    }
                    else {
                        MessageBox.Show("Este cliente foi desativado!");
                    }
                }
                else {
                    MessageBox.Show("Digite um código válido de cliente");
                }
            }
            catch {
                MessageBox.Show("Dados inválidos!");
            }
        }

        //atualiza valor do pedido atual no mostrador da tela principal
        //nao consegui fazer esse mostrador ser atualizado "automaticamente"
        //gostaria de fazer ele ser atualizado quando a janela de adicionar itens fosse fechada
        //mas nao aprendi como fazer um form acessar outro
        private void atualizaValorTextButton_Click(object sender, EventArgs e) {
            int codigo = int.Parse(codigoPedidoTextBox.Text);
            valorPedidoTextBox.Text = Auxiliar.identificaPedido(codigo).valorTotal().ToString("F2");
        }

        //abre janela para mostrar detalhes do pedido atual
        private void visualizarPedidoTextButton_Click(object sender, EventArgs e) {
            int pos = Auxiliar.identificaPosicaoPedido(int.Parse(codigoPedidoTextBox.Text));
            DetalhesPedido janelaDetalhesPedido = new DetalhesPedido(pos);
            janelaDetalhesPedido.ShowDialog();
        }

        //botao de confirmação de pedido
        private void ConfirmarPedidoButton_Click(object sender, EventArgs e) {

            //identifica se o pedido está vazio
            Pedido pedido = Auxiliar.identificaPedido(int.Parse(codigoPedidoTextBox.Text));
            if (pedido.itens.Count == 0) {
                MessageBox.Show("Não é possível criar um pedido vazio");
            }
            else {
                //adiciona um no contador de pedidos pendentes
                contadorPedidosPendentes.Text = (int.Parse(contadorPedidosPendentes.Text) + 1) + "";

                valorPedidoTextBox.Text = "";
                codigoPedidoTextBox.Text = "";
                codigoClienteTextBox.Text = "";

                //bloqueando botoes de edição de pedido
                CadastrarItensPedidoTextButton.Enabled = false;
                visualizarPedidoTextButton.Enabled = false;
                atualizaValorTextButton.Enabled = false;
                ConfirmarPedidoButton.Enabled = false;
                cancelarPedidoTextButton.Enabled = false;

                //liberando botoes de inicio de pedido
                iniciarPedidoButton.Enabled = true;
                codigoClienteTextBox.Enabled = true;
            }
        }

        //cancelar atual cadastramento de pedido
        private void cancelarPedidoTextButton_Click(object sender, EventArgs e) {
            valorPedidoTextBox.Text = "";
            codigoPedidoTextBox.Text = "";
            codigoClienteTextBox.Text = "";

            //bloqueando botoes de edição de pedido
            CadastrarItensPedidoTextButton.Enabled = false;
            visualizarPedidoTextButton.Enabled = false;
            atualizaValorTextButton.Enabled = false;
            ConfirmarPedidoButton.Enabled = false;
            cancelarPedidoTextButton.Enabled = false;

            //liberando botoes de inicio de pedido
            iniciarPedidoButton.Enabled = true;
            codigoClienteTextBox.Enabled = true;

            //identifica posicao do pedido sendo criado atualmente dentro da lista listaPedidos
            int pos = Program.listaPedidos.Count - 1;

            //retornar bebidas para o estoque!
            for (int i = 0; i < Program.listaPedidos[pos].itens.Count; i++) {
                if (Program.listaPedidos[pos].itens[i].item is cardapio.Bebida) {
                    int qtdBebidaRepos = Program.listaPedidos[pos].itens[i].qtd;
                    int codigoBebidaRepos = Program.listaPedidos[pos].itens[i].item.codigo;
                    int posBebida = Program.listaBebida.FindIndex(x => x.codigo == codigoBebidaRepos);
                    cardapio.Bebida bebida = (cardapio.Bebida)Program.listaBebida[posBebida];
                    bebida.estoque += qtdBebidaRepos;
                    Program.listaBebida[posBebida] = bebida;
                }
            }

            //remove pedido da lista listaPedidos
            Program.listaPedidos.RemoveAt(pos);

            //remove uma unidade do global que define a numeracao de pedidos
            Program.numeroPedido -= 1;
        }

        //abre janela de mostrar pedidos
        private void nãoEntreguesToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarPedidosList janelaMostrarPedidos = new MostrarPedidosList();
            janelaMostrarPedidos.ShowDialog();
        }

        //cancela um pedido ja cadastrado a partir do codigo informado
        private void CancelarPedidoCadastradoButton_Click(object sender, EventArgs e) {

            //verifica se o valor colocado no campo de codigo esta coerente
            try {
                int codigo = int.Parse(codigoPedidoAlteracaoTextBox.Text);
                int pos = Program.listaPedidos.FindIndex(x => x.codigo == codigo);

                //se o pedido com este codigo existe
                if (pos != -1) {
                    //verifica se o pedido ainda não foi entregue
                    if (!Program.listaPedidos[pos].situacao) {
                        //retornar bebidas para o estoque!
                        for (int i = 0; i < Program.listaPedidos[pos].itens.Count; i++) {
                            if (Program.listaPedidos[pos].itens[i].item is cardapio.Bebida) {
                                string nomeBebidaRepos = Program.listaPedidos[pos].itens[i].item.nome;
                                int qtdBebidaRepos = Program.listaPedidos[pos].itens[i].qtd;
                                int codigoBebidaRepos = Program.listaPedidos[pos].itens[i].item.codigo;

                                MessageBox.Show(qtdBebidaRepos + " " + nomeBebidaRepos + " voltaram para o estoque!");

                                int posBebida = Program.listaBebida.FindIndex(x => x.codigo == codigoBebidaRepos);
                                cardapio.Bebida bebida = (cardapio.Bebida)Program.listaBebida[posBebida];
                                bebida.estoque += qtdBebidaRepos;
                                Program.listaBebida[posBebida] = bebida;
                            }
                        }

                        //remove pedido da listaPedidos
                        Program.listaPedidos.RemoveAt(pos);
                        //reduz em uma unidade o contador de pedidos pendentes
                        contadorPedidosPendentes.Text = (int.Parse(contadorPedidosPendentes.Text) - 1) + "";
                        MessageBox.Show("Pedido " + codigo + " deletado");
                    }
                    else {
                        MessageBox.Show("Este pedido já foi entregue!");
                    }
                }
                else {
                    MessageBox.Show("Código de pedido inválido!");
                }
            }
            catch {
                MessageBox.Show("Dados inválidos!");
            }
        }

        //alterar pedido cadastrado
        private void AlterarPedidoBotao_Click(object sender, EventArgs e) {
            //verifica se o codigo informado é coerente
            try {
                int pos = Auxiliar.identificaPosicaoPedido(int.Parse(codigoPedidoAlteracaoTextBox.Text));


                Pedido pedidoTeste = Program.listaPedidos[pos];
                //verifica se o pedido já foi entregue
                if (!pedidoTeste.situacao) {
                    //caso o pedido não tenha sido entregue, libera botoes de edição de pedido
                    incluirBotao.Enabled = true;
                    excluirBotao.Enabled = true;
                    ConcluirAlterar.Enabled = true;
                    codigoPedidoAlteracaoTextBox.Enabled = false;
                }
                else {
                    MessageBox.Show("Este pedido já foi entregue!");
                }
            }
            catch{
                MessageBox.Show("Código de pedido inválido!");
            }


        }

        //finaliza alteração em pedido
        private void ConcluirAlterar_Click(object sender, EventArgs e) {
            incluirBotao.Enabled = false;
            excluirBotao.Enabled = false;
            ConcluirAlterar.Enabled = false;
            codigoPedidoAlteracaoTextBox.Enabled = true;
        }

        //botao para abrir janela de inclusão de novos itens no pedido
        private void incluirBotao_Click(object sender, EventArgs e) {
            int pos = Auxiliar.identificaPosicaoPedido(int.Parse(codigoPedidoAlteracaoTextBox.Text));
            CadastroItemPedido janelaCadastroItemPedido = new CadastroItemPedido(pos);
            janelaCadastroItemPedido.ShowDialog();
        }

        //botao para abrir janela de exclusão de itens no pedido
        //foi implementado de forma que só é possível excluir o ItemPedido completo
        //Exemplo: ItemPedido = 2 unidades de pastel
        //Não há como exluir somente 1 pastel!!!
        //É necessário excluir ambos (ItemPedido completo) e em seguida incluir 1 pastel (novo ItemPedido)!
        private void excluirBotao_Click(object sender, EventArgs e) {
            int pos = Auxiliar.identificaPosicaoPedido(int.Parse(codigoPedidoAlteracaoTextBox.Text));
            ExcluirItem janelaExcluirItem = new ExcluirItem(pos);
            janelaExcluirItem.ShowDialog();
        }

        //verifica se há pedidos pendentes e libera botoes de cadastro de entrega
        private void cadastrarEntregaBotao_Click(object sender, EventArgs e) {
            if (int.Parse(contadorPedidosPendentes.Text) > 0) {
                codigoPedidoCadastroEntregaTextBox.Enabled = true;
                codigoEntregadorCadastroEntregaTextBox.Enabled = true;
                enviarEntregadorBotao.Enabled = true;
                cancelarCadastroEntregaBotao.Enabled = true;
            }
            else {
                MessageBox.Show("Não há pedidos pendentes");
            }
        }

        //cancela cadastro de entrega
        private void cancelarCadastroEntregaBotao_Click(object sender, EventArgs e) {
            codigoPedidoCadastroEntregaTextBox.Enabled = false;
            codigoEntregadorCadastroEntregaTextBox.Enabled = false;
            enviarEntregadorBotao.Enabled = false;
            cancelarCadastroEntregaBotao.Enabled = false;
            codigoEntregadorCadastroEntregaTextBox.Clear();
            codigoPedidoCadastroEntregaTextBox.Clear();
        }

        //envia entregador que esteja com um pedido!
        private void enviarEntregadorBotao_Click(object sender, EventArgs e) {
            //estava aprendendo a usar o try e ficou essa bagunça
            try {
                int codEntreg = int.Parse(codigoEntregadorCadastroEntregaTextBox.Text);
                int codPedido = int.Parse(codigoPedidoCadastroEntregaTextBox.Text);
                int pos = Auxiliar.identificaPosicaoPedido(codPedido);

                try {
                    Pedido pedidoTeste = Program.listaPedidos[pos];

                    try {
                        Entregador entregadorTeste = Program.listaEntregadores[codEntreg - 1];

                        if (entregadorTeste.ocupado) {
                            MessageBox.Show("O entregador já está ocupado!");
                        }
                        else {
                            Program.listaEntregadores[codEntreg - 1].codigoPedidoEntrega = codPedido;
                            Program.listaEntregadores[codEntreg - 1].ocupado = true;
                            cancelarCadastroEntregaBotao_Click(sender, e);
                        }
                    }
                    catch {
                        MessageBox.Show("Código de entregador inválido");
                    }

                }
                catch {
                    MessageBox.Show("Código de pedido inválido");
                }
            }
            catch {
                MessageBox.Show("Dados inválidos!");
            }

        }

        //libera botoes de sucesso ou falha da entrega
        private void registrarSituacaoBotao_Click(object sender, EventArgs e) {
            codigoEntregadorRegSituacaoTextBox.Enabled = true;
            sucessoRegistrarSituacaoBotao.Enabled = true;
            falhaRegistrarSituacaoBotao.Enabled = true;
        }

        //botao para registrar falha da entrega
        private void falhaRegistrarSituacaoBotao_Click(object sender, EventArgs e) {
            try {
                int codEntreg = int.Parse(codigoEntregadorRegSituacaoTextBox.Text);
                int codPedido = Program.listaEntregadores[codEntreg - 1].codigoPedidoEntrega;

                int pos = Auxiliar.identificaPosicaoPedido(codPedido);

                //adiciona uma devolução para o cliente deste pedido
                Program.listaPedidos[pos].cliente.devolucoes += 1;
                //se devoluções =3 entao cliente se torna desativado
                if (Program.listaPedidos[pos].cliente.devolucoes == 3) {
                    Program.listaPedidos[pos].cliente.ativo = false;
                }

                //libera entregador
                Program.listaEntregadores[codEntreg - 1].codigoPedidoEntrega = 0;
                Program.listaEntregadores[codEntreg - 1].ocupado = false;

                //bloqueia botoes de registro de sucesso/falha na entrega
                codigoEntregadorRegSituacaoTextBox.Enabled = false;
                sucessoRegistrarSituacaoBotao.Enabled = false;
                falhaRegistrarSituacaoBotao.Enabled = false;
                codigoEntregadorRegSituacaoTextBox.Clear();
            }
            catch {
                MessageBox.Show("Dados inválidos");
            }
        }

        //botao de sucesso na entrega
        private void sucessoRegistrarSituacaoBotao_Click(object sender, EventArgs e) {
            try {
                

                int codEntreg = int.Parse(codigoEntregadorRegSituacaoTextBox.Text);
                int codPedido = Program.listaEntregadores[codEntreg - 1].codigoPedidoEntrega;

                int pos = Auxiliar.identificaPosicaoPedido(codPedido);

                //pedido é adicionado a lista de pedidos ENTREGUES do entregador
                Program.listaEntregadores[codEntreg - 1].listaPedidosEntregues.Add(Auxiliar.identificaPedido(codPedido));

                //entregador é liberado
                Program.listaEntregadores[codEntreg - 1].codigoPedidoEntrega = 0;
                Program.listaEntregadores[codEntreg - 1].ocupado = false;

                //situacao do pedido é setada como true
                Program.listaPedidos[pos].situacao = true;

                //bloqueia botoes de registro de entrega
                codigoEntregadorRegSituacaoTextBox.Enabled = false;
                sucessoRegistrarSituacaoBotao.Enabled = false;
                falhaRegistrarSituacaoBotao.Enabled = false;
                codigoEntregadorRegSituacaoTextBox.Clear();

                //retira uma unidade do mostrador de pedidos pendentes
                contadorPedidosPendentes.Text = (int.Parse(contadorPedidosPendentes.Text) - 1) + "";

                //abre a pergunta "pagamento em cheque" passando o objeto pedido como parametro
                PerguntaCheque janelaPerguntaCheque = new PerguntaCheque(pos);
                janelaPerguntaCheque.ShowDialog();
            }
            catch {
                MessageBox.Show("Dados inválidos!");
            }
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e) {
            //
        }

        //botao para abrir relatorio de pedidos do dia
        private void pedidosDoDiaToolStripMenuItem_Click(object sender, EventArgs e) {
            RelatorioPedidosDoDia janelaRelatorioPedidosDoDia = new RelatorioPedidosDoDia(dateTimePicker1.Value.Day,
                                                   dateTimePicker1.Value.Month,
                                                   dateTimePicker1.Value.Year);
            janelaRelatorioPedidosDoDia.ShowDialog();
        }

        //botao para abrir relatorio diario de entregadores
        private void entregadoresToolStripMenuItem_Click(object sender, EventArgs e) {
            RelatorioEntregadores janelaRelatorioEntregadores = new RelatorioEntregadores(dateTimePicker1.Value.Day,
                                                   dateTimePicker1.Value.Month,
                                                   dateTimePicker1.Value.Year);

            janelaRelatorioEntregadores.ShowDialog();
        }

        //botao para abrir relatorio de itens vendidos do dia
        private void itensVendidosToolStripMenuItem_Click(object sender, EventArgs e) {
            RelatorioItensVendidos janelaRelatorioItensVendidos = new RelatorioItensVendidos(
                dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
            janelaRelatorioItensVendidos.ShowDialog();
        }

        //botao para abrir menu de reativacao de cliente
        private void reativarClienteToolStripMenuItem_Click(object sender, EventArgs e) {
            ReativarCliente janelaReativarCliente = new ReativarCliente();
            janelaReativarCliente.ShowDialog();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e) {
            Ajuda janelaAjuda = new Ajuda();
            janelaAjuda.ShowDialog();
        }
    }
}
