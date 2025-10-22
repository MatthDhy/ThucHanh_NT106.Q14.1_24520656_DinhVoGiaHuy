namespace Code_NT106.Q14_1_Lab02_24520656.Lab02_Bai07
{
    partial class FormBai07
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
            this.rtbcontent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // rtbcontent
            // 
            this.rtbcontent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbcontent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtbcontent.Location = new System.Drawing.Point(317, 16);
            this.rtbcontent.Name = "rtbcontent";
            this.rtbcontent.ReadOnly = true;
            this.rtbcontent.Size = new System.Drawing.Size(457, 374);
            this.rtbcontent.TabIndex = 1;
            this.rtbcontent.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "FileContent";
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(12, 16);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(277, 374);
            this.treeView.TabIndex = 3;
            // 
            // FormBai07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbcontent);
            this.Name = "FormBai07";
            this.Text = "FormBai07";
            this.Load += new System.EventHandler(this.FormBai07_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbcontent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView;
    }
}