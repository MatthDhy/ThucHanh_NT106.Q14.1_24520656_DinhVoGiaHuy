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
    public partial class Lab01_Bai04 : Form
    {
        // Dictionary lưu giá phim
        Dictionary<string, int> giaPhim = new Dictionary<string, int>()
    {
        { "Đào, phở và piano", 45000 },
        { "Mai", 100000 },
        { "Gặp lại chị bầu", 70000 },
        { "Tarot", 90000 }
    };

        // HashSet lưu ghế đã bán
        HashSet<string> gheDaMua = new HashSet<string>();

        public Lab01_Bai04()
        {
            InitializeComponent();
        }

        private void Lab01_Bai04_Load(object sender, EventArgs e)
        {
            // Thêm phim vào combobox
            cboPhim.Items.AddRange(giaPhim.Keys.ToArray());

            // Thêm phòng
            cboPhong.Items.AddRange(new object[] { "1", "2", "3" });

            // Thêm danh sách ghế
            for (char hang = 'A'; hang <= 'C'; hang++)
            {
                for (int so = 1; so <= 5; so++)
                {
                    clbGhe.Items.Add($"{hang}{so}");
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            string ten = txtHoTen.Text.Trim();
            string phim = cboPhim.SelectedItem?.ToString();
            string phong = cboPhong.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(ten) || phim == null || phong == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (clbGhe.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế!");
                return;
            }

            int giaChuan = giaPhim[phim];
            double tongTien = 0;
            List<string> gheChon = new List<string>();

            foreach (var item in clbGhe.CheckedItems)
            {
                string ghe = item.ToString();

                // Check ghế đã mua chưa
                if (gheDaMua.Contains($"{phong}-{ghe}"))
                {
                    MessageBox.Show($"Ghế {ghe} ở phòng {phong} đã được mua!");
                    continue;
                }

                // Xác định loại ghế
                double giaVe = 0;
                if (ghe == "A1" || ghe == "A5" || ghe == "C1" || ghe == "C5")
                    giaVe = giaChuan * 0.25;
                else if (ghe.StartsWith("B") && ghe != "B1" && ghe != "B5")
                    giaVe = giaChuan * 2;
                else
                    giaVe = giaChuan;

                tongTien += giaVe;
                gheChon.Add(ghe);

                // Đánh dấu đã mua
                gheDaMua.Add($"{phong}-{ghe}");
            }

            // Xuất kết quả
            txtKetQua.Text =
                $"Khách hàng: {ten}\r\n" +
                $"Phim: {phim}\r\n" +
                $"Phòng: {phong}\r\n" +
                $"Ghế: {string.Join(", ", gheChon)}\r\n" +
                $"Tổng tiền: {tongTien:N0} VNĐ";
        }

        
    }

}
