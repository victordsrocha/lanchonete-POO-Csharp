namespace Lanchonete.telas {
    partial class Quantidade {
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
            this.quantidade_textBox = new System.Windows.Forms.TextBox();
            this.OkQuantidade_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade";
            // 
            // quantidade_textBox
            // 
            this.quantidade_textBox.Location = new System.Drawing.Point(81, 18);
            this.quantidade_textBox.Name = "quantidade_textBox";
            this.quantidade_textBox.Size = new System.Drawing.Size(100, 20);
            this.quantidade_textBox.TabIndex = 1;
            // 
            // OkQuantidade_button
            // 
            this.OkQuantidade_button.Location = new System.Drawing.Point(81, 44);
            this.OkQuantidade_button.Name = "OkQuantidade_button";
            this.OkQuantidade_button.Size = new System.Drawing.Size(75, 23);
            this.OkQuantidade_button.TabIndex = 2;
            this.OkQuantidade_button.Text = "OK";
            this.OkQuantidade_button.UseVisualStyleBackColor = true;
            this.OkQuantidade_button.Click += new System.EventHandler(this.OkQuantidade_button_Click);
            // 
            // Quantidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 79);
            this.Controls.Add(this.OkQuantidade_button);
            this.Controls.Add(this.quantidade_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Quantidade";
            this.Text = "Quantidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantidade_textBox;
        private System.Windows.Forms.Button OkQuantidade_button;
    }
}