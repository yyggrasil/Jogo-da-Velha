namespace projeto_1
{
    public partial class TitTacToe : Form
    {
        bool x_turn = true;
        Informações info = new Informações();
        public TitTacToe()
        {
            InitializeComponent();
            info.ShowDialog();
            greetings.Text = "Olá, " + info.nome_jogador;

        }
        private void Dificuldade_facil(object sender)
        {
            ((Button)sender).Text = "X";
            ((Button)sender).Enabled = false;


            int game_result = Game_Result();

            if (game_result == 0)
            {
                Random random = new Random();
                int pos0 = random.Next(9);
                Jogada_Bot(pos0);
            }
            else
            {

            }
            game_result = Game_Result();
            if (game_result == 1)
            {

            }
        }
        private void Jogada_Bot(int pos0)
        {
            int pos = 0;
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    if (pos == pos0)
                    {
                        if (((Button)c).Enabled == false)
                        {
                            Random r = new Random();
                            Jogada_Bot(r.Next(9));
                        }
                        else
                        {
                            ((Button)c).Text = "O";
                        }
                        break;
                    }
                    pos++;
                }
            }
        }
        private void Dificuldade_JxJ(object sender)
        {
            if (x_turn)
            {
                ((Button)sender).Text = "X";
            }
            else
            {
                ((Button)sender).Text = "O";
            }

            ((Button)sender).Enabled = false;
            x_turn = !(x_turn);
            Game_Result();
        }
        private int Game_Result()
        {
            bool draw = true;
            int win;
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
            win = win_check();
            if ((win == 0) && draw)
            {
                MessageBox.Show("Empate");
                win = -1;
            }
            return win;
        }
        private int win_check()
        {
            int win = 0;
            if ((button11.Text == button12.Text && button12.Text == button13.Text) && button11.Text != "" ||                             // linha um
                (button11.Text == button21.Text && button11.Text == button31.Text) && button11.Text != "")        // coluna 1
            {
                MessageBox.Show(button11.Text + " Ganhou!");
                buttons_enable(false);
                if (button11.Text == "X")
                {
                    win = 1;
                }
                else
                {
                    win = 2;
                }
            }
            else if ((button21.Text == button22.Text && button22.Text == button23.Text) && button22.Text != "" ||                        // linha dois
                    (button12.Text == button22.Text && button22.Text == button32.Text) && button22.Text != "" ||                        // coluna 2
                    (button11.Text == button22.Text && button22.Text == button33.Text) && button22.Text != "" ||                        // \
                    (button31.Text == button22.Text && button22.Text == button13.Text) && button22.Text != "")    // /
            {
                MessageBox.Show(button22.Text + " Ganhou!");
                buttons_enable(false);
                if (button11.Text == "X")
                {
                    win = 1;
                }
                else
                {
                    win = 2;
                }
            }
            else if ((button31.Text == button32.Text && button32.Text == button33.Text && button33.Text != "" ||                        // linha tres
                    button13.Text == button23.Text && button23.Text == button33.Text) && button33.Text != "")    // coluna 3
            {
                MessageBox.Show(button33.Text + " Ganhou!");
                buttons_enable(false);
                if (button11.Text == "X")
                {
                    win = 1;
                }
                else
                {
                    win = 2;
                }
            }
            return win;
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

            if (this.info.dificuldade == 0) // FACIL
            {
                Dificuldade_facil(sender);
            }
            else                            // JxJ
            {
                Dificuldade_JxJ(sender);
            }


            
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
            greetings.Text = "Olá, " + info.nome_jogador;
        }
        public void SaveListViewToFile(ListView listView, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write headers
                for (int i = 0; i < listView.Columns.Count; i++)
                {
                    writer.Write(listView.Columns[i].Text);
                    if (i < listView.Columns.Count - 1)
                        writer.Write(",");
                }
                writer.WriteLine();

                // Write rows
                foreach (ListViewItem item in listView.Items)
                {
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        writer.Write(item.SubItems[i].Text);
                        if (i < item.SubItems.Count - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();
                }
            }
        }
        public void ReadCSVToListView(string filePath, ListView listView)
        {
            // Clear existing items
            listView.Items.Clear();
            listView.Columns.Clear();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Read headers
                    string headerLine = reader.ReadLine();
                    string[] headers = headerLine.Split(',');
                    foreach (string header in headers)
                    {
                        listView.Columns.Add(header.Trim());
                    }

                    // Read data
                    while (!reader.EndOfStream)
                    {
                        string dataLine = reader.ReadLine();
                        string[] dataValues = dataLine.Split(',');
                        ListViewItem item = new ListViewItem(dataValues[0].Trim());
                        for (int i = 1; i < dataValues.Length; i++)
                        {
                            item.SubItems.Add(dataValues[i].Trim());
                        }
                        listView.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading the CSV file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
