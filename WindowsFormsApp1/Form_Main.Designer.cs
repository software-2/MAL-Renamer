namespace WindowsFormsApp1
{
    partial class Form_Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SourceFolder = new System.Windows.Forms.TextBox();
            this.button_SourceFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox_AnimeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_GetAnimeInfo = new System.Windows.Forms.Button();
            this.button_Rename = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Current,
            this.Preview});
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(925, 590);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Width = 31;
            // 
            // Current
            // 
            this.Current.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Current.HeaderText = "Current";
            this.Current.Name = "Current";
            // 
            // Preview
            // 
            this.Preview.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Preview.HeaderText = "Preview";
            this.Preview.Name = "Preview";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Folder";
            // 
            // textBox_SourceFolder
            // 
            this.textBox_SourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_SourceFolder.Location = new System.Drawing.Point(12, 655);
            this.textBox_SourceFolder.Name = "textBox_SourceFolder";
            this.textBox_SourceFolder.Size = new System.Drawing.Size(382, 20);
            this.textBox_SourceFolder.TabIndex = 2;
            this.textBox_SourceFolder.TextChanged += new System.EventHandler(this.TextBox_SourceFolder_TextChanged);
            // 
            // button_SourceFolder
            // 
            this.button_SourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_SourceFolder.Location = new System.Drawing.Point(400, 655);
            this.button_SourceFolder.Name = "button_SourceFolder";
            this.button_SourceFolder.Size = new System.Drawing.Size(23, 19);
            this.button_SourceFolder.TabIndex = 3;
            this.button_SourceFolder.Text = "...";
            this.button_SourceFolder.UseVisualStyleBackColor = true;
            this.button_SourceFolder.Click += new System.EventHandler(this.Button_SourceFolder_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // textBox_AnimeID
            // 
            this.textBox_AnimeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_AnimeID.Location = new System.Drawing.Point(12, 723);
            this.textBox_AnimeID.Name = "textBox_AnimeID";
            this.textBox_AnimeID.Size = new System.Drawing.Size(382, 20);
            this.textBox_AnimeID.TabIndex = 5;
            this.textBox_AnimeID.Text = "6547";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 707);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Anime ID";
            // 
            // button_GetAnimeInfo
            // 
            this.button_GetAnimeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_GetAnimeInfo.Location = new System.Drawing.Point(400, 724);
            this.button_GetAnimeInfo.Name = "button_GetAnimeInfo";
            this.button_GetAnimeInfo.Size = new System.Drawing.Size(23, 19);
            this.button_GetAnimeInfo.TabIndex = 6;
            this.button_GetAnimeInfo.Text = "...";
            this.button_GetAnimeInfo.UseVisualStyleBackColor = true;
            this.button_GetAnimeInfo.Click += new System.EventHandler(this.Button_GetAnimeInfo_Click);
            // 
            // button_Rename
            // 
            this.button_Rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Rename.Enabled = false;
            this.button_Rename.Location = new System.Drawing.Point(755, 906);
            this.button_Rename.Name = "button_Rename";
            this.button_Rename.Size = new System.Drawing.Size(181, 55);
            this.button_Rename.TabIndex = 7;
            this.button_Rename.Text = "Rename";
            this.button_Rename.UseVisualStyleBackColor = true;
            this.button_Rename.Click += new System.EventHandler(this.Button_Rename_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(450, 627);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 309);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 687);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 978);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Rename);
            this.Controls.Add(this.button_GetAnimeInfo);
            this.Controls.Add(this.textBox_AnimeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_SourceFolder);
            this.Controls.Add(this.textBox_SourceFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SourceFolder;
        private System.Windows.Forms.Button button_SourceFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox_AnimeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_GetAnimeInfo;
        private System.Windows.Forms.Button button_Rename;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

