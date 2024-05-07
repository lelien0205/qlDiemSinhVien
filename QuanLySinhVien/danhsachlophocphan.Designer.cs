namespace QuanLySinhVien
{
    partial class danhsachlophocphan
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
            this.btds = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grchucnang = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.id_lophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_monhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten_gv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttk = new System.Windows.Forms.Button();
            this.cb_mon = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grchucnang.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_lophoc,
            this.tenlop,
            this.id_monhoc,
            this.tenmonhoc,
            this.hoten_gv,
            this.hocky,
            this.nam});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1266, 556);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btds
            // 
            this.btds.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btds.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btds.Location = new System.Drawing.Point(9, 34);
            this.btds.Name = "btds";
            this.btds.Size = new System.Drawing.Size(189, 37);
            this.btds.TabIndex = 1;
            this.btds.Text = "Nhập điểm quá trình";
            this.btds.UseVisualStyleBackColor = true;
            this.btds.Click += new System.EventHandler(this.btds_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btds);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(6, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 88);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(204, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nhập điểm thi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(3, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1272, 582);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các lớp học phần";
            // 
            // grchucnang
            // 
            this.grchucnang.BackColor = System.Drawing.Color.DimGray;
            this.grchucnang.Controls.Add(this.groupBox4);
            this.grchucnang.Controls.Add(this.groupBox1);
            this.grchucnang.Controls.Add(this.groupBox3);
            this.grchucnang.Controls.Add(this.bttk);
            this.grchucnang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grchucnang.Location = new System.Drawing.Point(0, 603);
            this.grchucnang.Name = "grchucnang";
            this.grchucnang.Size = new System.Drawing.Size(1278, 117);
            this.grchucnang.TabIndex = 33;
            this.grchucnang.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1278, 603);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            // 
            // id_lophoc
            // 
            this.id_lophoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id_lophoc.DataPropertyName = "id_lophoc";
            this.id_lophoc.HeaderText = "Mã lớp học";
            this.id_lophoc.MinimumWidth = 6;
            this.id_lophoc.Name = "id_lophoc";
            this.id_lophoc.ReadOnly = true;
            this.id_lophoc.Width = 120;
            // 
            // tenlop
            // 
            this.tenlop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenlop.DataPropertyName = "tenlop";
            this.tenlop.HeaderText = "Tên lớp";
            this.tenlop.MinimumWidth = 6;
            this.tenlop.Name = "tenlop";
            this.tenlop.ReadOnly = true;
            // 
            // id_monhoc
            // 
            this.id_monhoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id_monhoc.DataPropertyName = "id_monhoc";
            this.id_monhoc.HeaderText = "Mã môn";
            this.id_monhoc.MinimumWidth = 6;
            this.id_monhoc.Name = "id_monhoc";
            this.id_monhoc.ReadOnly = true;
            this.id_monhoc.Width = 98;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn học";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.ReadOnly = true;
            this.tenmonhoc.Width = 120;
            // 
            // hoten_gv
            // 
            this.hoten_gv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten_gv.DataPropertyName = "hoten_gv";
            this.hoten_gv.HeaderText = "Họ Tên Giáo Viên";
            this.hoten_gv.MinimumWidth = 6;
            this.hoten_gv.Name = "hoten_gv";
            this.hoten_gv.ReadOnly = true;
            // 
            // hocky
            // 
            this.hocky.DataPropertyName = "hocky";
            this.hocky.HeaderText = "Học kỳ";
            this.hocky.MinimumWidth = 6;
            this.hocky.Name = "hocky";
            this.hocky.ReadOnly = true;
            this.hocky.Width = 83;
            // 
            // nam
            // 
            this.nam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nam.DataPropertyName = "nam";
            this.nam.HeaderText = "Năm";
            this.nam.MinimumWidth = 6;
            this.nam.Name = "nam";
            this.nam.ReadOnly = true;
            // 
            // bttk
            // 
            this.bttk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttk.Location = new System.Drawing.Point(805, 56);
            this.bttk.Name = "bttk";
            this.bttk.Size = new System.Drawing.Size(117, 32);
            this.bttk.TabIndex = 32;
            this.bttk.Text = "Tìm kiếm";
            this.bttk.UseVisualStyleBackColor = true;
            this.bttk.Click += new System.EventHandler(this.bttk_Click);
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
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_mon);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(585, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 81);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo môn";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_lop);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(376, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 81);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo lớp";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // danhsachlophocphan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 720);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.grchucnang);
            this.Name = "danhsachlophocphan";
            this.Text = "danhsachlophocphan";
            this.Load += new System.EventHandler(this.danhsachlophocphan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grchucnang.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btds;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grchucnang;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_monhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten_gv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_mon;
        private System.Windows.Forms.Button bttk;
    }
}