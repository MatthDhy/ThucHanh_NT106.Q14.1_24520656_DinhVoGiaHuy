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
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
