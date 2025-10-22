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


namespace Code_NT106.Q14_1_Lab02_24520656.Lab02_Bai01
{
    public partial class FormBai01 : Form
    {
        public FormBai01()
        {
            InitializeComponent();
        }

        private string GetFolderPath()
        {
            string folder = Path.Combine(Application.StartupPath, @"..\..\Lab02-Bai01");
            return Path.GetFullPath(folder); 
        }
        private void btnDocFile_Click(object sender, EventArgs e)
        {
            try
            {
                string folder = GetFolderPath();
                string filePath = Path.Combine(folder, "input1.txt");

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("⚠️ Không tìm thấy file input1.txt trong thư mục Lab02-Bai01!");
                    return;
                }

                using (StreamReader reader = new StreamReader(filePath))
                {
                    richTextBoxKQ.Text = reader.ReadToEnd();
                }

                MessageBox.Show("✅ Đọc file thành công!\nVị trí: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Đọc file thất bại!\n" + ex.Message);
            }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            try
            {
                string folder = GetFolderPath();
                string filePath = Path.Combine(folder, "output1.txt");

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(richTextBoxKQ.Text.ToUpper());
                }

                MessageBox.Show("✅ Ghi file thành công!\nVị trí: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Ghi file thất bại!\n" + ex.Message);
            }
        }


    }
}
