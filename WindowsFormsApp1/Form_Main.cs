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
using System.Collections;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{



    public partial class Form_Main : Form
    {
        List<Jikan.Episode> episodes;
        string[] fileEntries;

        private void UpdateGrid()
        {
            int fileEntryCount = 0;
            int episodeCount = -1;
            int enabledRowCount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    continue;
                }
                if (row.Cells[0].Value.ToString() == true.ToString())
                {
                    episodeCount++;
                    enabledRowCount++;
                    if (episodes.Count > episodeCount)
                    {
                        row.Cells[1].Value = Path.GetFileName(fileEntries[fileEntryCount]);
                        row.Cells[2].Value = Path.GetFileNameWithoutExtension(fileEntries[fileEntryCount]) + " - " + episodes[episodeCount].Title + Path.GetExtension(fileEntries[fileEntryCount]);
                    } else
                    {
                        row.Cells[1].Value = Path.GetFileName(fileEntries[fileEntryCount]);
                        row.Cells[2].Value = Path.GetFileName(fileEntries[fileEntryCount]);
                    }
                } else
                {
                    row.Cells[1].Value = Path.GetFileName(fileEntries[fileEntryCount]);
                    row.Cells[2].Value = Path.GetFileName(fileEntries[fileEntryCount]);
                }

                ++fileEntryCount;
            }

            button_Rename.Enabled = enabledRowCount == episodes.Count;
        }

        public class NaturalComparer : Comparer<string>
        {
            public override int Compare(string x, string y)
            {
                if (x == y) return 0;

                string[] x1, y1;
                x1 = Regex.Split(x.Replace(" ", ""), "([0-9]+)");
                y1 = Regex.Split(y.Replace(" ", ""), "([0-9]+)");

                for (int i = 0; i < x1.Length && i < y1.Length; i++)
                    if (x1[i] != y1[i]) return PartCompare(x1[i], y1[i]);

                if (y1.Length > x1.Length) return 1;
                else if (x1.Length > y1.Length) return -1;
                else return 0;
            }

            private static int PartCompare(string left, string right)
            {
                int x, y;

                if (int.TryParse(left, out x) && int.TryParse(right, out y))
                    return x.CompareTo(y);

                return left.CompareTo(right);
            }
        }

        public Form_Main()
        {
            InitializeComponent();
            episodes = new List<Jikan.Episode>();
            fileEntries = new string[] { };
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateGrid();
        }

        private void Button_SourceFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_SourceFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void TextBox_SourceFolder_TextChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBox_SourceFolder.Text))
            {
                dataGridView1.Rows.Clear();
                return;
            }

            fileEntries = Directory.GetFiles(textBox_SourceFolder.Text);

            var sortedCollection = fileEntries.ToList<string>();
            sortedCollection.OrderBy(x => x, new NaturalComparer());
            fileEntries = sortedCollection.ToArray();


            dataGridView1.Rows.Clear();
            foreach (string fileName in fileEntries)
            {
                dataGridView1.Rows.Add(true, Path.GetFileName(fileName), Path.GetFileName(fileName));
            }

            if (episodes.Count > 0)
            {
                UpdateGrid();
            }
        }

        private void Button_GetAnimeInfo_Click(object sender, EventArgs e)
        {
            episodes = Jikan.GetEpisodes(textBox_AnimeID.Text);
            var pictures = Jikan.GetPictures(textBox_AnimeID.Text);
            if (pictures != null && pictures.Count > 0)
            {
                using (System.Net.WebClient webClient = new System.Net.WebClient())
                {
                    using (Stream stream = webClient.OpenRead(pictures[0].Small))
                    {
                        pictureBox1.Image = Image.FromStream(stream);
                    }
                }
            }

            if (textBox_SourceFolder.Text.Length > 0)
            {
                UpdateGrid();
            }
        }

        private void Button_Rename_Click(object sender, EventArgs e)
        {
            button_Rename.Enabled = false;

            int fileEntryCount = 0;
            int episodeCount = -1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    continue;
                }
                if (row.Cells[0].Value.ToString() == true.ToString())
                {
                    episodeCount++;
                    if (episodes.Count > episodeCount)
                    {
                        var newName = Path.GetFileNameWithoutExtension(fileEntries[fileEntryCount]) + " - " + episodes[episodeCount].Title + Path.GetExtension(fileEntries[fileEntryCount]);
                        var newPath = fileEntries[fileEntryCount].Replace(Path.GetFileName(fileEntries[fileEntryCount]), newName);

                        File.Move(fileEntries[fileEntryCount], newPath);
                    }

                }

                ++fileEntryCount;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
