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
    public partial class MostrarCliente : Form {
        public MostrarCliente() {
            InitializeComponent();
        }

        private void MostrarCliente_Load(object sender, EventArgs e) {
            string s = "";
            for (int i = 0; i < Program.listaClientes.Count; i++) {
                s += Program.listaClientes[i].ToString();
                s += "{0}{0}";

                s = string.Format(s, Environment.NewLine);
                textBox1.Text = s;
                textBox1.ScrollBars = ScrollBars.Vertical;
            }
        }
    }
}
