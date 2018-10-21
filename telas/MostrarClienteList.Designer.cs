namespace Lanchonete.telas {
    partial class MostrarClienteList {
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
            this.codigoClienteColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeClienteColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enderecoClienteColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefoneClienteColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.referenciaClienteColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusClienteColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigoClienteColuna,
            this.nomeClienteColuna,
            this.enderecoClienteColuna,
            this.telefoneClienteColuna,
            this.referenciaClienteColuna,
            this.statusClienteColuna});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 426);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // codigoClienteColuna
            // 
            this.codigoClienteColuna.Text = "código";
            // 
            // nomeClienteColuna
            // 
            this.nomeClienteColuna.Text = "nome";
            this.nomeClienteColuna.Width = 189;
            // 
            // enderecoClienteColuna
            // 
            this.enderecoClienteColuna.Text = "endereço";
            this.enderecoClienteColuna.Width = 209;
            // 
            // telefoneClienteColuna
            // 
            this.telefoneClienteColuna.Text = "telefone";
            // 
            // referenciaClienteColuna
            // 
            this.referenciaClienteColuna.Text = "referencia";
            this.referenciaClienteColuna.Width = 195;
            // 
            // statusClienteColuna
            // 
            this.statusClienteColuna.Text = "status";
            // 
            // MostrarClienteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView);
            this.Name = "MostrarClienteList";
            this.Text = "MostrarClienteList";
            this.Load += new System.EventHandler(this.MostrarClienteList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader codigoClienteColuna;
        private System.Windows.Forms.ColumnHeader nomeClienteColuna;
        private System.Windows.Forms.ColumnHeader enderecoClienteColuna;
        private System.Windows.Forms.ColumnHeader telefoneClienteColuna;
        private System.Windows.Forms.ColumnHeader referenciaClienteColuna;
        private System.Windows.Forms.ColumnHeader statusClienteColuna;
    }
}