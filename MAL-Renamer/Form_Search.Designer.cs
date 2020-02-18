namespace MALRenamer
{
    partial class Form_Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SearchTerm = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Episodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Submit = new System.Windows.Forms.Button();
            this.textBox_Synopsis = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Term";
            // 
            // textBox_SearchTerm
            // 
            this.textBox_SearchTerm.Location = new System.Drawing.Point(12, 25);
            this.textBox_SearchTerm.Name = "textBox_SearchTerm";
            this.textBox_SearchTerm.Size = new System.Drawing.Size(318, 20);
            this.textBox_SearchTerm.TabIndex = 1;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(336, 25);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(60, 20);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Episodes,
            this.StartYear});
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(530, 282);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseDoubleClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Episodes
            // 
            this.Episodes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Episodes.HeaderText = "Episodes";
            this.Episodes.Name = "Episodes";
            this.Episodes.ReadOnly = true;
            this.Episodes.Width = 75;
            // 
            // StartYear
            // 
            this.StartYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StartYear.HeaderText = "Start";
            this.StartYear.Name = "StartYear";
            this.StartYear.ReadOnly = true;
            this.StartYear.Width = 54;
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(689, 411);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(98, 31);
            this.button_Submit.TabIndex = 11;
            this.button_Submit.Text = "Select";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // textBox_Synopsis
            // 
            this.textBox_Synopsis.Location = new System.Drawing.Point(12, 340);
            this.textBox_Synopsis.Multiline = true;
            this.textBox_Synopsis.Name = "textBox_Synopsis";
            this.textBox_Synopsis.Size = new System.Drawing.Size(530, 98);
            this.textBox_Synopsis.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(563, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 309);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Synopsis);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_SearchTerm);
            this.Controls.Add(this.label1);
            this.Name = "Form_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search For Anime";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SearchTerm;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Episodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartYear;
        private System.Windows.Forms.TextBox textBox_Synopsis;
    }
}