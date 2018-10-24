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

        private void Hunger_Load(object sender, EventArgs e) {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy  -  HH:mm";
        }

        private void lancheToolStripMenuItem_Click(object sender, EventArgs e) {
            CadastroProduto novaJanela = new CadastroProduto("lanche");
            novaJanela.ShowDialog();
        }

        private void refeicaoToolStripMenuItem_Click(object sender, EventArgs e) {
            CadastroProduto novaJanela = new CadastroProduto("refeicao");
            novaJanela.ShowDialog();
        }

        private void bebidaToolStripMenuItem_Click(object sender, EventArgs e) {
            CadastroProduto novaJanela = new CadastroProduto("bebida");
            novaJanela.ShowDialog();
        }

        private void sobremesaToolStripMenuItem_Click(object sender, EventArgs e) {
            CadastroProduto novaJanela = new CadastroProduto("sobremesa");
            novaJanela.ShowDialog();
        }

        private void completoToolStripMenuItem_Click(object sender, EventArgs e) {
            /*
            CardapioCompleto novaJanela = new CardapioCompleto();
            novaJanela.ShowDialog();
            */
            CardapioCompletoList janelaCardapioCompletoList = new CardapioCompletoList();
            janelaCardapioCompletoList.ShowDialog();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e) {
            CadastroCliente janelaCadastroCliente = new CadastroCliente();
            janelaCadastroCliente.ShowDialog();
        }

        private void mostrarClientesToolStripMenuItem_Click(object sender, EventArgs e) {
            /*
            MostrarCliente janelaMostrarCliente = new MostrarCliente();
            janelaMostrarCliente.ShowDialog();
            */
            MostrarClienteList janelaMostrarCliente = new MostrarClienteList();
            janelaMostrarCliente.ShowDialog();
        }

        private void cadastrarEntregadorToolStripMenuItem_Click(object sender, EventArgs e) {
            CadastroEntregador janelaCadastroEntregador = new CadastroEntregador();
            janelaCadastroEntregador.ShowDialog();
        }

        private void mostrarEntregadoresToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarEntregadores janelaMostrarEntregadores = new MostrarEntregadores();
            janelaMostrarEntregadores.ShowDialog();
        }

        private void CadastroItemPedidoButton_Click(object sender, EventArgs e) {
            int pos = Auxiliar.identificaPosicaoPedido(int.Parse(codigoPedidoTextBox.Text));
            CadastroItemPedido janelaCadastroItemPedido = new CadastroItemPedido(pos);
            janelaCadastroItemPedido.ShowDialog();
        }

        private void iniciarPedidoButton_Click(object sender, EventArgs e) {
            try {
                int codigoIniciado = int.Parse(codigoClienteTextBox.Text);
                if (codigoIniciado <= Program.listaClientes.Count && codigoIniciado >= 1) {

                    if (Program.listaClientes[codigoIniciado - 1].ativo) {
                        dateTimePicker1.Value = DateTime.Now;
                        dateTimePicker1.Refresh();

                        int ano = dateTimePicker1.Value.Year;
                        int mes = dateTimePicker1.Value.Month;
                        int dia = dateTimePicker1.Value.Day;
                        int hora = dateTimePicker1.Value.Hour;
                        int minuto = dateTimePicker1.Value.Minute;
                        int segundo = dateTimePicker1.Value.Second;
                        DateTime datetimeIniciado = new DateTime(ano, mes, dia, hora, minuto, segundo);



                        Cliente clientePedidoIniciado = Auxiliar.identificaCliente(codigoIniciado);

                        Pedido pedidoIniciado = new Pedido(clientePedidoIniciado, datetimeIniciado);
                        Program.listaPedidos.Add(pedidoIniciado);

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

        private void atualizaValorTextButton_Click(object sender, EventArgs e) {
            int codigo = int.Parse(codigoPedidoTextBox.Text);
            valorPedidoTextBox.Text = Auxiliar.identificaPedido(codigo).valorTotal().ToString("F2");
        }


        private void visualizarPedidoTextButton_Click(object sender, EventArgs e) {
            int pos = Auxiliar.identificaPosicaoPedido(int.Parse(codigoPedidoTextBox.Text));
            DetalhesPedido janelaDetalhesPedido = new DetalhesPedido(pos);
            janelaDetalhesPedido.ShowDialog();
        }

        private void ConfirmarPedidoButton_Click(object sender, EventArgs e) {

            Pedido pedido = Auxiliar.identificaPedido(int.Parse(codigoPedidoTextBox.Text));
            if (pedido.itens.Count == 0) {
                MessageBox.Show("Não é possível criar um pedido vazio");
            }
            else {

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


            Program.listaPedidos.RemoveAt(pos);

            Program.numeroPedido -= 1;
        }

        private void nãoEntreguesToolStripMenuItem_Click(object sender, EventArgs e) {
            //MostrarPedidos janelaMostrarPedidos = new MostrarPedidos();
            MostrarPedidosList janelaMostrarPedidos = new MostrarPedidosList();
            janelaMostrarPedidos.ShowDialog();
        }

        private void CancelarPedidoCadastradoButton_Click(object sender, EventArgs e) {


            try {
                int codigo = int.Parse(codigoPedidoAlteracaoTextBox.Text);
                int pos = Program.listaPedidos.FindIndex(x => x.codigo == codigo);

                if (pos != -1) {
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


                        Program.listaPedidos.RemoveAt(pos);
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

        private void AlterarPedidoBotao_Click(object sender, EventArgs e) {
            try {
                int pos = Auxiliar.identificaPosicaoPedido(int.Parse(codigoPedidoAlteracaoTextBox.Text));


                Pedido pedidoTeste = Program.listaPedidos[pos];
                if (!pedidoTeste.situacao) {
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
                MessageBox.Show("Código de pedido inválido! \n\n");
            }


        }

        private void ConcluirAlterar_Click(object sender, EventArgs e) {
            incluirBotao.Enabled = false;
            excluirBotao.Enabled = false;
            ConcluirAlterar.Enabled = false;
            codigoPedidoAlteracaoTextBox.Enabled = true;
        }

        private void incluirBotao_Click(object sender, EventArgs e) {
            int pos = Auxiliar.identificaPosicaoPedido(int.Parse(codigoPedidoAlteracaoTextBox.Text));
            CadastroItemPedido janelaCadastroItemPedido = new CadastroItemPedido(pos);
            janelaCadastroItemPedido.ShowDialog();
        }

        private void excluirBotao_Click(object sender, EventArgs e) {
            int pos = Auxiliar.identificaPosicaoPedido(int.Parse(codigoPedidoAlteracaoTextBox.Text));
            ExcluirItem janelaExcluirItem = new ExcluirItem(pos);
            janelaExcluirItem.ShowDialog();
        }

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

        private void cancelarCadastroEntregaBotao_Click(object sender, EventArgs e) {
            codigoPedidoCadastroEntregaTextBox.Enabled = false;
            codigoEntregadorCadastroEntregaTextBox.Enabled = false;
            enviarEntregadorBotao.Enabled = false;
            cancelarCadastroEntregaBotao.Enabled = false;
            codigoEntregadorCadastroEntregaTextBox.Clear();
            codigoPedidoCadastroEntregaTextBox.Clear();
        }

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

        private void registrarSituacaoBotao_Click(object sender, EventArgs e) {
            codigoEntregadorRegSituacaoTextBox.Enabled = true;
            sucessoRegistrarSituacaoBotao.Enabled = true;
            falhaRegistrarSituacaoBotao.Enabled = true;
        }

        private void falhaRegistrarSituacaoBotao_Click(object sender, EventArgs e) {
            try {
                int codEntreg = int.Parse(codigoEntregadorRegSituacaoTextBox.Text);
                int codPedido = Program.listaEntregadores[codEntreg - 1].codigoPedidoEntrega;

                int pos = Auxiliar.identificaPosicaoPedido(codPedido);

                Program.listaPedidos[pos].clientePedido.devolucoes += 1;
                if (Program.listaPedidos[pos].clientePedido.devolucoes == 3) {
                    Program.listaPedidos[pos].clientePedido.ativo = false;
                }

                Program.listaEntregadores[codEntreg - 1].codigoPedidoEntrega = 0;
                Program.listaEntregadores[codEntreg - 1].ocupado = false;

                codigoEntregadorRegSituacaoTextBox.Enabled = false;
                sucessoRegistrarSituacaoBotao.Enabled = false;
                falhaRegistrarSituacaoBotao.Enabled = false;
                codigoEntregadorRegSituacaoTextBox.Clear();
            }
            catch {
                MessageBox.Show("Dados inválidos");
            }
        }

        private void sucessoRegistrarSituacaoBotao_Click(object sender, EventArgs e) {
            try {
                

                int codEntreg = int.Parse(codigoEntregadorRegSituacaoTextBox.Text);
                int codPedido = Program.listaEntregadores[codEntreg - 1].codigoPedidoEntrega;

                int pos = Auxiliar.identificaPosicaoPedido(codPedido);

                //pedido é adicionado a lista de pedidos ENTREGUES do entregador
                Program.listaEntregadores[codEntreg - 1].listaPedidosEntregues.Add(Auxiliar.identificaPedido(codPedido));


                Program.listaEntregadores[codEntreg - 1].codigoPedidoEntrega = 0;
                Program.listaEntregadores[codEntreg - 1].ocupado = false;

                Program.listaPedidos[pos].situacao = true;


                codigoEntregadorRegSituacaoTextBox.Enabled = false;
                sucessoRegistrarSituacaoBotao.Enabled = false;
                falhaRegistrarSituacaoBotao.Enabled = false;
                codigoEntregadorRegSituacaoTextBox.Clear();
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

        private void pedidosDoDiaToolStripMenuItem_Click(object sender, EventArgs e) {
            RelatorioPedidosDoDia janelaRelatorioPedidosDoDia = new RelatorioPedidosDoDia(dateTimePicker1.Value.Day,
                                                   dateTimePicker1.Value.Month,
                                                   dateTimePicker1.Value.Year);
            janelaRelatorioPedidosDoDia.ShowDialog();
        }

        private void entregadoresToolStripMenuItem_Click(object sender, EventArgs e) {
            RelatorioEntregadores janelaRelatorioEntregadores = new RelatorioEntregadores(dateTimePicker1.Value.Day,
                                                   dateTimePicker1.Value.Month,
                                                   dateTimePicker1.Value.Year);

            janelaRelatorioEntregadores.ShowDialog();
        }

        private void itensVendidosToolStripMenuItem_Click(object sender, EventArgs e) {
            RelatorioItensVendidos janelaRelatorioItensVendidos = new RelatorioItensVendidos(
                dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
            janelaRelatorioItensVendidos.ShowDialog();
        }

        private void reativarClienteToolStripMenuItem_Click(object sender, EventArgs e) {
            ReativarCliente janelaReativarCliente = new ReativarCliente();
            janelaReativarCliente.ShowDialog();
        }
    }
}
