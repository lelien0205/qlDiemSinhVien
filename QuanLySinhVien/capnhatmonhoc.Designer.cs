namespace QuanLySinhVien
{
    partial class capnhatmonhoc
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
            this.label2 = new System.Windows.Forms.Label();
            this.txttenmonhoc = new System.Windows.Forms.TextBox();
            this.btquaylai = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btghilai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsotin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(36, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 63;
            this.label2.Text = "Tên môn học";
            // 
            // txttenmonhoc
            // 
            this.txttenmonhoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttenmonhoc.Location = new System.Drawing.Point(162, 90);
            this.txttenmonhoc.Name = "txttenmonhoc";
            this.txttenmonhoc.Size = new System.Drawing.Size(324, 27);
            this.txttenmonhoc.TabIndex = 62;
            // 
            // btquaylai
            // 
            this.btquaylai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btquaylai.Location = new System.Drawing.Point(305, 199);
            this.btquaylai.Name = "btquaylai";
            this.btquaylai.Size = new System.Drawing.Size(120, 36);
            this.btquaylai.TabIndex = 61;
            this.btquaylai.Text = "Quay lại";
            this.btquaylai.UseVisualStyleBackColor = true;
            this.btquaylai.Click += new System.EventHandler(this.btquaylai_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(157, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 25);
            this.label7.TabIndex = 60;
            this.label7.Text = "THÔNG TIN MÔN HỌC";
            // 
            // btghilai
            // 
            this.btghilai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btghilai.Location = new System.Drawing.Point(170, 198);
            this.btghilai.Name = "btghilai";
            this.btghilai.Size = new System.Drawing.Size(116, 37);
            this.btghilai.TabIndex = 58;
            this.btghilai.Text = "Lưu";
            this.btghilai.UseVisualStyleBackColor = true;
            this.btghilai.Click += new System.EventHandler(this.btghilai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(36, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "Số tín chỉ";
            // 
            // txtsotin
            // 
            this.txtsotin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsotin.Location = new System.Drawing.Point(162, 133);
            this.txtsotin.Name = "txtsotin";
            this.txtsotin.Size = new System.Drawing.Size(183, 27);
            this.txtsotin.TabIndex = 64;
            // 
            // capnhatmonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsotin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttenmonhoc);
            this.Controls.Add(this.btquaylai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btghilai);
            this.Name = "capnhatmonhoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "capnhatmonhoc";
            this.Load += new System.EventHandler(this.capnhatmonhoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenmonhoc;
        private System.Windows.Forms.Button btquaylai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btghilai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsotin;
    }
}