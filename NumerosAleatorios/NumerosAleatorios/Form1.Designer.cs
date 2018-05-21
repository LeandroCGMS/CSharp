namespace NumerosAleatorios
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
            this.btnGeraNumero = new System.Windows.Forms.Button();
            this.lblNumInt = new System.Windows.Forms.Label();
            this.lblNumDouble = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeraNumero
            // 
            this.btnGeraNumero.Location = new System.Drawing.Point(65, 81);
            this.btnGeraNumero.Name = "btnGeraNumero";
            this.btnGeraNumero.Size = new System.Drawing.Size(107, 61);
            this.btnGeraNumero.TabIndex = 0;
            this.btnGeraNumero.Text = "Gerar Número Pseudo Aleatório";
            this.btnGeraNumero.UseVisualStyleBackColor = true;
            this.btnGeraNumero.Click += new System.EventHandler(this.btnGeraNumero_Click);
            // 
            // lblNumInt
            // 
            this.lblNumInt.AutoSize = true;
            this.lblNumInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInt.Location = new System.Drawing.Point(237, 81);
            this.lblNumInt.Name = "lblNumInt";
            this.lblNumInt.Size = new System.Drawing.Size(70, 25);
            this.lblNumInt.TabIndex = 1;
            this.lblNumInt.Text = "label1";
            // 
            // lblNumDouble
            // 
            this.lblNumDouble.AutoSize = true;
            this.lblNumDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDouble.Location = new System.Drawing.Point(237, 117);
            this.lblNumDouble.Name = "lblNumDouble";
            this.lblNumDouble.Size = new System.Drawing.Size(70, 25);
            this.lblNumDouble.TabIndex = 2;
            this.lblNumDouble.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 304);
            this.Controls.Add(this.lblNumDouble);
            this.Controls.Add(this.lblNumInt);
            this.Controls.Add(this.btnGeraNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeraNumero;
        private System.Windows.Forms.Label lblNumInt;
        private System.Windows.Forms.Label lblNumDouble;
    }
}

