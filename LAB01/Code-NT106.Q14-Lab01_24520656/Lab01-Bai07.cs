using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_NT106.Q14_Lab01_24520656
{
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }

        private void buttonXuly_Click(object sender, EventArgs e)
        {
            string input = textBoxNhap.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("❌ Vui lòng nhập dữ liệu!");
                return;
            }

            string[] parts = input.Split(',');
            if (parts.Length < 2)
            {
                MessageBox.Show("❌ Sai format! Cần nhập tên và ít nhất 1 điểm.");
                return;
            }

            string name = parts[0].Trim();

            double[] scores = new double [parts.Length - 1];
            for (int i = 1; i < parts.Length; i++)
            {
                if (!double.TryParse(parts[i].Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out scores[i - 1]))
                {
                    MessageBox.Show($"❌ Điểm nhập sai định dạng ở vị trí {i}: {parts[i]}");
                    return;
                }
            }

            StringBuilder result = new StringBuilder();
            result.AppendLine($"Họ và tên: {name}");

            for (int i = 0; i < scores.Length; i++)
            {
                result.AppendLine($"Môn {i + 1}: {scores[i]}");
            }

            // Điểm trung bình
            double avg = scores.Average();
            result.AppendLine($"\nĐiểm trung bình: {avg:F2}");

            // Điểm cao nhất + thấp nhất
            double max = scores.Max();
            double min = scores.Min();
            result.AppendLine($"Điểm cao nhất: {max}");
            result.AppendLine($"Điểm thấp nhất: {min}");

            // Số môn đậu / rớt
            int pass = scores.Count(s => s >= 5);
            int fail = scores.Length - pass;
            result.AppendLine($"Số môn đậu: {pass}");
            result.AppendLine($"Số môn rớt: {fail}");

            // Xếp loại
            string rank;
            if (avg >= 8 && scores.All(s => s >= 6.5))
                rank = "Giỏi";
            else if (avg >= 6.5 && scores.All(s => s >= 5))
                rank = "Khá";
            else if (avg >= 5 && scores.All(s => s >= 3.5))
                rank = "Trung Bình";
            else if (avg >= 3.5 && scores.All(s => s >= 2))
                rank = "Yếu";
            else
                rank = "Kém";

            result.AppendLine($"Xếp loại: {rank}");

            textBoxKetQua.Text = result.ToString();
        }

        
    }
}
