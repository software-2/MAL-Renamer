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
        Jikan.GeneralInfo info;
        string[] fileEntries;

        private string GenerateFileName(int index, string fileExtension)
        {
            if (fileEntries.Count() < index - 1)
            {
                return "Error: File count exceeds index!";
            }
            if (episodes.Count < index)
            {
                return "Error: Episodes count exceeds index!";
            }


            string title = "";
            if (radioButton_Title_Title.Checked)
            {
                title = textBox_Title_Default.Text + textBox_SectionDivider.Text;
            }
            else if (radioButton_Title_En.Checked)
            {
                title = textBox_Title_English.Text + textBox_SectionDivider.Text;
            }
            else if (radioButton_Title_Jp.Checked)
            {
                title = textBox_Title_Japanese.Text + textBox_SectionDivider.Text;
            }

            string season = "";
            if (checkBox_IncludeSeason.Checked)
            {
                season = textBox_Season_Prefix.Text + 
                    int.Parse(textBox_Season.Text).ToString(textBox_Season_Digits.Text) +
                    textBox_Season_Suffix.Text;
            }

            string episode = "";
            if (checkBox_IncludeEpisode.Checked)
            {
                episode = textBox_Episode_Prefix.Text + 
                    index.ToString(textBox_Episode_Digits.Text) + 
                    textBox_Episode_Suffix.Text;
            }

            string episodeTitle = "";
            if (radioButton_Episodes_Default.Checked)
            {
                episodeTitle = textBox_SectionDivider.Text + episodes[index - 1].Title;
            }
            else if (radioButton_Episodes_Default.Checked)
            {
                episodeTitle = textBox_SectionDivider.Text + episodes[index - 1].TitleRO;
            }
            else if (radioButton_Episodes_Default.Checked)
            {
                episodeTitle = textBox_SectionDivider.Text + episodes[index - 1].TitleJP;
            }


            return title + season + episode + episodeTitle + fileExtension;

        }

        private bool isKnownVideoFile(string extension)
        {
            string[] formats = new [] { ".WEBM", ".MKV", ".MPG", ".MP2", ".MPEG", ".MPE", ".MPV", ".OGG", ".MP4", ".M4P", ".M4V", ".AVI", ".WMV", ".MOV", ".QT", ".FLV", ".SWF", ".AVCHD"};
            return formats.Contains(extension, StringComparer.OrdinalIgnoreCase);
        }

        private void UpdateGrid()
        {
            int fileEntryCount = 0;
            int episodeCount = -1;
            int enabledRowCount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null || fileEntries.Count() <= fileEntryCount)
                {
                    continue;
                }
                if (row.Cells[0].Value.ToString() == true.ToString())
                {
                    episodeCount++;
                    enabledRowCount++;
                    row.Cells[1].Value = Path.GetFileName(fileEntries[fileEntryCount]);
                    row.Cells[2].Value = GenerateFileName(episodeCount + int.Parse(textBox_StartingEpisode.Text), Path.GetExtension(fileEntries[fileEntryCount]));
                } else
                {
                    row.Cells[1].Value = Path.GetFileName(fileEntries[fileEntryCount]);
                    row.Cells[2].Value = Path.GetFileName(fileEntries[fileEntryCount]);
                }

                ++fileEntryCount;
            }

            if (episodes != null)
            {
                button_Rename.Enabled = enabledRowCount == episodes.Count;
            }
        }

        private async Task GetAnimeInfoAsync()
        {
            Form loading = new Form_Loading();
            loading.Show(this);
            await loadAnimeInfo();
            loading.Close();

            textBox_Title_Default.Text = info.Title;
            textBox_Title_English.Text = info.TitleEnglish;
            textBox_Title_Japanese.Text = info.TitleJapanese;

            if (textBox_SourceFolder.Text.Length > 0)
            {
                UpdateGrid();
            }
        }

        private async Task loadAnimeInfo()
        {
            await Task.Run(() =>
            {
                info = Jikan.GetInfo(textBox_AnimeID.Text);
                episodes = Jikan.GetEpisodes(textBox_AnimeID.Text);

                if (info != null && info.ImageURL != null)
                {
                    using (System.Net.WebClient webClient = new System.Net.WebClient())
                    {
                        using (Stream stream = webClient.OpenRead(info.ImageURL))
                        {
                            pictureBox1.Image = Image.FromStream(stream);
                        }
                    }
                }
            });
        }

        private void RefreshSourceFiles()
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
                bool enabled = isKnownVideoFile(Path.GetExtension(fileName));
                dataGridView1.Rows.Add(enabled, Path.GetFileName(fileName), Path.GetFileName(fileName));
            }

            //Populate the Season number box
            var dirInfo = new DirectoryInfo(textBox_SourceFolder.Text);
            if (dirInfo.Name.ToLower().Contains("season"))
            {
                string afterSeason = dirInfo.Name.Substring(dirInfo.Name.ToLower().IndexOf("season") + 6);
                afterSeason = afterSeason.Trim().Replace(".", "").Replace("-", "");
                string digits = new String(afterSeason.TakeWhile(Char.IsDigit).ToArray());
                textBox_Season.Text = digits;
            }
            else
            {
                textBox_Season.Text = "1";
            }

            if (episodes.Count > 0)
            {
                UpdateGrid();
            }
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

        private void Button_SourceFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_SourceFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void TextBox_SourceFolder_TextChanged(object sender, EventArgs e)
        {
            RefreshSourceFiles();
        }

        private void Button_GetAnimeInfo_Click(object sender, EventArgs e)
        {
            _ = GetAnimeInfoAsync();
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
                        var newName = GenerateFileName(episodeCount + int.Parse(textBox_StartingEpisode.Text), Path.GetExtension(fileEntries[fileEntryCount]));
                        var newPath = fileEntries[fileEntryCount].Replace(Path.GetFileName(fileEntries[fileEntryCount]), newName);

                        File.Move(fileEntries[fileEntryCount], newPath);
                    }

                }

                ++fileEntryCount;
            }
            RefreshSourceFiles();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string searchQuery = "";
            if (Directory.Exists(textBox_SourceFolder.Text))
            {
                var dirInfo = new DirectoryInfo(textBox_SourceFolder.Text);
                searchQuery = dirInfo.Name;
                if (searchQuery.ToLower().Contains("season"))
                {
                    searchQuery = dirInfo.Parent.Name + " " + searchQuery;
                }
            }

            using (var searchForm = new Form_Search(searchQuery))
            {
                var result = searchForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBox_AnimeID.Text = searchForm.MAL_ID.ToString();
                    _ = GetAnimeInfoAsync();
                }
            }

        }

        private void TextBox_AnimeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                _ = GetAnimeInfoAsync();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (info != null)
            {
                System.Diagnostics.Process.Start(info.URL);
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateGrid();
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateGrid();
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            UpdateGrid();
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void TextBox_Title_Default_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void TextBox_Title_English_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void TextBox_Title_Japanese_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void TextBox_Season_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void TextBox_SectionDivider_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void TextBox_StartingEpisode_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void TextBox_Season_Prefix_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void TextBox_Season_Digits_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void TextBox_Season_Suffix_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void TextBox_Episode_Prefix_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void TextBox_Episode_Digits_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void TextBox_Episode_Suffix_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void RadioButton_Title_Title_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void RadioButton_Title_En_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void RadioButton_Title_Jp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void RadioButton_Title_None_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void RadioButton_Episodes_Default_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void RadioButton_Episodes_En_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void RadioButton_Episodes_Jp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void RadioButton_Episodes_None_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void CheckBox_IncludeSeason_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void CheckBox_IncludeEpisode_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
