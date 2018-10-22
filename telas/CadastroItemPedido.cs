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
    public partial class CadastroItemPedido : Form {

        int pos;

        public CadastroItemPedido(int pos) {
            this.pos = pos;
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e) {

            int codigo = int.Parse(codigoTextBox.Text);
            ItemCardapio instanciaItemCardapio = Auxiliar.identificaItem(codigo);

            int qtd = int.Parse(quantidadeTextBox.Text);


            nomeTextBox.Text = instanciaItemCardapio.nome;
            categoriaTextBox.Text = instanciaItemCardapio.categoria;
            valorUniTextBox.Text = Convert.ToString(instanciaItemCardapio.preco.ToString("F2"));
            ValorQtdTextBox.Text = Convert.ToString((instanciaItemCardapio.preco * qtd).ToString("F2"));
            if (instanciaItemCardapio is cardapio.Bebida) {
                estoqueTextBox.Text = Convert.ToString(Auxiliar.identificaEstoque(codigo));
            }
            else {
                estoqueTextBox.Text = "-";
            }
            
            if (instanciaItemCardapio is cardapio.Lanche) {
                categoriaTextBox.Text = "lanche";
            }
            else if (instanciaItemCardapio is cardapio.Refeicao) {
                categoriaTextBox.Text = "refeicao";
            }
            else if (instanciaItemCardapio is cardapio.Bebida) {
                categoriaTextBox.Text = "bebida";
            }
            else if (instanciaItemCardapio is cardapio.Sobremesa) {
                categoriaTextBox.Text = "sobremesa";
            }


        }

        private void CadastroItemPedido_Load(object sender, EventArgs e) {

        }

        private void Confirmarbutton_Click(object sender, EventArgs e) {
            int codigo = int.Parse(codigoTextBox.Text);
            ItemCardapio instanciaItemCardapio = Auxiliar.identificaItem(codigo);
            int qtd = int.Parse(quantidadeTextBox.Text);

            if (instanciaItemCardapio is cardapio.Bebida) {
                if (qtd <= Auxiliar.identificaEstoque(codigo)) {
                    ItemPedido instanciaItemPedido = new ItemPedido(instanciaItemCardapio, qtd);
                    //Program.listaPedidos[Program.listaPedidos.Count - 1].itens.Add(instanciaItemPedido);
                    Program.listaPedidos[pos].itens.Add(instanciaItemPedido);
                    this.Close();
                }
                else {
                    MessageBox.Show("Estoque insuficiente!");
                }
            }
            else {
                ItemPedido instanciaItemPedido = new ItemPedido(instanciaItemCardapio, qtd);
                //Program.listaPedidos[Program.listaPedidos.Count - 1].itens.Add(instanciaItemPedido);
                Program.listaPedidos[pos].itens.Add(instanciaItemPedido);
                this.Close();
            }

        }
    }
}

