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
            //para reconhecer o local deve-se colocar um @ antes ou colocar \\
            string nomeArq = @"C:\Users\adm\Documents\Visual Studio 2017\exercicios\Curso Forms\ProjetoModulo05arquivos\ProjetoModulo05arquivos\bin\Debug\Arquivos\Arquivo.txt";
            //se o arquivo ja existir aparece a mensagem se não ele aparece outra mensagem e realiza a criaçao
            if(File.Exists(nomeArq))
            {
                MessageBox.Show("Arquivo existe");
            }
            else
            {
                MessageBox.Show("Arquivo não existe");
                //criaçao do arquivo
                Stream arquivo = File.Create(nomeArq);
                //fecha o arquivo(para que nao fique em uso)
                arquivo.Close();
            }
           
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string nomeArq = @"C:\Users\adm\Documents\Visual Studio 2017\exercicios\Curso Forms\ProjetoModulo05arquivos\ProjetoModulo05arquivos\bin\Debug\Arquivos\Arquivo.txt";
            if (File.Exists(nomeArq))
            {
                MessageBox.Show("Arquivo existe");
                //Exclui o arquivo
                File.Delete(nomeArq);
            }
            else
            {
                MessageBox.Show("Arquivo não existe");
             
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomepasta = @"C:\Users\adm\Documents\Visual Studio 2017\exercicios\Curso Forms\ProjetoModulo05arquivos\ProjetoModulo05arquivos\bin\Debug\Exemplos";
            //cria uma nova pasta e  cria um arquivo txt no repositorio
            string nomeArquivo = nomepasta + @"\PrimeiroExemplo.txt";
            //baseado no local é criado uma nova pasta
            if(!Directory.Exists(nomepasta))
            {
                Directory.CreateDirectory(nomepasta);
            }
            if( !File.Exists(nomeArquivo))
            {
                File.Create(nomeArquivo);
            }
            
        }
    }
}
