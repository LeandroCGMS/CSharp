using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Color_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCorFundo_Click(object sender, EventArgs e)
        {
            if(cdgCaixaCores.ShowDialog() == DialogResult.OK)
            {
                txtCores.BackColor = cdgCaixaCores.Color;
            }
        }

        private void btnCorTexto_Click(object sender, EventArgs e)
        {
            ColorDialog cdgCaixaCores2 = new ColorDialog();
            cdgCaixaCores2.AllowFullOpen = false;
            cdgCaixaCores2.AnyColor = true;
            cdgCaixaCores2.SolidColorOnly = false;
            cdgCaixaCores2.Color = Color.Blue;

            if(cdgCaixaCores2.ShowDialog() == DialogResult.OK)
            {
                txtCores.ForeColor = cdgCaixaCores2.Color;
            }
        }
    }
}
