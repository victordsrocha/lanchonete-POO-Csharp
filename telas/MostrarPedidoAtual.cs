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
    public partial class MostrarPedidoAtual : Form {
        public MostrarPedidoAtual() {
            InitializeComponent();
        }

        private void MostrarPedidoAtual_Load(object sender, EventArgs e) {
            

            string s = Program.listaPedidos[Program.listaPedidos.Count - 1].ToString();
            s = string.Format(s, Environment.NewLine);
            textBox1.Text = s;
            textBox1.ScrollBars = ScrollBars.Vertical;

        }
    }
}
