using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_e_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAdicionaItem.Text))
            {
                MessageBox.Show("Digite um item para adicionar à lista.", "Caixa vazia.");
            }
            else
            {
                lstAnimais.Items.Add(txtAdicionaItem.Text);
                txtAdicionaItem.Clear();
                txtAdicionaItem.Focus();
            }
        }

        private void btnPreenche_Click(object sender, EventArgs e)
        {
            if(lstAnimais.Items.Count == 0)
            {
                string[] bichos = new string[10] { "Jacaré", "Onça", "Elefante", "Girafa", "Urso", "Leão", "Tigre", "Foca", "Iena", "Rinoceronte" };
                lstAnimais.Items.AddRange(bichos);
            }
            else
            {
                MessageBox.Show("Lista já preenchida", "Lista Preenchida");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lstAnimais.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for ( int i = lstAnimais.SelectedIndices.Count -1; i >= 0; i--)
            {
                lstAnimais.Items.RemoveAt(lstAnimais.SelectedIndices[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(lstAnimais.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um item da lista.","Item Não Selecionado");
            }
            else
            {
                string item = lstAnimais.SelectedItem.ToString();
                MessageBox.Show("Item selecionado: " + item, "Item Selecionado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstAnimais.Sorted = true;
        }
    }
}
