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
using System.Net;

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

        private ValidationState SafetyCheck()
        {
            if (fileEntries == null || fileEntries.Count() == 0)
            {
                if (textBox_SourceFolder.TextLength == 0)
                {
                    return ValidationState.SpecifyFolder;
                }
                return ValidationState.NoFilesPresent;
            }

            if (episodes == null || episodes.Count == 0)
            {
                return ValidationState.NoEpisodes;
            }

            int fileEntryCount = 0;
            int enabledRowCount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null || fileEntries.Count() <= fileEntryCount)
                {
                    continue;
                }
                if (row.Cells[0].Value.ToString() == true.ToString())
                {
                    enabledRowCount++;
                }

                ++fileEntryCount;
            }

            if (enabledRowCount > episodes.Count + (1 - int.Parse(textBox_StartingEpisode.Text)))
            {
                return ValidationState.TooManyFiles;
            }

            if (enabledRowCount < episodes.Count + (1 - int.Parse(textBox_StartingEpisode.Text)))
            {
                return ValidationState.TooManyEpisodes;
            }

            return ValidationState.Good;
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

            var valid = SafetyCheck();
            if (valid.Type == ValidationState.ErrorType.NoIssues)
            { 
                button_Rename.BackColor = SystemColors.Control;
            }
            else if (valid.Type == ValidationState.ErrorType.Warning)
            {
                button_Rename.BackColor = Color.LemonChiffon;
            }
            else
            {
                button_Rename.BackColor = Color.LightSalmon;
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
                if (x == y)
                {
                    return 0;
                }

                string[] x1, y1;
                x1 = Regex.Split(x.Replace(" ", ""), "([0-9]+)");
                y1 = Regex.Split(y.Replace(" ", ""), "([0-9]+)");

                for (int i = 0; i < x1.Length && i < y1.Length; i++)
                {
                    if (x1[i] != y1[i]) return PartCompare(x1[i], y1[i]);
                }

                if (y1.Length > x1.Length)
                {
                    return 1;
                }
                else if (x1.Length > y1.Length)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

            private static int PartCompare(string left, string right)
            {
                int x, y;

                if (int.TryParse(left, out x) && int.TryParse(right, out y))
                {
                    return x.CompareTo(y);
                }

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


        private bool ValidateFilesAccess()
        {
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
                        try
                        {
                            using (var fs = File.Open(fileEntries[fileEntryCount], FileMode.Open))
                            {
                                if (!fs.CanWrite)
                                {
                                    return false;
                                }
                            }
                        }
                        catch
                        {
                            return false;
                        }
                    }

                }

                ++fileEntryCount;
            }

            return true;
        }

        private void Button_Rename_Click(object sender, EventArgs e)
        {
            var valid = SafetyCheck();
            if (valid.Type == ValidationState.ErrorType.Warning)
            {
                var result = MessageBox.Show(valid.Message, "Warning! Proceed?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                {
                    return;
                }
            }
            else if (valid.Type == ValidationState.ErrorType.Error)
            {
                MessageBox.Show(valid.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateFilesAccess())
            {
                MessageBox.Show("Error! Didn't have write access to one or more files! Activating secret technique of running away! (No files have been modified)", 
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


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

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
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

            using (var editForm = new Form_CustomEdit(fileEntries[e.RowIndex], title))
            {
                var result = editForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefreshSourceFiles();
                }
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
            bool enabled = checkBox_IncludeSeason.Checked;
            textBox_Season_Prefix.Enabled = enabled;
            textBox_Season_Digits.Enabled = enabled;
            textBox_Season_Suffix.Enabled = enabled;

            UpdateGrid();
        }

        private void CheckBox_IncludeEpisode_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = checkBox_IncludeEpisode.Checked;
            textBox_Episode_Prefix.Enabled = enabled;
            textBox_Episode_Digits.Enabled = enabled;
            textBox_Episode_Suffix.Enabled = enabled;

            UpdateGrid();
        }

        private void SeriesS00E00ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_SectionDivider.Text = " - ";
            radioButton_Title_Title.Checked = true;
            radioButton_Episodes_None.Checked = true;
            checkBox_IncludeSeason.Checked = true;
            textBox_Season_Prefix.Text = "S";
            textBox_Season_Digits.Text = "00";
            textBox_Season_Suffix.Text = "";
            checkBox_IncludeEpisode.Checked = true;
            textBox_Episode_Prefix.Text = "E";
            textBox_Episode_Digits.Text = "00";
            textBox_Episode_Suffix.Text = "";
            textBox_StartingEpisode.Text = "1";
        }

        private void SeriesS00E00EpisodeTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_SectionDivider.Text = " - ";
            radioButton_Title_Title.Checked = true;
            radioButton_Episodes_Default.Checked = true;
            checkBox_IncludeSeason.Checked = true;
            textBox_Season_Prefix.Text = "S";
            textBox_Season_Digits.Text = "00";
            textBox_Season_Suffix.Text = "";
            checkBox_IncludeEpisode.Checked = true;
            textBox_Episode_Prefix.Text = "E";
            textBox_Episode_Digits.Text = "00";
            textBox_Episode_Suffix.Text = "";
            textBox_StartingEpisode.Text = "1";
        }

        private void SeriesS00E00ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox_SectionDivider.Text = " ";
            radioButton_Title_Title.Checked = true;
            radioButton_Episodes_None.Checked = true;
            checkBox_IncludeSeason.Checked = true;
            textBox_Season_Prefix.Text = "[S";
            textBox_Season_Digits.Text = "00";
            textBox_Season_Suffix.Text = "";
            checkBox_IncludeEpisode.Checked = true;
            textBox_Episode_Prefix.Text = "E";
            textBox_Episode_Digits.Text = "00";
            textBox_Episode_Suffix.Text = "]";
            textBox_StartingEpisode.Text = "1";
        }

        private void SeriesS00E00EpisodeTitleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox_SectionDivider.Text = " ";
            radioButton_Title_Title.Checked = true;
            radioButton_Episodes_Default.Checked = true;
            checkBox_IncludeSeason.Checked = true;
            textBox_Season_Prefix.Text = "[S";
            textBox_Season_Digits.Text = "00";
            textBox_Season_Suffix.Text = "";
            checkBox_IncludeEpisode.Checked = true;
            textBox_Episode_Prefix.Text = "E";
            textBox_Episode_Digits.Text = "00";
            textBox_Episode_Suffix.Text = "]";
            textBox_StartingEpisode.Text = "1";
        }

        private void EpisodeTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_SectionDivider.Text = " - ";
            radioButton_Title_None.Checked = true;
            radioButton_Episodes_Default.Checked = true;
            checkBox_IncludeSeason.Checked = false;
            textBox_Season_Prefix.Text = "S";
            textBox_Season_Digits.Text = "00";
            textBox_Season_Suffix.Text = "";
            checkBox_IncludeEpisode.Checked = true;
            textBox_Episode_Prefix.Text = "";
            textBox_Episode_Digits.Text = "00";
            textBox_Episode_Suffix.Text = "";
            textBox_StartingEpisode.Text = "1";
        }

        private void ProjectGitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/software-2/MAL-Renamer");
        }

        private void ReportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/software-2/MAL-Renamer/issues"); 
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var version = (new WebClient()).DownloadString("https://github.com/software-2/MAL-Renamer/raw/master/latestversion.txt");
            try
            {
                var parsed = Version.Parse(version);
                
                if (parsed.CompareTo(new Version(1, 0, 0)) != 0)
                {
                    var result = MessageBox.Show("There is a new version! Want to go get it?", "New Version!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://github.com/software-2/MAL-Renamer/releases");
                    }
                }
                else
                {
                    MessageBox.Show("You expected an update, but it was me! Dio!", "Up To Date!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                var result = MessageBox.Show("Sorry, I couldn't find the version number. Do you want to go to the website to check?", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://github.com/software-2/MAL-Renamer/releases"); 
                }
            }
        }
    }
}
