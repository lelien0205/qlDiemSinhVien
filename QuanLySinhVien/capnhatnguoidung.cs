using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class capnhatnguoidung : Form
    {
        SqlConnection con;
        string tendangnhap = "";
        public capnhatnguoidung(string tendangnhap)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            this.tendangnhap = tendangnhap;
        }

        private void btquaylai_Click(object sender, EventArgs e)
        {
            //frm_QuanLyNguoiDung f = new frm_QuanLyNguoiDung();
            //this.Hide();
            //f.ShowDialog();
            this.Close();
        }
        private string GetLoaiNguoiDung(int loai)
        {
            switch (loai)
            {
                case 0:
                    return "admin";
                case 1:
                    return "giáo viên";
                case 2:
                    return "cán bộ";
                case 3:
                    return "sinh viên";
                default:
                    return "Không xác định";
            }
        }
        private void capnhatnguoidung_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (string.IsNullOrEmpty(tendangnhap))
            {
                this.Text = "Thêm mới người dùng";
            }
            else
            {
                this.Text = "Cập nhật người dùng";
                txttendangnhap.Enabled = false;
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_nguoidung where tendangnhap = '" + tendangnhap + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txttendangnhap.Text = tendangnhap;
                txtmk.Text = dt.Rows[0][1].ToString();

                int loainguoidung = Convert.ToInt32(dt.Rows[0][2]);

                cbnguoidung.Text = GetLoaiNguoiDung(loainguoidung);

            }
        }
        private int SetLoaiNguoiDung(string loai)
        {
            switch (loai)
            {
                case "Admin":
                    return 0;
                case "Giáo viên":
                    return 1;
                case "Cán bộ":
                    return 2;
                case "Sinh viên":
                    return 3;
                default:
                    return -1;
            }
        }

        private void btghilai_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtmk.Text) || string.IsNullOrEmpty(txttendangnhap.Text) || string.IsNullOrEmpty(cbnguoidung.Text))
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin");
                return;
            }
           
            if (string.IsNullOrEmpty(tendangnhap))
            {
                SqlCommand cmdCheckExist = new SqlCommand("SELECT COUNT(*) FROM tbl_nguoidung WHERE tendangnhap = @tendangnhap ", con);
                cmdCheckExist.Parameters.AddWithValue("@tendangnhap", txttendangnhap.Text);
                int count = (int)cmdCheckExist.ExecuteScalar();
                if (count == 0)
                {
                    SqlCommand cmd = new SqlCommand(
                    "INSERT INTO dbo.tbl_nguoidung (tendangnhap ,matkhau, loainguoidung)" +
                    "VALUES(@tendangnhap, @matkhau, @loainguoidung)", con);
                    cmd.Parameters.AddWithValue("@tendangnhap", txttendangnhap.Text);
                    cmd.Parameters.AddWithValue("@matkhau", txtmk.Text);
                    cmd.Parameters.AddWithValue("@loainguoidung", SetLoaiNguoiDung(cbnguoidung.Text));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm người dùng thành công");
                        //frm_QuanLyNguoiDung f = new frm_QuanLyNguoiDung();
                        //this.Hide();
                        //f.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("Thêm người dùng thất bại");
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbl_nguoidung SET matkhau = @matkhau, loainguoidung = @loainguoidung " +
                    "where tendangnhap = '" + tendangnhap + "'", con);
                cmd.Parameters.AddWithValue("@matkhau", txtmk.Text);
                cmd.Parameters.AddWithValue("@loainguoidung", int.Parse(SetLoaiNguoiDung(cbnguoidung.Text).ToString()));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    //frm_QuanLyNguoiDung f = new frm_QuanLyNguoiDung();
                    //this.Hide();
                    //f.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Sửa thất bại");
            }
        }
    }
}
