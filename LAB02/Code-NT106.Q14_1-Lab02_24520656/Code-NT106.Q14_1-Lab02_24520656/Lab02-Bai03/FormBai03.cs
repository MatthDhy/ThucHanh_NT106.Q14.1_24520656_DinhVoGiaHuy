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

namespace Code_NT106.Q14_1_Lab02_24520656.Lab02_Bai03
{
    public partial class FormBai03 : Form
    {
        private string filepath = string.Empty;
        private List<string> expressions = new List<string>();
        public FormBai03()
        {
            InitializeComponent();
        }

        private string GetFolderPath()
        {
            string folder = Path.Combine(Application.StartupPath, @"..\..\Lab02-Bai03");
            return Path.GetFullPath(folder);
        }
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string folder = GetFolderPath();
            string inputPath = Path.Combine(folder, "input3.txt");
            try
            {
                if (!File.Exists(inputPath))
                {
                    MessageBox.Show("⚠️ Không tìm thấy file input3.txt trong thư mục Lab02-Bai03!");
                    return;
                }

                filepath = inputPath;
                expressions = new List<string>(File.ReadAllLines(filepath));
                rtbKetQua.Text = string.Join("\n", expressions);

                MessageBox.Show("✅ Đọc file input3.txt thành công!\nVị trí: " + filepath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filepath))
            {
                MessageBox.Show("⚠️ Hãy đọc file input3.txt trước!");
                return;
            }

            string folder = GetFolderPath();
            string outputPath = Path.Combine(folder, "output3.txt");
            List<string> ketQua = new List<string>();

            try
            {
                foreach (string expr in expressions)
                {
                    if (string.IsNullOrWhiteSpace(expr)) continue;

                    try
                    {
                        double result = EvaluateExpression(expr);
                        ketQua.Add($"{expr} = {result}");
                    }
                    catch
                    {
                        ketQua.Add($"{expr} = [Biểu thức không hợp lệ]");
                    }
                }

                File.WriteAllLines(outputPath, ketQua);
                rtbKetQua.Text = string.Join("\n", ketQua);

                MessageBox.Show("✅ Đã ghi kết quả ra file output3.txt thành công!\nVị trí: " + outputPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi tính toán: " + ex.Message);
            }
        }

        // ---------------------- Xử lý biểu thức ----------------------
        private double EvaluateExpression(string expr)
        {
            var tokens = Tokenize(expr);
            int index = 0;
            return ParseExpression(tokens, ref index);
        }

        private List<string> Tokenize(string expr)
        {
            List<string> tokens = new List<string>();
            string num = "";

            foreach (char c in expr.Replace(" ", ""))
            {
                if (char.IsDigit(c) || c == '.')
                    num += c;
                else
                {
                    if (num != "")
                    {
                        tokens.Add(num);
                        num = "";
                    }
                    tokens.Add(c.ToString());
                }
            }
            if (num != "") tokens.Add(num);
            return tokens;
        }

        private double ParseExpression(List<string> tokens, ref int i)
        {
            double value = ParseTerm(tokens, ref i);
            while (i < tokens.Count)
            {
                string op = tokens[i];
                if (op == "+" || op == "-")
                {
                    i++;
                    double rhs = ParseTerm(tokens, ref i);
                    if (op == "+") value += rhs;
                    else value -= rhs;
                }
                else break;
            }
            return value;
        }

        private double ParseTerm(List<string> tokens, ref int i)
        {
            double value = ParseFactor(tokens, ref i);
            while (i < tokens.Count)
            {
                string op = tokens[i];
                if (op == "*" || op == "/")
                {
                    i++;
                    double rhs = ParseFactor(tokens, ref i);
                    if (op == "*") value *= rhs;
                    else value /= rhs;
                }
                else break;
            }
            return value;
        }

        private double ParseFactor(List<string> tokens, ref int i)
        {
            string token = tokens[i];
            if (token == "(")
            {
                i++;
                double value = ParseExpression(tokens, ref i);
                if (i < tokens.Count && tokens[i] == ")") i++;
                return value;
            }
            else
            {
                i++;
                return double.Parse(token);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}