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
    public partial class RelatorioItensVendidos : Form {
        int hojeDia;
        int hojeMes;
        int hojeAno;
        public RelatorioItensVendidos(int hojeDia, int hojeMes, int hojeAno) {
            this.hojeDia = hojeDia;
            this.hojeMes = hojeMes;
            this.hojeAno = hojeAno;
            InitializeComponent();
        }

        private void RelatorioItensVendidos_Load(object sender, EventArgs e) {

            dataTextBox.Text = hojeDia + "/" + hojeMes + "/" + hojeAno;

            //lista para guardar vetores nos quais a primeira posição registra o codigo de um produto vendido
            //e a segundo posicao armazena a quantidade deste ItemCardapio
            List<int[]> listaUnidades = new List<int[]>();

            ListViewItem item;
            foreach (Pedido pedido in Program.listaPedidos) {
                //verifica se o pedido é de hoje
                if (pedido.data.Day == hojeDia &&
                    pedido.data.Month == hojeMes &&
                    pedido.data.Year == hojeAno) {
                    //verifica se o pedido foi entregue
                    if (pedido.situacao) {
                        //preenche a lista com os vetores [codigo][quantidade]
                        foreach (ItemPedido itemPedido in pedido.listaItensPedidos) {

                            int codigo = itemPedido.item.codigo;
                            int pos = listaUnidades.FindIndex(x => x[0] == codigo);

                            if (pos == -1) {
                                int[] v = new int[2];
                                v[0] = codigo;
                                v[1] = itemPedido.qtd;
                                listaUnidades.Add(v);
                            }
                            else {
                                listaUnidades[pos][1] += itemPedido.qtd;
                            }
                        }
                    }
                }
            }
            //preenche formulario de acordo com a lista preenchida acima, identificando produtos pelo codigo e
            //passando suas quantidades
            for (int i = 0; i < listaUnidades.Count; i++) {
                int codigo = listaUnidades[i][0];
                item = new ListViewItem(codigo + "");
                string nome = Auxiliar.identificaItem(codigo).nome;
                item.SubItems.Add(nome);
                int unidades = listaUnidades[i][1];
                item.SubItems.Add(unidades + "");
                if (unidades >= 5) {
                    item.SubItems.Add("sim");
                }
                else {
                    item.SubItems.Add("não");
                }
                listView.Items.Add(item);
            }
        }
    }
}
