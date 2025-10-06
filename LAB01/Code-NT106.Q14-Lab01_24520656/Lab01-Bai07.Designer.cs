namespace Code_NT106.Q14_Lab01_24520656
{
    partial class Lab01_Bai07
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelnhap = new System.Windows.Forms.Label();
            this.textBoxNhap = new System.Windows.Forms.TextBox();
            this.buttonXuly = new System.Windows.Forms.Button();
            this.textBoxKetQua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(190, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "XỬ LÝ CHUỖI";
            // 
            // labelnhap
            // 
            this.labelnhap.AutoSize = true;
            this.labelnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelnhap.Location = new System.Drawing.Point(34, 127);
            this.labelnhap.Name = "labelnhap";
            this.labelnhap.Size = new System.Drawing.Size(226, 25);
            this.labelnhap.TabIndex = 1;
            this.labelnhap.Text = "Nhập thông tin sinh viên:";
            // 
            // textBoxNhap
            // 
            this.textBoxNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNhap.Location = new System.Drawing.Point(39, 155);
            this.textBoxNhap.Name = "textBoxNhap";
            this.textBoxNhap.Size = new System.Drawing.Size(506, 30);
            this.textBoxNhap.TabIndex = 2;
            // 
            // buttonXuly
            // 
            this.buttonXuly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonXuly.Location = new System.Drawing.Point(455, 191);
            this.buttonXuly.Name = "buttonXuly";
            this.buttonXuly.Size = new System.Drawing.Size(86, 47);
            this.buttonXuly.TabIndex = 3;
            this.buttonXuly.Text = "Xử lý";
            this.buttonXuly.UseVisualStyleBackColor = true;
            this.buttonXuly.Click += new System.EventHandler(this.buttonXuly_Click);
            // 
            // textBoxKetQua
            // 
            this.textBoxKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxKetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKetQua.Location = new System.Drawing.Point(39, 253);
            this.textBoxKetQua.Multiline = true;
            this.textBoxKetQua.Name = "textBoxKetQua";
            this.textBoxKetQua.ReadOnly = true;
            this.textBoxKetQua.Size = new System.Drawing.Size(502, 258);
            this.textBoxKetQua.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
           
            // 
            // labelKQ
            // 
            this.labelKQ.AutoSize = true;
            this.labelKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelKQ.Location = new System.Drawing.Point(34, 225);
            this.labelKQ.Name = "labelKQ";
            this.labelKQ.Size = new System.Drawing.Size(150, 25);
            this.labelKQ.TabIndex = 6;
            this.labelKQ.Text = "Kết Quả Trả Về";
            // 
            // Lab01_Bai07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(574, 546);
            this.Controls.Add(this.labelKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKetQua);
            this.Controls.Add(this.buttonXuly);
            this.Controls.Add(this.textBoxNhap);
            this.Controls.Add(this.labelnhap);
            this.Controls.Add(this.label1);
            this.Name = "Lab01_Bai07";
            this.Text = "Lab01_Bai07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelnhap;
        private System.Windows.Forms.TextBox textBoxNhap;
        private System.Windows.Forms.Button buttonXuly;
        private System.Windows.Forms.TextBox textBoxKetQua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelKQ;
    }
}