namespace QuanLySinhVien
{
    partial class frm_QuanLyLopHoc
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
            this.id_lophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoahoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hedaotao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namnhaphoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.txt_timkiem_thao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grchucnang = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bttk = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grchucnang.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_lophoc,
            this.tenlop,
            this.khoahoc,
            this.hedaotao,
            this.namnhaphoc,
            this.tenkhoa,
            this.id_khoa});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(950, 390);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
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
            // tenlop
            // 
            this.tenlop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenlop.DataPropertyName = "tenlop";
            this.tenlop.HeaderText = "Tên lớp";
            this.tenlop.MinimumWidth = 6;
            this.tenlop.Name = "tenlop";
            this.tenlop.ReadOnly = true;
            // 
            // khoahoc
            // 
            this.khoahoc.DataPropertyName = "khoahoc";
            this.khoahoc.HeaderText = "Khóa học";
            this.khoahoc.MinimumWidth = 6;
            this.khoahoc.Name = "khoahoc";
            this.khoahoc.ReadOnly = true;
            this.khoahoc.Width = 125;
            // 
            // hedaotao
            // 
            this.hedaotao.DataPropertyName = "hedaotao";
            this.hedaotao.HeaderText = "Hệ đào tạo";
            this.hedaotao.MinimumWidth = 6;
            this.hedaotao.Name = "hedaotao";
            this.hedaotao.ReadOnly = true;
            this.hedaotao.Width = 125;
            // 
            // namnhaphoc
            // 
            this.namnhaphoc.DataPropertyName = "namnhaphoc";
            this.namnhaphoc.HeaderText = "Năm nhập học";
            this.namnhaphoc.MinimumWidth = 6;
            this.namnhaphoc.Name = "namnhaphoc";
            this.namnhaphoc.ReadOnly = true;
            this.namnhaphoc.Width = 125;
            // 
            // tenkhoa
            // 
            this.tenkhoa.DataPropertyName = "tenkhoa";
            this.tenkhoa.HeaderText = "Tên khoa";
            this.tenkhoa.MinimumWidth = 6;
            this.tenkhoa.Name = "tenkhoa";
            this.tenkhoa.ReadOnly = true;
            this.tenkhoa.Width = 125;
            // 
            // id_khoa
            // 
            this.id_khoa.DataPropertyName = "id_khoa";
            this.id_khoa.HeaderText = "Mã khoa";
            this.id_khoa.MinimumWidth = 6;
            this.id_khoa.Name = "id_khoa";
            this.id_khoa.ReadOnly = true;
            this.id_khoa.Width = 125;
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btthem.Location = new System.Drawing.Point(10, 33);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(87, 37);
            this.btthem.TabIndex = 1;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btsua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btsua.Location = new System.Drawing.Point(113, 33);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(87, 37);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click_1);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btxoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btxoa.Location = new System.Drawing.Point(215, 33);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(87, 37);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // txt_timkiem_thao
            // 
            this.txt_timkiem_thao.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_timkiem_thao.Location = new System.Drawing.Point(36, 34);
            this.txt_timkiem_thao.Name = "txt_timkiem_thao";
            this.txt_timkiem_thao.Size = new System.Drawing.Size(270, 27);
            this.txt_timkiem_thao.TabIndex = 6;
            this.txt_timkiem_thao.TextChanged += new System.EventHandler(this.txt_timkiem_thao_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_timkiem_thao);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(332, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 89);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(3, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(956, 416);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp học";
            // 
            // grchucnang
            // 
            this.grchucnang.Controls.Add(this.btxoa);
            this.grchucnang.Controls.Add(this.btsua);
            this.grchucnang.Controls.Add(this.btthem);
            this.grchucnang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grchucnang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grchucnang.Location = new System.Drawing.Point(7, 19);
            this.grchucnang.Name = "grchucnang";
            this.grchucnang.Size = new System.Drawing.Size(319, 88);
            this.grchucnang.TabIndex = 23;
            this.grchucnang.TabStop = false;
            this.grchucnang.Text = "Chức năng";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DimGray;
            this.groupBox3.Controls.Add(this.bttk);
            this.groupBox3.Controls.Add(this.grchucnang);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 437);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(962, 126);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // bttk
            // 
            this.bttk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttk.Location = new System.Drawing.Point(678, 47);
            this.bttk.Name = "bttk";
            this.bttk.Size = new System.Drawing.Size(123, 37);
            this.bttk.TabIndex = 4;
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
            this.groupBox5.Size = new System.Drawing.Size(962, 437);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            // 
            // frm_QuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 563);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Name = "frm_QuanLyLopHoc";
            this.Text = "frm_QuanLyLopHoc_Thao";
            this.Load += new System.EventHandler(this.frm_QuanLyLopHoc_Thao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grchucnang.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.TextBox txt_timkiem_thao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grchucnang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bttk;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lophoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoahoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hedaotao;
        private System.Windows.Forms.DataGridViewTextBoxColumn namnhaphoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_khoa;
    }
}