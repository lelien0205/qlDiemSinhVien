namespace QuanLySinhVien
{
    partial class frm_QuanLySinhVien
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
            this.id_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hodem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_lophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.txtsv = new System.Windows.Forms.TextBox();
            this.grchucnang = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.excel = new System.Windows.Forms.Button();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grchucnang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_sv,
            this.hodem,
            this.ten,
            this.ngaysinh,
            this.gioitinh,
            this.quequan,
            this.sdt,
            this.id_lophoc,
            this.tendangnhap});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1292, 427);
            this.dataGridView1.TabIndex = 0;
            // 
            // id_sv
            // 
            this.id_sv.DataPropertyName = "id_sv";
            this.id_sv.HeaderText = "Mã sinh viên";
            this.id_sv.MinimumWidth = 6;
            this.id_sv.Name = "id_sv";
            this.id_sv.ReadOnly = true;
            this.id_sv.Width = 125;
            // 
            // hodem
            // 
            this.hodem.DataPropertyName = "hodem";
            this.hodem.HeaderText = "Họ đệm";
            this.hodem.MinimumWidth = 6;
            this.hodem.Name = "hodem";
            this.hodem.ReadOnly = true;
            this.hodem.Width = 125;
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            this.ngaysinh.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            this.gioitinh.Width = 125;
            // 
            // quequan
            // 
            this.quequan.DataPropertyName = "quequan";
            this.quequan.HeaderText = "Quê quán";
            this.quequan.MinimumWidth = 6;
            this.quequan.Name = "quequan";
            this.quequan.ReadOnly = true;
            this.quequan.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 125;
            // 
            // id_lophoc
            // 
            this.id_lophoc.DataPropertyName = "id_lophoc";
            this.id_lophoc.HeaderText = "Mã lớp";
            this.id_lophoc.MinimumWidth = 6;
            this.id_lophoc.Name = "id_lophoc";
            this.id_lophoc.ReadOnly = true;
            this.id_lophoc.Width = 125;
            // 
            // tendangnhap
            // 
            this.tendangnhap.DataPropertyName = "tendangnhap";
            this.tendangnhap.HeaderText = "Tên đăng nhập";
            this.tendangnhap.MinimumWidth = 6;
            this.tendangnhap.Name = "tendangnhap";
            this.tendangnhap.ReadOnly = true;
            this.tendangnhap.Width = 125;
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btxoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btxoa.Location = new System.Drawing.Point(214, 33);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(87, 37);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btsua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btsua.Location = new System.Drawing.Point(112, 33);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(87, 37);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btthem.Location = new System.Drawing.Point(9, 33);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(87, 37);
            this.btthem.TabIndex = 1;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // txtsv
            // 
            this.txtsv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsv.Location = new System.Drawing.Point(36, 34);
            this.txtsv.Name = "txtsv";
            this.txtsv.Size = new System.Drawing.Size(207, 27);
            this.txtsv.TabIndex = 6;
            this.txtsv.TextChanged += new System.EventHandler(this.txtsv_TextChanged);
            // 
            // grchucnang
            // 
            this.grchucnang.Controls.Add(this.btxoa);
            this.grchucnang.Controls.Add(this.btsua);
            this.grchucnang.Controls.Add(this.btthem);
            this.grchucnang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grchucnang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grchucnang.Location = new System.Drawing.Point(6, 19);
            this.grchucnang.Name = "grchucnang";
            this.grchucnang.Size = new System.Drawing.Size(315, 88);
            this.grchucnang.TabIndex = 26;
            this.grchucnang.TabStop = false;
            this.grchucnang.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(3, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1298, 453);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(331, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 81);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo mã";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DimGray;
            this.groupBox3.Controls.Add(this.excel);
            this.groupBox3.Controls.Add(this.bttimkiem);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.grchucnang);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 474);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1304, 121);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // excel
            // 
            this.excel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.excel.Location = new System.Drawing.Point(1022, 50);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(116, 39);
            this.excel.TabIndex = 41;
            this.excel.Text = "Xuất Excel";
            this.excel.UseVisualStyleBackColor = true;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // bttimkiem
            // 
            this.bttimkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttimkiem.Location = new System.Drawing.Point(861, 50);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(142, 39);
            this.bttimkiem.TabIndex = 40;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.UseVisualStyleBackColor = true;
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cb_lop);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(601, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(254, 79);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tên lớp";
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(30, 29);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(198, 27);
            this.cb_lop.TabIndex = 30;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1304, 474);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            // 
            // frm_QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 595);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Name = "frm_QuanLySinhVien";
            this.Text = "3";
            this.Load += new System.EventHandler(this.frm_QuanLySinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grchucnang.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox txtsv;
        private System.Windows.Forms.GroupBox grchucnang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.Button excel;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hodem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendangnhap;
    }
}