﻿namespace Lanchonete.telas {
    partial class RelatorioPedidosDoDia {
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
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.telefone,
            this.data,
            this.hora,
            this.valor});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(12, 49);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 389);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // nome
            // 
            this.nome.Text = "nome";
            this.nome.Width = 289;
            // 
            // telefone
            // 
            this.telefone.Text = "telefone";
            this.telefone.Width = 169;
            // 
            // data
            // 
            this.data.Text = "data";
            this.data.Width = 116;
            // 
            // hora
            // 
            this.hora.Text = "hora";
            this.hora.Width = 135;
            // 
            // valor
            // 
            this.valor.Text = "valor total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relatório de pedidos do dia da data: ";
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(190, 19);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ReadOnly = true;
            this.dataTextBox.Size = new System.Drawing.Size(193, 20);
            this.dataTextBox.TabIndex = 2;
            // 
            // RelatorioPedidosDoDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Name = "RelatorioPedidosDoDia";
            this.Text = "RelatorioPedidosDoDia";
            this.Load += new System.EventHandler(this.RelatorioPedidosDoDia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader telefone;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader hora;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataTextBox;
    }
}