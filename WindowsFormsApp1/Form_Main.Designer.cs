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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Title_None = new System.Windows.Forms.RadioButton();
            this.radioButton_Title_Jp = new System.Windows.Forms.RadioButton();
            this.radioButton_Title_En = new System.Windows.Forms.RadioButton();
            this.radioButton_Title_Title = new System.Windows.Forms.RadioButton();
            this.textBox_Title_Default = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Title_English = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Title_Japanese = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_StartingEpisode = new System.Windows.Forms.TextBox();
            this.textBox_SectionDivider = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_IncludeEpisode = new System.Windows.Forms.CheckBox();
            this.checkBox_IncludeSeason = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_Episodes_None = new System.Windows.Forms.RadioButton();
            this.radioButton_Episodes_Jp = new System.Windows.Forms.RadioButton();
            this.radioButton_Episodes_En = new System.Windows.Forms.RadioButton();
            this.radioButton_Episodes_Default = new System.Windows.Forms.RadioButton();
            this.textBox_Season = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_Season_Suffix = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Season_Prefix = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Season_Digits = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_Episode_Suffix = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_Episode_Prefix = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_Episode_Digits = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seriesS00E00ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seriesS00E00EpisodeTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seriesS00E00ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seriesS00E00EpisodeTitleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.episodeTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectGitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Size = new System.Drawing.Size(1126, 599);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseDoubleClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseClick);
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
            this.label1.Location = new System.Drawing.Point(12, 627);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Folder";
            // 
            // textBox_SourceFolder
            // 
            this.textBox_SourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SourceFolder.Location = new System.Drawing.Point(12, 643);
            this.textBox_SourceFolder.Name = "textBox_SourceFolder";
            this.textBox_SourceFolder.Size = new System.Drawing.Size(382, 20);
            this.textBox_SourceFolder.TabIndex = 2;
            this.textBox_SourceFolder.TextChanged += new System.EventHandler(this.TextBox_SourceFolder_TextChanged);
            // 
            // button_SourceFolder
            // 
            this.button_SourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SourceFolder.Location = new System.Drawing.Point(400, 643);
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
            this.textBox_AnimeID.Location = new System.Drawing.Point(12, 693);
            this.textBox_AnimeID.Name = "textBox_AnimeID";
            this.textBox_AnimeID.Size = new System.Drawing.Size(61, 20);
            this.textBox_AnimeID.TabIndex = 5;
            this.textBox_AnimeID.Text = "6547";
            this.textBox_AnimeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_AnimeID_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 677);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Anime ID";
            // 
            // button_GetAnimeInfo
            // 
            this.button_GetAnimeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_GetAnimeInfo.Location = new System.Drawing.Point(190, 681);
            this.button_GetAnimeInfo.Name = "button_GetAnimeInfo";
            this.button_GetAnimeInfo.Size = new System.Drawing.Size(93, 32);
            this.button_GetAnimeInfo.TabIndex = 6;
            this.button_GetAnimeInfo.Text = "Manual Load";
            this.button_GetAnimeInfo.UseVisualStyleBackColor = true;
            this.button_GetAnimeInfo.Click += new System.EventHandler(this.Button_GetAnimeInfo_Click);
            // 
            // button_Rename
            // 
            this.button_Rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Rename.Location = new System.Drawing.Point(954, 946);
            this.button_Rename.Name = "button_Rename";
            this.button_Rename.Size = new System.Drawing.Size(183, 55);
            this.button_Rename.TabIndex = 7;
            this.button_Rename.Text = "Rename";
            this.button_Rename.UseVisualStyleBackColor = true;
            this.button_Rename.Click += new System.EventHandler(this.Button_Rename_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(83, 681);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton_Title_None);
            this.groupBox1.Controls.Add(this.radioButton_Title_Jp);
            this.groupBox1.Controls.Add(this.radioButton_Title_En);
            this.groupBox1.Controls.Add(this.radioButton_Title_Title);
            this.groupBox1.Location = new System.Drawing.Point(681, 627);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 119);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Title";
            // 
            // radioButton_Title_None
            // 
            this.radioButton_Title_None.AutoSize = true;
            this.radioButton_Title_None.Location = new System.Drawing.Point(7, 89);
            this.radioButton_Title_None.Name = "radioButton_Title_None";
            this.radioButton_Title_None.Size = new System.Drawing.Size(69, 17);
            this.radioButton_Title_None.TabIndex = 3;
            this.radioButton_Title_None.Text = "Omit Title";
            this.radioButton_Title_None.UseVisualStyleBackColor = true;
            this.radioButton_Title_None.CheckedChanged += new System.EventHandler(this.RadioButton_Title_None_CheckedChanged);
            // 
            // radioButton_Title_Jp
            // 
            this.radioButton_Title_Jp.AutoSize = true;
            this.radioButton_Title_Jp.Location = new System.Drawing.Point(7, 66);
            this.radioButton_Title_Jp.Name = "radioButton_Title_Jp";
            this.radioButton_Title_Jp.Size = new System.Drawing.Size(93, 17);
            this.radioButton_Title_Jp.TabIndex = 2;
            this.radioButton_Title_Jp.Text = "Use Japanese";
            this.radioButton_Title_Jp.UseVisualStyleBackColor = true;
            this.radioButton_Title_Jp.CheckedChanged += new System.EventHandler(this.RadioButton_Title_Jp_CheckedChanged);
            // 
            // radioButton_Title_En
            // 
            this.radioButton_Title_En.AutoSize = true;
            this.radioButton_Title_En.Location = new System.Drawing.Point(7, 43);
            this.radioButton_Title_En.Name = "radioButton_Title_En";
            this.radioButton_Title_En.Size = new System.Drawing.Size(81, 17);
            this.radioButton_Title_En.TabIndex = 1;
            this.radioButton_Title_En.Text = "Use English";
            this.radioButton_Title_En.UseVisualStyleBackColor = true;
            this.radioButton_Title_En.CheckedChanged += new System.EventHandler(this.RadioButton_Title_En_CheckedChanged);
            // 
            // radioButton_Title_Title
            // 
            this.radioButton_Title_Title.AutoSize = true;
            this.radioButton_Title_Title.Checked = true;
            this.radioButton_Title_Title.Location = new System.Drawing.Point(7, 20);
            this.radioButton_Title_Title.Name = "radioButton_Title_Title";
            this.radioButton_Title_Title.Size = new System.Drawing.Size(104, 17);
            this.radioButton_Title_Title.TabIndex = 0;
            this.radioButton_Title_Title.TabStop = true;
            this.radioButton_Title_Title.Text = "Use Default Title";
            this.radioButton_Title_Title.UseVisualStyleBackColor = true;
            this.radioButton_Title_Title.CheckedChanged += new System.EventHandler(this.RadioButton_Title_Title_CheckedChanged);
            // 
            // textBox_Title_Default
            // 
            this.textBox_Title_Default.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Title_Default.Location = new System.Drawing.Point(12, 766);
            this.textBox_Title_Default.Name = "textBox_Title_Default";
            this.textBox_Title_Default.Size = new System.Drawing.Size(382, 20);
            this.textBox_Title_Default.TabIndex = 12;
            this.textBox_Title_Default.TextChanged += new System.EventHandler(this.TextBox_Title_Default_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 750);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Default Title";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 739);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 2);
            this.label4.TabIndex = 13;
            // 
            // textBox_Title_English
            // 
            this.textBox_Title_English.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Title_English.Location = new System.Drawing.Point(12, 814);
            this.textBox_Title_English.Name = "textBox_Title_English";
            this.textBox_Title_English.Size = new System.Drawing.Size(382, 20);
            this.textBox_Title_English.TabIndex = 15;
            this.textBox_Title_English.TextChanged += new System.EventHandler(this.TextBox_Title_English_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 798);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "English Title";
            // 
            // textBox_Title_Japanese
            // 
            this.textBox_Title_Japanese.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Title_Japanese.Location = new System.Drawing.Point(12, 862);
            this.textBox_Title_Japanese.Name = "textBox_Title_Japanese";
            this.textBox_Title_Japanese.Size = new System.Drawing.Size(382, 20);
            this.textBox_Title_Japanese.TabIndex = 17;
            this.textBox_Title_Japanese.TextChanged += new System.EventHandler(this.TextBox_Title_Japanese_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 846);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Japanese Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox_StartingEpisode);
            this.groupBox2.Controls.Add(this.textBox_SectionDivider);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(836, 627);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 244);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advanced";
            // 
            // textBox_StartingEpisode
            // 
            this.textBox_StartingEpisode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_StartingEpisode.Location = new System.Drawing.Point(6, 82);
            this.textBox_StartingEpisode.Name = "textBox_StartingEpisode";
            this.textBox_StartingEpisode.Size = new System.Drawing.Size(79, 20);
            this.textBox_StartingEpisode.TabIndex = 22;
            this.textBox_StartingEpisode.Text = "1";
            this.textBox_StartingEpisode.TextChanged += new System.EventHandler(this.TextBox_StartingEpisode_TextChanged);
            // 
            // textBox_SectionDivider
            // 
            this.textBox_SectionDivider.AccessibleDescription = "";
            this.textBox_SectionDivider.Location = new System.Drawing.Point(6, 32);
            this.textBox_SectionDivider.Name = "textBox_SectionDivider";
            this.textBox_SectionDivider.Size = new System.Drawing.Size(79, 20);
            this.textBox_SectionDivider.TabIndex = 1;
            this.textBox_SectionDivider.Text = " - ";
            this.textBox_SectionDivider.TextChanged += new System.EventHandler(this.TextBox_SectionDivider_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Starting Episode";
            // 
            // label7
            // 
            this.label7.AccessibleDescription = "";
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Section Divider";
            // 
            // checkBox_IncludeEpisode
            // 
            this.checkBox_IncludeEpisode.AutoSize = true;
            this.checkBox_IncludeEpisode.Checked = true;
            this.checkBox_IncludeEpisode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_IncludeEpisode.Location = new System.Drawing.Point(7, 0);
            this.checkBox_IncludeEpisode.Name = "checkBox_IncludeEpisode";
            this.checkBox_IncludeEpisode.Size = new System.Drawing.Size(64, 17);
            this.checkBox_IncludeEpisode.TabIndex = 24;
            this.checkBox_IncludeEpisode.Text = "Episode";
            this.checkBox_IncludeEpisode.UseVisualStyleBackColor = true;
            this.checkBox_IncludeEpisode.CheckedChanged += new System.EventHandler(this.CheckBox_IncludeEpisode_CheckedChanged);
            // 
            // checkBox_IncludeSeason
            // 
            this.checkBox_IncludeSeason.AutoSize = true;
            this.checkBox_IncludeSeason.Checked = true;
            this.checkBox_IncludeSeason.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_IncludeSeason.Location = new System.Drawing.Point(7, 0);
            this.checkBox_IncludeSeason.Name = "checkBox_IncludeSeason";
            this.checkBox_IncludeSeason.Size = new System.Drawing.Size(62, 17);
            this.checkBox_IncludeSeason.TabIndex = 23;
            this.checkBox_IncludeSeason.Text = "Season";
            this.checkBox_IncludeSeason.UseVisualStyleBackColor = true;
            this.checkBox_IncludeSeason.CheckedChanged += new System.EventHandler(this.CheckBox_IncludeSeason_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.radioButton_Episodes_None);
            this.groupBox3.Controls.Add(this.radioButton_Episodes_Jp);
            this.groupBox3.Controls.Add(this.radioButton_Episodes_En);
            this.groupBox3.Controls.Add(this.radioButton_Episodes_Default);
            this.groupBox3.Location = new System.Drawing.Point(681, 752);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 119);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Episodes";
            // 
            // radioButton_Episodes_None
            // 
            this.radioButton_Episodes_None.AutoSize = true;
            this.radioButton_Episodes_None.Location = new System.Drawing.Point(7, 89);
            this.radioButton_Episodes_None.Name = "radioButton_Episodes_None";
            this.radioButton_Episodes_None.Size = new System.Drawing.Size(69, 17);
            this.radioButton_Episodes_None.TabIndex = 3;
            this.radioButton_Episodes_None.Text = "Omit Title";
            this.radioButton_Episodes_None.UseVisualStyleBackColor = true;
            this.radioButton_Episodes_None.CheckedChanged += new System.EventHandler(this.RadioButton_Episodes_None_CheckedChanged);
            // 
            // radioButton_Episodes_Jp
            // 
            this.radioButton_Episodes_Jp.AutoSize = true;
            this.radioButton_Episodes_Jp.Location = new System.Drawing.Point(7, 66);
            this.radioButton_Episodes_Jp.Name = "radioButton_Episodes_Jp";
            this.radioButton_Episodes_Jp.Size = new System.Drawing.Size(93, 17);
            this.radioButton_Episodes_Jp.TabIndex = 2;
            this.radioButton_Episodes_Jp.Text = "Use Japanese";
            this.radioButton_Episodes_Jp.UseVisualStyleBackColor = true;
            this.radioButton_Episodes_Jp.CheckedChanged += new System.EventHandler(this.RadioButton_Episodes_Jp_CheckedChanged);
            // 
            // radioButton_Episodes_En
            // 
            this.radioButton_Episodes_En.AutoSize = true;
            this.radioButton_Episodes_En.Location = new System.Drawing.Point(7, 43);
            this.radioButton_Episodes_En.Name = "radioButton_Episodes_En";
            this.radioButton_Episodes_En.Size = new System.Drawing.Size(81, 17);
            this.radioButton_Episodes_En.TabIndex = 1;
            this.radioButton_Episodes_En.Text = "Use English";
            this.radioButton_Episodes_En.UseVisualStyleBackColor = true;
            this.radioButton_Episodes_En.CheckedChanged += new System.EventHandler(this.RadioButton_Episodes_En_CheckedChanged);
            // 
            // radioButton_Episodes_Default
            // 
            this.radioButton_Episodes_Default.AutoSize = true;
            this.radioButton_Episodes_Default.Checked = true;
            this.radioButton_Episodes_Default.Location = new System.Drawing.Point(7, 20);
            this.radioButton_Episodes_Default.Name = "radioButton_Episodes_Default";
            this.radioButton_Episodes_Default.Size = new System.Drawing.Size(104, 17);
            this.radioButton_Episodes_Default.TabIndex = 0;
            this.radioButton_Episodes_Default.TabStop = true;
            this.radioButton_Episodes_Default.Text = "Use Default Title";
            this.radioButton_Episodes_Default.UseVisualStyleBackColor = true;
            this.radioButton_Episodes_Default.CheckedChanged += new System.EventHandler(this.RadioButton_Episodes_Default_CheckedChanged);
            // 
            // textBox_Season
            // 
            this.textBox_Season.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Season.Location = new System.Drawing.Point(12, 910);
            this.textBox_Season.Name = "textBox_Season";
            this.textBox_Season.Size = new System.Drawing.Size(43, 20);
            this.textBox_Season.TabIndex = 20;
            this.textBox_Season.TextChanged += new System.EventHandler(this.TextBox_Season_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 894);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Season";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.textBox_Season_Suffix);
            this.groupBox4.Controls.Add(this.checkBox_IncludeSeason);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBox_Season_Prefix);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBox_Season_Digits);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(681, 877);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 59);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // textBox_Season_Suffix
            // 
            this.textBox_Season_Suffix.Location = new System.Drawing.Point(155, 32);
            this.textBox_Season_Suffix.Name = "textBox_Season_Suffix";
            this.textBox_Season_Suffix.Size = new System.Drawing.Size(104, 20);
            this.textBox_Season_Suffix.TabIndex = 30;
            this.textBox_Season_Suffix.TextChanged += new System.EventHandler(this.TextBox_Season_Suffix_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(155, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Suffix";
            // 
            // textBox_Season_Prefix
            // 
            this.textBox_Season_Prefix.Location = new System.Drawing.Point(6, 32);
            this.textBox_Season_Prefix.Name = "textBox_Season_Prefix";
            this.textBox_Season_Prefix.Size = new System.Drawing.Size(104, 20);
            this.textBox_Season_Prefix.TabIndex = 28;
            this.textBox_Season_Prefix.Text = "S";
            this.textBox_Season_Prefix.TextChanged += new System.EventHandler(this.TextBox_Season_Prefix_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Prefix";
            // 
            // textBox_Season_Digits
            // 
            this.textBox_Season_Digits.Location = new System.Drawing.Point(116, 32);
            this.textBox_Season_Digits.Name = "textBox_Season_Digits";
            this.textBox_Season_Digits.Size = new System.Drawing.Size(33, 20);
            this.textBox_Season_Digits.TabIndex = 26;
            this.textBox_Season_Digits.Text = "00";
            this.textBox_Season_Digits.TextChanged += new System.EventHandler(this.TextBox_Season_Digits_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Digits";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.checkBox_IncludeEpisode);
            this.groupBox5.Controls.Add(this.textBox_Episode_Suffix);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.textBox_Episode_Prefix);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.textBox_Episode_Digits);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Location = new System.Drawing.Point(681, 942);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(267, 59);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            // 
            // textBox_Episode_Suffix
            // 
            this.textBox_Episode_Suffix.Location = new System.Drawing.Point(155, 32);
            this.textBox_Episode_Suffix.Name = "textBox_Episode_Suffix";
            this.textBox_Episode_Suffix.Size = new System.Drawing.Size(104, 20);
            this.textBox_Episode_Suffix.TabIndex = 30;
            this.textBox_Episode_Suffix.TextChanged += new System.EventHandler(this.TextBox_Episode_Suffix_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(155, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Suffix";
            // 
            // textBox_Episode_Prefix
            // 
            this.textBox_Episode_Prefix.Location = new System.Drawing.Point(6, 32);
            this.textBox_Episode_Prefix.Name = "textBox_Episode_Prefix";
            this.textBox_Episode_Prefix.Size = new System.Drawing.Size(104, 20);
            this.textBox_Episode_Prefix.TabIndex = 28;
            this.textBox_Episode_Prefix.Text = "E";
            this.textBox_Episode_Prefix.TextChanged += new System.EventHandler(this.TextBox_Episode_Prefix_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Prefix";
            // 
            // textBox_Episode_Digits
            // 
            this.textBox_Episode_Digits.Location = new System.Drawing.Point(116, 32);
            this.textBox_Episode_Digits.Name = "textBox_Episode_Digits";
            this.textBox_Episode_Digits.Size = new System.Drawing.Size(33, 20);
            this.textBox_Episode_Digits.TabIndex = 26;
            this.textBox_Episode_Digits.Text = "00";
            this.textBox_Episode_Digits.TextChanged += new System.EventHandler(this.TextBox_Episode_Digits_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(116, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Digits";
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Refresh.Location = new System.Drawing.Point(954, 910);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(183, 31);
            this.button_Refresh.TabIndex = 32;
            this.button_Refresh.Text = "Refresh Preview";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(450, 627);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 309);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.presetsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seriesS00E00ToolStripMenuItem,
            this.seriesS00E00EpisodeTitleToolStripMenuItem,
            this.seriesS00E00ToolStripMenuItem1,
            this.seriesS00E00EpisodeTitleToolStripMenuItem1,
            this.episodeTitleToolStripMenuItem});
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.presetsToolStripMenuItem.Text = "&Presets";
            // 
            // seriesS00E00ToolStripMenuItem
            // 
            this.seriesS00E00ToolStripMenuItem.Name = "seriesS00E00ToolStripMenuItem";
            this.seriesS00E00ToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.seriesS00E00ToolStripMenuItem.Text = "Series - S00E00";
            this.seriesS00E00ToolStripMenuItem.Click += new System.EventHandler(this.SeriesS00E00ToolStripMenuItem_Click);
            // 
            // seriesS00E00EpisodeTitleToolStripMenuItem
            // 
            this.seriesS00E00EpisodeTitleToolStripMenuItem.Name = "seriesS00E00EpisodeTitleToolStripMenuItem";
            this.seriesS00E00EpisodeTitleToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.seriesS00E00EpisodeTitleToolStripMenuItem.Text = "Series - S00E00 - Episode Title";
            this.seriesS00E00EpisodeTitleToolStripMenuItem.Click += new System.EventHandler(this.SeriesS00E00EpisodeTitleToolStripMenuItem_Click);
            // 
            // seriesS00E00ToolStripMenuItem1
            // 
            this.seriesS00E00ToolStripMenuItem1.Name = "seriesS00E00ToolStripMenuItem1";
            this.seriesS00E00ToolStripMenuItem1.Size = new System.Drawing.Size(229, 22);
            this.seriesS00E00ToolStripMenuItem1.Text = "Series [S00E00]";
            this.seriesS00E00ToolStripMenuItem1.Click += new System.EventHandler(this.SeriesS00E00ToolStripMenuItem1_Click);
            // 
            // seriesS00E00EpisodeTitleToolStripMenuItem1
            // 
            this.seriesS00E00EpisodeTitleToolStripMenuItem1.Name = "seriesS00E00EpisodeTitleToolStripMenuItem1";
            this.seriesS00E00EpisodeTitleToolStripMenuItem1.Size = new System.Drawing.Size(229, 22);
            this.seriesS00E00EpisodeTitleToolStripMenuItem1.Text = "Series [S00E00] Episode Title";
            this.seriesS00E00EpisodeTitleToolStripMenuItem1.Click += new System.EventHandler(this.SeriesS00E00EpisodeTitleToolStripMenuItem1_Click);
            // 
            // episodeTitleToolStripMenuItem
            // 
            this.episodeTitleToolStripMenuItem.Name = "episodeTitleToolStripMenuItem";
            this.episodeTitleToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.episodeTitleToolStripMenuItem.Text = "00 - Episode Title";
            this.episodeTitleToolStripMenuItem.Click += new System.EventHandler(this.EpisodeTitleToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectGitHubToolStripMenuItem,
            this.reportABugToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // projectGitHubToolStripMenuItem
            // 
            this.projectGitHubToolStripMenuItem.Name = "projectGitHubToolStripMenuItem";
            this.projectGitHubToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.projectGitHubToolStripMenuItem.Text = "Project GitHub";
            this.projectGitHubToolStripMenuItem.Click += new System.EventHandler(this.ProjectGitHubToolStripMenuItem_Click);
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reportABugToolStripMenuItem.Text = "Report A Bug";
            this.reportABugToolStripMenuItem.Click += new System.EventHandler(this.ReportABugToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 1014);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox_Season);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox_Title_Japanese);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Title_English);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Title_Default);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1166, 500);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAL Renamer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Title_None;
        private System.Windows.Forms.RadioButton radioButton_Title_Jp;
        private System.Windows.Forms.RadioButton radioButton_Title_En;
        private System.Windows.Forms.RadioButton radioButton_Title_Title;
        private System.Windows.Forms.TextBox textBox_Title_Default;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Title_English;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Title_Japanese;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_SectionDivider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_StartingEpisode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_Episodes_None;
        private System.Windows.Forms.RadioButton radioButton_Episodes_Jp;
        private System.Windows.Forms.RadioButton radioButton_Episodes_En;
        private System.Windows.Forms.RadioButton radioButton_Episodes_Default;
        private System.Windows.Forms.TextBox textBox_Season;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_Season_Suffix;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Season_Prefix;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_Season_Digits;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox_Episode_Suffix;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_Episode_Prefix;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_Episode_Digits;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.CheckBox checkBox_IncludeEpisode;
        private System.Windows.Forms.CheckBox checkBox_IncludeSeason;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seriesS00E00ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seriesS00E00EpisodeTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seriesS00E00ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seriesS00E00EpisodeTitleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem episodeTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectGitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

