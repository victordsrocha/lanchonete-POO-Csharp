namespace Lanchonete.telas {
    partial class ExcluirItem {
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
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.excluirBotao = new System.Windows.Forms.Button();
            this.IdColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantidadeColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precoColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColuna,
            this.nomeColuna,
            this.quantidadeColuna,
            this.precoColuna});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(12, 64);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 374);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(36, 28);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // excluirBotao
            // 
            this.excluirBotao.Location = new System.Drawing.Point(142, 26);
            this.excluirBotao.Name = "excluirBotao";
            this.excluirBotao.Size = new System.Drawing.Size(75, 23);
            this.excluirBotao.TabIndex = 3;
            this.excluirBotao.Text = "excluir";
            this.excluirBotao.UseVisualStyleBackColor = true;
            this.excluirBotao.Click += new System.EventHandler(this.excluirBotao_Click);
            // 
            // IdColuna
            // 
            this.IdColuna.Text = "ID";
            // 
            // nomeColuna
            // 
            this.nomeColuna.Text = "nome";
            this.nomeColuna.Width = 343;
            // 
            // quantidadeColuna
            // 
            this.quantidadeColuna.Text = "quantidade";
            this.quantidadeColuna.Width = 81;
            // 
            // precoColuna
            // 
            this.precoColuna.Text = "preço";
            // 
            // ExcluirItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.excluirBotao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.listView);
            this.Name = "ExcluirItem";
            this.Text = "ExcluirItem";
            this.Load += new System.EventHandler(this.ExcluirItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button excluirBotao;
        private System.Windows.Forms.ColumnHeader IdColuna;
        private System.Windows.Forms.ColumnHeader nomeColuna;
        private System.Windows.Forms.ColumnHeader quantidadeColuna;
        private System.Windows.Forms.ColumnHeader precoColuna;
    }
}