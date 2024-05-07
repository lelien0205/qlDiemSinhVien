namespace QuanLySinhVien
{
    partial class capnhatkhoa
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
            this.btquaylai = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btghilai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenkhoa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btquaylai
            // 
            this.btquaylai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btquaylai.Location = new System.Drawing.Point(230, 143);
            this.btquaylai.Name = "btquaylai";
            this.btquaylai.Size = new System.Drawing.Size(120, 36);
            this.btquaylai.TabIndex = 53;
            this.btquaylai.Text = "Quay lại";
            this.btquaylai.UseVisualStyleBackColor = true;
            this.btquaylai.Click += new System.EventHandler(this.btquaylai_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(90, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 25);
            this.label7.TabIndex = 52;
            this.label7.Text = "THÔNG TIN KHOA";
            // 
            // btghilai
            // 
            this.btghilai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btghilai.Location = new System.Drawing.Point(95, 143);
            this.btghilai.Name = "btghilai";
            this.btghilai.Size = new System.Drawing.Size(116, 37);
            this.btghilai.TabIndex = 50;
            this.btghilai.Text = "Lưu";
            this.btghilai.UseVisualStyleBackColor = true;
            this.btghilai.Click += new System.EventHandler(this.btghilai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(61, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tên khoa";
            // 
            // txt_tenkhoa
            // 
            this.txt_tenkhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tenkhoa.Location = new System.Drawing.Point(167, 75);
            this.txt_tenkhoa.Name = "txt_tenkhoa";
            this.txt_tenkhoa.Size = new System.Drawing.Size(183, 27);
            this.txt_tenkhoa.TabIndex = 55;
            // 
            // capnhatkhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 218);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tenkhoa);
            this.Controls.Add(this.btquaylai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btghilai);
            this.Name = "capnhatkhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "capnhatkhoa";
            this.Load += new System.EventHandler(this.capnhatkhoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btquaylai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btghilai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenkhoa;
    }
}