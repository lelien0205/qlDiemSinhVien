namespace QuanLySinhVien
{
    partial class frm_thongtinsinhvien
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
            this.label_msv = new System.Windows.Forms.Label();
            this.label_hoten = new System.Windows.Forms.Label();
            this.label_gioitinh = new System.Windows.Forms.Label();
            this.label_ngaysinh = new System.Windows.Forms.Label();
            this.label_quequan = new System.Windows.Forms.Label();
            this.label_sodienthoai = new System.Windows.Forms.Label();
            this.label_lop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_msv
            // 
            this.label_msv.AutoSize = true;
            this.label_msv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_msv.Location = new System.Drawing.Point(67, 69);
            this.label_msv.Name = "label_msv";
            this.label_msv.Size = new System.Drawing.Size(133, 25);
            this.label_msv.TabIndex = 1;
            this.label_msv.Text = "Mã sinh viên: ";
            // 
            // label_hoten
            // 
            this.label_hoten.AutoSize = true;
            this.label_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hoten.Location = new System.Drawing.Point(67, 158);
            this.label_hoten.Name = "label_hoten";
            this.label_hoten.Size = new System.Drawing.Size(80, 25);
            this.label_hoten.TabIndex = 2;
            this.label_hoten.Text = "Họ tên: ";
            // 
            // label_gioitinh
            // 
            this.label_gioitinh.AutoSize = true;
            this.label_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gioitinh.Location = new System.Drawing.Point(67, 247);
            this.label_gioitinh.Name = "label_gioitinh";
            this.label_gioitinh.Size = new System.Drawing.Size(93, 25);
            this.label_gioitinh.TabIndex = 3;
            this.label_gioitinh.Text = "Giới tính: ";
            // 
            // label_ngaysinh
            // 
            this.label_ngaysinh.AutoSize = true;
            this.label_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ngaysinh.Location = new System.Drawing.Point(486, 69);
            this.label_ngaysinh.Name = "label_ngaysinh";
            this.label_ngaysinh.Size = new System.Drawing.Size(110, 25);
            this.label_ngaysinh.TabIndex = 4;
            this.label_ngaysinh.Text = "Ngày sinh: ";
            // 
            // label_quequan
            // 
            this.label_quequan.AutoSize = true;
            this.label_quequan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quequan.Location = new System.Drawing.Point(486, 158);
            this.label_quequan.Name = "label_quequan";
            this.label_quequan.Size = new System.Drawing.Size(110, 25);
            this.label_quequan.TabIndex = 5;
            this.label_quequan.Text = "Quê quán: ";
            // 
            // label_sodienthoai
            // 
            this.label_sodienthoai.AutoSize = true;
            this.label_sodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sodienthoai.Location = new System.Drawing.Point(486, 247);
            this.label_sodienthoai.Name = "label_sodienthoai";
            this.label_sodienthoai.Size = new System.Drawing.Size(137, 25);
            this.label_sodienthoai.TabIndex = 6;
            this.label_sodienthoai.Text = "Số điện thoại: ";
            // 
            // label_lop
            // 
            this.label_lop.AutoSize = true;
            this.label_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lop.Location = new System.Drawing.Point(317, 336);
            this.label_lop.Name = "label_lop";
            this.label_lop.Size = new System.Drawing.Size(56, 25);
            this.label_lop.TabIndex = 7;
            this.label_lop.Text = "Lớp: ";
            // 
            // frm_thongtinsinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 431);
            this.Controls.Add(this.label_lop);
            this.Controls.Add(this.label_sodienthoai);
            this.Controls.Add(this.label_quequan);
            this.Controls.Add(this.label_ngaysinh);
            this.Controls.Add(this.label_gioitinh);
            this.Controls.Add(this.label_hoten);
            this.Controls.Add(this.label_msv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_thongtinsinhvien";
            this.Text = "frm_thongtinsinhvien";
            this.Load += new System.EventHandler(this.frm_thongtinsinhvien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_msv;
        private System.Windows.Forms.Label label_hoten;
        private System.Windows.Forms.Label label_gioitinh;
        private System.Windows.Forms.Label label_ngaysinh;
        private System.Windows.Forms.Label label_quequan;
        private System.Windows.Forms.Label label_sodienthoai;
        private System.Windows.Forms.Label label_lop;
    }
}