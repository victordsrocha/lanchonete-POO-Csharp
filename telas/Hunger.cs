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
    }
}
