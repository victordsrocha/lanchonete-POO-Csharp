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
    public partial class DetalhesPedido : Form {

        int pos;

        public DetalhesPedido(int pos) {
            this.pos = pos;
            InitializeComponent();
        }

        private void DetalhesPedido_Load(object sender, EventArgs e) {
            Pedido pedido = Program.listaPedidos[pos];
            CodigotextBox.Text = pedido.codigo+"";
            DatatextBox.Text = pedido.dateTimePedido + "";
            NometextBox.Text = pedido.cliente.nome;
            CodigoClientetextBox.Text = pedido.cliente.codigo + "";
            ValorTotaltextBox.Text = pedido.valorTotal().ToString("F2");

            ListViewItem item;
            foreach (ItemPedido itemPedido in pedido.itens) {
                item = new ListViewItem(itemPedido.item.codigo + "");
                item.SubItems.Add(itemPedido.item.nome);
                item.SubItems.Add(Auxiliar.identificaCategoria(itemPedido.item.codigo));
                item.SubItems.Add(itemPedido.item.preco.ToString("F2"));
                item.SubItems.Add(itemPedido.qtd+"");
                item.SubItems.Add(itemPedido.subTotal().ToString("F2"));
                listView.Items.Add(item);
            }
        }
    }
}
