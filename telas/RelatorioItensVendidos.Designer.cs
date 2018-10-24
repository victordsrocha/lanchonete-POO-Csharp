namespace Lanchonete.telas {
    partial class RelatorioItensVendidos {
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
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unidadesVendidas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.nome,
            this.unidadesVendidas,
            this.pico});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(12, 44);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 394);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // codigo
            // 
            this.codigo.Text = "codigo";
            // 
            // nome
            // 
            this.nome.Text = "nome";
            this.nome.Width = 488;
            // 
            // unidadesVendidas
            // 
            this.unidadesVendidas.Text = "unidades vendidas";
            this.unidadesVendidas.Width = 127;
            // 
            // pico
            // 
            this.pico.Text = "pico de procura";
            this.pico.Width = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relatório de itens vendidos na data:";
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(195, 17);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ReadOnly = true;
            this.dataTextBox.Size = new System.Drawing.Size(193, 20);
            this.dataTextBox.TabIndex = 2;
            // 
            // RelatorioItensVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Name = "RelatorioItensVendidos";
            this.Text = "RelatorioItensVendidos";
            this.Load += new System.EventHandler(this.RelatorioItensVendidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader unidadesVendidas;
        private System.Windows.Forms.ColumnHeader pico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataTextBox;
    }
}