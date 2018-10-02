using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lanchonete;

namespace Lanchonete.telas {
    public partial class CadastroProduto : Form {

        public string categoriaCadastro { get; set; }

        public CadastroProduto(string categoriaCadastro) {
            this.categoriaCadastro = categoriaCadastro;
            InitializeComponent();
        }

        private void CadastroProduto_Load(object sender, EventArgs e) {
            categoriaCadastro_textBox.Text = categoriaCadastro;
            codigoCadastro_textBox.Text = Convert.ToString(Auxiliar.defineCodigoProduto(categoriaCadastro));
        }

        private void okBotaoCadastro_Click(object sender, EventArgs e) {
            if (categoriaCadastro_textBox.Text == "lanche") {
                string nome = nomeCadastro_textBox.Text;
                double preco = double.Parse(precoCadastro_textBox.Text);
                int codigo = int.Parse(codigoCadastro_textBox.Text);
                ItemCardapio P = new cardapio.Lanche(nome, preco, codigo);
                Program.listaLanche.Add(P);
            }
            else if (categoriaCadastro_textBox.Text == "refeicao") {
                string nome = nomeCadastro_textBox.Text;
                double preco = double.Parse(precoCadastro_textBox.Text);
                int codigo = int.Parse(codigoCadastro_textBox.Text);
                ItemCardapio P = new cardapio.Refeicao(nome, preco, codigo);
                Program.listaRefeicao.Add(P);
            }
            else if (categoriaCadastro_textBox.Text == "bebida") {
                string nome = nomeCadastro_textBox.Text;
                double preco = double.Parse(precoCadastro_textBox.Text);
                int codigo = int.Parse(codigoCadastro_textBox.Text);
                Quantidade janelaQuantidade = new Quantidade();
                janelaQuantidade.ShowDialog();
                int qtd = janelaQuantidade.quantidade;
                ItemCardapio P = new cardapio.Bebida(nome, preco, codigo, qtd);
                Program.listaBebida.Add(P);
            }
            else if (categoriaCadastro_textBox.Text == "sobremesa") {
                string nome = nomeCadastro_textBox.Text;
                double preco = double.Parse(precoCadastro_textBox.Text);
                int codigo = int.Parse(codigoCadastro_textBox.Text);
                ItemCardapio P = new cardapio.Lanche(nome, preco, codigo);
                Program.listaSobremesa.Add(P);
            }
            this.Close();


            
        }
    }
}
