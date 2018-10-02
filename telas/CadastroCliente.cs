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
    public partial class CadastroCliente : Form {
        public CadastroCliente() {
            InitializeComponent();
            codigoClienteCadastroTextBox.Text = Convert.ToString(Auxiliar.defineCodigoCliente());
        }

        private void button1_Click(object sender, EventArgs e) {
            int codigo = int.Parse(codigoClienteCadastroTextBox.Text);
            string nome = nomeCadastroClienteTextBox.Text;
            string telefone = telefoneCadastroClienteTextBox.Text;
            string endereco = enderecoCadastroClienteTextBox.Text;
            string referencia = referenciaCadastroClienteTextBox.Text;

            Cliente clienteCadastrado = new Cliente(codigo ,nome, telefone, endereco, referencia);
            Program.listaClientes.Add(clienteCadastrado);

            this.Close();
        }

        private void CadastroCliente_Load(object sender, EventArgs e) {

        }
    }
}
