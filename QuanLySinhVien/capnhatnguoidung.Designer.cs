namespace QuanLySinhVien
{
    partial class capnhatnguoidung
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.btquaylai = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btghilai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbnguoidung = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(39, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Mật khẩu";
            // 
            // txtmk
            // 
            this.txtmk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmk.Location = new System.Drawing.Point(200, 144);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(183, 27);
            this.txtmk.TabIndex = 61;
            // 
            // btquaylai
            // 
            this.btquaylai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btquaylai.Location = new System.Drawing.Point(239, 281);
            this.btquaylai.Name = "btquaylai";
            this.btquaylai.Size = new System.Drawing.Size(120, 36);
            this.btquaylai.TabIndex = 60;
            this.btquaylai.Text = "Quay lại";
            this.btquaylai.UseVisualStyleBackColor = true;
            this.btquaylai.Click += new System.EventHandler(this.btquaylai_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(74, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(306, 25);
            this.label7.TabIndex = 59;
            this.label7.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // btghilai
            // 
            this.btghilai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btghilai.Location = new System.Drawing.Point(104, 281);
            this.btghilai.Name = "btghilai";
            this.btghilai.Size = new System.Drawing.Size(116, 37);
            this.btghilai.TabIndex = 58;
            this.btghilai.Text = "Lưu";
            this.btghilai.UseVisualStyleBackColor = true;
            this.btghilai.Click += new System.EventHandler(this.btghilai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(39, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "Loại người dùng";
            // 
            // cbnguoidung
            // 
            this.cbnguoidung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnguoidung.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbnguoidung.FormattingEnabled = true;
            this.cbnguoidung.Items.AddRange(new object[] {
            "Admin",
            "Giáo viên",
            "Cán bộ",
            "Sinh Viên"});
            this.cbnguoidung.Location = new System.Drawing.Point(200, 209);
            this.cbnguoidung.Name = "cbnguoidung";
            this.cbnguoidung.Size = new System.Drawing.Size(183, 27);
            this.cbnguoidung.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(39, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 67;
            this.label3.Text = "Tên đăng nhập";
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttendangnhap.Location = new System.Drawing.Point(200, 81);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(183, 27);
            this.txttendangnhap.TabIndex = 66;
            // 
            // capnhatnguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.cbnguoidung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.btquaylai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btghilai);
            this.Name = "capnhatnguoidung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "capnhatnguoidung";
            this.Load += new System.EventHandler(this.capnhatnguoidung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Button btquaylai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btghilai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbnguoidung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttendangnhap;
    }
}