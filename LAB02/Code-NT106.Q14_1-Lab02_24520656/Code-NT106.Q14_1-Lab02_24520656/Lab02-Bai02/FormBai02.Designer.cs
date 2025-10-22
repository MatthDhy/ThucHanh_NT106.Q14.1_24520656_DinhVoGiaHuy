namespace Code_NT106.Q14_1_Lab02_24520656.Lab02_Bai02
{
    partial class FormBai02
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
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.labelFilename = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.labelLineCount = new System.Windows.Forms.Label();
            this.labelWordCount = new System.Windows.Forms.Label();
            this.labelCharacterCount = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxLineCount = new System.Windows.Forms.TextBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.textBoxCharacterCount = new System.Windows.Forms.TextBox();
            this.textBoxWordCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReadFile
            // 
            this.btnReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReadFile.Location = new System.Drawing.Point(44, 55);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(186, 53);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "Read From File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(44, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 53);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(472, 55);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(317, 402);
            this.rtbContent.TabIndex = 2;
            this.rtbContent.Text = "";
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFilename.Location = new System.Drawing.Point(39, 143);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(100, 25);
            this.labelFilename.TabIndex = 3;
            this.labelFilename.Text = "File Name";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSize.Location = new System.Drawing.Point(39, 186);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(51, 25);
            this.labelSize.TabIndex = 4;
            this.labelSize.Text = "Size";
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelURL.Location = new System.Drawing.Point(39, 233);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(50, 25);
            this.labelURL.TabIndex = 5;
            this.labelURL.Text = "URL";
            // 
            // labelLineCount
            // 
            this.labelLineCount.AutoSize = true;
            this.labelLineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLineCount.Location = new System.Drawing.Point(39, 275);
            this.labelLineCount.Name = "labelLineCount";
            this.labelLineCount.Size = new System.Drawing.Size(107, 25);
            this.labelLineCount.TabIndex = 6;
            this.labelLineCount.Text = "Line Count";
            // 
            // labelWordCount
            // 
            this.labelWordCount.AutoSize = true;
            this.labelWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelWordCount.Location = new System.Drawing.Point(39, 318);
            this.labelWordCount.Name = "labelWordCount";
            this.labelWordCount.Size = new System.Drawing.Size(123, 25);
            this.labelWordCount.TabIndex = 7;
            this.labelWordCount.Text = "Words count";
            // 
            // labelCharacterCount
            // 
            this.labelCharacterCount.AutoSize = true;
            this.labelCharacterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCharacterCount.Location = new System.Drawing.Point(39, 357);
            this.labelCharacterCount.Name = "labelCharacterCount";
            this.labelCharacterCount.Size = new System.Drawing.Size(161, 25);
            this.labelCharacterCount.TabIndex = 8;
            this.labelCharacterCount.Text = "Characters count";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFileName.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxFileName.Location = new System.Drawing.Point(224, 138);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(205, 30);
            this.textBoxFileName.TabIndex = 9;
            // 
            // textBoxSize
            // 
            this.textBoxSize.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSize.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxSize.Location = new System.Drawing.Point(224, 181);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.ReadOnly = true;
            this.textBoxSize.Size = new System.Drawing.Size(205, 30);
            this.textBoxSize.TabIndex = 10;
            // 
            // textBoxLineCount
            // 
            this.textBoxLineCount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxLineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLineCount.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxLineCount.Location = new System.Drawing.Point(224, 270);
            this.textBoxLineCount.Name = "textBoxLineCount";
            this.textBoxLineCount.ReadOnly = true;
            this.textBoxLineCount.Size = new System.Drawing.Size(205, 30);
            this.textBoxLineCount.TabIndex = 12;
            // 
            // textBoxURL
            // 
            this.textBoxURL.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxURL.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxURL.Location = new System.Drawing.Point(224, 228);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.ReadOnly = true;
            this.textBoxURL.Size = new System.Drawing.Size(205, 30);
            this.textBoxURL.TabIndex = 11;
            // 
            // textBoxCharacterCount
            // 
            this.textBoxCharacterCount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxCharacterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCharacterCount.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxCharacterCount.Location = new System.Drawing.Point(224, 352);
            this.textBoxCharacterCount.Name = "textBoxCharacterCount";
            this.textBoxCharacterCount.ReadOnly = true;
            this.textBoxCharacterCount.Size = new System.Drawing.Size(205, 30);
            this.textBoxCharacterCount.TabIndex = 14;
            // 
            // textBoxWordCount
            // 
            this.textBoxWordCount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxWordCount.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxWordCount.Location = new System.Drawing.Point(224, 313);
            this.textBoxWordCount.Name = "textBoxWordCount";
            this.textBoxWordCount.ReadOnly = true;
            this.textBoxWordCount.Size = new System.Drawing.Size(205, 30);
            this.textBoxWordCount.TabIndex = 13;
            // 
            // FormBai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(801, 637);
            this.Controls.Add(this.textBoxCharacterCount);
            this.Controls.Add(this.textBoxWordCount);
            this.Controls.Add(this.textBoxLineCount);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.labelCharacterCount);
            this.Controls.Add(this.labelWordCount);
            this.Controls.Add(this.labelLineCount);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadFile);
            this.Name = "FormBai02";
            this.Text = "Lab02_Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Label labelLineCount;
        private System.Windows.Forms.Label labelWordCount;
        private System.Windows.Forms.Label labelCharacterCount;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.TextBox textBoxLineCount;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TextBox textBoxCharacterCount;
        private System.Windows.Forms.TextBox textBoxWordCount;
    }
}