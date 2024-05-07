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
    public partial class capnhatgiaovien : Form
    {
        SqlConnection con;
        string id_gv = "";
        public capnhatgiaovien(string id_gv)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            this.id_gv = id_gv;
        }

        private void capnhatgiaovien_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (string.IsNullOrEmpty(id_gv))
            {
                this.Text = "Thêm mới giáo viên";
                loadex();
            }
            else
            {
                this.Text = "Cập nhật giáo viên";
                loadex();
                txttendangnhap.Enabled = true;
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_giaovien where id_gv = '" + id_gv + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txthodem.Text = dt.Rows[0][1].ToString();
                object ngaySinhObject = dt.Rows[0][2];
                DateTime ngaySinh;

                if (ngaySinhObject != DBNull.Value)
                {
                    ngaySinh = DateTime.Parse(ngaySinhObject.ToString());
                    dateTimePicker1.Value = ngaySinh;
                }
                object maKhoaObject = dt.Rows[0][3];
                string maKhoa = maKhoaObject != DBNull.Value ? maKhoaObject.ToString() : "";
                cb_khoa.SelectedValue = maKhoa;
                txttendangnhap.Text = dt.Rows[0][4].ToString();
            
            }
        }
        private void loadex()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT tbl_khoa.tenkhoa, tbl_khoa.id_khoa  from tbl_khoa ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_khoa.DataSource = dt;
            cb_khoa.DisplayMember = "tenkhoa";
            cb_khoa.ValueMember = "id_khoa";
        }

        private void btquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }
        bool kiemtra_dulieu()
        {
            float n;

            if (kiemtra(txthodem.Text)
                || kiemtra(txttendangnhap.Text)
                || kiemtra(cb_khoa.Text))
            {
                return false;
            }

            return true;
        }
        private void btluu_Click(object sender, EventArgs e)
        {
            if (!kiemtra_dulieu())
            {
                MessageBox.Show("Dữ liệu nhập chưa đúng");
                return;
            }
            if (string.IsNullOrEmpty(id_gv))
            {
                //them_user();
                SqlCommand cmdCheckExist = new SqlCommand("SELECT COUNT(*) FROM tbl_nguoidung WHERE tendangnhap = @tendangnhap ", con);
                cmdCheckExist.Parameters.AddWithValue("@tendangnhap", txttendangnhap.Text);
                int count = (int)cmdCheckExist.ExecuteScalar();
                if (count == 0)
                {
                    SqlCommand _cmd = new SqlCommand(
                        "INSERT INTO tbl_nguoidung  (tendangnhap , matkhau, loainguoidung) " +
                        "VALUES ( @tendangnhap , @matkhau,  @quyen)", con);
                    _cmd.Parameters.AddWithValue("@tendangnhap", txttendangnhap.Text);
                    _cmd.Parameters.AddWithValue("@matkhau", "123");
                    _cmd.Parameters.AddWithValue("@quyen", "1");
                    if (_cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm tên đăng nhập thành công");
                    }
                    else MessageBox.Show("Thêm tên đăng nhập không thành công");
                    SqlCommand cmd = new SqlCommand(
                    "INSERT INTO dbo.tbl_giaovien (hoten_gv, ngaysinh, id_khoa, tendangnhap)" +
                    "VALUES(@hoten_gv, @ngaysinh, @id_khoa, @tendangnhap)", con);

                    cmd.Parameters.AddWithValue("@hoten_gv", txthodem.Text);
                    cmd.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@id_khoa", cb_khoa.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@tendangnhap", txttendangnhap.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        this.Close();
                    }
                    else MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                }
                
            }
            else
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbl_giaovien SET hoten_gv = @hoten_gv, ngaysinh = @ngaysinh " +
                    ",  id_khoa = @id_khoa, tendangnhap = @tendangnhap " +
                    "WHERE id_gv = '" + id_gv + "' ", con);
                cmd.Parameters.AddWithValue("@hoten_gv", txthodem.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@id_khoa", cb_khoa.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@tendangnhap", txttendangnhap.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    this.Close();
                }
                else MessageBox.Show("Sửa thất bại");
            }
        }
        private void them_user()
        {
            SqlCommand cmdCheckExist = new SqlCommand("SELECT COUNT(*) FROM tbl_nguoidung WHERE tendangnhap = @tendangnhap ", con);
            cmdCheckExist.Parameters.AddWithValue("@tendangnhap", txttendangnhap.Text);
            int count = (int)cmdCheckExist.ExecuteScalar();
            if (count == 0)
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO tbl_nguoidung  (tendangnhap , matkhau, loainguoidung) " +
                    "VALUES ( @tendangnhap , @matkhau,  @quyen)", con);
                cmd.Parameters.AddWithValue("@tendangnhap", txttendangnhap.Text);
                cmd.Parameters.AddWithValue("@matkhau", "123");
                cmd.Parameters.AddWithValue("@quyen", "1");
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm tên đăng nhập thành công");
                }
                else MessageBox.Show("Thêm tên đăng nhập không thành công");

            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
            }
            
        }
    }
}
