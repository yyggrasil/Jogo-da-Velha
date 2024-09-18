using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_1
{

    public partial class Informações : Form
    {
        public string nome_jogador = string.Empty;
        public bool dificuldade;


        public Informações()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NomeJogador.Text == string.Empty) {
                MessageBox.Show("nome não pode ser vazio");
            }
            else {
                dificuldade = difDificil.Checked; // verdadeiro se dificil selecionado
                nome_jogador = NomeJogador.Text;
                Close();
            }
        }
    }
}
