namespace Lanchonete.telas {
    partial class RelatorioEntregadores {
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
            this.entregas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.entregas,
            this.soma,
            this.comissao});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 426);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // nome
            // 
            this.nome.Text = "nome";
            this.nome.Width = 371;
            // 
            // entregas
            // 
            this.entregas.Text = "entregas";
            // 
            // soma
            // 
            this.soma.Text = "soma dos valores dos pedidos entregues";
            this.soma.Width = 265;
            // 
            // comissao
            // 
            this.comissao.Text = "comissao";
            // 
            // RelatorioEntregadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView);
            this.Name = "RelatorioEntregadores";
            this.Text = "RelatorioEntregadores";
            this.Load += new System.EventHandler(this.RelatorioEntregadores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader entregas;
        private System.Windows.Forms.ColumnHeader soma;
        private System.Windows.Forms.ColumnHeader comissao;
    }
}