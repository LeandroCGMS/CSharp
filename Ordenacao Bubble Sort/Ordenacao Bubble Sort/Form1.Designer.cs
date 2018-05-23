namespace Ordenacao_Bubble_Sort
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
            this.btnCriaArray = new System.Windows.Forms.Button();
            this.btnOrdenaArray = new System.Windows.Forms.Button();
            this.btnMetodoSort = new System.Windows.Forms.Button();
            this.lblArrayOriginal = new System.Windows.Forms.Label();
            this.lblOrdenado = new System.Windows.Forms.Label();
            this.lblOrdenado2 = new System.Windows.Forms.Label();
            this.lblArrayOriginal2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCriaArray
            // 
            this.btnCriaArray.Location = new System.Drawing.Point(63, 35);
            this.btnCriaArray.Name = "btnCriaArray";
            this.btnCriaArray.Size = new System.Drawing.Size(122, 66);
            this.btnCriaArray.TabIndex = 0;
            this.btnCriaArray.Text = "Criar Array";
            this.btnCriaArray.UseVisualStyleBackColor = true;
            this.btnCriaArray.Click += new System.EventHandler(this.btnCriaArray_Click);
            // 
            // btnOrdenaArray
            // 
            this.btnOrdenaArray.Location = new System.Drawing.Point(63, 133);
            this.btnOrdenaArray.Name = "btnOrdenaArray";
            this.btnOrdenaArray.Size = new System.Drawing.Size(122, 66);
            this.btnOrdenaArray.TabIndex = 1;
            this.btnOrdenaArray.Text = "Ordenar Array";
            this.btnOrdenaArray.UseVisualStyleBackColor = true;
            this.btnOrdenaArray.Click += new System.EventHandler(this.btnOrdenaArray_Click);
            // 
            // btnMetodoSort
            // 
            this.btnMetodoSort.Location = new System.Drawing.Point(63, 234);
            this.btnMetodoSort.Name = "btnMetodoSort";
            this.btnMetodoSort.Size = new System.Drawing.Size(122, 66);
            this.btnMetodoSort.TabIndex = 2;
            this.btnMetodoSort.Text = "Ordena Método Sort";
            this.btnMetodoSort.UseVisualStyleBackColor = true;
            this.btnMetodoSort.Click += new System.EventHandler(this.btnMetodoSort_Click);
            // 
            // lblArrayOriginal
            // 
            this.lblArrayOriginal.AutoSize = true;
            this.lblArrayOriginal.Location = new System.Drawing.Point(299, 55);
            this.lblArrayOriginal.Name = "lblArrayOriginal";
            this.lblArrayOriginal.Size = new System.Drawing.Size(112, 13);
            this.lblArrayOriginal.TabIndex = 3;
            this.lblArrayOriginal.Text = "Array 1 não ordenado.";
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.Location = new System.Drawing.Point(299, 160);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(114, 13);
            this.lblOrdenado.TabIndex = 4;
            this.lblOrdenado.Text = "Array 1 ordenado aqui.";
            // 
            // lblOrdenado2
            // 
            this.lblOrdenado2.AutoSize = true;
            this.lblOrdenado2.Location = new System.Drawing.Point(299, 261);
            this.lblOrdenado2.Name = "lblOrdenado2";
            this.lblOrdenado2.Size = new System.Drawing.Size(114, 13);
            this.lblOrdenado2.TabIndex = 5;
            this.lblOrdenado2.Text = "Array 2 ordenado aqui.";
            // 
            // lblArrayOriginal2
            // 
            this.lblArrayOriginal2.AutoSize = true;
            this.lblArrayOriginal2.Location = new System.Drawing.Point(465, 55);
            this.lblArrayOriginal2.Name = "lblArrayOriginal2";
            this.lblArrayOriginal2.Size = new System.Drawing.Size(112, 13);
            this.lblArrayOriginal2.TabIndex = 6;
            this.lblArrayOriginal2.Text = "Array 2 não ordenado.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 424);
            this.Controls.Add(this.lblArrayOriginal2);
            this.Controls.Add(this.lblOrdenado2);
            this.Controls.Add(this.lblOrdenado);
            this.Controls.Add(this.lblArrayOriginal);
            this.Controls.Add(this.btnMetodoSort);
            this.Controls.Add(this.btnOrdenaArray);
            this.Controls.Add(this.btnCriaArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriaArray;
        private System.Windows.Forms.Button btnOrdenaArray;
        private System.Windows.Forms.Button btnMetodoSort;
        private System.Windows.Forms.Label lblArrayOriginal;
        private System.Windows.Forms.Label lblOrdenado;
        private System.Windows.Forms.Label lblOrdenado2;
        private System.Windows.Forms.Label lblArrayOriginal2;
    }
}

