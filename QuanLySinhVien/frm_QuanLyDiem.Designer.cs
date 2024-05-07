namespace QuanLySinhVien
{
    partial class frm_QuanLyDiem
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_mon = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.grchucnang = new System.Windows.Forms.GroupBox();
            this.btsua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hodem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemchuyencan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemheso1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemheso2_t1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemheso2_t2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemquatrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemhocphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.xuatdiem = new System.Windows.Forms.Button();
            this.btexcel = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtsv = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grchucnang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_mon);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(543, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 87);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tên môn";
            // 
            // cb_mon
            // 
            this.cb_mon.FormattingEnabled = true;
            this.cb_mon.Location = new System.Drawing.Point(21, 29);
            this.cb_mon.Name = "cb_mon";
            this.cb_mon.Size = new System.Drawing.Size(202, 27);
            this.cb_mon.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_lop);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(283, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 87);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên lớp";
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(30, 29);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(198, 27);
            this.cb_lop.TabIndex = 30;
            this.cb_lop.SelectedIndexChanged += new System.EventHandler(this.cb_lop_SelectedIndexChanged);
            // 
            // grchucnang
            // 
            this.grchucnang.Controls.Add(this.button1);
            this.grchucnang.Controls.Add(this.btsua);
            this.grchucnang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grchucnang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grchucnang.Location = new System.Drawing.Point(12, 12);
            this.grchucnang.Name = "grchucnang";
            this.grchucnang.Size = new System.Drawing.Size(265, 88);
            this.grchucnang.TabIndex = 36;
            this.grchucnang.TabStop = false;
            this.grchucnang.Text = "Chức năng";
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btsua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btsua.Location = new System.Drawing.Point(18, 30);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(125, 37);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "Sửa điểm";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(3, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1608, 653);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp học";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_diem,
            this.id_sv,
            this.hodem,
            this.ten,
            this.tenlop,
            this.tenmonhoc,
            this.sotinchi,
            this.diemchuyencan,
            this.diemheso1,
            this.diemheso2_t1,
            this.diemheso2_t2,
            this.diemquatrinh,
            this.diemthi,
            this.diemhocphan});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1602, 627);
            this.dataGridView1.TabIndex = 0;
            // 
            // id_diem
            // 
            this.id_diem.DataPropertyName = "id_diem";
            this.id_diem.HeaderText = "ID";
            this.id_diem.MinimumWidth = 6;
            this.id_diem.Name = "id_diem";
            this.id_diem.Width = 24;
            // 
            // id_sv
            // 
            this.id_sv.DataPropertyName = "id_sv";
            this.id_sv.HeaderText = "Mã sinh viên";
            this.id_sv.MinimumWidth = 6;
            this.id_sv.Name = "id_sv";
            this.id_sv.ReadOnly = true;
            this.id_sv.Width = 24;
            // 
            // hodem
            // 
            this.hodem.DataPropertyName = "hodem";
            this.hodem.HeaderText = "Họ Đệm";
            this.hodem.MinimumWidth = 6;
            this.hodem.Name = "hodem";
            this.hodem.ReadOnly = true;
            this.hodem.Width = 125;
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên ";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // tenlop
            // 
            this.tenlop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.tenlop.DataPropertyName = "tenlop";
            this.tenlop.HeaderText = "Tên lớp";
            this.tenlop.MinimumWidth = 6;
            this.tenlop.Name = "tenlop";
            this.tenlop.ReadOnly = true;
            this.tenlop.Width = 24;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.ReadOnly = true;
            this.tenmonhoc.Width = 93;
            // 
            // sotinchi
            // 
            this.sotinchi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sotinchi.DataPropertyName = "sotinchi";
            this.sotinchi.HeaderText = "Số TC";
            this.sotinchi.MinimumWidth = 6;
            this.sotinchi.Name = "sotinchi";
            this.sotinchi.ReadOnly = true;
            this.sotinchi.Width = 76;
            // 
            // diemchuyencan
            // 
            this.diemchuyencan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemchuyencan.DataPropertyName = "diemchuyencan";
            this.diemchuyencan.HeaderText = "Điểm chuyên cần";
            this.diemchuyencan.MinimumWidth = 6;
            this.diemchuyencan.Name = "diemchuyencan";
            this.diemchuyencan.ReadOnly = true;
            this.diemchuyencan.Width = 109;
            // 
            // diemheso1
            // 
            this.diemheso1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemheso1.DataPropertyName = "diemheso1";
            this.diemheso1.HeaderText = "Điểm hệ số 1";
            this.diemheso1.MinimumWidth = 6;
            this.diemheso1.Name = "diemheso1";
            this.diemheso1.ReadOnly = true;
            this.diemheso1.Width = 82;
            // 
            // diemheso2_t1
            // 
            this.diemheso2_t1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemheso2_t1.DataPropertyName = "diemheso2_t1";
            this.diemheso2_t1.HeaderText = "Điểm hệ số 2 (1)";
            this.diemheso2_t1.MinimumWidth = 6;
            this.diemheso2_t1.Name = "diemheso2_t1";
            this.diemheso2_t1.ReadOnly = true;
            this.diemheso2_t1.Width = 85;
            // 
            // diemheso2_t2
            // 
            this.diemheso2_t2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemheso2_t2.DataPropertyName = "diemheso2_t2";
            this.diemheso2_t2.HeaderText = "Điểm hệ số 2 (2)";
            this.diemheso2_t2.MinimumWidth = 6;
            this.diemheso2_t2.Name = "diemheso2_t2";
            this.diemheso2_t2.ReadOnly = true;
            this.diemheso2_t2.Width = 85;
            // 
            // diemquatrinh
            // 
            this.diemquatrinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemquatrinh.DataPropertyName = "diemquatrinh";
            this.diemquatrinh.HeaderText = "Điểm quá trình";
            this.diemquatrinh.MinimumWidth = 6;
            this.diemquatrinh.Name = "diemquatrinh";
            this.diemquatrinh.ReadOnly = true;
            this.diemquatrinh.Width = 103;
            // 
            // diemthi
            // 
            this.diemthi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemthi.DataPropertyName = "diemthi";
            this.diemthi.HeaderText = "Điểm thi";
            this.diemthi.MinimumWidth = 6;
            this.diemthi.Name = "diemthi";
            this.diemthi.ReadOnly = true;
            this.diemthi.Width = 95;
            // 
            // diemhocphan
            // 
            this.diemhocphan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemhocphan.DataPropertyName = "diemhocphan";
            this.diemhocphan.HeaderText = "Điểm học phần";
            this.diemhocphan.MinimumWidth = 6;
            this.diemhocphan.Name = "diemhocphan";
            this.diemhocphan.ReadOnly = true;
            this.diemhocphan.Width = 95;
            // 
            // bttimkiem
            // 
            this.bttimkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttimkiem.Location = new System.Drawing.Point(1065, 41);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(142, 39);
            this.bttimkiem.TabIndex = 37;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.UseVisualStyleBackColor = true;
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1614, 674);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.DimGray;
            this.groupBox6.Controls.Add(this.xuatdiem);
            this.groupBox6.Controls.Add(this.btexcel);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Controls.Add(this.grchucnang);
            this.groupBox6.Controls.Add(this.bttimkiem);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(0, 557);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1614, 117);
            this.groupBox6.TabIndex = 41;
            this.groupBox6.TabStop = false;
            // 
            // xuatdiem
            // 
            this.xuatdiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuatdiem.Location = new System.Drawing.Point(1387, 41);
            this.xuatdiem.Name = "xuatdiem";
            this.xuatdiem.Size = new System.Drawing.Size(142, 39);
            this.xuatdiem.TabIndex = 42;
            this.xuatdiem.Text = "Xuất Điểm";
            this.xuatdiem.UseVisualStyleBackColor = true;
            this.xuatdiem.Click += new System.EventHandler(this.xuatdiem_Click);
            // 
            // btexcel
            // 
            this.btexcel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btexcel.Location = new System.Drawing.Point(1228, 42);
            this.btexcel.Name = "btexcel";
            this.btexcel.Size = new System.Drawing.Size(142, 39);
            this.btexcel.TabIndex = 41;
            this.btexcel.Text = "Xuất Excel";
            this.btexcel.UseVisualStyleBackColor = true;
            this.btexcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtsv);
            this.groupBox7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox7.Location = new System.Drawing.Point(805, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(245, 87);
            this.groupBox7.TabIndex = 40;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sinh viên";
            // 
            // txtsv
            // 
            this.txtsv.Location = new System.Drawing.Point(17, 31);
            this.txtsv.Name = "txtsv";
            this.txtsv.Size = new System.Drawing.Size(208, 27);
            this.txtsv.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(162, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frm_QuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 674);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "frm_QuanLyDiem";
            this.Text = "frm_QuanLyDiem";
            this.Load += new System.EventHandler(this.frm_QuanLyDiem_Thao_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grchucnang.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_mon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.GroupBox grchucnang;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtsv;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btexcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button xuatdiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hodem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemchuyencan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemheso1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemheso2_t1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemheso2_t2;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemquatrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemhocphan;
        private System.Windows.Forms.Button button1;
    }
}