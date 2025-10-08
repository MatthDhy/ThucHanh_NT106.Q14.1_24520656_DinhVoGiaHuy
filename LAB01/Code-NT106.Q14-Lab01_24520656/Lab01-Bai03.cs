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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void labelNhap_Click(object sender, EventArgs e)
        {

        }

        private void buttonDoc_Click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(textBoxNhap.Text.Trim(), out num))
            {
                string result = "";
                switch (num)
                {
                    case 0: result = "Không"; break;
                    case 1: result = "Một"; break;
                    case 2: result = "Hai"; break;
                    case 3: result = "Ba"; break;
                    case 4: result = "Bốn"; break;
                    case 5: result = "Năm"; break;
                    case 6: result = "Sáu"; break;
                    case 7: result = "Bảy"; break;
                    case 8: result = "Tám"; break;
                    case 9: result = "Chín"; break;
                    default:
                        MessageBox.Show("Vui lòng nhập số trong khoảng 0-9!");
                        return;
                }
                textBoxKetQua.Text = result;
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
                textBoxNhap.Clear();
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBoxNhap.Clear();
            textBoxKetQua.Clear();
            textBoxKetQuaNC.Clear();
            textBoxNhapBaiNC.Clear();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDocNC_Click(object sender, EventArgs e)
        {
            string input = textBoxNhapBaiNC.Text.Trim();

            if (!long.TryParse(input, out long number))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ (tối đa 12 chữ số)!");
                return;
            }

            if (number < 0 || number > 999999999999)
            {
                MessageBox.Show("Số phải nằm trong khoảng 0 đến 999,999,999,999 (12 chữ số)!");
                return;
            }

            textBoxKetQuaNC.Text = DocSoTiengViet(number);
        }

        // Hàm đọc số thành chữ tiếng Việt
        private string DocSoTiengViet(long number)
        {
            if (number == 0) return "không";

            string[] donViNhom = { "", "nghìn", "triệu", "tỷ" };
            string ketQua = "";
            int nhom = 0;

            while (number > 0)
            {
                int baSo = (int)(number % 1000);
                if (baSo != 0)
                {
                    string nhomSo = DocBaSo(baSo);
                    ketQua = nhomSo + " " + donViNhom[nhom] + " " + ketQua;
                }
                number /= 1000;
                nhom++;
            }

            return ketQua.Trim().Replace("  ", " ");
        }

        // Đọc nhóm 3 chữ số
        private string DocBaSo(int n)
        {
            string[] soChu = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

            int tram = n / 100;
            int chuc = (n / 10) % 10;
            int donvi = n % 10;

            StringBuilder sb = new StringBuilder();

            if (tram > 0)
            {
                sb.Append(soChu[tram] + " trăm ");
                if (chuc == 0 && donvi > 0) sb.Append("lẻ ");
            }

            if (chuc > 1)
            {
                sb.Append(soChu[chuc] + " mươi ");
                if (donvi == 1) sb.Append("mốt ");
                else if (donvi == 5) sb.Append("lăm ");
                else if (donvi > 0) sb.Append(soChu[donvi] + " ");
            }
            else if (chuc == 1)
            {
                sb.Append("mười ");
                if (donvi == 5) sb.Append("lăm ");
                else if (donvi > 0) sb.Append(soChu[donvi] + " ");
            }
            else if (chuc == 0 && donvi > 0)
            {
                sb.Append(soChu[donvi] + " ");
            }

            return sb.ToString().Trim();
        }
    }
}
