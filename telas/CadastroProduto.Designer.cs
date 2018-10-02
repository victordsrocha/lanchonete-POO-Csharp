namespace Lanchonete.telas {
    partial class CadastroProduto {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.precoCadastro_textBox = new System.Windows.Forms.TextBox();
            this.nomeCadastro_textBox = new System.Windows.Forms.TextBox();
            this.codigoCadastro_textBox = new System.Windows.Forms.TextBox();
            this.categoriaCadastro_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.okBotaoCadastro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.okBotaoCadastro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.precoCadastro_textBox);
            this.groupBox1.Controls.Add(this.nomeCadastro_textBox);
            this.groupBox1.Controls.Add(this.codigoCadastro_textBox);
            this.groupBox1.Controls.Add(this.categoriaCadastro_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preço";
            // 
            // precoCadastro_textBox
            // 
            this.precoCadastro_textBox.Location = new System.Drawing.Point(64, 94);
            this.precoCadastro_textBox.Name = "precoCadastro_textBox";
            this.precoCadastro_textBox.Size = new System.Drawing.Size(231, 20);
            this.precoCadastro_textBox.TabIndex = 6;
            // 
            // nomeCadastro_textBox
            // 
            this.nomeCadastro_textBox.Location = new System.Drawing.Point(64, 68);
            this.nomeCadastro_textBox.Name = "nomeCadastro_textBox";
            this.nomeCadastro_textBox.Size = new System.Drawing.Size(231, 20);
            this.nomeCadastro_textBox.TabIndex = 5;
            // 
            // codigoCadastro_textBox
            // 
            this.codigoCadastro_textBox.Location = new System.Drawing.Point(64, 42);
            this.codigoCadastro_textBox.Name = "codigoCadastro_textBox";
            this.codigoCadastro_textBox.ReadOnly = true;
            this.codigoCadastro_textBox.Size = new System.Drawing.Size(231, 20);
            this.codigoCadastro_textBox.TabIndex = 4;
            // 
            // categoriaCadastro_textBox
            // 
            this.categoriaCadastro_textBox.Location = new System.Drawing.Point(64, 16);
            this.categoriaCadastro_textBox.Name = "categoriaCadastro_textBox";
            this.categoriaCadastro_textBox.ReadOnly = true;
            this.categoriaCadastro_textBox.Size = new System.Drawing.Size(231, 20);
            this.categoriaCadastro_textBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // okBotaoCadastro
            // 
            this.okBotaoCadastro.Location = new System.Drawing.Point(112, 120);
            this.okBotaoCadastro.Name = "okBotaoCadastro";
            this.okBotaoCadastro.Size = new System.Drawing.Size(75, 23);
            this.okBotaoCadastro.TabIndex = 8;
            this.okBotaoCadastro.Text = "OK";
            this.okBotaoCadastro.UseVisualStyleBackColor = true;
            this.okBotaoCadastro.Click += new System.EventHandler(this.okBotaoCadastro_Click);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 176);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastroProduto";
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.CadastroProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox precoCadastro_textBox;
        private System.Windows.Forms.TextBox nomeCadastro_textBox;
        private System.Windows.Forms.TextBox codigoCadastro_textBox;
        private System.Windows.Forms.TextBox categoriaCadastro_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okBotaoCadastro;
    }
}