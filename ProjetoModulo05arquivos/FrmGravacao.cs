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
    public partial class FrmGravacao : Form
    {
        public FrmGravacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //utilizando a classe stream writer
            string nomeArq = @"C:\Users\adm\Documents\Visual Studio 2017\exercicios\Curso Forms\ProjetoModulo05arquivos\ProjetoModulo05arquivos\bin\Debug\Arquivos\Arquivo.txt";
            if (File.Exists(nomeArq))
            {
                //verifica se o arquivo existe para inserir informacao
                //StreamWriter writer = new StreamWriter(nomeArq);

                // Adicionando texto
               // writer.WriteLine("primeiro conteudo escrito");
              //  writer.Close();
            }
            //segunda forma
            using (StreamWriter writer = new StreamWriter(nomeArq))
            {
                writer.WriteLine("Primeiro conteudo escrito parte dois");
            }
        }
    }
}
