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
    public partial class RelatorioPedidosDoDia : Form {

        int hojeDia;
        int hojeMes;
        int hojeAno;

        public RelatorioPedidosDoDia(int hojeDia, int hojeMes, int hojeAno) {
            this.hojeDia = hojeDia;
            this.hojeMes = hojeMes;
            this.hojeAno = hojeAno;
            InitializeComponent();
        }

        private void RelatorioPedidosDoDia_Load(object sender, EventArgs e) {

            //preenche data de hoje
            dataTextBox.Text = hojeDia + "/" + hojeMes + "/" + hojeAno;

            ListViewItem item;
            foreach (Pedido pedido in Program.listaPedidos) {

                //verifica se o pedido é de hoje
                if (pedido.dateTimePedido.Day == hojeDia &&
                    pedido.dateTimePedido.Month == hojeMes &&
                    pedido.dateTimePedido.Year == hojeAno) {

                    item = new ListViewItem(pedido.cliente.nome + "");
                    item.SubItems.Add(pedido.cliente.telefone);
                    item.SubItems.Add(Auxiliar.data(pedido.dateTimePedido));
                    item.SubItems.Add(Auxiliar.hora(pedido.dateTimePedido));
                    item.SubItems.Add(pedido.valorTotal().ToString("F2"));
                    listView.Items.Add(item);
                }
            }
        }

        
    }
}
