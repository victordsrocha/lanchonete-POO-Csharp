namespace Lanchonete.telas {
    partial class CardapioCompleto {
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
            this.Cardapio_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cardapio_textBox
            // 
            this.Cardapio_textBox.Location = new System.Drawing.Point(12, 12);
            this.Cardapio_textBox.Multiline = true;
            this.Cardapio_textBox.Name = "Cardapio_textBox";
            this.Cardapio_textBox.ReadOnly = true;
            this.Cardapio_textBox.Size = new System.Drawing.Size(776, 426);
            this.Cardapio_textBox.TabIndex = 0;
            // 
            // CardapioCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cardapio_textBox);
            this.Name = "CardapioCompleto";
            this.Text = "CardapioCompleto";
            this.Load += new System.EventHandler(this.CardapioCompleto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cardapio_textBox;
    }
}