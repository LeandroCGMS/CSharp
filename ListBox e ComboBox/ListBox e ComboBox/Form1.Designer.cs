namespace ListBox_e_ComboBox
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
            this.txtAdicionaItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnPreenche = new System.Windows.Forms.Button();
            this.lstAnimais = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtAdicionaItem
            // 
            this.txtAdicionaItem.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicionaItem.Location = new System.Drawing.Point(12, 68);
            this.txtAdicionaItem.Name = "txtAdicionaItem";
            this.txtAdicionaItem.Size = new System.Drawing.Size(225, 32);
            this.txtAdicionaItem.TabIndex = 0;
            this.txtAdicionaItem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trabalhando com  ListBox em C#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite um item para adicionar ao ListBox:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Adcionar Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 53);
            this.button3.TabIndex = 5;
            this.button3.Text = "Classificar Lista";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(549, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 53);
            this.button4.TabIndex = 6;
            this.button4.Text = "Ler Item da Lista";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(549, 146);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 53);
            this.button5.TabIndex = 7;
            this.button5.Text = "Remover Selecionado";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(549, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 53);
            this.button6.TabIndex = 8;
            this.button6.Text = "Limpar Lista";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnPreenche
            // 
            this.btnPreenche.Location = new System.Drawing.Point(63, 194);
            this.btnPreenche.Name = "btnPreenche";
            this.btnPreenche.Size = new System.Drawing.Size(165, 53);
            this.btnPreenche.TabIndex = 9;
            this.btnPreenche.Text = "Preencher Lista Automaticamente";
            this.btnPreenche.UseVisualStyleBackColor = true;
            this.btnPreenche.Click += new System.EventHandler(this.btnPreenche_Click);
            // 
            // lstAnimais
            // 
            this.lstAnimais.FormattingEnabled = true;
            this.lstAnimais.Location = new System.Drawing.Point(298, 68);
            this.lstAnimais.Name = "lstAnimais";
            this.lstAnimais.Size = new System.Drawing.Size(182, 290);
            this.lstAnimais.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 377);
            this.Controls.Add(this.lstAnimais);
            this.Controls.Add(this.btnPreenche);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdicionaItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdicionaItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnPreenche;
        private System.Windows.Forms.ListBox lstAnimais;
    }
}

