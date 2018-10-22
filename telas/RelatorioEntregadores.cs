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
    public partial class RelatorioEntregadores : Form {
        int hojeDia;
        int hojeMes;
        int hojeAno;
        public RelatorioEntregadores(int hojeDia, int hojeMes, int hojeAno) {
            this.hojeDia = hojeDia;
            this.hojeMes = hojeMes;
            this.hojeAno = hojeAno;
            InitializeComponent();
        }

        private void RelatorioEntregadores_Load(object sender, EventArgs e) {
            ListViewItem item;
            double somaValores=0;
            foreach (Entregador entregador in Program.listaEntregadores) {
                item = new ListViewItem(entregador.nome);
                item.SubItems.Add(entregador.listaPedidosEntreguesHoje.Count + "");
                foreach (Pedido pedido in entregador.listaPedidosEntreguesHoje) {
                    somaValores += pedido.valorTotal();
                }
                item.SubItems.Add(somaValores.ToString("F2"));
                item.SubItems.Add((0.05 * somaValores).ToString("F2"));
                listView.Items.Add(item);
            }

            
        }
    }
}
