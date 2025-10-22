using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_NT106.Q14_1_Lab02_24520656.Lab02_Bai05
{
    public partial class FormBai05 : Form
    {
        private string folderPath;
        private List<Phim> danhSachPhim = new List<Phim>();
        private Phim currentPhim = null;

        // when user clicks seat btn, we store the last clicked seat coords
        private (int r, int c)? lastSelectedSeat = null;

        public FormBai05()
        {
            InitializeComponent();
        }

        private void FormBai05_Load(object sender, EventArgs e)
        {
            folderPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Lab02-Bai05"));
            if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            comboBoxFilms.Items.Clear();
            lblFilmInfo.Text = "";
        }

        // ---------- Read input5.txt ----------
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                string inputPath = Path.Combine(folderPath, "input5.txt");
                if (!File.Exists(inputPath))
                {
                    MessageBox.Show("⚠️ Không tìm thấy input5.txt ở:\n" + folderPath);
                    return;
                }

                var lines = File.ReadAllLines(inputPath, Encoding.UTF8)
                                .Select(l => l.TrimEnd('\r')).ToList();

                danhSachPhim.Clear();

                int i = 0;
                while (i < lines.Count)
                {
                    // skip empty lines
                    if (string.IsNullOrWhiteSpace(lines[i])) { i++; continue; }

                    string ten = lines[i++];
                    if (i >= lines.Count) break;
                    if (!double.TryParse(lines[i++], out double gia)) gia = 0;
                    if (i >= lines.Count) break;
                    string phong = lines[i++];
                    if (i >= lines.Count) break;
                    var parts = lines[i++].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length < 2) throw new Exception($"Sai định dạng hàng/ cột cho phim {ten}.");
                    if (!int.TryParse(parts[0], out int R)) R = 0;
                    if (!int.TryParse(parts[1], out int C)) C = 0;

                    // read R rows of seat map
                    var seatmap = new List<string>();
                    for (int r = 0; r < R && i < lines.Count; r++, i++)
                    {
                        string row = lines[i].Trim();
                        // pad or trim to C
                        if (row.Length < C) row = row.PadRight(C, '0');
                        if (row.Length > C) row = row.Substring(0, C);
                        seatmap.Add(row);
                    }

                    var phim = new Phim(ten, gia, phong, R, C, seatmap);
                    danhSachPhim.Add(phim);

                    // optional separator lines: skip empty lines
                    while (i < lines.Count && string.IsNullOrWhiteSpace(lines[i])) i++;
                }

                // fill combo
                comboBoxFilms.Items.Clear();
                foreach (var p in danhSachPhim) comboBoxFilms.Items.Add(p.TenPhim);
                if (comboBoxFilms.Items.Count > 0) comboBoxFilms.SelectedIndex = 0;

                // show raw content
                var sb = new StringBuilder();
                sb.AppendLine("Đã đọc input5.txt — Danh sách phim:");
                foreach (var p in danhSachPhim) sb.AppendLine(p.ToShortString());
                rtbOutput.Text = sb.ToString();

                MessageBox.Show("✅ Đã đọc input5.txt thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi đọc input5.txt: " + ex.Message);
            }
        }

        // ---------- Save back to input5.txt (cập nhật trạng thái ghế) ----------
        private void btnSaveInput_Click(object sender, EventArgs e)
        {
            try
            {
                string inputPath = Path.Combine(folderPath, "input5.txt");
                using (var sw = new StreamWriter(inputPath, false, Encoding.UTF8))
                {
                    foreach (var p in danhSachPhim)
                    {
                        sw.WriteLine(p.TenPhim);
                        sw.WriteLine(p.GiaVe);
                        sw.WriteLine(p.PhongChieu);
                        sw.WriteLine($"{p.Rows} {p.Cols}");
                        for (int r = 0; r < p.Rows; r++)
                            sw.WriteLine(new string(Enumerable.Range(0, p.Cols).Select(c => p.Seat[r][c] ? '1' : '0').ToArray()));
                        sw.WriteLine(); // blank line between films
                    }
                }
                MessageBox.Show("✅ Đã lưu trạng thái vào input5.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi lưu input5.txt: " + ex.Message);
            }
        }

        // ---------- build seat buttons for selected film ----------
        private void comboBoxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = comboBoxFilms.SelectedIndex;
            if (idx < 0 || idx >= danhSachPhim.Count) return;
            currentPhim = danhSachPhim[idx];
            DrawSeatMap(currentPhim);
            UpdateFilmInfoLabel(currentPhim);
        }

        private void UpdateFilmInfoLabel(Phim p)
        {
            lblFilmInfo.Text = $"Phim: {p.TenPhim} | Giá: {p.GiaVe:N0} | Phòng: {p.PhongChieu} | Bán: {p.SoldCount()} | Tồn: {p.AvailableCount()}";
        }

        private void DrawSeatMap(Phim p)
        {
            panelSeats.Controls.Clear();
            lastSelectedSeat = null;
            int R = p.Rows, C = p.Cols;
            int btnSize = 36;
            int padding = 6;
            panelSeats.Width = Math.Min(420, C * (btnSize + padding) + padding);
            int y = padding;
            for (int r = 0; r < R; r++)
            {
                int x = padding;
                for (int c = 0; c < C; c++)
                {
                    var btn = new Button();
                    btn.Width = btnSize;
                    btn.Height = btnSize;
                    btn.Left = x;
                    btn.Top = y;
                    btn.Tag = (r, c);
                    btn.Margin = new Padding(2);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                    btn.Text = $"{(char)('A' + r)}{c + 1}";
                    bool isBooked = p.Seat[r][c];
                    btn.BackColor = isBooked ? Color.IndianRed : Color.LightGreen;
                    btn.Click += SeatButton_Click;
                    panelSeats.Controls.Add(btn);
                    x += btnSize + padding;
                }
                y += btnSize + padding;
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;
            var (r, c) = ((int r, int c))btn.Tag;
            lastSelectedSeat = (r, c);
            // highlight selection
            foreach (Control ctrl in panelSeats.Controls)
            {
                if (ctrl is Button b) b.FlatAppearance.BorderSize = 0;
            }
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = Color.Blue;
        }

        // ---------- Book selected seat ----------
        private void btnBook_Click(object sender, EventArgs e)
        {
            if (currentPhim == null) { MessageBox.Show("Chưa chọn phim."); return; }
            if (lastSelectedSeat == null) { MessageBox.Show("Chọn ghế trước khi đặt."); return; }
            var (r, c) = lastSelectedSeat.Value;
            if (currentPhim.Seat[r][c])
            {
                MessageBox.Show("Ghế đã được đặt.");
                return;
            }
            currentPhim.Seat[r][c] = true;
            // update UI
            DrawSeatMap(currentPhim);
            UpdateFilmInfoLabel(currentPhim);
            rtbOutput.AppendText($"{DateTime.Now}: Đặt ghế {(char)('A' + r)}{c + 1} cho phim {currentPhim.TenPhim}\n");
        }

        // ---------- Cancel (unbook) selected seat ----------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentPhim == null) { MessageBox.Show("Chưa chọn phim."); return; }
            if (lastSelectedSeat == null) { MessageBox.Show("Chọn ghế trước khi hủy."); return; }
            var (r, c) = lastSelectedSeat.Value;
            if (!currentPhim.Seat[r][c])
            {
                MessageBox.Show("Ghế đang trống.");
                return;
            }
            currentPhim.Seat[r][c] = false;
            DrawSeatMap(currentPhim);
            UpdateFilmInfoLabel(currentPhim);
            rtbOutput.AppendText($"{DateTime.Now}: Hủy ghế {(char)('A' + r)}{c + 1} cho phim {currentPhim.TenPhim}\n");
        }

        // ---------- Export stats to output5.txt and show it ----------
        private async void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (danhSachPhim.Count == 0) { MessageBox.Show("Chưa có dữ liệu phim."); return; }
                // compute stats
                foreach (var p in danhSachPhim) p.TinhDoanhThu();

                var sorted = danhSachPhim.OrderByDescending(p => p.DoanhThu).ToList();
                for (int i = 0; i < sorted.Count; i++) sorted[i].XepHang = i + 1;

                string outputPath = Path.Combine(folderPath, "output5.txt");
                progressBar1.Value = 0;
                progressBar1.Maximum = Math.Max(1, sorted.Count);

                var sb = new StringBuilder();
                sb.AppendLine("THỐNG KÊ DOANH THU PHIM");
                sb.AppendLine($"Xuất tại: {DateTime.Now}");
                sb.AppendLine();

                using (var sw = new StreamWriter(outputPath, false, Encoding.UTF8))
                {
                    await sw.WriteLineAsync("THỐNG KÊ DOANH THU PHIM");
                    await sw.WriteLineAsync($"Xuất tại: {DateTime.Now}");
                    await sw.WriteLineAsync("");

                    for (int i = 0; i < sorted.Count; i++)
                    {
                        var p = sorted[i];
                        string line = p.ToThongKe();
                        await sw.WriteLineAsync(line);
                        sb.AppendLine(line);

                        progressBar1.Value = Math.Min(progressBar1.Maximum, progressBar1.Value + 1);
                        await Task.Delay(200); // để nhìn thấy progress
                    }
                    await sw.FlushAsync();
                }

                // show on RichTextBox
                rtbOutput.Text = sb.ToString();

                MessageBox.Show("✅ Đã xuất output5.txt và hiển thị kết quả trên form.\n" + outputPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất: " + ex.Message);
            }
            finally
            {
                progressBar1.Value = 0;
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(folderPath))
                System.Diagnostics.Process.Start("explorer.exe", folderPath);
            else MessageBox.Show("Thư mục không tồn tại: " + folderPath);
        }
    }

    // ---------------- Phim class ----------------
    public class Phim
    {
        public string TenPhim { get; set; }
        public double GiaVe { get; set; }
        public string PhongChieu { get; set; }
        public int Rows { get; set; }
        public int Cols { get; set; }
        // Seat[r][c] true = booked(1), false = empty(0)
        public bool[][] Seat { get; set; }
        public double DoanhThu { get; set; }
        public int XepHang { get; set; }

        public Phim() { }

        // construct from seatmap strings (each string length = Cols)
        public Phim(string ten, double gia, string phong, int rows, int cols, List<string> seatmap)
        {
            TenPhim = ten; GiaVe = gia; PhongChieu = phong;
            Rows = rows; Cols = cols;
            Seat = new bool[Rows][];
            for (int r = 0; r < Rows; r++)
            {
                Seat[r] = new bool[Cols];
                string row = (r < seatmap.Count) ? seatmap[r] : new string('0', Cols);
                for (int c = 0; c < Cols; c++)
                    Seat[r][c] = (row[c] == '1');
            }
            TinhDoanhThu();
        }

        public int SoldCount()
        {
            int s = 0;
            for (int r = 0; r < Rows; r++) for (int c = 0; c < Cols; c++) if (Seat[r][c]) s++;
            return s;
        }

        public int AvailableCount()
        {
            return Rows * Cols - SoldCount();
        }

        public void TinhDoanhThu()
        {
            DoanhThu = SoldCount() * GiaVe;
        }

        public string ToShortString()
        {
            return $"{TenPhim} | Giá: {GiaVe:N0} | Phòng: {PhongChieu} | Ghế: {Rows}x{Cols} | Bán: {SoldCount()} | Tồn: {AvailableCount()}";
        }

        public string ToThongKe()
        {
            int tong = Rows * Cols;
            int sold = SoldCount();
            int ton = tong - sold;
            double tiLe = tong == 0 ? 0 : (double)sold / tong * 100.0;
            return $"[{XepHang}] {TenPhim} | Vé bán: {sold} | Vé tồn: {ton} | Tỉ lệ bán: {tiLe:F2}% | Doanh thu: {DoanhThu:N0} VND";
        }
    }
}
