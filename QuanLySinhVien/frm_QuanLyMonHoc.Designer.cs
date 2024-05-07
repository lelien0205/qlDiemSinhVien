namespace QuanLySinhVien
{
    partial class frm_QuanLyMonHoc
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
            this.id_monhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grchucnang = new System.Windows.Forms.GroupBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttk = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
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
            this.id_monhoc,
            this.tenmonhoc,
            this.sotinchi});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(926, 556);
            this.dataGridView1.TabIndex = 20;
            // 
            // id_monhoc
            // 
            this.id_monhoc.DataPropertyName = "id_monhoc";
            this.id_monhoc.HeaderText = "Mã môn";
            this.id_monhoc.MinimumWidth = 6;
            this.id_monhoc.Name = "id_monhoc";
            this.id_monhoc.ReadOnly = true;
            this.id_monhoc.Width = 125;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.ReadOnly = true;
            // 
            // sotinchi
            // 
            this.sotinchi.DataPropertyName = "sotinchi";
            this.sotinchi.HeaderText = "Số tín chỉ";
            this.sotinchi.MinimumWidth = 6;
            this.sotinchi.Name = "sotinchi";
            this.sotinchi.ReadOnly = true;
            this.sotinchi.Width = 125;
            // 
            // grchucnang
            // 
            this.grchucnang.Controls.Add(this.btxoa);
            this.grchucnang.Controls.Add(this.btsua);
            this.grchucnang.Controls.Add(this.btthem);
            this.grchucnang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grchucnang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grchucnang.Location = new System.Drawing.Point(17, 28);
            this.grchucnang.Name = "grchucnang";
            this.grchucnang.Size = new System.Drawing.Size(314, 88);
            this.grchucnang.TabIndex = 31;
            this.grchucnang.TabStop = false;
            this.grchucnang.Text = "Chức năng";
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btxoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btxoa.Location = new System.Drawing.Point(217, 35);
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
            this.btsua.Location = new System.Drawing.Point(115, 35);
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
            this.btthem.Location = new System.Drawing.Point(12, 35);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(87, 37);
            this.btthem.TabIndex = 1;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_timkiem);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(340, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 86);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo mã môn";
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
            this.groupBox2.Size = new System.Drawing.Size(932, 582);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách môn";
            // 
            // bttk
            // 
            this.bttk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttk.Location = new System.Drawing.Point(694, 63);
            this.bttk.Name = "bttk";
            this.bttk.Size = new System.Drawing.Size(146, 37);
            this.bttk.TabIndex = 4;
            this.bttk.Text = "Tìm kiếm";
            this.bttk.UseVisualStyleBackColor = true;
            this.bttk.Click += new System.EventHandler(this.bttk_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(938, 603);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DimGray;
            this.groupBox5.Controls.Add(this.bttk);
            this.groupBox5.Controls.Add(this.grchucnang);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(0, 471);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(938, 132);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            // 
            // frm_QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 603);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Name = "frm_QuanLyMonHoc";
            this.Text = "frm_QuanLyMonHoc";
            this.Load += new System.EventHandler(this.frm_QuanLyMonHoc_Load);
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
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_monhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchi;
        private System.Windows.Forms.Button bttk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}