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
    public partial class MostrarPedidosList : Form {
        public MostrarPedidosList() {
            InitializeComponent();
        }

        private void MostrarPedidosList_Load(object sender, EventArgs e) {
            ListViewItem item;
            foreach (Pedido pedido in Program.listaPedidos) {
                item = new ListViewItem(pedido.codigo + "");
                item.SubItems.Add(pedido.cliente.nome);
                item.SubItems.Add(pedido.dateTimePedido + "");
                if (pedido.situacao) {
                    item.SubItems.Add("atendido");
                }
                else {
                    item.SubItems.Add("pendente");
                }
                item.SubItems.Add(pedido.valorTotal().ToString("F2"));

                if (pedido.cheque == null) {
                    item.SubItems.Add("não");
                    item.SubItems.Add("-");
                    item.SubItems.Add("-");
                    item.SubItems.Add("-");
                    item.SubItems.Add("-");
                }
                else {
                    item.SubItems.Add("Sim");
                    item.SubItems.Add(pedido.cheque.numero + "");
                    item.SubItems.Add(pedido.cheque.conta + "");
                    item.SubItems.Add(pedido.cheque.agencia + "");
                    item.SubItems.Add(pedido.cheque.banco);
                }

                listView.Items.Add(item);
            }
        }

        private void todosBotao_Click(object sender, EventArgs e) {
            listView.Items.Clear();
            ListViewItem item;
            foreach (Pedido pedido in Program.listaPedidos) {
                item = new ListViewItem(pedido.codigo + "");
                item.SubItems.Add(pedido.cliente.nome);
                item.SubItems.Add(pedido.dateTimePedido + "");
                if (pedido.situacao) {
                    item.SubItems.Add("atendido");
                }
                else {
                    item.SubItems.Add("pendente");
                }
                item.SubItems.Add(pedido.valorTotal().ToString("F2"));
                listView.Items.Add(item);
            }
        }

        private void pendentesBotao_Click(object sender, EventArgs e) {
            listView.Items.Clear();
            ListViewItem item;
            foreach (Pedido pedido in Program.listaPedidos) {
                if (!pedido.situacao) {
                    item = new ListViewItem(pedido.codigo + "");
                    item.SubItems.Add(pedido.cliente.nome);
                    item.SubItems.Add(pedido.dateTimePedido + "");
                    if (pedido.situacao) {
                        item.SubItems.Add("atendido");
                    }
                    else {
                        item.SubItems.Add("pendente");
                    }
                    item.SubItems.Add(pedido.valorTotal().ToString("F2"));
                    listView.Items.Add(item);
                }
            }
        }

        private void entreguesBotao_Click(object sender, EventArgs e) {
            listView.Items.Clear();
            ListViewItem item;
            foreach (Pedido pedido in Program.listaPedidos) {
                if (pedido.situacao) {
                    item = new ListViewItem(pedido.codigo + "");
                    item.SubItems.Add(pedido.cliente.nome);
                    item.SubItems.Add(pedido.dateTimePedido + "");
                    if (pedido.situacao) {
                        item.SubItems.Add("atendido");
                    }
                    else {
                        item.SubItems.Add("pendente");
                    }
                    item.SubItems.Add(pedido.valorTotal().ToString("F2"));
                    listView.Items.Add(item);
                }
            }
        }

        private void mostrarDetalheBotao_Click(object sender, EventArgs e) {
            int pos = Auxiliar.identificaPosicaoPedido(int.Parse(codigoDetalhePedidoTextBox.Text));
            DetalhesPedido janelaDetalhesPedido = new DetalhesPedido(pos);
            janelaDetalhesPedido.ShowDialog();
        }
    }
}
