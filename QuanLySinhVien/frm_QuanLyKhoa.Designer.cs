namespace QuanLySinhVien
{
    partial class frm_QuanLyKhoa
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
            this.id_khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grchucnang = new System.Windows.Forms.GroupBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bttk = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grchucnang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_khoa,
            this.tenkhoa});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(969, 602);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // id_khoa
            // 
            this.id_khoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_khoa.DataPropertyName = "id_khoa";
            this.id_khoa.HeaderText = "Mã khoa";
            this.id_khoa.MinimumWidth = 6;
            this.id_khoa.Name = "id_khoa";
            this.id_khoa.ReadOnly = true;
            // 
            // tenkhoa
            // 
            this.tenkhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenkhoa.DataPropertyName = "tenkhoa";
            this.tenkhoa.HeaderText = "Tên khoa";
            this.tenkhoa.MinimumWidth = 6;
            this.tenkhoa.Name = "tenkhoa";
            this.tenkhoa.ReadOnly = true;
            // 
            // grchucnang
            // 
            this.grchucnang.Controls.Add(this.btxoa);
            this.grchucnang.Controls.Add(this.btsua);
            this.grchucnang.Controls.Add(this.btthem);
            this.grchucnang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grchucnang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grchucnang.Location = new System.Drawing.Point(11, 19);
            this.grchucnang.Name = "grchucnang";
            this.grchucnang.Size = new System.Drawing.Size(323, 88);
            this.grchucnang.TabIndex = 28;
            this.grchucnang.TabStop = false;
            this.grchucnang.Text = "Chức năng";
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btxoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btxoa.Location = new System.Drawing.Point(218, 26);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(87, 44);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btsua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btsua.Location = new System.Drawing.Point(116, 26);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(87, 44);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_timkiem);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(340, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 88);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo tên khoa";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_timkiem.Location = new System.Drawing.Point(36, 34);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(270, 27);
            this.txt_timkiem.TabIndex = 6;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_thao_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(3, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(975, 628);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khoa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(981, 649);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DimGray;
            this.groupBox5.Controls.Add(this.bttk);
            this.groupBox5.Controls.Add(this.grchucnang);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(0, 528);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(981, 121);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            // 
            // bttk
            // 
            this.bttk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttk.Location = new System.Drawing.Point(687, 49);
            this.bttk.Name = "bttk";
            this.bttk.Size = new System.Drawing.Size(132, 37);
            this.bttk.TabIndex = 4;
            this.bttk.Text = "Tìm kiếm";
            this.bttk.UseVisualStyleBackColor = true;
            this.bttk.Click += new System.EventHandler(this.bttk_Click);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btthem.Location = new System.Drawing.Point(13, 26);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(87, 44);
            this.btthem.TabIndex = 1;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // frm_QuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 649);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Name = "frm_QuanLyKhoa";
            this.Text = "frm_QuanLyKhoa_Thao";
            this.Load += new System.EventHandler(this.frm_QuanLyKhoa_Thao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grchucnang.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grchucnang;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bttk;
        private System.Windows.Forms.Button btthem;
    }
}