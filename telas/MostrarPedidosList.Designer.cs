namespace Lanchonete.telas {
    partial class MostrarPedidosList {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listView = new System.Windows.Forms.ListView();
            this.pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.situacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.todosBotao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.codigoDetalhePedidoTextBox = new System.Windows.Forms.TextBox();
            this.mostrarDetalheBotao = new System.Windows.Forms.Button();
            this.pendentesBotao = new System.Windows.Forms.Button();
            this.entreguesBotao = new System.Windows.Forms.Button();
            this.cheque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.conta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.agencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.banco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pedido,
            this.cliente,
            this.data,
            this.situacao,
            this.valor,
            this.cheque,
            this.numero,
            this.conta,
            this.agencia,
            this.banco});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(12, 74);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1049, 364);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // pedido
            // 
            this.pedido.Text = "pedido";
            // 
            // cliente
            // 
            this.cliente.Text = "cliente";
            this.cliente.Width = 220;
            // 
            // data
            // 
            this.data.Text = "data";
            this.data.Width = 223;
            // 
            // situacao
            // 
            this.situacao.Text = "situação";
            // 
            // valor
            // 
            this.valor.Text = "valor total";
            this.valor.Width = 81;
            // 
            // todosBotao
            // 
            this.todosBotao.Location = new System.Drawing.Point(12, 28);
            this.todosBotao.Name = "todosBotao";
            this.todosBotao.Size = new System.Drawing.Size(75, 23);
            this.todosBotao.TabIndex = 1;
            this.todosBotao.Text = "todos";
            this.todosBotao.UseVisualStyleBackColor = true;
            this.todosBotao.Click += new System.EventHandler(this.todosBotao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "mostrar detalhes do pedido de código: ";
            // 
            // codigoDetalhePedidoTextBox
            // 
            this.codigoDetalhePedidoTextBox.Location = new System.Drawing.Point(644, 35);
            this.codigoDetalhePedidoTextBox.Name = "codigoDetalhePedidoTextBox";
            this.codigoDetalhePedidoTextBox.Size = new System.Drawing.Size(39, 20);
            this.codigoDetalhePedidoTextBox.TabIndex = 3;
            // 
            // mostrarDetalheBotao
            // 
            this.mostrarDetalheBotao.Location = new System.Drawing.Point(689, 33);
            this.mostrarDetalheBotao.Name = "mostrarDetalheBotao";
            this.mostrarDetalheBotao.Size = new System.Drawing.Size(75, 23);
            this.mostrarDetalheBotao.TabIndex = 4;
            this.mostrarDetalheBotao.Text = "mostrar";
            this.mostrarDetalheBotao.UseVisualStyleBackColor = true;
            this.mostrarDetalheBotao.Click += new System.EventHandler(this.mostrarDetalheBotao_Click);
            // 
            // pendentesBotao
            // 
            this.pendentesBotao.Location = new System.Drawing.Point(93, 28);
            this.pendentesBotao.Name = "pendentesBotao";
            this.pendentesBotao.Size = new System.Drawing.Size(75, 23);
            this.pendentesBotao.TabIndex = 5;
            this.pendentesBotao.Text = "pendentes";
            this.pendentesBotao.UseVisualStyleBackColor = true;
            this.pendentesBotao.Click += new System.EventHandler(this.pendentesBotao_Click);
            // 
            // entreguesBotao
            // 
            this.entreguesBotao.Location = new System.Drawing.Point(174, 28);
            this.entreguesBotao.Name = "entreguesBotao";
            this.entreguesBotao.Size = new System.Drawing.Size(75, 23);
            this.entreguesBotao.TabIndex = 6;
            this.entreguesBotao.Text = "entregues";
            this.entreguesBotao.UseVisualStyleBackColor = true;
            this.entreguesBotao.Click += new System.EventHandler(this.entreguesBotao_Click);
            // 
            // cheque
            // 
            this.cheque.Text = "cheque";
            this.cheque.Width = 75;
            // 
            // numero
            // 
            this.numero.Text = "numero";
            this.numero.Width = 76;
            // 
            // conta
            // 
            this.conta.Text = "conta";
            this.conta.Width = 71;
            // 
            // agencia
            // 
            this.agencia.Text = "agencia";
            this.agencia.Width = 65;
            // 
            // banco
            // 
            this.banco.Text = "banco";
            this.banco.Width = 113;
            // 
            // MostrarPedidosList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.entreguesBotao);
            this.Controls.Add(this.pendentesBotao);
            this.Controls.Add(this.mostrarDetalheBotao);
            this.Controls.Add(this.codigoDetalhePedidoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todosBotao);
            this.Controls.Add(this.listView);
            this.Name = "MostrarPedidosList";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.MostrarPedidosList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader pedido;
        private System.Windows.Forms.ColumnHeader cliente;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader situacao;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.Button todosBotao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoDetalhePedidoTextBox;
        private System.Windows.Forms.Button mostrarDetalheBotao;
        private System.Windows.Forms.Button pendentesBotao;
        private System.Windows.Forms.Button entreguesBotao;
        private System.Windows.Forms.ColumnHeader cheque;
        private System.Windows.Forms.ColumnHeader numero;
        private System.Windows.Forms.ColumnHeader conta;
        private System.Windows.Forms.ColumnHeader agencia;
        private System.Windows.Forms.ColumnHeader banco;
    }
}