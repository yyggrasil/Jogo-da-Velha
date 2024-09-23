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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace projeto_1
{
    public partial class Ranking : Form
    {
        string filePath;
        public Ranking()
        {
            InitializeComponent();

            // Caminho relativo do programa
            string NomeArquivo = "ranking.csv";
            string DiretorioProjeto = Directory.GetCurrentDirectory();
            filePath = Path.Combine(DiretorioProjeto, NomeArquivo);
            ReadCSVToListView(filePath);
        }
        class Comparador : IComparer
        {
            private int col;
            public Comparador(int coluna)
            {
                col = coluna;
            }
            public int Compare(object x, object y)
            {
                return -1 * String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }
        private void SaveListViewToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // escrita dos items
                foreach (ListViewItem item in this.ranks.Items)
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
        private void sortList()
        {
            this.ranks.Sorting = SortOrder.Descending;

            // ordena pela coluna 4 (pontuação)
            this.ranks.ListViewItemSorter = new Comparador(4);

            int pos = 1;
            foreach (ListViewItem item in this.ranks.Items)
            {
                item.SubItems[0].Text = pos.ToString();
                pos++;
            }
        }
        public void ReadCSVToListView(string filePath)
        {
            // limpa a listview para inserir
            this.ranks.Items.Clear();

            using (StreamReader reader = new StreamReader(filePath))
            {
                // ler o csv
                while (!reader.EndOfStream)
                {
                    string jogador = reader.ReadLine();
                    string[] dados = jogador.Split(',');
                    ListViewItem item = new ListViewItem(dados[0].Trim());
                    for (int i = 1; i < dados.Length; i++)
                    {
                        item.SubItems.Add(dados[i].Trim());
                    }
                    this.ranks.Items.Add(item);
                }
            }
        }
        public void AddNewGame(int result, string nome)
        {
            bool achou = false;
            foreach (ListViewItem jogador in this.ranks.Items)
            {
                if (jogador.SubItems[1].Text == nome)
                {
                    achou = true;

                    // AUMENTAR O NUMERO DE PARTIDAS
                    jogador.SubItems[2].Text = (int.Parse(jogador.SubItems[2].Text) + 1).ToString();

                    if (result == 1) // jogador ganhou
                    {
                        // AUMENTAR O NUMERO DE VITORIAS
                        jogador.SubItems[3].Text = (int.Parse(jogador.SubItems[3].Text) + 1).ToString();

                        // pontuação aumenta em 10
                        jogador.SubItems[4].Text = (int.Parse(jogador.SubItems[4].Text) + 10).ToString();
                    }
                }
            }
            if (!achou)
            {
                // criar novo item 
                int pos = ranks.Items.Count;
                ListViewItem jogador = new ListViewItem(pos.ToString());
                jogador.SubItems.Add(nome);
                jogador.SubItems.Add("1"); // partida
                // vitorias e pontuação
                if (result == 1)
                {
                    jogador.SubItems.Add("1");
                    jogador.SubItems.Add("10");
                }
                else
                {
                    jogador.SubItems.Add("0");
                    jogador.SubItems.Add("0");
                }
                ranks.Items.Add(jogador);
            }
            sortList();
            SaveListViewToFile(this.filePath);
        }

        private void reset_ranking(object sender, EventArgs e)
        {
            this.ranks.Items.Clear();
        }
    }
}
