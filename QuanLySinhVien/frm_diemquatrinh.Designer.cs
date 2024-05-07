namespace QuanLySinhVien
{
    partial class frm_diemquatrinh
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hodem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemchuyencan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemheso1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemheso2_t1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemheso2_t2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btluu = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cb_mon = new System.Windows.Forms.ComboBox();
            this.bttk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenmonhoc,
            this.sotinchi,
            this.id_sv,
            this.hodem,
            this.ten,
            this.tenlop,
            this.diemchuyencan,
            this.diemheso1,
            this.diemheso2_t1,
            this.diemheso2_t2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1349, 577);
            this.dataGridView1.TabIndex = 0;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn học";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.ReadOnly = true;
            this.tenmonhoc.Width = 120;
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
            // id_sv
            // 
            this.id_sv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id_sv.DataPropertyName = "id_sv";
            this.id_sv.HeaderText = "Mã sinh viên";
            this.id_sv.MinimumWidth = 6;
            this.id_sv.Name = "id_sv";
            this.id_sv.ReadOnly = true;
            this.id_sv.Width = 121;
            // 
            // hodem
            // 
            this.hodem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.hodem.DataPropertyName = "hodem";
            this.hodem.HeaderText = "Họ Đệm";
            this.hodem.MinimumWidth = 6;
            this.hodem.Name = "hodem";
            this.hodem.ReadOnly = true;
            this.hodem.Width = 24;
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
            // diemchuyencan
            // 
            this.diemchuyencan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemchuyencan.DataPropertyName = "diemchuyencan";
            this.diemchuyencan.HeaderText = "Điểm chuyên cần";
            this.diemchuyencan.MinimumWidth = 6;
            this.diemchuyencan.Name = "diemchuyencan";
            this.diemchuyencan.Width = 126;
            // 
            // diemheso1
            // 
            this.diemheso1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemheso1.DataPropertyName = "diemheso1";
            this.diemheso1.HeaderText = "Điểm hệ số 1";
            this.diemheso1.MinimumWidth = 6;
            this.diemheso1.Name = "diemheso1";
            this.diemheso1.Width = 95;
            // 
            // diemheso2_t1
            // 
            this.diemheso2_t1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemheso2_t1.DataPropertyName = "diemheso2_t1";
            this.diemheso2_t1.HeaderText = "Điểm hệ số 2 (1)";
            this.diemheso2_t1.MinimumWidth = 6;
            this.diemheso2_t1.Name = "diemheso2_t1";
            this.diemheso2_t1.Width = 113;
            // 
            // diemheso2_t2
            // 
            this.diemheso2_t2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemheso2_t2.DataPropertyName = "diemheso2_t2";
            this.diemheso2_t2.HeaderText = "Điểm hệ số 2 (2)";
            this.diemheso2_t2.MinimumWidth = 6;
            this.diemheso2_t2.Name = "diemheso2_t2";
            this.diemheso2_t2.Width = 113;
            // 
            // btluu
            // 
            this.btluu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btluu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btluu.Location = new System.Drawing.Point(20, 35);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(95, 37);
            this.btluu.TabIndex = 1;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btluu);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(5, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 88);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(3, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1355, 603);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1361, 624);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DimGray;
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.bttk);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 517);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1361, 107);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cb_lop);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(151, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(203, 86);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm theo lớp";
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Items.AddRange(new object[] {
            ""});
            this.cb_lop.Location = new System.Drawing.Point(14, 33);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(177, 27);
            this.cb_lop.TabIndex = 0;
            this.cb_lop.SelectedIndexChanged += new System.EventHandler(this.cb_lop_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cb_mon);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(360, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(203, 86);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tìm kiếm theo môn";
            // 
            // cb_mon
            // 
            this.cb_mon.FormattingEnabled = true;
            this.cb_mon.Items.AddRange(new object[] {
            ""});
            this.cb_mon.Location = new System.Drawing.Point(14, 33);
            this.cb_mon.Name = "cb_mon";
            this.cb_mon.Size = new System.Drawing.Size(177, 27);
            this.cb_mon.TabIndex = 0;
            this.cb_mon.SelectedIndexChanged += new System.EventHandler(this.cb_mon_SelectedIndexChanged);
            // 
            // bttk
            // 
            this.bttk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttk.Location = new System.Drawing.Point(580, 55);
            this.bttk.Name = "bttk";
            this.bttk.Size = new System.Drawing.Size(117, 32);
            this.bttk.TabIndex = 35;
            this.bttk.Text = "Tìm kiếm";
            this.bttk.UseVisualStyleBackColor = true;
            this.bttk.Click += new System.EventHandler(this.bttk_Click);
            // 
            // frm_diemquatrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 624);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_diemquatrinh";
            this.Text = "frm_diemquatrinh";
            this.Load += new System.EventHandler(this.frm_diemquatrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_monhoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hodem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemchuyencan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemheso1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemheso2_t1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemheso2_t2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cb_mon;
        private System.Windows.Forms.Button bttk;
    }
}