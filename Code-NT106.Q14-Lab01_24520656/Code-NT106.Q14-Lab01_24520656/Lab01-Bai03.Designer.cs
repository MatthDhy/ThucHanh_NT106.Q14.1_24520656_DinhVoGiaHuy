namespace Code_NT106.Q14_Lab01_24520656
{
    partial class Lab01_Bai03
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
            this.labelNhap = new System.Windows.Forms.Label();
            this.textBoxNhap = new System.Windows.Forms.TextBox();
            this.labelKetQua = new System.Windows.Forms.Label();
            this.textBoxKetQua = new System.Windows.Forms.TextBox();
            this.buttonDoc = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.TieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNhap
            // 
            this.labelNhap.AutoSize = true;
            this.labelNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNhap.Location = new System.Drawing.Point(29, 108);
            this.labelNhap.Name = "labelNhap";
            this.labelNhap.Size = new System.Drawing.Size(257, 25);
            this.labelNhap.TabIndex = 0;
            this.labelNhap.Text = "Nhập vào số nguyên từ 0 - 9";
            this.labelNhap.Click += new System.EventHandler(this.labelNhap_Click);
            // 
            // textBoxNhap
            // 
            this.textBoxNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNhap.Location = new System.Drawing.Point(292, 103);
            this.textBoxNhap.Name = "textBoxNhap";
            this.textBoxNhap.Size = new System.Drawing.Size(97, 30);
            this.textBoxNhap.TabIndex = 1;
            // 
            // labelKetQua
            // 
            this.labelKetQua.AutoSize = true;
            this.labelKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelKetQua.Location = new System.Drawing.Point(29, 225);
            this.labelKetQua.Name = "labelKetQua";
            this.labelKetQua.Size = new System.Drawing.Size(85, 25);
            this.labelKetQua.TabIndex = 2;
            this.labelKetQua.Text = "Kết Quả";
            // 
            // textBoxKetQua
            // 
            this.textBoxKetQua.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxKetQua.Enabled = false;
            this.textBoxKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxKetQua.Location = new System.Drawing.Point(34, 253);
            this.textBoxKetQua.Name = "textBoxKetQua";
            this.textBoxKetQua.Size = new System.Drawing.Size(150, 30);
            this.textBoxKetQua.TabIndex = 3;
            // 
            // buttonDoc
            // 
            this.buttonDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDoc.Location = new System.Drawing.Point(417, 116);
            this.buttonDoc.Name = "buttonDoc";
            this.buttonDoc.Size = new System.Drawing.Size(83, 54);
            this.buttonDoc.TabIndex = 4;
            this.buttonDoc.Text = "Đọc";
            this.buttonDoc.UseVisualStyleBackColor = true;
            this.buttonDoc.Click += new System.EventHandler(this.buttonDoc_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonXoa.Location = new System.Drawing.Point(417, 176);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(83, 50);
            this.buttonXoa.TabIndex = 5;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonThoat.Location = new System.Drawing.Point(417, 233);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(83, 50);
            this.buttonThoat.TabIndex = 6;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // TieuDe
            // 
            this.TieuDe.AutoSize = true;
            this.TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieuDe.Location = new System.Drawing.Point(208, 48);
            this.TieuDe.Name = "TieuDe";
            this.TieuDe.Size = new System.Drawing.Size(124, 32);
            this.TieuDe.TabIndex = 7;
            this.TieuDe.Text = "ĐỌC SỐ";
            // 
            // Lab01_Bai03
            // 
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(541, 498);
            this.Controls.Add(this.TieuDe);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonDoc);
            this.Controls.Add(this.textBoxKetQua);
            this.Controls.Add(this.labelKetQua);
            this.Controls.Add(this.textBoxNhap);
            this.Controls.Add(this.labelNhap);
            this.Name = "Lab01_Bai03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNhap;
        private System.Windows.Forms.TextBox textBoxNhap;
        private System.Windows.Forms.Label labelKetQua;
        private System.Windows.Forms.TextBox textBoxKetQua;
        private System.Windows.Forms.Button buttonDoc;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label TieuDe;
    }
}