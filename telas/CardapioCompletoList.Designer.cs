namespace Lanchonete.telas {
    partial class CardapioCompletoList {
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
            this.CardapioListViewBox = new System.Windows.Forms.ListView();
            this.codigoColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoriaColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precoColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estoqueColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bebidasBotao = new System.Windows.Forms.Button();
            this.lanchesBotao = new System.Windows.Forms.Button();
            this.refeicaoBotao = new System.Windows.Forms.Button();
            this.sobremesaBotao = new System.Windows.Forms.Button();
            this.cardapioCompletoBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CardapioListViewBox
            // 
            this.CardapioListViewBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigoColuna,
            this.categoriaColuna,
            this.nomeColuna,
            this.precoColuna,
            this.estoqueColuna});
            this.CardapioListViewBox.GridLines = true;
            this.CardapioListViewBox.Location = new System.Drawing.Point(12, 76);
            this.CardapioListViewBox.Name = "CardapioListViewBox";
            this.CardapioListViewBox.Size = new System.Drawing.Size(776, 362);
            this.CardapioListViewBox.TabIndex = 0;
            this.CardapioListViewBox.UseCompatibleStateImageBehavior = false;
            this.CardapioListViewBox.View = System.Windows.Forms.View.Details;
            // 
            // codigoColuna
            // 
            this.codigoColuna.Text = "código";
            this.codigoColuna.Width = 48;
            // 
            // categoriaColuna
            // 
            this.categoriaColuna.Text = "categoria";
            this.categoriaColuna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.categoriaColuna.Width = 128;
            // 
            // nomeColuna
            // 
            this.nomeColuna.Text = "nome";
            this.nomeColuna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nomeColuna.Width = 436;
            // 
            // precoColuna
            // 
            this.precoColuna.Text = "preço";
            this.precoColuna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.precoColuna.Width = 101;
            // 
            // estoqueColuna
            // 
            this.estoqueColuna.Text = "estoque";
            this.estoqueColuna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bebidasBotao
            // 
            this.bebidasBotao.Location = new System.Drawing.Point(255, 31);
            this.bebidasBotao.Name = "bebidasBotao";
            this.bebidasBotao.Size = new System.Drawing.Size(75, 23);
            this.bebidasBotao.TabIndex = 1;
            this.bebidasBotao.Text = "Bebidas";
            this.bebidasBotao.UseVisualStyleBackColor = true;
            this.bebidasBotao.Click += new System.EventHandler(this.bebidasBotao_Click);
            // 
            // lanchesBotao
            // 
            this.lanchesBotao.Location = new System.Drawing.Point(93, 31);
            this.lanchesBotao.Name = "lanchesBotao";
            this.lanchesBotao.Size = new System.Drawing.Size(75, 23);
            this.lanchesBotao.TabIndex = 2;
            this.lanchesBotao.Text = "Lanches";
            this.lanchesBotao.UseVisualStyleBackColor = true;
            this.lanchesBotao.Click += new System.EventHandler(this.lanchesBotao_Click);
            // 
            // refeicaoBotao
            // 
            this.refeicaoBotao.Location = new System.Drawing.Point(174, 31);
            this.refeicaoBotao.Name = "refeicaoBotao";
            this.refeicaoBotao.Size = new System.Drawing.Size(75, 23);
            this.refeicaoBotao.TabIndex = 3;
            this.refeicaoBotao.Text = "Refeição";
            this.refeicaoBotao.UseVisualStyleBackColor = true;
            this.refeicaoBotao.Click += new System.EventHandler(this.refeicaoBotao_Click);
            // 
            // sobremesaBotao
            // 
            this.sobremesaBotao.Location = new System.Drawing.Point(336, 31);
            this.sobremesaBotao.Name = "sobremesaBotao";
            this.sobremesaBotao.Size = new System.Drawing.Size(75, 23);
            this.sobremesaBotao.TabIndex = 4;
            this.sobremesaBotao.Text = "Sobremesa";
            this.sobremesaBotao.UseVisualStyleBackColor = true;
            this.sobremesaBotao.Click += new System.EventHandler(this.sobremesaBotao_Click);
            // 
            // cardapioCompletoBotao
            // 
            this.cardapioCompletoBotao.Location = new System.Drawing.Point(12, 31);
            this.cardapioCompletoBotao.Name = "cardapioCompletoBotao";
            this.cardapioCompletoBotao.Size = new System.Drawing.Size(75, 23);
            this.cardapioCompletoBotao.TabIndex = 5;
            this.cardapioCompletoBotao.Text = "Completo";
            this.cardapioCompletoBotao.UseVisualStyleBackColor = true;
            this.cardapioCompletoBotao.Click += new System.EventHandler(this.cardapioCompletoBotao_Click);
            // 
            // CardapioCompletoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cardapioCompletoBotao);
            this.Controls.Add(this.sobremesaBotao);
            this.Controls.Add(this.refeicaoBotao);
            this.Controls.Add(this.lanchesBotao);
            this.Controls.Add(this.bebidasBotao);
            this.Controls.Add(this.CardapioListViewBox);
            this.Name = "CardapioCompletoList";
            this.Text = "Cardapio";
            this.Load += new System.EventHandler(this.CardapioCompletoList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CardapioListViewBox;
        private System.Windows.Forms.ColumnHeader codigoColuna;
        private System.Windows.Forms.ColumnHeader categoriaColuna;
        private System.Windows.Forms.ColumnHeader nomeColuna;
        private System.Windows.Forms.ColumnHeader precoColuna;
        private System.Windows.Forms.ColumnHeader estoqueColuna;
        private System.Windows.Forms.Button bebidasBotao;
        private System.Windows.Forms.Button lanchesBotao;
        private System.Windows.Forms.Button refeicaoBotao;
        private System.Windows.Forms.Button sobremesaBotao;
        private System.Windows.Forms.Button cardapioCompletoBotao;
    }
}