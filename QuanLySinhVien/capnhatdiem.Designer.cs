namespace QuanLySinhVien
{
    partial class capnhatdiem
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hodem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemchuyencan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemheso1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemheso2_t1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemheso2_t2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btquaylai = new System.Windows.Forms.Button();
            this.btghilai = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1397, 266);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
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
            this.diemchuyencan,
            this.diemheso1,
            this.diemheso2_t1,
            this.diemheso2_t2,
            this.diemthi});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1391, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // id_diem
            // 
            this.id_diem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id_diem.DataPropertyName = "id_diem";
            this.id_diem.HeaderText = "ID";
            this.id_diem.MinimumWidth = 6;
            this.id_diem.Name = "id_diem";
            this.id_diem.ReadOnly = true;
            this.id_diem.Width = 56;
            // 
            // id_sv
            // 
            this.id_sv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
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
            this.tenlop.DataPropertyName = "tenlop";
            this.tenlop.HeaderText = "Tên lớp";
            this.tenlop.MinimumWidth = 6;
            this.tenlop.Name = "tenlop";
            this.tenlop.ReadOnly = true;
            this.tenlop.Width = 125;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.ReadOnly = true;
            this.tenmonhoc.Width = 125;
            // 
            // diemchuyencan
            // 
            this.diemchuyencan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemchuyencan.DataPropertyName = "diemchuyencan";
            this.diemchuyencan.HeaderText = "Điểm chuyên cần";
            this.diemchuyencan.MinimumWidth = 6;
            this.diemchuyencan.Name = "diemchuyencan";
            this.diemchuyencan.Width = 109;
            // 
            // diemheso1
            // 
            this.diemheso1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemheso1.DataPropertyName = "diemheso1";
            this.diemheso1.HeaderText = "Điểm hệ số 1";
            this.diemheso1.MinimumWidth = 6;
            this.diemheso1.Name = "diemheso1";
            this.diemheso1.Width = 82;
            // 
            // diemheso2_t1
            // 
            this.diemheso2_t1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemheso2_t1.DataPropertyName = "diemheso2_t1";
            this.diemheso2_t1.HeaderText = "Điểm hệ số 2 (1)";
            this.diemheso2_t1.MinimumWidth = 6;
            this.diemheso2_t1.Name = "diemheso2_t1";
            this.diemheso2_t1.Width = 85;
            // 
            // diemheso2_t2
            // 
            this.diemheso2_t2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemheso2_t2.DataPropertyName = "diemheso2_t2";
            this.diemheso2_t2.HeaderText = "Điểm hệ số 2 (2)";
            this.diemheso2_t2.MinimumWidth = 6;
            this.diemheso2_t2.Name = "diemheso2_t2";
            this.diemheso2_t2.Width = 85;
            // 
            // diemthi
            // 
            this.diemthi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemthi.DataPropertyName = "diemthi";
            this.diemthi.HeaderText = "Điểm thi";
            this.diemthi.MinimumWidth = 6;
            this.diemthi.Name = "diemthi";
            this.diemthi.Width = 95;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1397, 84);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // btquaylai
            // 
            this.btquaylai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btquaylai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btquaylai.Location = new System.Drawing.Point(139, 21);
            this.btquaylai.Name = "btquaylai";
            this.btquaylai.Size = new System.Drawing.Size(120, 36);
            this.btquaylai.TabIndex = 58;
            this.btquaylai.Text = "Quay lại";
            this.btquaylai.UseVisualStyleBackColor = true;
            this.btquaylai.Click += new System.EventHandler(this.btquaylai_Click_1);
            // 
            // btghilai
            // 
            this.btghilai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btghilai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btghilai.Location = new System.Drawing.Point(6, 21);
            this.btghilai.Name = "btghilai";
            this.btghilai.Size = new System.Drawing.Size(116, 37);
            this.btghilai.TabIndex = 57;
            this.btghilai.Text = "Lưu";
            this.btghilai.UseVisualStyleBackColor = true;
            this.btghilai.Click += new System.EventHandler(this.btghilai_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btquaylai);
            this.groupBox3.Controls.Add(this.btghilai);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 63);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // capnhatdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 266);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "capnhatdiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "capnhatdiem";
            this.Load += new System.EventHandler(this.capnhatdiem_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btquaylai;
        private System.Windows.Forms.Button btghilai;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hodem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemchuyencan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemheso1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemheso2_t1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemheso2_t2;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthi;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}