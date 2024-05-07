namespace QuanLySinhVien
{
    partial class frm_QuanLyLopHocPhan
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
            this.id_lophocphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten_gv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.grchucnang = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_mon = new System.Windows.Forms.ComboBox();
            this.bttk = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grchucnang.SuspendLayout();
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
            this.id_lophocphan,
            this.tenlop,
            this.tenmonhoc,
            this.hoten_gv,
            this.hocky,
            this.nam});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 611);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // id_lophocphan
            // 
            this.id_lophocphan.DataPropertyName = "id_lophocphan";
            this.id_lophocphan.HeaderText = "Mã lớp";
            this.id_lophocphan.MinimumWidth = 6;
            this.id_lophocphan.Name = "id_lophocphan";
            this.id_lophocphan.ReadOnly = true;
            this.id_lophocphan.Width = 125;
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
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn học";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.ReadOnly = true;
            this.tenmonhoc.Width = 125;
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
            this.hocky.Width = 125;
            // 
            // nam
            // 
            this.nam.DataPropertyName = "nam";
            this.nam.HeaderText = "Năm";
            this.nam.MinimumWidth = 6;
            this.nam.Name = "nam";
            this.nam.ReadOnly = true;
            this.nam.Width = 125;
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btxoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btxoa.Location = new System.Drawing.Point(217, 34);
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
            this.btsua.Location = new System.Drawing.Point(115, 34);
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
            this.btthem.Location = new System.Drawing.Point(12, 34);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(87, 37);
            this.btthem.TabIndex = 1;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // grchucnang
            // 
            this.grchucnang.Controls.Add(this.btxoa);
            this.grchucnang.Controls.Add(this.btsua);
            this.grchucnang.Controls.Add(this.btthem);
            this.grchucnang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grchucnang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grchucnang.Location = new System.Drawing.Point(9, 19);
            this.grchucnang.Name = "grchucnang";
            this.grchucnang.Size = new System.Drawing.Size(320, 88);
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
            this.groupBox2.Size = new System.Drawing.Size(1044, 637);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_lop);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(335, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 88);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo lớp";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_mon);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(544, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 86);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo môn";
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
            // bttk
            // 
            this.bttk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttk.Location = new System.Drawing.Point(764, 58);
            this.bttk.Name = "bttk";
            this.bttk.Size = new System.Drawing.Size(117, 32);
            this.bttk.TabIndex = 27;
            this.bttk.Text = "Tìm kiếm";
            this.bttk.UseVisualStyleBackColor = true;
            this.bttk.Click += new System.EventHandler(this.bttk_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1050, 658);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.DimGray;
            this.groupBox6.Controls.Add(this.bttk);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.grchucnang);
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(0, 531);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1050, 127);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            // 
            // frm_QuanLyLopHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 658);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "frm_QuanLyLopHocPhan";
            this.Text = "frm_QuanLyLopHocPhan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_QuanLyLopHocPhan_FormClosed);
            this.Load += new System.EventHandler(this.frm_QuanLyLopHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grchucnang.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.GroupBox grchucnang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_mon;
        private System.Windows.Forms.Button bttk;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lophocphan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten_gv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam;
    }
}