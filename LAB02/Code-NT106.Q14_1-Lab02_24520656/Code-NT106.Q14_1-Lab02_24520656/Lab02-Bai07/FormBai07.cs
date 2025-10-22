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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Code_NT106.Q14_1_Lab02_24520656.Lab02_Bai07
{
    public partial class FormBai07 : Form
    {
        public FormBai07()
        {
            InitializeComponent();
        }

        private void FormBai07_Load(object sender, EventArgs e)
        {
            // 🔹 Lấy danh sách tất cả ổ đĩa trên máy
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                TreeNode driveNode = new TreeNode(drive.Name) { Tag = drive.Name };
                treeView.Nodes.Add(driveNode);

                // Thêm node ảo để có dấu “+” (expand được)
                driveNode.Nodes.Add("...");
            }

            // 🔹 Khi người dùng mở 1 thư mục (expand)
            treeView.BeforeExpand += TreeView_BeforeExpand;

            // 🔹 Khi chọn 1 node (click vào file hoặc thư mục)
            treeView.AfterSelect += TreeView_AfterSelect;
        }

        private void TreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear(); // Xóa node ảo trước khi load thật

            string path = node.Tag.ToString();

            try
            {
                // Load thư mục con
                foreach (string dir in Directory.GetDirectories(path))
                {
                    TreeNode dirNode = new TreeNode(Path.GetFileName(dir)) { Tag = dir };
                    dirNode.Nodes.Add("...");
                    node.Nodes.Add(dirNode);
                }

                // Load file con
                foreach (string file in Directory.GetFiles(path))
                {
                    TreeNode fileNode = new TreeNode(Path.GetFileName(file)) { Tag = file };
                    node.Nodes.Add(fileNode);
                }
            }
            catch
            {
                // Một số thư mục hệ thống không truy cập được
            }
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedPath = e.Node.Tag.ToString();

            if (File.Exists(selectedPath))
            {
                try
                {
                    // Chỉ đọc file nhỏ thôi, tránh crash khi mở file lớn
                    FileInfo fi = new FileInfo(selectedPath);
                    if (fi.Length > 2_000_000) // >2MB
                    {
                        rtbcontent.Text = "[⚠️ File quá lớn, không hiển thị toàn bộ nội dung.]";
                        return;
                    }

                    rtbcontent.Text = File.ReadAllText(selectedPath);
                }
                catch (Exception ex)
                {
                    rtbcontent.Text = "❌ Không thể đọc file này.\n" + ex.Message;
                }
            }
            else
            {
                rtbcontent.Clear();
            }
        }
    }
}