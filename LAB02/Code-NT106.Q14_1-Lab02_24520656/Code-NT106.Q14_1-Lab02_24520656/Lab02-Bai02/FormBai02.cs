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

namespace Code_NT106.Q14_1_Lab02_24520656.Lab02_Bai02
{
    public partial class FormBai02 : Form
    {
        public FormBai02()
        {
            InitializeComponent();
        }

        private string GetFolderPath()
        {
            string folder = Path.Combine(Application.StartupPath, @"..\..\Lab02-Bai02");
            return Path.GetFullPath(folder);
        }
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string defaultFolder = GetFolderPath();
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                Title = "Chọn file .txt để đọc",
                InitialDirectory = defaultFolder
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filepath = ofd.FileName;
                try
                {
                    string content = File.ReadAllText(filepath);
                    rtbContent.Text = content;

                    FileInfo fi = new FileInfo(filepath);
                    textBoxFileName.Text = $"{fi.Name}";
                    textBoxURL.Text = $"{fi.FullName}";
                    textBoxSize.Text = $"{fi.Length} bytes ({fi.Length / 1024.0:F2} KB)";

                    int lineCount = File.ReadAllLines(filepath).Length;
                    int charCount = content.Length;
                    int wordCount = content.Split(new char[] { ' ', '\n', '\r', '\t' },
                                                  StringSplitOptions.RemoveEmptyEntries).Length;
                    textBoxLineCount.Text = $"{lineCount}";
                    textBoxCharacterCount.Text = $"{charCount}";
                    textBoxWordCount.Text = $"{wordCount}";

                    string outputPath = Path.Combine(defaultFolder, "output2.txt");
                    File.WriteAllText(outputPath,
                        $"File name: {fi.Name}\n" +
                        $"Path: {fi.FullName}\n" +
                        $"Size: {fi.Length} bytes\n" +
                        $"Lines: {lineCount}\n" +
                        $"Words: {wordCount}\n" +
                        $"Characters: {charCount}\n\n" +
                        $"{content}"
                    );

                    MessageBox.Show("✅ Đã đọc và ghi thông tin ra file output2.txt trong thư mục Lab02_Bai02!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi đọc file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
