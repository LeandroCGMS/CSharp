using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenacao_Bubble_Sort
{
    public partial class Form1 : Form
    {
        int[] x = { 2, 1, 8, 7, 5, 9, 15, 3, 6 };
        int[] y = { 4, 2, 9, 7, 6, 18, 11, 4, 8 };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriaArray_Click(object sender, EventArgs e)
        {
            lblArrayOriginal.Text = "Itens do array na ordem original:\n";
            for ( int i = 0; i < x.Length; i++)
            {
                lblArrayOriginal.Text += " " + x[i];
            }

            lblArrayOriginal2.Text = "Itens do array na ordem original:\n";
            for (int i = 0; i < y.Length; i++)
            {
                lblArrayOriginal2.Text += " " + y[i];
            }

        }

        private void btnOrdenaArray_Click(object sender, EventArgs e)
        {
            //Ordenando e exibindo o array:
            bubblesort(x);
            lblOrdenado.Text = "Itens do array ordenados:\n";
            for ( int i = 0; i < x.Length; i++)
            {
                lblOrdenado.Text += " " + x[i];
            }

        }

        //criando o método bubblesort
        public void bubblesort(int[] y)
        {
            for ( int i = 1; i < y.Length; i++)
            {
                for( int j = 0; j < y.Length; j++)
                {
                    if(j < y.Length -1)
                    {
                        if (y[j] > y[j + 1])
                        {
                            troca(y, j);
                        }
                    }
                    
                }
            }
        }

        //algoritmo de troca de valores de variáveis
        public void troca(int[] g, int primeiro)
        {
            int aux;
            aux = g[primeiro];
            g[primeiro] = g[primeiro + 1];
            g[primeiro + 1] = aux;
        }

        private void btnMetodoSort_Click(object sender, EventArgs e)
        {
            //Ordenando e exibindo o array:
            Array.Sort(y);
            lblOrdenado2.Text = "Itens do array ordenados:\n";
            foreach (int item in y)
            {
                lblOrdenado2.Text += " " + item.ToString();
            }
        }
    }
}
