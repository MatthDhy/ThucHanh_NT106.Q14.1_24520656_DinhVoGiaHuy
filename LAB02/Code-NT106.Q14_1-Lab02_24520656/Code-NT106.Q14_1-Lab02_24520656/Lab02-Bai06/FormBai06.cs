using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Code_NT106.Q14_1_Lab02_24520656.Lab02_Bai06
{
    public partial class FormBai06 : Form
    {
        private string dbPath;

        public FormBai06()
        {
            InitializeComponent();
            dbPath = Path.Combine(Application.StartupPath, @"..\..\Lab02-Bai06\monan.db");
            dbPath = Path.GetFullPath(dbPath);
        }

        private void FormBai06_Load(object sender, EventArgs e)
        {
            LoadMonAn();
        }

        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection($"Data Source={dbPath};Version=3;");
        }

        private void LoadMonAn()
        {
            lvMonAn.Items.Clear();

            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"SELECT MonAn.IDMA, MonAn.TenMonAn, NguoiDung.HoVaTen, MonAn.HinhAnh
                               FROM MonAn JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC";

                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["IDMA"].ToString());
                        item.SubItems.Add(reader["TenMonAn"].ToString());
                        item.SubItems.Add(reader["HoVaTen"].ToString());
                        item.SubItems.Add(reader["HinhAnh"].ToString());
                        lvMonAn.Items.Add(item);
                    }
                }
            }
        }

        private void lvMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMonAn.SelectedItems.Count > 0)
            {
                string imageFile = lvMonAn.SelectedItems[0].SubItems[3].Text;
                string path = Path.Combine(Application.StartupPath, @"..\..\Lab02_Bai06\Images", imageFile);

                if (File.Exists(path))
                    picMon.Image = Image.FromFile(path);
                else
                    picMon.Image = null;

                lblNguoiDongGop.Text = "Đóng góp bởi: " + lvMonAn.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnNgauNhien_Click(object sender, EventArgs e)
        {
            if (lvMonAn.Items.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu món ăn!");
                return;
            }

            Random rnd = new Random();
            int index = rnd.Next(lvMonAn.Items.Count);
            lvMonAn.Items[index].Selected = true;
            lvMonAn.Select();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMonAn();
        }
    }
}
