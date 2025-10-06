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
    public partial class Lab01_Bai08 : Form
    {
        private List<string> monAn = new List<string>();
        public Lab01_Bai08()
        {
            InitializeComponent();

            monAn = new List<string> { "Phở", "Bún bò", "Cơm tấm", "Bánh mì", "Hủ tiếu" };
            CapNhatDanhSach();
        }

        private void CapNhatDanhSach()
        {
            textBoxDanhSach.Text = string.Join(", ", monAn);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string monMoi = textBoxNhap.Text.Trim();
            if (string.IsNullOrEmpty(monMoi))
            {
                MessageBox.Show("❌ Vui lòng nhập tên món ăn!");
                return;
            }
            monAn.Add(monMoi);
            textBoxNhap.Clear();
            CapNhatDanhSach();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (monAn.Count == 0)
            {
                MessageBox.Show("❌ Danh sách rỗng!");
                return;
            }


             Random rnd = new Random();
             int index = rnd.Next(monAn.Count);
             string luaChon = monAn[index];
             textBoxKetQua.Text = $"👉 {luaChon}";
            
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
