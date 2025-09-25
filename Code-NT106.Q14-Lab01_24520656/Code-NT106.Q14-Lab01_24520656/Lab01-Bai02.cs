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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lab01_Bai02_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            int max, min;
            
            if (!int.TryParse(textBox1.Text.Trim(), out num1)){
                MessageBox.Show("⚠️ Số thứ nhất không hợp lệ! Vui lòng nhập lại.");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            if (!int.TryParse(textBox2.Text.Trim(), out num2)){
                MessageBox.Show("⚠️ Số thứ hai không hợp lệ! Vui lòng nhập lại.");
                textBox2.Clear();
                textBox2.Focus();
                return;
            }
            if (!int.TryParse(textBox3.Text.Trim(), out num3)){
                MessageBox.Show("⚠️ Số thứ ba không hợp lệ! Vui lòng nhập lại.");
                textBox3.Clear();
                textBox3.Focus();
                return;
            }

            max = Math.Max(num1, Math.Max(num2, num3));
            min = Math.Min(num1, Math.Min(num2, num3));
            textBox5.Text = max.ToString();
            textBox4.Text = min.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
