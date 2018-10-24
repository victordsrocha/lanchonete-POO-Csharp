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

            //preenche data de hoje
            dataTextBox.Text = hojeDia + "/" + hojeMes + "/" + hojeAno;

            ListViewItem item;
            //somaValores armazena o total dos valores das entregas para cada entregador
            double somaValores = 0;
            foreach (Entregador entregador in Program.listaEntregadores) {
                item = new ListViewItem(entregador.nome);

                // qtdEntregasJoje armazena a quantidade de entregas feitas hoje pelo entregador
                int qtdEntregasHoje = 0;

                //analisa cada pedido na lista de pedidos ja entregues de cada entregador
                foreach (Pedido pedido in entregador.listaPedidosEntregues) {
                    //verifica se a entrega é de hoje
                    if (pedido.dateTimePedido.Day == hojeDia &&
                    pedido.dateTimePedido.Month == hojeMes &&
                    pedido.dateTimePedido.Year == hojeAno) {
                        //incrementa os valores de qtdEntregasHoje e somaValores
                        qtdEntregasHoje++;
                        somaValores += pedido.valorTotal();
                    }
                }

                item.SubItems.Add(qtdEntregasHoje + "");
                item.SubItems.Add(somaValores.ToString("F2"));
                item.SubItems.Add((0.05 * somaValores).ToString("F2"));
                listView.Items.Add(item);
            }


        }
    }
}
