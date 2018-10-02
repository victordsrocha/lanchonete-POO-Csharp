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
    public partial class CadastroEntregador : Form {
        public CadastroEntregador() {
            InitializeComponent();
            codigoEntregadorCadastroTextBox.Text = Convert.ToString(Auxiliar.defineCodigoEntregador());
        }

        private void CadastroEntregador_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            int codigo = int.Parse(codigoEntregadorCadastroTextBox.Text);
            string nome = nomeEntregadorCadastroTextBox.Text;
            string placa = placaEntregadorCadastroTextBox.Text;

            Entregador entregadorCadastrado = new Entregador(codigo, nome, placa);
            Program.listaEntregadores.Add(entregadorCadastrado);

            this.Close();
        }
    }
}
