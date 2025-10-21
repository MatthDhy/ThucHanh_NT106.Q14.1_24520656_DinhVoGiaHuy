using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_NT106.Q14_1_Lab02_24520656
{
    public partial class Lab02 : Form
    {
        public Lab02()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Lab02_Bai01 Bai01 = new Lab02_Bai01();
            this.Hide();
            Bai01.ShowDialog();
            this.Close();

        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            Lab02_Bai02 Bai02 = new Lab02_Bai02();
            this.Hide();
            Bai02.ShowDialog();
            this.Close();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {

        }

        private void btnBai04_Click(object sender, EventArgs e)
        {

        }

        private void btnBai05_Click(object sender, EventArgs e)
        {

        }

        private void btnBai06_Click(object sender, EventArgs e)
        {

        }

        private void btnBai07_Click(object sender, EventArgs e)
        {

        }
    }
}
