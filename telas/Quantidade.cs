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
    public partial class Quantidade : Form {

        public int quantidade { get; set; }

        public Quantidade() {
            InitializeComponent();
        }

        private void OkQuantidade_button_Click(object sender, EventArgs e) {
            this.quantidade = int.Parse(quantidade_textBox.Text);
            this.Close();
        }
    }
}
