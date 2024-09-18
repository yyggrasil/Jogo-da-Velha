namespace projeto_1
{
    public partial class TitTacToe : Form
    {
        bool x_turn = true;
        public TitTacToe()
        {
            InitializeComponent();
            Informações info = new Informações();
            info.ShowDialog();
            greetings.Text = "Olá, " + info.nome_jogador;

        }

        private bool[] win_condition()
        {
            bool draw = true, win = false;
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    if (c.Text == "")
                    {
                        draw = false;
                    }
                }
            }

            if (draw)
            {
                MessageBox.Show("Empate");
            }
            else
            {
                if (button11.Text == button12.Text && button12.Text == button13.Text && button11.Text != "" || // linha um
                    button11.Text == button21.Text && button11.Text == button31.Text && button11.Text != "") // coluna 1
                {
                    MessageBox.Show(button11.Text + " Ganhou!");
                    buttons_enable(false);
                    win = true;
                }
                else if (button21.Text == button22.Text && button22.Text == button23.Text && button22.Text != "" || // linha dois
                        button12.Text == button22.Text && button22.Text == button32.Text && button22.Text != "" || // coluna 2
                        button11.Text == button22.Text && button22.Text == button33.Text && button22.Text != "" ||  // \
                        button31.Text == button22.Text && button22.Text == button13.Text && button22.Text != "")    // /
                {
                    MessageBox.Show(button22.Text + " Ganhou!");
                    buttons_enable(false);
                    win = true;
                }
                else if (button31.Text == button32.Text && button32.Text == button33.Text && button31.Text != "" || // linha tres
                        button13.Text == button23.Text && button23.Text == button33.Text && button13.Text != "")    // coluna 3
                {
                    MessageBox.Show(button33.Text + " Ganhou!");
                    buttons_enable(false);
                    win = true;
                }
            }
            return [win, draw];
        }
        private void buttons_enable(bool c)
        {
            button11.Enabled = c;
            button12.Enabled = c;
            button13.Enabled = c;
            button21.Enabled = c;
            button22.Enabled = c;
            button23.Enabled = c;
            button31.Enabled = c;
            button32.Enabled = c;
            button33.Enabled = c;
        }
        private void buttons_clear()
        {
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";

            button21.Text = "";
            button22.Text = "";
            button23.Text = "";

            button31.Text = "";
            button32.Text = "";
            button33.Text = "";
        }

        private void Reset_Game(object sender, EventArgs e)
        {
            buttons_clear();
            buttons_enable(true);
            x_turn = true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (x_turn)
            {
                ((Button)sender).ForeColor = Color.CornflowerBlue;
                ((Button)sender).Text = "X";
            }
            else
            {
                ((Button)sender).ForeColor = Color.Red;
                ((Button)sender).Text = "O";
            }

            ((Button)sender).Enabled = false;
            x_turn = !(x_turn);
            win_condition();
        }

        private void rankingDosJogadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ranking rank = new Ranking();
            rank.ShowDialog();
        }

        private void informarDadosDoJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informações info = new Informações();
            info.ShowDialog();
        }
    }
}
