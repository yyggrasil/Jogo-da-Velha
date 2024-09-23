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
        public int dificuldade;
        public Informações()
        {
            InitializeComponent();
        }
        // EVENTO DE QUANDO PRECIONA O BOTAO DE INCIAR PARTIDA, VERIFICANDO TEM INFORMOU O NOME
        private void IniciarPartida(object sender, EventArgs e)
        {
            if (NomeJogador.Text == string.Empty)
            {
                MessageBox.Show("nome não pode ser vazio");
            }
            else
            {
                nome_jogador = NomeJogador.Text;


                if (difFacil.Checked)
                {
                    dificuldade = 0;    // facil
                }
                else
                {
                    dificuldade = -1;   // JxJ
                }
                Close();
            }
        }
    }
}
