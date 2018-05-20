namespace Controle_TextBox
{
    partial class Controle_TextBox
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
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.btnTeste = new System.Windows.Forms.Button();
            this.btnColar = new System.Windows.Forms.Button();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEntrada.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtEntrada.Location = new System.Drawing.Point(49, 105);
            this.txtEntrada.MaxLength = 10000;
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntrada.Size = new System.Drawing.Size(153, 96);
            this.txtEntrada.TabIndex = 0;
            this.txtEntrada.Click += new System.EventHandler(this.txtEntrada_Click);
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtEntrada_TextChanged);
            this.txtEntrada.MouseHover += new System.EventHandler(this.txtEntrada_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Meu nome vem de uma variável e vai pra Text Box abaixo, ao clicar aqui.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Apagar todos os elementos.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // txtSaida
            // 
            this.txtSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaida.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaida.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSaida.Location = new System.Drawing.Point(49, 226);
            this.txtSaida.MaxLength = 10000;
            this.txtSaida.Multiline = true;
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSaida.Size = new System.Drawing.Size(153, 96);
            this.txtSaida.TabIndex = 3;
            this.txtSaida.TextChanged += new System.EventHandler(this.txtSaida_TextChanged);
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(208, 117);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(153, 67);
            this.btnTeste.TabIndex = 4;
            this.btnTeste.Text = "Clique Aqui.";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // btnColar
            // 
            this.btnColar.Location = new System.Drawing.Point(208, 246);
            this.btnColar.Name = "btnColar";
            this.btnColar.Size = new System.Drawing.Size(153, 67);
            this.btnColar.TabIndex = 5;
            this.btnColar.Text = "Colar";
            this.btnColar.UseVisualStyleBackColor = true;
            this.btnColar.Click += new System.EventHandler(this.btnColar_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(385, 117);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(153, 67);
            this.btnOcultar.TabIndex = 6;
            this.btnOcultar.Text = "Ocultar";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(385, 246);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(153, 67);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Controle_TextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 349);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.btnColar);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEntrada);
            this.Name = "Controle_TextBox";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Button btnColar;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.Button btnMostrar;
    }
}

