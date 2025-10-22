namespace Code_NT106.Q14_1_Lab02_24520656.Lab02_Bai05
{
    partial class FormBai05
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxFilms;
        private System.Windows.Forms.Panel panelSeats;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnSaveInput;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label lblFilmInfo;
        private System.Windows.Forms.Button btnOpenFolder;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxFilms = new System.Windows.Forms.ComboBox();
            this.panelSeats = new System.Windows.Forms.Panel();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnSaveInput = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.lblFilmInfo = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxFilms
            // 
            this.comboBoxFilms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxFilms.FormattingEnabled = true;
            this.comboBoxFilms.Location = new System.Drawing.Point(12, 12);
            this.comboBoxFilms.Name = "comboBoxFilms";
            this.comboBoxFilms.Size = new System.Drawing.Size(420, 28);
            this.comboBoxFilms.TabIndex = 0;
            this.comboBoxFilms.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilms_SelectedIndexChanged);
            // 
            // panelSeats
            // 
            this.panelSeats.AutoScroll = true;
            this.panelSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSeats.Location = new System.Drawing.Point(12, 50);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Size = new System.Drawing.Size(420, 360);
            this.panelSeats.TabIndex = 1;
            // 
            // btnReadFile
            // 
            this.btnReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReadFile.Location = new System.Drawing.Point(450, 10);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(140, 30);
            this.btnReadFile.TabIndex = 2;
            this.btnReadFile.Text = "Read input5.txt";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnSaveInput
            // 
            this.btnSaveInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveInput.Location = new System.Drawing.Point(610, 10);
            this.btnSaveInput.Name = "btnSaveInput";
            this.btnSaveInput.Size = new System.Drawing.Size(140, 30);
            this.btnSaveInput.TabIndex = 3;
            this.btnSaveInput.Text = "Save input5.txt";
            this.btnSaveInput.UseVisualStyleBackColor = true;
            this.btnSaveInput.Click += new System.EventHandler(this.btnSaveInput_Click);
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBook.Location = new System.Drawing.Point(450, 60);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(140, 40);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "Đặt chỗ";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(610, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy chỗ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport.Location = new System.Drawing.Point(450, 120);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(300, 40);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Xuất thống kê -> output5.txt";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(450, 180);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 25);
            this.progressBar1.TabIndex = 7;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtbOutput.Location = new System.Drawing.Point(12, 420);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(738, 220);
            this.rtbOutput.TabIndex = 8;
            this.rtbOutput.Text = "";
            // 
            // lblFilmInfo
            // 
            this.lblFilmInfo.AutoSize = true;
            this.lblFilmInfo.Location = new System.Drawing.Point(450, 220);
            this.lblFilmInfo.Name = "lblFilmInfo";
            this.lblFilmInfo.Size = new System.Drawing.Size(56, 16);
            this.lblFilmInfo.TabIndex = 9;
            this.lblFilmInfo.Text = "Film info";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOpenFolder.Location = new System.Drawing.Point(450, 250);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(140, 30);
            this.btnOpenFolder.TabIndex = 10;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // FormBai05
            // 
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(762, 652);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.lblFilmInfo);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnSaveInput);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.panelSeats);
            this.Controls.Add(this.comboBoxFilms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBai05";
            this.Text = "Bài 5 - Quản lý phòng vé (Lab02)";
            this.Load += new System.EventHandler(this.FormBai05_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
