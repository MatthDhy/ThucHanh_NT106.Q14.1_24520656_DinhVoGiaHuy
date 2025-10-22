namespace Code_NT106.Q14_1_Lab02_24520656.Lab02_Bai06
{
    partial class FormBai06
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lvMonAn = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNguoiDongGop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHinhAnh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picMon = new System.Windows.Forms.PictureBox();
            this.lblNguoiDongGop = new System.Windows.Forms.Label();
            this.btnNgauNhien = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMon)).BeginInit();
            this.SuspendLayout();
            // 
            // lvMonAn
            // 
            this.lvMonAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colTenMon,
            this.colNguoiDongGop,
            this.colHinhAnh});
            this.lvMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lvMonAn.FullRowSelect = true;
            this.lvMonAn.GridLines = true;
            this.lvMonAn.HideSelection = false;
            this.lvMonAn.Location = new System.Drawing.Point(12, 55);
            this.lvMonAn.MultiSelect = false;
            this.lvMonAn.Name = "lvMonAn";
            this.lvMonAn.Size = new System.Drawing.Size(450, 370);
            this.lvMonAn.TabIndex = 0;
            this.lvMonAn.UseCompatibleStateImageBehavior = false;
            this.lvMonAn.View = System.Windows.Forms.View.Details;
            this.lvMonAn.SelectedIndexChanged += new System.EventHandler(this.lvMonAn_SelectedIndexChanged);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 50;
            // 
            // colTenMon
            // 
            this.colTenMon.Text = "Tên món ăn";
            this.colTenMon.Width = 180;
            // 
            // colNguoiDongGop
            // 
            this.colNguoiDongGop.Text = "Người đóng góp";
            this.colNguoiDongGop.Width = 140;
            // 
            // colHinhAnh
            // 
            this.colHinhAnh.Text = "Ảnh";
            this.colHinhAnh.Width = 80;
            // 
            // picMon
            // 
            this.picMon.BackColor = System.Drawing.Color.MistyRose;
            this.picMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMon.Location = new System.Drawing.Point(480, 55);
            this.picMon.Name = "picMon";
            this.picMon.Size = new System.Drawing.Size(300, 220);
            this.picMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMon.TabIndex = 1;
            this.picMon.TabStop = false;
            // 
            // lblNguoiDongGop
            // 
            this.lblNguoiDongGop.AutoSize = true;
            this.lblNguoiDongGop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNguoiDongGop.Location = new System.Drawing.Point(476, 290);
            this.lblNguoiDongGop.Name = "lblNguoiDongGop";
            this.lblNguoiDongGop.Size = new System.Drawing.Size(191, 25);
            this.lblNguoiDongGop.TabIndex = 2;
            this.lblNguoiDongGop.Text = "Đóng góp bởi: (trống)";
            // 
            // btnNgauNhien
            // 
            this.btnNgauNhien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnNgauNhien.Location = new System.Drawing.Point(480, 340);
            this.btnNgauNhien.Name = "btnNgauNhien";
            this.btnNgauNhien.Size = new System.Drawing.Size(140, 45);
            this.btnNgauNhien.TabIndex = 3;
            this.btnNgauNhien.Text = "🍀 Chọn ngẫu nhiên";
            this.btnNgauNhien.UseVisualStyleBackColor = true;
            this.btnNgauNhien.Click += new System.EventHandler(this.btnNgauNhien_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLoad.Location = new System.Drawing.Point(640, 340);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(140, 45);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "🔄 Tải lại dữ liệu";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(270, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 29);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "🍽️ HÔM NAY ĂN GÌ?";
            // 
            // FormBai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNgauNhien);
            this.Controls.Add(this.lblNguoiDongGop);
            this.Controls.Add(this.picMon);
            this.Controls.Add(this.lvMonAn);
            this.Name = "FormBai06";
            this.Text = "FormBai06 - Hôm nay ăn gì?";
            this.Load += new System.EventHandler(this.FormBai06_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView lvMonAn;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colTenMon;
        private System.Windows.Forms.ColumnHeader colNguoiDongGop;
        private System.Windows.Forms.ColumnHeader colHinhAnh;
        private System.Windows.Forms.PictureBox picMon;
        private System.Windows.Forms.Label lblNguoiDongGop;
        private System.Windows.Forms.Button btnNgauNhien;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTitle;
    }
}
