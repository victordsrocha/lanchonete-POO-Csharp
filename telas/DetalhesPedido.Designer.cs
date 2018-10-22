namespace Lanchonete.telas {
    partial class DetalhesPedido {
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
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precoUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unidades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.NometextBox = new System.Windows.Forms.TextBox();
            this.DatatextBox = new System.Windows.Forms.TextBox();
            this.CodigoClientetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ValorTotaltextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.nome,
            this.categoria,
            this.precoUnit,
            this.unidades,
            this.valor});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(12, 104);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 334);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // codigo
            // 
            this.codigo.Text = "codigo";
            this.codigo.Width = 67;
            // 
            // precoUnit
            // 
            this.precoUnit.DisplayIndex = 3;
            this.precoUnit.Text = "preço unitário";
            this.precoUnit.Width = 82;
            // 
            // unidades
            // 
            this.unidades.DisplayIndex = 4;
            this.unidades.Text = "unidades";
            // 
            // valor
            // 
            this.valor.DisplayIndex = 5;
            this.valor.Text = "valor";
            // 
            // nome
            // 
            this.nome.DisplayIndex = 1;
            this.nome.Text = "nome";
            this.nome.Width = 372;
            // 
            // categoria
            // 
            this.categoria.DisplayIndex = 2;
            this.categoria.Text = "categoria";
            this.categoria.Width = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "código do pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "nome do cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "data do pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "código do cliente";
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Location = new System.Drawing.Point(107, 10);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.ReadOnly = true;
            this.CodigotextBox.Size = new System.Drawing.Size(150, 20);
            this.CodigotextBox.TabIndex = 5;
            // 
            // NometextBox
            // 
            this.NometextBox.Location = new System.Drawing.Point(107, 33);
            this.NometextBox.Name = "NometextBox";
            this.NometextBox.ReadOnly = true;
            this.NometextBox.Size = new System.Drawing.Size(150, 20);
            this.NometextBox.TabIndex = 6;
            // 
            // DatatextBox
            // 
            this.DatatextBox.Location = new System.Drawing.Point(353, 10);
            this.DatatextBox.Name = "DatatextBox";
            this.DatatextBox.ReadOnly = true;
            this.DatatextBox.Size = new System.Drawing.Size(150, 20);
            this.DatatextBox.TabIndex = 7;
            // 
            // CodigoClientetextBox
            // 
            this.CodigoClientetextBox.Location = new System.Drawing.Point(353, 34);
            this.CodigoClientetextBox.Name = "CodigoClientetextBox";
            this.CodigoClientetextBox.ReadOnly = true;
            this.CodigoClientetextBox.Size = new System.Drawing.Size(150, 20);
            this.CodigoClientetextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "valor total";
            // 
            // ValorTotaltextBox
            // 
            this.ValorTotaltextBox.Location = new System.Drawing.Point(645, 34);
            this.ValorTotaltextBox.Name = "ValorTotaltextBox";
            this.ValorTotaltextBox.ReadOnly = true;
            this.ValorTotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.ValorTotaltextBox.TabIndex = 10;
            // 
            // DetalhesPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ValorTotaltextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CodigoClientetextBox);
            this.Controls.Add(this.DatatextBox);
            this.Controls.Add(this.NometextBox);
            this.Controls.Add(this.CodigotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Name = "DetalhesPedido";
            this.Text = "DetalhesPedido";
            this.Load += new System.EventHandler(this.DetalhesPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader precoUnit;
        private System.Windows.Forms.ColumnHeader unidades;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CodigotextBox;
        private System.Windows.Forms.TextBox NometextBox;
        private System.Windows.Forms.TextBox DatatextBox;
        private System.Windows.Forms.TextBox CodigoClientetextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ValorTotaltextBox;
    }
}