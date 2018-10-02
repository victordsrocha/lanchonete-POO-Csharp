namespace Lanchonete.telas {
    partial class Hunger {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cardapioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lancheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refeicaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bebidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobremesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarCardapioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cardapioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cardapioToolStripMenuItem
            // 
            this.cardapioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProdutoToolStripMenuItem,
            this.mostrarCardapioToolStripMenuItem});
            this.cardapioToolStripMenuItem.Name = "cardapioToolStripMenuItem";
            this.cardapioToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.cardapioToolStripMenuItem.Text = "Cardapio";
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            this.cadastrarProdutoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lancheToolStripMenuItem,
            this.refeicaoToolStripMenuItem,
            this.bebidaToolStripMenuItem,
            this.sobremesaToolStripMenuItem});
            this.cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            this.cadastrarProdutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarProdutoToolStripMenuItem.Text = "Cadastrar Produto";
            // 
            // lancheToolStripMenuItem
            // 
            this.lancheToolStripMenuItem.Name = "lancheToolStripMenuItem";
            this.lancheToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lancheToolStripMenuItem.Text = "Lanche";
            this.lancheToolStripMenuItem.Click += new System.EventHandler(this.lancheToolStripMenuItem_Click);
            // 
            // refeicaoToolStripMenuItem
            // 
            this.refeicaoToolStripMenuItem.Name = "refeicaoToolStripMenuItem";
            this.refeicaoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refeicaoToolStripMenuItem.Text = "Refeicao";
            this.refeicaoToolStripMenuItem.Click += new System.EventHandler(this.refeicaoToolStripMenuItem_Click);
            // 
            // bebidaToolStripMenuItem
            // 
            this.bebidaToolStripMenuItem.Name = "bebidaToolStripMenuItem";
            this.bebidaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bebidaToolStripMenuItem.Text = "Bebida";
            this.bebidaToolStripMenuItem.Click += new System.EventHandler(this.bebidaToolStripMenuItem_Click);
            // 
            // sobremesaToolStripMenuItem
            // 
            this.sobremesaToolStripMenuItem.Name = "sobremesaToolStripMenuItem";
            this.sobremesaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobremesaToolStripMenuItem.Text = "Sobremesa";
            this.sobremesaToolStripMenuItem.Click += new System.EventHandler(this.sobremesaToolStripMenuItem_Click);
            // 
            // mostrarCardapioToolStripMenuItem
            // 
            this.mostrarCardapioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completoToolStripMenuItem});
            this.mostrarCardapioToolStripMenuItem.Name = "mostrarCardapioToolStripMenuItem";
            this.mostrarCardapioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarCardapioToolStripMenuItem.Text = "Mostrar Cardapio";
            // 
            // completoToolStripMenuItem
            // 
            this.completoToolStripMenuItem.Name = "completoToolStripMenuItem";
            this.completoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.completoToolStripMenuItem.Text = "Completo";
            this.completoToolStripMenuItem.Click += new System.EventHandler(this.completoToolStripMenuItem_Click);
            // 
            // Hunger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Hunger";
            this.Text = "Hunger";
            this.Load += new System.EventHandler(this.Hunger_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cardapioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lancheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refeicaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bebidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobremesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarCardapioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completoToolStripMenuItem;
    }
}