namespace Tratamento_de_Exceções
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFator1 = new System.Windows.Forms.TextBox();
            this.txtFator2 = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.botaoMultiplica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFator1
            // 
            this.txtFator1.Location = new System.Drawing.Point(31, 31);
            this.txtFator1.Name = "txtFator1";
            this.txtFator1.Size = new System.Drawing.Size(100, 20);
            this.txtFator1.TabIndex = 0;
            // 
            // txtFator2
            // 
            this.txtFator2.Location = new System.Drawing.Point(31, 82);
            this.txtFator2.Name = "txtFator2";
            this.txtFator2.Size = new System.Drawing.Size(100, 20);
            this.txtFator2.TabIndex = 1;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(31, 176);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProduto.TabIndex = 2;
            // 
            // botaoMultiplica
            // 
            this.botaoMultiplica.Location = new System.Drawing.Point(44, 122);
            this.botaoMultiplica.Name = "botaoMultiplica";
            this.botaoMultiplica.Size = new System.Drawing.Size(75, 39);
            this.botaoMultiplica.TabIndex = 3;
            this.botaoMultiplica.Text = "Multiplica";
            this.botaoMultiplica.UseVisualStyleBackColor = true;
            this.botaoMultiplica.Click += new System.EventHandler(this.botaoMultiplica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(184, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoMultiplica);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtFator2);
            this.Controls.Add(this.txtFator1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFator1;
        private System.Windows.Forms.TextBox txtFator2;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button botaoMultiplica;
        private System.Windows.Forms.Label label1;
    }
}

