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
    public partial class ReativarCliente : Form {
        public ReativarCliente() {
            InitializeComponent();
        }

        private void ReativarCliente_Load(object sender, EventArgs e) {

        }

        private void continuarBotao_Click(object sender, EventArgs e) {
            int codigo = int.Parse(codigoClienteReativarTextBox.Text);
            Cliente cliente = Auxiliar.identificaCliente(codigo);

            codigoClienteReativarTextBox.Enabled = false;
            continuarBotao.Enabled = false;

            NomeTextBox.Enabled = true;
            statusTextBox.Enabled = true;
            devolucoesTextBox.Enabled = true;
            reativarClienteBotao.Enabled = true;
            cancelarBotao.Enabled = true;

            NomeTextBox.Text = cliente.nome;

            if (cliente.ativo) {
                statusTextBox.Text = "ativo";
            }
            else {
                statusTextBox.Text = "desativado";
            }

            devolucoesTextBox.Text = cliente.devolucoes + "";
        }

        private void cancelarBotao_Click(object sender, EventArgs e) {

            codigoClienteReativarTextBox.Enabled = true;
            continuarBotao.Enabled = true;

            NomeTextBox.Enabled = false;
            statusTextBox.Enabled = false;
            devolucoesTextBox.Enabled = false;
            reativarClienteBotao.Enabled = false;
            cancelarBotao.Enabled = false;

            NomeTextBox.Clear();
            statusTextBox.Clear();
            devolucoesTextBox.Clear();

            codigoClienteReativarTextBox.Clear();
        }

        private void reativarClienteBotao_Click(object sender, EventArgs e) {
            int codigo = int.Parse(codigoClienteReativarTextBox.Text);
            Cliente cliente = Auxiliar.identificaCliente(codigo);
            cliente.ativo = true;
            cliente.devolucoes = 0;
            MessageBox.Show("O cliente foi reativado e suas devoluções voltaram para zero");
            this.Close();
        }
    }
}
