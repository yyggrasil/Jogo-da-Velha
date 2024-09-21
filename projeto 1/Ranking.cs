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
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
            // Using a relative path
            string NomeArquivo = "data.csv";
            string DiretorioProjeto = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(DiretorioProjeto, NomeArquivo);
            ReadCSVToListView(filePath, ranks);
            
            /*
            ListViewItem item = new ListViewItem("0");

            item.SubItems[0].Text = "0";
            item.SubItems.Add("kaue");
            item.SubItems.Add("12");
            item.SubItems.Add("10");
            item.SubItems.Add("100");
            ranks.Items.Add(item);
            
             */
        }
        private void SaveListViewToFile(ListView listView, string filePath)
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
        public void ReadCSVToListView(string filePath, ListView rank)
        {
            

            // limpa a listview para inserir
            rank.Items.Clear();
            rank.Columns.Clear();

            // cria arquivo caso nao exista e o header
            if (File.Exists(filePath))
            {
                FileStream fs = File.Create(filePath);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    int i = 0;
                    foreach (string collum in ranks.Columns)
                    {
                        if (i < 3)
                        {
                            writer.Write(collum + ",");
                        }
                        else
                        {
                            writer.Write(collum + "\n");
                        }
                        i++;
                    }
                }
            }

            using (StreamReader reader = new StreamReader(filePath))
            {

                // leia o nome das colunas
                string headerLine = reader.ReadLine();
                string[] headers = headerLine.Split(',');
                foreach (string header in headers)
                {
                    rank.Columns.Add(header.Trim()); // retiras os espaços na direita e na esquerda
                }

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
                    rank.Items.Add(item);
                }
            }
        }
    }
}
