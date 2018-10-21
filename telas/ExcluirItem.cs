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
            this.pos = pos - 1;
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
            Program.listaPedidos[pos].itens.RemoveAt(id - 1);

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
