using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosAleatorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeraNumero_Click(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();
            int valorInteiro = numAleatorio.Next(1,101);
            double valorDecimal = numAleatorio.NextDouble();
            lblNumInt.Text = valorInteiro.ToString();
            lblNumDouble.Text = valorDecimal.ToString();
        }
    }
}
