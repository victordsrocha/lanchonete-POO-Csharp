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
    public partial class Ajuda : Form {
        public Ajuda() {
            InitializeComponent();
        }

        private void Ajuda_Load(object sender, EventArgs e) {
            string s = "";

            s += "Cadastros:{0}{0}" +
                "1. Use os menus no topo da janela principal para cadastrar novos itens ao cardápio, novos clientes, " +
                "e novos entregadores{0}";
            s += "2. No menu clientes é possível visualizar a situação de um cliente e o número de " +
                "devoluções em suas entregas. Também é possível reativar um cliente{0}";


            s += "{0}{0}Pedidos:{0}{0}";
            s += "1. Consultar código de cliente usando o menu cliente > mostrar clientes {0}";
            s += "2. Inserir código do cliente no campo 'código do cliente' na janela principal{0}";
            s += "3. Iniciar pedido{0}";
            s += "4. Usar o botão cadastrar itens no pedido para adicionar itens ao pedido{0}";
            s += "5. Inserir código do item pretendido e quantidade, usar o botão de consultar cardápio para " +
                "identificar código{0}";
            s += "6. Confirmar pedido{0}";
            s += "7. Após a confirmação, caso deseje cancelar ou alterar o pedido usar o campo da janela principal chamado " +
                "'Alterar ou cancelar pedidos cadastrados'{0}";
            s += "8. Cadastrar entrega{0}";
            s += "9. Usar menu entregador para verificar código de entregadores não ocupados e em seguida " +
                "adicionar o pedido e o entregador para a entrega na janela principal{0}";
            s += "10. Enviar entregador{0}";
            s += "11. Use o botão registrar situação da entrega para registrar se uma entrega foi realizada" +
                " com sucesso{0}";
            s += "12. Insira os dados do cheque de pagamento caso o pedido tenha sido pago com cheque{0}";

            s += "{0}{0}Relatórios{0}{0}";
            s += "1. No menu relatórios é possível gerar relatórios de itens, pedidos e entregadores para o " +
                "dia corrente, a partir das entregas realizadas com sucesso no dia corrente{0}";


            s = string.Format(s, Environment.NewLine);
            textBox.Text = s;
            textBox.ScrollBars = ScrollBars.Vertical;
        }
    }
}

