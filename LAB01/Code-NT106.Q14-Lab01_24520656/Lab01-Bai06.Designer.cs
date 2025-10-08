namespace Code_NT106.Q14_Lab01_24520656
{
    partial class Lab01_Bai06
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tieude = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNhap = new System.Windows.Forms.TextBox();
            this.textBoxKetQua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTim = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tieude
            // 
            this.tieude.AutoSize = true;
            this.tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tieude.Location = new System.Drawing.Point(176, 59);
            this.tieude.Name = "tieude";
            this.tieude.Size = new System.Drawing.Size(322, 31);
            this.tieude.TabIndex = 0;
            this.tieude.Text = "TÌM CUNG HOÀNG ĐẠO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(48, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập ngày tháng năm sinh:";
            // 
            // textBoxNhap
            // 
            this.textBoxNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNhap.Location = new System.Drawing.Point(320, 131);
            this.textBoxNhap.Name = "textBoxNhap";
            this.textBoxNhap.Size = new System.Drawing.Size(196, 30);
            this.textBoxNhap.TabIndex = 2;
            // 
            // textBoxKetQua
            // 
            this.textBoxKetQua.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxKetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxKetQua.Location = new System.Drawing.Point(320, 192);
            this.textBoxKetQua.Name = "textBoxKetQua";
            this.textBoxKetQua.ReadOnly = true;
            this.textBoxKetQua.Size = new System.Drawing.Size(196, 30);
            this.textBoxKetQua.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(184, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bạn là cung";
            // 
            // buttonTim
            // 
            this.buttonTim.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonTim.Location = new System.Drawing.Point(320, 279);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(81, 48);
            this.buttonTim.TabIndex = 5;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonXoa.Location = new System.Drawing.Point(435, 279);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(81, 48);
            this.buttonXoa.TabIndex = 6;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // Lab01_Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(688, 566);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKetQua);
            this.Controls.Add(this.textBoxNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tieude);
            this.Name = "Lab01_Bai06";
            this.Text = "Lab01_Bai06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tieude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNhap;
        private System.Windows.Forms.TextBox textBoxKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.Button buttonXoa;
    }
}