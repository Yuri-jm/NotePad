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
    public partial class Localizar : Form
    {
        public Localizar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String busca = txtBxLocalizar.Text;
            String texto = ((Form1)this.Owner).richTextBox1.Text;

            //Procura parte da palavra e inteira
            RichTextBoxFinds regraDePesquisa = RichTextBoxFinds.None;

            if (chckBxCaseSensitive.Checked == true)
            {
                //Maiúscula e minúscula
                regraDePesquisa = RichTextBoxFinds.MatchCase;
            }

            if (chckBxPalavraInteira.Checked == true)
            {
                regraDePesquisa = RichTextBoxFinds.WholeWord;
            }
            //procurar palavra no texto
            //localiza última ocorrência do que foi buscado
            int index = 0;
            while(index < ((Form1)this.Owner).richTextBox1.Text.LastIndexOf(busca))
            {
                ((Form1)this.Owner).richTextBox1.Find(busca, index, texto.Length, regraDePesquisa);
                ((Form1)this.Owner).richTextBox1.SelectionBackColor = Color.Lime;
                index = ((Form1)this.Owner).richTextBox1.Text.IndexOf(busca, index) + 1;
            }
            this.Close();
        }
    }
}
