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
            CardapioCompleto novaJanela = new CardapioCompleto();
            novaJanela.ShowDialog();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e) {
            CadastroCliente janelaCadastroCliente = new CadastroCliente();
            janelaCadastroCliente.ShowDialog();
        }

        private void mostrarClientesToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarCliente janelaMostrarCliente = new MostrarCliente();
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
            CadastroItemPedido janelaCadastroItemPedido = new CadastroItemPedido();
            janelaCadastroItemPedido.ShowDialog();
        }

        private void iniciarPedidoButton_Click(object sender, EventArgs e) {
            int codigoIniciado = int.Parse(codigoClienteTextBox.Text);
            if (codigoIniciado <= Program.listaClientes.Count && codigoIniciado >= 1) {
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
                MessageBox.Show("Digite um código válido de cliente");
                
            }
        }

        private void atualizaValorTextButton_Click(object sender, EventArgs e) {
            int codigo = int.Parse(codigoPedidoTextBox.Text);
            valorPedidoTextBox.Text = Auxiliar.identificaPedido(codigo).valorTotal().ToString("F2");
        }

        private void visualizarPedidoTextButton_Click(object sender, EventArgs e) {
            MostrarPedidoAtual janelaMostrarPedidoAtual = new MostrarPedidoAtual();
            janelaMostrarPedidoAtual.ShowDialog();
        }

        private void ConfirmarPedidoButton_Click(object sender, EventArgs e) {
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
            Program.listaPedidos.RemoveAt(pos);
        }

        private void nãoEntreguesToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarPedidos janelaMostrarPedidos = new MostrarPedidos();
            janelaMostrarPedidos.ShowDialog();
        }
    }
}
