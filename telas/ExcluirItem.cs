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
    public partial class ExcluirItem : Form {

        int pos;

        public ExcluirItem(int pos) {
            this.pos = pos;
            InitializeComponent();
        }

        private void ExcluirItem_Load(object sender, EventArgs e) {
            ListViewItem item;
            int i = 0;
            foreach (ItemPedido itemPedido in Program.listaPedidos[pos].itens) {
                i++;
                item = new ListViewItem(Convert.ToString(i));
                item.SubItems.Add(itemPedido.item.nome);
                item.SubItems.Add(itemPedido.qtd + "");
                item.SubItems.Add(itemPedido.subTotal() + "");
                listView.Items.Add(item);
            }
        }

        private void excluirBotao_Click(object sender, EventArgs e) {
            int id = int.Parse(IdTextBox.Text);

            if (Program.listaPedidos[pos].itens[id - 1].item is cardapio.Bebida) {
                string nomeBebidaRepos = Program.listaPedidos[pos].itens[id - 1].item.nome;
                int qtdBebidaRepos = Program.listaPedidos[pos].itens[id - 1].qtd;
                int codigoBebidaRepos = Program.listaPedidos[pos].itens[id - 1].item.codigo;

                MessageBox.Show(qtdBebidaRepos + " " + nomeBebidaRepos + " voltaram para o estoque!");

                int posBebida = Program.listaBebida.FindIndex(x => x.codigo == codigoBebidaRepos);
                cardapio.Bebida bebida = (cardapio.Bebida)Program.listaBebida[posBebida];
                bebida.estoque += qtdBebidaRepos;
                Program.listaBebida[posBebida] = bebida;

                Program.listaPedidos[pos].itens.RemoveAt(id - 1);
            }
            else {
                Program.listaPedidos[pos].itens.RemoveAt(id - 1);
            }
            

            listView.Items.Clear();
            ListViewItem item;
            int i = 0;
            foreach (ItemPedido itemPedido in Program.listaPedidos[pos].itens) {
                i++;
                item = new ListViewItem(Convert.ToString(i));
                item.SubItems.Add(itemPedido.item.nome);
                item.SubItems.Add(itemPedido.qtd + "");
                item.SubItems.Add(itemPedido.subTotal() + "");
                listView.Items.Add(item);
            }
        }
    }
}
