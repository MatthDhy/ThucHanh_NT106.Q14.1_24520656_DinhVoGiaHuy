using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_NT106.Q14_Lab01_24520656
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void buttonTinh_Click(object sender, EventArgs e)
        {
            int A, B;
            if (!int.TryParse(textboxNhapA.Text.Trim(), out A) || !int.TryParse(textboxNhapB.Text.Trim(), out B))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }

            string option = cboChucNang.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(option))
            {
                MessageBox.Show("Vui lòng chọn chức năng!");
                return;
            }

            if (option == "Bảng cửu chương")
            {
                /*string result = "";
                for (int i = A; i <= B; i++)
                {
                    result += $"--- Bảng cửu chương {i} ---\r\n";
                    for (int j = 1; j <= 9; j++)
                    {
                        result += $"{i} x {j} = {i * j}\r\n";
                    }
                    result += "\r\n";
                }
                textboxKetQua.Text = result;*/
                StringBuilder result = new StringBuilder();

                int start = Math.Min(A, B);
                int end = Math.Max(A, B);

                for (int i = start; i <= end; i++)
                {
                    result.AppendLine($"--- Bảng cửu chương {i} ---");
                    for (int j = 1; j <= 9; j++)
                    {
                        result.AppendLine($"{i} x {j} = {i * j}");
                    }
                    result.AppendLine();
                }

                textboxKetQua.Text = result.ToString();
            }
            else if (option == "Tính toán giá trị")
            {
 
                int n = A - B;
                long factorial = 1;
                if (n < 0) factorial = -1;
                else
                {
                    for (int i = 1; i <= n; i++)
                        factorial *= i;
                }

                double sum = 0;
                for (int i = 1; i <= B; i++)
                    sum += Math.Pow(A, i);

                    textboxKetQua.Text =
                    $"(A - B)! = {(factorial == -1 ? "Không tính được (số âm)" : factorial.ToString())}\r\n" +
                    $"Tổng S = {sum}";
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textboxNhapA.Clear();
            textboxNhapB.Clear();
            textboxKetQua.Clear();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
