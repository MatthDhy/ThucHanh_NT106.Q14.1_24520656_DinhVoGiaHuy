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
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void Button_Bai1_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 Bai01 = new Lab01_Bai01();
            this.Hide();
            Bai01.ShowDialog();
            this.Show();
        }

        private void Button_Bai2_Click(object sender, EventArgs e)
        {
            Lab01_Bai02 Bai02 = new Lab01_Bai02();
            this.Hide();
            Bai02.ShowDialog();
            this.Show();
        }

        private void Button_Bai3_Click(object sender, EventArgs e)
        {
            Lab01_Bai03 Bai03 = new Lab01_Bai03();
            this.Hide();
            Bai03.ShowDialog();
            this.Show();
        }
        private void Button_Bai4_Click(object sender, EventArgs e)
        {
            Lab01_Bai04 Bai04 = new Lab01_Bai04();
            this.Hide();
            Bai04.ShowDialog();
            this.Show();
        }
        private void Button_Bai5_Click(object sender, EventArgs e)
        {
            Lab01_Bai05 Bai05 = new Lab01_Bai05();
            this.Hide();
            Bai05.ShowDialog();
            this.Show();
        }
        private void Button_Bai6_Click(object sender, EventArgs e)
        {
            Lab01_Bai06 Bai06 = new Lab01_Bai06();
            this.Hide();
            Bai06.ShowDialog();
            this.Show();
        }
        private void Button_Bai7_Click(object sender, EventArgs e)
        {
            Lab01_Bai07 Bai07 = new Lab01_Bai07();
            this.Hide();
            Bai07.ShowDialog();
            this.Show();
        }
        private void Button_Bai8_Click(object sender, EventArgs e)
        {
            Lab01_Bai08 Bai08 = new Lab01_Bai08();
            this.Hide();
            Bai08.ShowDialog();
            this.Show();
        }

        
    }
}
