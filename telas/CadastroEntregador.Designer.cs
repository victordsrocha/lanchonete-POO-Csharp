namespace Lanchonete.telas {
    partial class CadastroEntregador {
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.placaEntregadorCadastroTextBox = new System.Windows.Forms.TextBox();
            this.nomeEntregadorCadastroTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.codigoEntregadorCadastroTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "placa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "nome";
            // 
            // placaEntregadorCadastroTextBox
            // 
            this.placaEntregadorCadastroTextBox.Location = new System.Drawing.Point(86, 94);
            this.placaEntregadorCadastroTextBox.Name = "placaEntregadorCadastroTextBox";
            this.placaEntregadorCadastroTextBox.Size = new System.Drawing.Size(314, 20);
            this.placaEntregadorCadastroTextBox.TabIndex = 6;
            // 
            // nomeEntregadorCadastroTextBox
            // 
            this.nomeEntregadorCadastroTextBox.Location = new System.Drawing.Point(86, 68);
            this.nomeEntregadorCadastroTextBox.Name = "nomeEntregadorCadastroTextBox";
            this.nomeEntregadorCadastroTextBox.Size = new System.Drawing.Size(314, 20);
            this.nomeEntregadorCadastroTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "código do entregador";
            // 
            // codigoEntregadorCadastroTextBox
            // 
            this.codigoEntregadorCadastroTextBox.Location = new System.Drawing.Point(300, 42);
            this.codigoEntregadorCadastroTextBox.Name = "codigoEntregadorCadastroTextBox";
            this.codigoEntregadorCadastroTextBox.ReadOnly = true;
            this.codigoEntregadorCadastroTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoEntregadorCadastroTextBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.codigoEntregadorCadastroTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nomeEntregadorCadastroTextBox);
            this.groupBox1.Controls.Add(this.placaEntregadorCadastroTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 165);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de entregador";
            // 
            // CadastroEntregador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 181);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastroEntregador";
            this.Text = "Cadastro de Entregador";
            this.Load += new System.EventHandler(this.CadastroEntregador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox placaEntregadorCadastroTextBox;
        private System.Windows.Forms.TextBox nomeEntregadorCadastroTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoEntregadorCadastroTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}