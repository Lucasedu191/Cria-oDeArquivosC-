using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ProjetoModulo05arquivos
{
    public partial class FrmLeituraArquivo : Form
    {
        public FrmLeituraArquivo()
        {
            InitializeComponent();
        }

        private void btnLeitura_Click(object sender, EventArgs e)
        {
            //variavel para o nome do arquivo que sera criado
            //para reconhecer o local deve-se colocar um @ antes ou colocar \\
            string nomeArq = @"C:\Users\adm\Documents\Visual Studio 2017\exercicios\Curso Forms\ProjetoModulo05arquivos\ProjetoModulo05arquivos\bin\Debug\Arquivos\Arquivo.txt";
            //se o arquivo ja existir aparece a mensagem se não ele aparece outra mensagem e realiza a criaçao
            if (File.Exists(nomeArq))
            {
                //realiza a leitura de todo o arquivo apenas uma vez
                string[] array = File.ReadAllLines(nomeArq);
                lsbConteudo.Items.Clear();
                foreach (var item in array)
                {
                    lsbConteudo.Items.Add(item); 
                }
            }
        }

        private void btnLeitura2_Click(object sender, EventArgs e)
        {
            //variavel para o nome do arquivo que sera criado
            //para reconhecer o local deve-se colocar um @ antes ou colocar \\
            string nomeArq = @"C:\Users\adm\Documents\Visual Studio 2017\exercicios\Curso Forms\ProjetoModulo05arquivos\ProjetoModulo05arquivos\bin\Debug\Arquivos\Arquivo.txt";
            //se o arquivo ja existir aparece a mensagem se não ele aparece outra mensagem e realiza a criaçao
            if (File.Exists(nomeArq))
            {
                // Primeira Forma
                // //realiza a leitura linha a linha do documento 
                // StreamReader reader = new StreamReader(nomeArq);
                // string linha = reader.ReadLine();
                // lsbConteudo.Items.Clear();
                // while(linha != null)
                // {
                //     lsbConteudo.Items.Add(linha);
                //     linha = reader.ReadLine();
                //
                // }
                // reader.Close();

                // Segunda forma

                using (StreamReader reader = new StreamReader(nomeArq))
                {
                    string linha = reader.ReadLine();
                    lsbConteudo.Items.Clear();
                    while(linha != null)
                    {
                        lsbConteudo.Items.Add(linha);
                        linha = reader.ReadLine();
                    }

                }

            }
        }

        private void btnLeitura3_Click(object sender, EventArgs e)
        {
            //variavel para o nome do arquivo que sera criado
            //para reconhecer o local deve-se colocar um @ antes ou colocar \\
            string nomeArq = @"C:\Users\adm\Documents\Visual Studio 2017\exercicios\Curso Forms\ProjetoModulo05arquivos\ProjetoModulo05arquivos\bin\Debug\Arquivos\Arquivo.txt";
            //se o arquivo ja existir aparece a mensagem se não ele aparece outra mensagem e realiza a criaçao
            // if (File.Exists(nomeArq))
            // {
            //     //realiza a leitura linha a linha do documento 
            //     StreamReader reader = File.OpenText(nomeArq);
            //     lsbConteudo.Items.Clear();
            //     while (!reader.EndOfStream)
            //     {
            //         string linha = reader.ReadLine();
            //         lsbConteudo.Items.Add(linha);
            //     }
            //     
            //     reader.Close();
            // }


            //utilizando a forma using vc faz com que o c# 
            //atue encontrando uma forma de arrumar algum erro durante a execucao
            using (StreamReader reader = File.OpenText(nomeArq))
            {
                lsbConteudo.Items.Clear();
                while (!reader.EndOfStream)
                 {
                     string linha = reader.ReadLine();
                     lsbConteudo.Items.Add(linha);
                 }
            }

        }
    }
}
