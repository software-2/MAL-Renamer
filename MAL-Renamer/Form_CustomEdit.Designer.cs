namespace MALRenamer
{
    partial class Form_CustomEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CustomEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Original = new System.Windows.Forms.TextBox();
            this.textBox_Custom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_New = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Rename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original File Name:";
            // 
            // textBox_Original
            // 
            this.textBox_Original.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Original.Location = new System.Drawing.Point(12, 25);
            this.textBox_Original.Name = "textBox_Original";
            this.textBox_Original.ReadOnly = true;
            this.textBox_Original.Size = new System.Drawing.Size(776, 20);
            this.textBox_Original.TabIndex = 4;
            // 
            // textBox_Custom
            // 
            this.textBox_Custom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Custom.Location = new System.Drawing.Point(12, 73);
            this.textBox_Custom.Name = "textBox_Custom";
            this.textBox_Custom.Size = new System.Drawing.Size(776, 20);
            this.textBox_Custom.TabIndex = 1;
            this.textBox_Custom.TextChanged += new System.EventHandler(this.TextBox_Custom_TextChanged);
            this.textBox_Custom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Custom_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Custom:";
            // 
            // textBox_New
            // 
            this.textBox_New.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_New.Location = new System.Drawing.Point(12, 123);
            this.textBox_New.Name = "textBox_New";
            this.textBox_New.Size = new System.Drawing.Size(776, 20);
            this.textBox_New.TabIndex = 2;
            this.textBox_New.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_New_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "New File Name:";
            // 
            // button_Rename
            // 
            this.button_Rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Rename.Location = new System.Drawing.Point(660, 155);
            this.button_Rename.Name = "button_Rename";
            this.button_Rename.Size = new System.Drawing.Size(128, 44);
            this.button_Rename.TabIndex = 3;
            this.button_Rename.Text = "Rename";
            this.button_Rename.UseVisualStyleBackColor = true;
            this.button_Rename.Click += new System.EventHandler(this.Button_Rename_Click);
            // 
            // Form_CustomEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 211);
            this.Controls.Add(this.button_Rename);
            this.Controls.Add(this.textBox_New);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Custom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Original);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(284, 250);
            this.Name = "Form_CustomEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manually Modify File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Original;
        private System.Windows.Forms.TextBox textBox_Custom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_New;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Rename;
    }
}