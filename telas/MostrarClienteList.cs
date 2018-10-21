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
    public partial class MostrarClienteList : Form {
        public MostrarClienteList() {
            InitializeComponent();
        }

        private void MostrarClienteList_Load(object sender, EventArgs e) {
            ListViewItem item;
            foreach (Cliente cliente in Program.listaClientes) {
                item = new ListViewItem(cliente.codigo + "");
                item.SubItems.Add(cliente.nome);
                item.SubItems.Add(cliente.endereco);
                item.SubItems.Add(cliente.telefone);
                item.SubItems.Add(cliente.referencia);
                if (cliente.ativo) {
                    item.SubItems.Add("ativo");
                }
                else {
                    item.SubItems.Add("desativado");
                }
                listView.Items.Add(item);
            }
        }
    }
}
