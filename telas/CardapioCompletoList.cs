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
    public partial class CardapioCompletoList : Form {
        public CardapioCompletoList() {
            InitializeComponent();
        }

        private void bebidasBotao_Click(object sender, EventArgs e) {
            CardapioListViewBox.Items.Clear();
            ListViewItem item;
            foreach (cardapio.Bebida bebida in Program.listaBebida) {
                item = new ListViewItem(bebida.codigo+"");
                item.SubItems.Add("bebida");
                item.SubItems.Add(bebida.nome);
                item.SubItems.Add(bebida.preco.ToString("F2")+"");
                item.SubItems.Add(bebida.estoque+"");
                CardapioListViewBox.Items.Add(item);
            }
        }

        private void lanchesBotao_Click(object sender, EventArgs e) {
            CardapioListViewBox.Items.Clear();
            ListViewItem item;
            foreach (cardapio.Lanche lanche in Program.listaLanche) {
                item = new ListViewItem(lanche.codigo + "");
                item.SubItems.Add("lanche");
                item.SubItems.Add(lanche.nome);
                item.SubItems.Add(lanche.preco.ToString("F2") + "");
                item.SubItems.Add("-");
                CardapioListViewBox.Items.Add(item);
            }
        }

        private void refeicaoBotao_Click(object sender, EventArgs e) {
            CardapioListViewBox.Items.Clear();
            ListViewItem item;
            foreach (cardapio.Refeicao refeicao in Program.listaRefeicao) {
                item = new ListViewItem(refeicao.codigo + "");
                item.SubItems.Add("refeicao");
                item.SubItems.Add(refeicao.nome);
                item.SubItems.Add(refeicao.preco.ToString("F2") + "");
                item.SubItems.Add("-");
                CardapioListViewBox.Items.Add(item);
            }
        }

        private void sobremesaBotao_Click(object sender, EventArgs e) {
            CardapioListViewBox.Items.Clear();
            ListViewItem item;
            foreach (cardapio.Sobremesa sobremesa in Program.listaSobremesa) {
                item = new ListViewItem(sobremesa.codigo + "");
                item.SubItems.Add("sobremesa");
                item.SubItems.Add(sobremesa.nome);
                item.SubItems.Add(sobremesa.preco.ToString("F2") + "");
                item.SubItems.Add("-");
                CardapioListViewBox.Items.Add(item);
            }
        }

        private void cardapioCompletoBotao_Click(object sender, EventArgs e) {
            CardapioListViewBox.Items.Clear();
            ListViewItem item;
            foreach (cardapio.Lanche lanche in Program.listaLanche) {
                item = new ListViewItem(lanche.codigo + "");
                item.SubItems.Add("lanche");
                item.SubItems.Add(lanche.nome);
                item.SubItems.Add(lanche.preco.ToString("F2") + "");
                item.SubItems.Add("-");
                CardapioListViewBox.Items.Add(item);
            }
            foreach (cardapio.Refeicao refeicao in Program.listaRefeicao) {
                item = new ListViewItem(refeicao.codigo + "");
                item.SubItems.Add("refeicao");
                item.SubItems.Add(refeicao.nome);
                item.SubItems.Add(refeicao.preco.ToString("F2") + "");
                item.SubItems.Add("-");
                CardapioListViewBox.Items.Add(item);
            }
            foreach (cardapio.Bebida bebida in Program.listaBebida) {
                item = new ListViewItem(bebida.codigo + "");
                item.SubItems.Add("bebida");
                item.SubItems.Add(bebida.nome);
                item.SubItems.Add(bebida.preco.ToString("F2") + "");
                item.SubItems.Add(bebida.estoque + "");
                CardapioListViewBox.Items.Add(item);
            }
            foreach (cardapio.Sobremesa sobremesa in Program.listaSobremesa) {
                item = new ListViewItem(sobremesa.codigo + "");
                item.SubItems.Add("sobremesa");
                item.SubItems.Add(sobremesa.nome);
                item.SubItems.Add(sobremesa.preco.ToString("F2") + "");
                item.SubItems.Add("-");
                CardapioListViewBox.Items.Add(item);
            }
        }

        private void CardapioCompletoList_Load(object sender, EventArgs e) {
            cardapioCompletoBotao_Click(sender, e);
        }
    }
}
