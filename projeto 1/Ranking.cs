using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            ReadCSVToListView("ranking.csv", ranks);
            
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
        public void ReadCSVToListView(string filePath, ListView listView)
        {
            // Clear existing items
            listView.Items.Clear();
            listView.Columns.Clear();

            // cria arquivo caso nao exista
            if (File.Exists(filePath))
            {
                FileStream fs = File.Create(filePath);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string collum in ranks.Columns)
                    {
                        writer.Write(collum + ",");ranks.Columns.
                    }
                }
            }

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
