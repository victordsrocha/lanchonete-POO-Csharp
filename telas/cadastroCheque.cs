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
    public partial class CadastroCheque : Form {

        int posPedido;

        public CadastroCheque(int posPedido) {
            this.posPedido = posPedido;
            InitializeComponent();
        }

        private void CadastroCheque_Load(object sender, EventArgs e) {

        }

        private void okBotao_Click(object sender, EventArgs e) {

            if (!(bancoTextBox.Text == "")) {
                try {
                    int numero = int.Parse(numeroTextBox.Text);
                    int conta = int.Parse(contaTextBox.Text);
                    int agencia = int.Parse(agenciaTextBox.Text);
                    string banco = bancoTextBox.Text;
                    Pedido pedido = Program.listaPedidos[posPedido];


                    //atribui o cheque no pedido e o pedido no cheque
                    try {
                        Cheque cheque = new Cheque(numero, conta, agencia, banco, pedido);
                        pedido.cheque = cheque;
                        this.Close();
                    }
                    catch {
                        MessageBox.Show("Dados inválidos");
                    }
                }
                catch {
                    MessageBox.Show("Dados inválidos");
                }
            }
        }
    }
}
