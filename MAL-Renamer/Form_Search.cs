using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Search : Form
    {
        List<Jikan.SearchResult> searchResults = new List<Jikan.SearchResult> { };

        public int MAL_ID { get; set; }

        private void doSearch()
        {
            searchResults = Jikan.Search(textBox_SearchTerm.Text);

            dataGridView1.Rows.Clear();
            if (searchResults == null)
            {
                return;
            }

            foreach (Jikan.SearchResult result in searchResults)
            {
                string startYear = "-";
                if (result.StartDate != null)
                {
                    startYear = DateTime.Parse(result.StartDate, null, System.Globalization.DateTimeStyles.RoundtripKind).Year.ToString();
                }
                dataGridView1.Rows.Add(result.Title, result.EpisodeCount, startYear);
            }
        }

        public Form_Search(string searchTerm)
        {
            InitializeComponent();
            
            if (searchTerm.Length > 0)
            {
                textBox_SearchTerm.Text = searchTerm;
                doSearch();
            }
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            doSearch();
        }


        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = null;
            if (e.RowIndex >= searchResults.Count)
            {
                return;
            }

            textBox_Synopsis.Text = searchResults[e.RowIndex].Synopsis;


            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                using (Stream stream = webClient.OpenRead(searchResults[e.RowIndex].ImageURL))
                {
                    pictureBox1.Image = Image.FromStream(stream);
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                return;
            }

            System.Diagnostics.Process.Start(searchResults[dataGridView1.SelectedRows[0].Index].URL);
        }

        private void Submit()
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                return;
            }

            this.MAL_ID = searchResults[dataGridView1.SelectedRows[0].Index].ID;
            this.DialogResult = DialogResult.OK;

            Close();
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Submit();
        }
    }
}
