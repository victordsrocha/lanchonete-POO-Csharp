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
    public partial class PerguntaCheque : Form {

        int posPedido;

        public PerguntaCheque(int posPedido) {
            this.posPedido = posPedido;
            InitializeComponent();
        }

        private void PerguntaCheque_Load(object sender, EventArgs e) {
            
        }

        private void naoBotao_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void simBotao_Click(object sender, EventArgs e) {
            CadastroCheque janelaCadastroCheque = new CadastroCheque(posPedido);
            janelaCadastroCheque.ShowDialog();
            this.Close();
        }
    }
}
