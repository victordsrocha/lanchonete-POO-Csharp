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
    public partial class MostrarEntregadores : Form {
        public MostrarEntregadores() {
            InitializeComponent();
        }

        private void MostrarEntregadores_Load(object sender, EventArgs e) {
            string s = "";
            for (int i = 0; i < Program.listaEntregadores.Count; i++) {
                s += Program.listaEntregadores[i].ToString();
                s += "{0}{0}";

                s = string.Format(s, Environment.NewLine);
                textBox1.Text = s;
                textBox1.ScrollBars = ScrollBars.Vertical;
            }
        }
    }
}
