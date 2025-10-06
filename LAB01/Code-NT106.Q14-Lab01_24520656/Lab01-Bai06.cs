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
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            string input = textBoxNhap.Text.Trim(); // textbox bạn tạo để nhập ngày sinh

            DateTime birthDate;
            if (!DateTime.TryParseExact(input, "dd/MM/yyyy",
                                        CultureInfo.InvariantCulture,
                                        DateTimeStyles.None,
                                        out birthDate))
            {
                MessageBox.Show("❌ Vui lòng nhập đúng định dạng dd/MM/yyyy (VD: 15/08/2004)");
                return;
            }

            string zodiac = GetZodiac(birthDate.Day, birthDate.Month);

            textBoxKetQua.Text = $"{zodiac}";
        }

        private string GetZodiac(int day, int month)
        {
            switch (month)
            {
                case 3: return (day >= 21) ? "Bạch Dương" : "Song Ngư";
                case 4: return (day >= 21) ? "Kim Ngưu" : "Bạch Dương";
                case 5: return (day >= 22) ? "Song Tử" : "Kim Ngưu";
                case 6: return (day >= 22) ? "Cự Giải" : "Song Tử";
                case 7: return (day >= 23) ? "Sư Tử" : "Cự Giải";
                case 8: return (day >= 23) ? "Xử Nữ" : "Sư Tử";
                case 9: return (day >= 24) ? "Thiên Bình" : "Xử Nữ";
                case 10: return (day >= 24) ? "Thần Nông" : "Thiên Bình";
                case 11: return (day >= 23) ? "Nhân Mã" : "Thần Nông";
                case 12: return (day >= 22) ? "Ma Kết" : "Nhân Mã";
                case 1: return (day >= 21) ? "Bảo Bình" : "Ma Kết";
                case 2: return (day >= 20) ? "Song Ngư" : "Bảo Bình";
                default: return "Ngày tháng không hợp lệ!";
            }
        }

    }
}
