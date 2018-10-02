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
    public partial class CardapioCompleto : Form {
        public CardapioCompleto() {
            InitializeComponent();
        }

        /*
        private void CardapioCompleto_Load(object sender, EventArgs e) {
            string s = "codigo\tcategoria\t\tnome\tpreco\tquantidade{0}";
            for (int i = 0; i < Program.listaLanche.Count; i++) {
                s += Program.listaLanche[i].ToString();
                s += "{0}";
            }
            for (int i = 0; i < Program.listaRefeicao.Count; i++) {
                s += Program.listaRefeicao[i].ToString();
                s += "{0}";
            }
            for (int i = 0; i < Program.listaSobremesa.Count; i++) {
                s += Program.listaSobremesa[i].ToString();
                s += "{0}";
            }
            for (int i = 0; i < Program.listaBebida.Count; i++) {
                s += Program.listaBebida[i].ToString();
                s += "{0}";
            }
            s = string.Format(s,Environment.NewLine);
            Cardapio_textBox.Text = s;
        }
        */

        private void CardapioCompleto_Load(object sender, EventArgs e) {
            string s1 = "Categoria Lanche:{0}{0}";
            for (int i = 0; i < Program.listaLanche.Count; i++) {
                s1 += Program.listaLanche[i].ToString();
                s1 += "{0}{0}";
            }

            string s2 = "Categoria Refeição:{0}{0}";
            for (int i = 0; i < Program.listaRefeicao.Count; i++) {
                s2 += Program.listaRefeicao[i].ToString();
                s2 += "{0}{0}";
            }

            string s3 = "Categoria Sobremesa:{0}{0}";
            for (int i = 0; i < Program.listaSobremesa.Count; i++) {
                s3 += Program.listaSobremesa[i].ToString();
                s3 += "{0}{0}";
            }

            string s4 = "Categoria Bebida:{0}{0}";
            for (int i = 0; i < Program.listaBebida.Count; i++) {
                s4 += Program.listaBebida[i].ToString();
                s4 += "{0}{0}";
            }

            s1 = string.Format(s1, Environment.NewLine);
            s2 = string.Format(s2, Environment.NewLine);
            s3 = string.Format(s3, Environment.NewLine);
            s4 = string.Format(s4, Environment.NewLine);

            Cardapio_textBox.Text = s1 + s2 + s3 + s4;
            Cardapio_textBox.ScrollBars = ScrollBars.Vertical;
        }
    }
}
