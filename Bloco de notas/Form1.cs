using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloco_de_notas
{
    public partial class Form1 : Form
    {
        bool alterado;

        //Controlar nível de zoom
        int zoom = 100;

        public Form1()
        {
            InitializeComponent();
            //Zerar a informação da extensão do arquivo, quando abrir um conteúdo novo e isso garante que não haja nenhuma informação na abertura do bl
            this.Text = "";

            //Sempre inicializa com a barra de status
            barraDeStatusToolStripMenuItem.Checked = true;

        }


        private void atualizaPosicao()
        {
            int linha = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
            int coluna = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexFromLine(linha);
            tlStrpSttsLblPosicionamento.Text = "Ln: " + 1 + linha.ToString() + " Col: " + coluna.ToString();
        }



        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrir nova instância do formulário principal
            Form1 frm = new Form1();
            //permite alternar entre as janelas abertas. ShowDialog impede isso
            frm.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            alterado = true;
            this.atualizaPosicao();
        }

        //Abrir um arquivo txt direto 
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //É necessário verificar se o arquivo foi alterado, para que ele dê a opção de salvar
            if (!alterado)
            {
                this.abrir();

            }
            else
            {
                //se o usário não quiser salvar o texto que está no bloco de notas, o programa simplesmente abre outro
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "Bloco de notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.abrir();
                }

                else

                {//significa que já existe um arquivo aberto, pq o titulo da aplicação não está em branco
                    if (this.Text != "")
                    {
                        //passa como parâmetro o nome do arquivo que já está aberto
                        this.salvar(this.Text);
                    }
                    else
                    //caso esteja em branco...
                    {
                        //ele abre caixa de diálogo perguntando o nome do arquivo a ser salvo
                        this.salvarComo();
                    }
                }
            }
        }


        private void abrir()
        {
            //Abrir caixa de dialógo te dá 2 opções, por isso é necessário criar a condicional.
            //retorna um objeto do tipo dailog result - quando clica em abrir
            if (opnFlDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                //para que o nome do arquivo aberto apareça no título do formulário
                this.Text = opnFlDlgAbrir.FileName;
                //Abrir o aquivo
                using (StreamReader reader = new StreamReader(opnFlDlgAbrir.OpenFile()))
                {
                    //Ele lê todo o conteúdo e adiciona ao rtb
                    richTextBox1.Text = reader.ReadToEnd();
                    alterado = false;
                }
                //Para adicionar o contéudo a página atual do bloco

            }
        }

        private void salvar(String arquivo)
        {
            if (arquivo != "")
            {
                //cria um arquivo no disco, no caminho e nome especificado no arquivo
                StreamWriter buffer = new StreamWriter(arquivo);

                //grava o arquivo
                buffer.Write(richTextBox1.Rtf);

                //fechando o buffer
                buffer.Close();

                //exibir nome na caixinha
                this.Text = arquivo;

                //para identificar que já foi salvo e não houve alteração
                alterado = false;

            }
            //Se o arquivo não tiver um nome especificado
            else
            {
                MessageBox.Show("Nome de arquivo inválido!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvarComo()
        {
            //abrir caixa de diálogo e verificar qual botão foi pressionado
            //significa que o usuário nomeou e clicou em ok (só vai ser possível clicar em ok, caso tenha um nome
            if (svFlDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                //caso seja isso, chama o método salvar com o parâmetro o file name da caixinha gerada no save file dialog
                this.salvar(svFlDlgAbrir.FileName);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text != "")
            {
                //passa como parâmetro o nome do arquivo que já está aberto
                this.salvar(this.Text);
            }
            else
            //caso esteja em branco...
            {
                //ele abre caixa de diálogo perguntando o nome do arquivo a ser salvo
                this.salvarComo();
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.salvarComo();
        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                //jogo o objeto para memória - em vez de texto, pois texto perderia info sobre fonte e cor
                Clipboard.SetDataObject(richTextBox1.SelectedText);
                //deixa em branco o que foi selecionado
                richTextBox1.SelectedText = "";
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                //jogo o objeto para memória 
                Clipboard.SetDataObject(richTextBox1.SelectedText);
                //mantém o texto na caixa

            }
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verificar se existe texto salvo no clipboard
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                richTextBox1.SelectedText = (String)Clipboard.GetData(DataFormats.Text);
            }

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedRtf = "";
        }

        private void buscarComOBingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedRtf != "")
            {
                String texto = richTextBox1.SelectedText;
                texto.Replace(' ', '+');

                System.Diagnostics.Process.Start("microsoft-edge:https://www.bing.com/search?q=" + texto);
            }
            else
            {
                MessageBox.Show("É necessário selecionar um termo para pesquisar.", "Buscar com o Bing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void horaEDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = System.Environment.NewLine + DateTime.Now;
        }

        private void quebraAutomáticaDeLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quebraAutomáticaDeLinhaToolStripMenuItem.CheckState == CheckState.Checked)
            {
                quebraAutomáticaDeLinhaToolStripMenuItem.CheckState = CheckState.Unchecked;
                richTextBox1.WordWrap = false;
            }
            else
            {
                quebraAutomáticaDeLinhaToolStripMenuItem.CheckState = CheckState.Checked;
                richTextBox1.WordWrap = true;
            }
        }

        private void configurarPáginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrir configuração de página
            pageSetupDialog1.ShowDialog();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrir opções de impressão
            printDialog1.ShowDialog();
        }

        //criar application exit com pergunta de fechar guia atual ou todas
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //para fechar apenas a aba atual
            this.Close();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!alterado)
            {
                this.Text = "";
                richTextBox1.Text = "";
            }

            else
            {
                //se o usário não quiser salvar o texto que está no bloco de notas, o programa simplesmente abre outro
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "Bloco de notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Text = "";
                    richTextBox1.Text = "";
                }

                else

                {//significa que já existe um arquivo aberto, pq o titulo da aplicação não está em branco
                    if (this.Text != "")
                    {
                        //passa como parâmetro o nome do arquivo que já está aberto
                        this.salvar(this.Text);
                    }
                    else
                    //caso esteja em branco...
                    {
                        //ele abre caixa de diálogo perguntando o nome do arquivo a ser salvo
                        this.salvarComo();
                    }
                }
            }

        }

        private void fonteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tlStrpSttsLblPosicionamento_Click(object sender, EventArgs e)
        {

        }


        //Somente exibe o zoom na barra de status
        private void atualizaZoom()
        {

            tlStrpSttsLblZoom.Text = this.zoom.ToString() + "%";
        }

        private void barraDeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se a barra de status estiver marcada, deve receber o oposto
            barraDeStatusToolStripMenuItem.Checked = !barraDeStatusToolStripMenuItem.Checked;
            statusStrip1.Visible = !statusStrip1.Visible;

        }

        //aumentar zoom de 1 em 1, mantendo a fonte original e chamando a função para exibir na barra de status
        private void zoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.zoom++;
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size + 1, richTextBox1.Font.Style);
            this.atualizaZoom();
        }

        private void reduzirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sinalizar zoom na barra
            this.zoom--;
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size - 1, richTextBox1.Font.Style);
            this.atualizaZoom();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //12 é o padrão
            this.zoom = 100;
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            this.atualizaZoom();
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void substituirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Além do construtor, esse novo formulário é filha do principal 
            Substituir frm = new Substituir();
            //Já enviar o conteúdo selecionado para pré preencher a caixa (alterar modificador do segundo frm)
            frm.txtBxLocalizar.Text = richTextBox1.SelectedText;
            //indicar que essa segunda tela é dependente da primeira
            frm.Show(this);

        }

        private void localizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localizar frm = new Localizar();
            frm.txtBxLocalizar.Text = richTextBox1.SelectedText;
            frm.Show(this);
        }
    }
}
