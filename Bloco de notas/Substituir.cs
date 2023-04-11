using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloco_de_notas
{
    public partial class Substituir : Form
    {
        public Substituir()
        {
            InitializeComponent();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnSubstituir_Click(object sender, EventArgs e)
        {
            String busca = txtBxLocalizar.Text;
            String novaPalavra = txtBxSubstituir.Text;
            //recebe uma cópia do frm principal
            String texto = ((Form1)this.Owner).richTextBox1.Text;
            ((Form1)this.Owner).richTextBox1.Text = texto.Replace(busca, novaPalavra);
        }

        private void Substituir_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
