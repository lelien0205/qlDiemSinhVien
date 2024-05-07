using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class menu : Form
    {
        // 0: admin - 1: giáo viên - 2: sinh viên
        bool thongtin_collapsed;
        bool thongke_collapsed;
        bool nhapdiem_collapsed;
        string ten = "";
        string quyen = "";
        private Form currentFormChild;
        public menu(string tendangnhap, string loainguodung)
        {
            InitializeComponent();
            this.ten = tendangnhap;
            this.quyen = loainguodung;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void ThongTin_Timer_Tick(object sender, EventArgs e)
        {
            if (thongtin_collapsed)
            {
                thongtin_panel.Height += 10;
                if (thongtin_panel.Height == thongtin_panel.MaximumSize.Height)
                {
                    thongtin_collapsed = false;
                    ThongTin_Timer.Stop();
                }
            }
            else
            {
                thongtin_panel.Height -= 10;
                if (thongtin_panel.Height == thongtin_panel.MinimumSize.Height)
                {
                    thongtin_collapsed = true;
                    ThongTin_Timer.Stop();
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel_left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ThongTin_Timer.Start();
        }

        private void thongtin_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            thongke_timer.Start();
        }

        private void thongke_timer_Tick(object sender, EventArgs e)
        {
            if (thongke_collapsed)
            {
                thongke_panel.Height += 10;
                if (thongke_panel.Height == thongke_panel.MaximumSize.Height)
                {
                    thongke_collapsed = false;
                    thongke_timer.Stop();
                }
            }
            else
            {
                thongke_panel.Height -= 10;
                if (thongke_panel.Height == thongke_panel.MinimumSize.Height)
                {
                    thongke_collapsed = true;
                    thongke_timer.Stop();
                }
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            childForm.TopLevel = false; // cho biết nó không phải là form cấp cao nhất
            childForm.FormBorderStyle = FormBorderStyle.None; // loại bỏ đường biên chuẩn của cửa sổ.
            childForm.Dock = DockStyle.Fill; //  làm cho nó lấp đầy toàn bộ khu vực trống.
            panel_body.Controls.Add(childForm); // Thêm form con 
            panel_body.Tag = childForm; // liên kết form với panel.
            childForm.BringToFront(); // Đưa form con lên phía trước
            childForm.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            label1.Text = "TRANG CHỦ";
            if (quyen == "0")
                this.Text = "Giao diện trang chủ của admin";
            else if (quyen == "1")
            {
                this.Text = "Giao diện trang chủ của giáo viên";
                xethocbong_p.Visible = false; // không được hiển thị
                taikhoan_panel.Visible = false;
            }
            else if (quyen == "2")
            {
                this.Text = "Giao diện trang chủ của cán bộ ";
                taikhoan_panel.Visible = false;
            }
            else if (quyen == "3")
            {
                this.Text = "Giao diện trang chủ của sinh viên";
                thongtin_panel.MaximumSize = new Size(197, 145);
                giaovien_p.Enabled = false; // không được tương tác vs người dùng 
                lophoc_p.Enabled = false;
                khoa_p.Enabled = false;
                giaovien_p.Visible = false;
                lophoc_p.Visible = false;
                khoa_p.Visible = false;
                p_nhapdiem.Visible = false;
                thongke_panel.Visible = false;
                taikhoan_panel.Visible = false;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất ? ", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Dangnhap f = new Dangnhap();
                this.Hide();
                f.ShowDialog();
            }
        }
        private void btsinhvien_Click(object sender, EventArgs e)
        {
            label1.Text = "THÔNG TIN SINH VIÊN";
            if (quyen == "3")
            {
                OpenChildForm(new frm_thongtinsinhvien());
            }
            else
            {
                OpenChildForm(new frm_QuanLySinhVien(quyen, 0));
            }
        }

        private void btgiaovien_Click(object sender, EventArgs e)
        {
            label1.Text = "THÔNG TIN GIÁO VIÊN";
            OpenChildForm(new frm_QuanLyGiaoVien(quyen));
        }

        private void btkhoa_Click(object sender, EventArgs e)
        {
            label1.Text = "THÔNG TIN KHOA";
            OpenChildForm(new frm_QuanLyKhoa(quyen));
        }

        private void btlophoc_Click(object sender, EventArgs e)
        {
            label1.Text = "THÔNG TIN LỚP HỌC";
            OpenChildForm(new frm_QuanLyLopHoc(quyen));
        }

        private void btmonhoc_Click(object sender, EventArgs e)
        {
            label1.Text = "THÔNG TIN MÔN HỌC";
            OpenChildForm(new frm_QuanLyMonHoc(quyen));
        }

        private void btlophocphan_Click(object sender, EventArgs e)
        {
            label1.Text = "THÔNG TIN LỚP HỌC PHẦN";
            OpenChildForm(new frm_QuanLyLopHocPhan(quyen));

        }

        private void btnhapdiem_Click(object sender, EventArgs e)
        {
            nhapdiem_time.Start();
        }

        private void btxembangdiem_Click(object sender, EventArgs e)
        {
            label1.Text = "THÔNG TIN BẢNG ĐIỂM";
            OpenChildForm(new frm_QuanLyDiem(quyen, 0));
        }

        private void bttaikhoan_Click(object sender, EventArgs e)
        {
            label1.Text = "THÔNG TIN TÀI KHOẢN";
            OpenChildForm(new frm_QuanLyNguoiDung());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            thongke_timer.Start();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "TRANG CHỦ";
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btxet_Click(object sender, EventArgs e)
        {
            label1.Text = "XÉT HỌC BỔNG";
            OpenChildForm(new frm_diemtrungbinh());
        }

        private void btdssv_Click(object sender, EventArgs e)
        {
            label1.Text = "XUẤT DANH SÁCH SINH VIÊN CỦA MỘT LỚP";
            OpenChildForm(new frm_QuanLySinhVien(quyen, 1));
        }

        private void btdsd_Click(object sender, EventArgs e)
        {
            label1.Text = "XUẤT DANH SÁCH ĐIỂM MỘT MÔN CỦA MỘT LỚP";
            OpenChildForm(new frm_QuanLyDiem(quyen, 1));
        }

        private void btbaocao_Click(object sender, EventArgs e)
        {
            label1.Text = "XUẤT BẢNG ĐIỂM CỦA MỘT SINH VIÊN";
            OpenChildForm(new frm_QuanLyDiem(quyen, 2));
        }

        private void nhapdiem_time_Tick(object sender, EventArgs e)
        {
            if (nhapdiem_collapsed)
            {
                p_nhapdiem.Height += 10;
                if (p_nhapdiem.Height == p_nhapdiem.MaximumSize.Height)
                {
                    nhapdiem_collapsed = false;
                    nhapdiem_time.Stop();
                }
            }
            else
            {
                p_nhapdiem.Height -= 10;
                if (p_nhapdiem.Height == p_nhapdiem.MinimumSize.Height)
                {
                    nhapdiem_collapsed = true;
                    nhapdiem_time.Stop();
                }
            }
        }

        private void btquatrinh_Click(object sender, EventArgs e)
        {
            label1.Text = "NHẬP ĐIỂM QUÁ TRÌNH";
            OpenChildForm(new frm_diemquatrinh());
        }

        private void btthi_Click(object sender, EventArgs e)
        {
            label1.Text = "NHẬP ĐIỂM THI";
            OpenChildForm(new frm_diemthi());
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
