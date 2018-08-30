using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
