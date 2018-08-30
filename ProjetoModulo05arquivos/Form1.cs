using System;
using System.IO;
using System.Windows.Forms;

namespace ProjetoModulo05arquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // diz o caminho de execução do programa (primeira forma)
            //MessageBox.Show(System.Environment.CurrentDirectory);

            //segunda forma

            MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory);
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            //variavel para o nome do arquivo que sera criado
            string nomeArq = "Arquivo.txt";
            //criaçao do arquivo
            Stream arquivo = File.Create(nomeArq);
        }
    }
}
