﻿namespace Lanchonete.telas {
    partial class PerguntaCheque {
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
            this.simBotao = new System.Windows.Forms.Button();
            this.naoBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A entrega foi paga em cheque?";
            // 
            // simBotao
            // 
            this.simBotao.Location = new System.Drawing.Point(35, 59);
            this.simBotao.Name = "simBotao";
            this.simBotao.Size = new System.Drawing.Size(75, 23);
            this.simBotao.TabIndex = 1;
            this.simBotao.Text = "sim";
            this.simBotao.UseVisualStyleBackColor = true;
            this.simBotao.Click += new System.EventHandler(this.simBotao_Click);
            // 
            // naoBotao
            // 
            this.naoBotao.Location = new System.Drawing.Point(134, 59);
            this.naoBotao.Name = "naoBotao";
            this.naoBotao.Size = new System.Drawing.Size(75, 23);
            this.naoBotao.TabIndex = 2;
            this.naoBotao.Text = "não";
            this.naoBotao.UseVisualStyleBackColor = true;
            this.naoBotao.Click += new System.EventHandler(this.naoBotao_Click);
            // 
            // PerguntaCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 109);
            this.Controls.Add(this.naoBotao);
            this.Controls.Add(this.simBotao);
            this.Controls.Add(this.label1);
            this.Name = "PerguntaCheque";
            this.Load += new System.EventHandler(this.PerguntaCheque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button simBotao;
        private System.Windows.Forms.Button naoBotao;
    }
}