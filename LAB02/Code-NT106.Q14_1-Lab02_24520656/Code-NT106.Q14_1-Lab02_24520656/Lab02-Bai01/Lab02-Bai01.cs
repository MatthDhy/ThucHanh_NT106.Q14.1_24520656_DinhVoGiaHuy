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


namespace Code_NT106.Q14_1_Lab02_24520656
{
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            try {
                using (StreamReader reader = new StreamReader("D:\\HK3\\LTMang\\TH\\LAB\\LAB02\\input1.txt"))
                richTextBoxKQ.Text = reader.ReadToEnd();
                MessageBox.Show("Đọc File thành công!");
            }
            catch
            {
                MessageBox.Show("Đọc File thất bại! Vui lòng kiểm tra lại.");
            }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            try
            {   
                using (StreamWriter writer = new StreamWriter("output1.txt"))
                writer.Write(richTextBoxKQ.Text.ToUpper());
                MessageBox.Show("Ghi File thành công!");
            }
            catch
            {
                MessageBox.Show("Ghi File thất bại!");
            }
        }

      
    }
}
