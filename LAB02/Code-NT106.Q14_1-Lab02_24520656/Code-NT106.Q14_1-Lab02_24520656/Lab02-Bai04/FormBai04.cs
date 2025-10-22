using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace Code_NT106.Q14_1_Lab02_24520656.Lab02_Bai04
{
    public partial class FormBai04 : Form
    {
        private List<SinhVien> danhSach = new List<SinhVien>();
        private int trangHienTai = 0;
        public FormBai04()
        {
            InitializeComponent();
        }

        private string GetFolderPath()
        {
            string folder = Path.Combine(Application.StartupPath, @"..\..\Lab02-Bai04");
            return Path.GetFullPath(folder);
        }
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                string folder = GetFolderPath();
                string input = Path.Combine(folder, "input4.txt");
                string output = Path.Combine(folder, "output4.txt");

                if (!File.Exists(input))
                {
                    MessageBox.Show("⚠️ Không tìm thấy file input4.txt trong thư mục Lab02-Bai04!");
                    return;
                }

                string json = File.ReadAllText(input);
                danhSach = JsonSerializer.Deserialize<List<SinhVien>>(json);

                foreach (var sv in danhSach)
                    sv.TinhDiemTB();

                File.WriteAllText(output, JsonSerializer.Serialize(danhSach, new JsonSerializerOptions { WriteIndented = true }));
                rtb.Text = JsonSerializer.Serialize(danhSach, new JsonSerializerOptions { WriteIndented = true });

                trangHienTai = 0;
                HienThi1SinhVien();

                MessageBox.Show("✅ Đã đọc file input4.txt và ghi output4.txt thành công!\nVị trí: " + output);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi đọc file: " + ex.Message);
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                string folder = GetFolderPath();
                string input = Path.Combine(folder, "input4.txt");
                string json = JsonSerializer.Serialize(danhSach, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(input, json);
                MessageBox.Show("✅ Đã ghi danh sách vào file input4.txt!\nVị trí: " + input);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi ghi file: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = textBoxName2.Text.Trim();
                string mssv = textBoxID2.Text.Trim();
                string sdt = textBoxPhone2.Text.Trim();
                float d1 = float.Parse(textBoxcourse1_2.Text);
                float d2 = float.Parse(textBoxcourse2_2.Text);
                float d3 = float.Parse(textBoxcourse3_2.Text);

                if (!Regex.IsMatch(mssv, @"^\d{8}$"))
                    throw new Exception("❌ MSSV phải gồm 8 chữ số!");
                if (!Regex.IsMatch(sdt, @"^0\d{9}$"))
                    throw new Exception("❌ SĐT phải gồm 10 số và bắt đầu bằng 0!");
                if (d1 < 0 || d1 > 10 || d2 < 0 || d2 > 10 || d3 < 0 || d3 > 10)
                    throw new Exception("❌ Điểm phải nằm trong khoảng [0,10].");

                var sv = new SinhVien(ten, mssv, sdt, d1, d2, d3);
                sv.TinhDiemTB();
                danhSach.Add(sv);

                MessageBox.Show("✅ Thêm sinh viên thành công!");
                rtb.Text = JsonSerializer.Serialize(danhSach, new JsonSerializerOptions { WriteIndented = true });
                clearinput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi: " + ex.Message);
            }
        }


        // ------------------- Hỗ trợ giao diện -------------------
        

        private void ClearLeft()
        {
            textboxName1.Clear();
            textboxID1.Clear();
            textBoxPhone1.Clear();
            textBoxcourse1_1.Clear();
            textBoxcourse2_1.Clear();
            textBoxcourse3_1.Clear();
            textBoxAverage1.Clear();
        }

        private void ClearRight()
        {
            textBoxName2.Clear();
            textBoxID2.Clear();
            textBoxPhone2.Clear();
            textBoxcourse1_2.Clear();
            textBoxcourse2_2.Clear();
            textBoxcourse3_2.Clear();
            textBoxAverage2.Clear();
        }

        // ========================== HIỂN THỊ 1 SINH VIÊN ==========================
        private void HienThi1SinhVien()
        {
            if (danhSach.Count == 0)
            {
                MessageBox.Show("Danh sách trống!");
                return;
            }

            if (trangHienTai < 0) trangHienTai = 0;
            if (trangHienTai >= danhSach.Count) trangHienTai = danhSach.Count - 1;

            var sv = danhSach[trangHienTai];

            textBoxName2.Text = sv.HoTen;
            textBoxID2.Text = sv.MSSV;
            textBoxPhone2.Text = sv.DienThoai;
            textBoxcourse1_2.Text = sv.Mon1.ToString();
            textBoxcourse2_2.Text = sv.Mon2.ToString();
            textBoxcourse3_2.Text = sv.Mon3.ToString();
            textBoxAverage2.Text = sv.DiemTB.ToString("0.00");

            lbltrang.Text = $"{trangHienTai + 1}/{danhSach.Count}";
        }

        // ========================== NÚT NEXT / BACK ==========================
        private void buttonnext_Click(object sender, EventArgs e)
        {
            if (trangHienTai < danhSach.Count - 1)
            {
                trangHienTai++;
                HienThi1SinhVien();
            }
            else
            {
                MessageBox.Show("✅ Đã ở sinh viên cuối cùng!");
            }
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            if (trangHienTai > 0)
            {
                trangHienTai--;
                HienThi1SinhVien();
            }
            else
            {
                MessageBox.Show("✅ Đã ở sinh viên đầu tiên!");
            }
        }

        private void clearinput()
        {
            textBoxName2.Clear();
            textBoxID2.Clear();
            textBoxPhone2.Clear();
            textBoxcourse1_2.Clear();
            textBoxcourse2_2.Clear();
            textBoxcourse3_2.Clear();
        }

        private void FormBai04_Load(object sender, EventArgs e)
        {
            lbltrang.Text = "0";
        }
    }

    // ========================== CLASS SINHVIEN ==========================
    public class SinhVien
    {
        public string HoTen { get; set; }
        public string MSSV { get; set; }
        public string DienThoai { get; set; }
        public float Mon1 { get; set; }
        public float Mon2 { get; set; }
        public float Mon3 { get; set; }
        public float DiemTB { get; set; }

        public SinhVien() { }

        public SinhVien(string ten, string mssv, string sdt, float m1, float m2, float m3)
        {
            HoTen = ten;
            MSSV = mssv;
            DienThoai = sdt;
            Mon1 = m1;
            Mon2 = m2;
            Mon3 = m3;
        }

        public void TinhDiemTB()
        {
            DiemTB = (Mon1 + Mon2 + Mon3) / 3f;
        }
    }
}