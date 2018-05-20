namespace Controle_Color_Dialog
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
            this.btnCorFundo = new System.Windows.Forms.Button();
            this.btnCorTexto = new System.Windows.Forms.Button();
            this.txtCores = new System.Windows.Forms.TextBox();
            this.cdgCaixaCores = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnCorFundo
            // 
            this.btnCorFundo.Location = new System.Drawing.Point(61, 53);
            this.btnCorFundo.Name = "btnCorFundo";
            this.btnCorFundo.Size = new System.Drawing.Size(97, 60);
            this.btnCorFundo.TabIndex = 0;
            this.btnCorFundo.Text = "Cor de Fundo";
            this.btnCorFundo.UseVisualStyleBackColor = true;
            this.btnCorFundo.Click += new System.EventHandler(this.btnCorFundo_Click);
            // 
            // btnCorTexto
            // 
            this.btnCorTexto.Location = new System.Drawing.Point(61, 136);
            this.btnCorTexto.Name = "btnCorTexto";
            this.btnCorTexto.Size = new System.Drawing.Size(97, 60);
            this.btnCorTexto.TabIndex = 1;
            this.btnCorTexto.Text = "Cor do Texto";
            this.btnCorTexto.UseVisualStyleBackColor = true;
            this.btnCorTexto.Click += new System.EventHandler(this.btnCorTexto_Click);
            // 
            // txtCores
            // 
            this.txtCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCores.Location = new System.Drawing.Point(164, 113);
            this.txtCores.Name = "txtCores";
            this.txtCores.Size = new System.Drawing.Size(292, 35);
            this.txtCores.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 370);
            this.Controls.Add(this.txtCores);
            this.Controls.Add(this.btnCorTexto);
            this.Controls.Add(this.btnCorFundo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCorFundo;
        private System.Windows.Forms.Button btnCorTexto;
        private System.Windows.Forms.TextBox txtCores;
        private System.Windows.Forms.ColorDialog cdgCaixaCores;
    }
}

