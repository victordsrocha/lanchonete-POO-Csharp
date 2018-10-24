namespace Lanchonete.telas {
    partial class ReativarCliente {
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
            this.label1 = new System.Windows.Forms.Label();
            this.codigoClienteReativarTextBox = new System.Windows.Forms.TextBox();
            this.continuarBotao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.devolucoesTextBox = new System.Windows.Forms.TextBox();
            this.reativarClienteBotao = new System.Windows.Forms.Button();
            this.cancelarBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite código do cliente a ser reativado";
            // 
            // codigoClienteReativarTextBox
            // 
            this.codigoClienteReativarTextBox.Location = new System.Drawing.Point(209, 12);
            this.codigoClienteReativarTextBox.Name = "codigoClienteReativarTextBox";
            this.codigoClienteReativarTextBox.Size = new System.Drawing.Size(74, 20);
            this.codigoClienteReativarTextBox.TabIndex = 1;
            // 
            // continuarBotao
            // 
            this.continuarBotao.Location = new System.Drawing.Point(285, 10);
            this.continuarBotao.Name = "continuarBotao";
            this.continuarBotao.Size = new System.Drawing.Size(75, 23);
            this.continuarBotao.TabIndex = 2;
            this.continuarBotao.Text = "continuar";
            this.continuarBotao.UseVisualStyleBackColor = true;
            this.continuarBotao.Click += new System.EventHandler(this.continuarBotao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "devoluções";
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Enabled = false;
            this.NomeTextBox.Location = new System.Drawing.Point(84, 50);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.ReadOnly = true;
            this.NomeTextBox.Size = new System.Drawing.Size(276, 20);
            this.NomeTextBox.TabIndex = 6;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Enabled = false;
            this.statusTextBox.Location = new System.Drawing.Point(84, 81);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(276, 20);
            this.statusTextBox.TabIndex = 7;
            // 
            // devolucoesTextBox
            // 
            this.devolucoesTextBox.Enabled = false;
            this.devolucoesTextBox.Location = new System.Drawing.Point(84, 111);
            this.devolucoesTextBox.Name = "devolucoesTextBox";
            this.devolucoesTextBox.ReadOnly = true;
            this.devolucoesTextBox.Size = new System.Drawing.Size(276, 20);
            this.devolucoesTextBox.TabIndex = 8;
            // 
            // reativarClienteBotao
            // 
            this.reativarClienteBotao.Enabled = false;
            this.reativarClienteBotao.Location = new System.Drawing.Point(71, 140);
            this.reativarClienteBotao.Name = "reativarClienteBotao";
            this.reativarClienteBotao.Size = new System.Drawing.Size(113, 23);
            this.reativarClienteBotao.TabIndex = 9;
            this.reativarClienteBotao.Text = "Reativar cliente";
            this.reativarClienteBotao.UseVisualStyleBackColor = true;
            this.reativarClienteBotao.Click += new System.EventHandler(this.reativarClienteBotao_Click);
            // 
            // cancelarBotao
            // 
            this.cancelarBotao.Enabled = false;
            this.cancelarBotao.Location = new System.Drawing.Point(209, 140);
            this.cancelarBotao.Name = "cancelarBotao";
            this.cancelarBotao.Size = new System.Drawing.Size(113, 23);
            this.cancelarBotao.TabIndex = 10;
            this.cancelarBotao.Text = "cancelar";
            this.cancelarBotao.UseVisualStyleBackColor = true;
            this.cancelarBotao.Click += new System.EventHandler(this.cancelarBotao_Click);
            // 
            // ReativarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 172);
            this.Controls.Add(this.cancelarBotao);
            this.Controls.Add(this.reativarClienteBotao);
            this.Controls.Add(this.devolucoesTextBox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.NomeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.continuarBotao);
            this.Controls.Add(this.codigoClienteReativarTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ReativarCliente";
            this.Text = "ReativarCliente";
            this.Load += new System.EventHandler(this.ReativarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoClienteReativarTextBox;
        private System.Windows.Forms.Button continuarBotao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox devolucoesTextBox;
        private System.Windows.Forms.Button reativarClienteBotao;
        private System.Windows.Forms.Button cancelarBotao;
    }
}