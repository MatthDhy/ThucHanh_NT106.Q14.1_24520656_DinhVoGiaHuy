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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            int sum = 0;
            if (!int.TryParse(textBox3.Text.Trim(), out num1)){
                MessageBox.Show("⚠️ Số thứ nhất không hợp lệ! Vui lòng nhập lại.");
                textBox3.Clear();
                textBox3.Focus();
                return;
            }
            if (!int.TryParse(textBox2.Text.Trim(), out num2)){
                MessageBox.Show("⚠️ Số thứ hai không hợp lệ! Vui lòng nhập lại.");
                textBox2.Clear();
                textBox2.Focus();
                return;
            }
     
            sum = num1 + num2;
            textBox1.Text = sum.ToString();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lab01_Bai01_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
