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
    public partial class Form_CustomEdit : Form
    {
        private string originalFilename;
        private string prefix;

        public string newFilename { get; set; }

        private string generateNewFilename(string custom)
        {
            return prefix +
                textBox_Custom.Text +
                Path.GetExtension(originalFilename);
        }

        public Form_CustomEdit(string originalFilename, string prefix)
        {
            InitializeComponent();
            this.CenterToParent();

            this.originalFilename = originalFilename;
            this.prefix = prefix;

            textBox_Original.Text = Path.GetFileName(originalFilename);
            textBox_New.Text = generateNewFilename("");
        }

        private void Button_Rename_Click(object sender, EventArgs e)
        {
            var newName = textBox_New.Text;
            var newPath = originalFilename.Replace(Path.GetFileName(originalFilename), newName);

            File.Move(originalFilename, newPath);

            this.DialogResult = DialogResult.OK;
            this.newFilename = newPath;

            Close();
        }

        private void TextBox_Custom_TextChanged(object sender, EventArgs e)
        {
            textBox_New.Text = generateNewFilename(textBox_Custom.Text);
        }
    }
}
