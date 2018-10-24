namespace Lanchonete.telas {
    partial class CadastroCheque {
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.contaTextBox = new System.Windows.Forms.TextBox();
            this.agenciaTextBox = new System.Windows.Forms.TextBox();
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.okBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "banco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "agência";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(67, 12);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(183, 20);
            this.numeroTextBox.TabIndex = 4;
            // 
            // contaTextBox
            // 
            this.contaTextBox.Location = new System.Drawing.Point(67, 44);
            this.contaTextBox.Name = "contaTextBox";
            this.contaTextBox.Size = new System.Drawing.Size(183, 20);
            this.contaTextBox.TabIndex = 5;
            // 
            // agenciaTextBox
            // 
            this.agenciaTextBox.Location = new System.Drawing.Point(67, 75);
            this.agenciaTextBox.Name = "agenciaTextBox";
            this.agenciaTextBox.Size = new System.Drawing.Size(183, 20);
            this.agenciaTextBox.TabIndex = 6;
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.Location = new System.Drawing.Point(67, 106);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(183, 20);
            this.bancoTextBox.TabIndex = 7;
            // 
            // okBotao
            // 
            this.okBotao.Location = new System.Drawing.Point(101, 144);
            this.okBotao.Name = "okBotao";
            this.okBotao.Size = new System.Drawing.Size(75, 23);
            this.okBotao.TabIndex = 8;
            this.okBotao.Text = "OK";
            this.okBotao.UseVisualStyleBackColor = true;
            this.okBotao.Click += new System.EventHandler(this.okBotao_Click);
            // 
            // CadastroCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 175);
            this.Controls.Add(this.okBotao);
            this.Controls.Add(this.bancoTextBox);
            this.Controls.Add(this.agenciaTextBox);
            this.Controls.Add(this.contaTextBox);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroCheque";
            this.Text = "cadastroCheque";
            this.Load += new System.EventHandler(this.CadastroCheque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox contaTextBox;
        private System.Windows.Forms.TextBox agenciaTextBox;
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.Button okBotao;
    }
}