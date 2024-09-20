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

        // Usage example
        private void btnSaveListView_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveListViewToFile(ranks, saveFileDialog.FileName);
                MessageBox.Show("ListView saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            
        
    }
}
