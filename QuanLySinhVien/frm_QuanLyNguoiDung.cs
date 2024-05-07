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
    public partial class frm_QuanLyNguoiDung : Form
    {
        SqlConnection con;
        public frm_QuanLyNguoiDung()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
        }

        private void frm_QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            loadex();
        }
        private void loadex()
        {
            SqlCommand cmd = new SqlCommand("SELECT tendangnhap, matkhau, CASE  " +
                    "WHEN loainguoidung = 0 THEN N'admin' " +
                    "WHEN loainguoidung = 1 THEN N'giáo viên' " +
                    " WHEN loainguoidung = 2 THEN N'cán bộ' " +
                    "WHEN loainguoidung = 3 THEN N'Sinh Viên'  " +
                "END AS loainguoidung FROM tbl_nguoidung;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bttk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_timkiem.Text))
            {
                MessageBox.Show("Vui lòng điền thông tin cần tìm");
                loadex();
                return;
            }
            int quyen = 0;
            if (txt_timkiem.Text.Equals("admin", StringComparison.OrdinalIgnoreCase)) quyen = 0;
            if (txt_timkiem.Text.Equals("cán bộ", StringComparison.OrdinalIgnoreCase)) quyen = 2;
            if (txt_timkiem.Text.Equals("sinh viên", StringComparison.OrdinalIgnoreCase)) quyen = 3;
            if (txt_timkiem.Text.Equals("giáo viên", StringComparison.OrdinalIgnoreCase)) quyen = 1;


            SqlCommand cmd = new SqlCommand("SELECT tendangnhap, matkhau, CASE  " +
                "WHEN loainguoidung = 0 THEN N'admin' " +
                "WHEN loainguoidung = 1 THEN N'giáo viên' " +
                "WHEN loainguoidung = 2 THEN N'cán bộ' " +
                "WHEN loainguoidung = 3 THEN N'Sinh Viên' " +
                "END AS loainguoidung " +
                "FROM tbl_nguoidung " +
                "WHERE tendangnhap LIKE N'%' + @searchText + N'%' OR loainguoidung LIKE N'%' + @searchText + N'%'", con);

            cmd.Parameters.AddWithValue("@searchText", txt_timkiem.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            int dongchon = dataGridView1.CurrentRow.Index;
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM tbl_nguoidung WHERE tendangnhap = @tendangnhap", con);
            cmd.Parameters.AddWithValue("@tendangnhap", dataGridView1.Rows[dongchon].Cells["tendangnhap"].Value.ToString());
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
            loadex();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentRow.Index;
            if (dongchon >= 0)
            {
                new capnhatnguoidung(dataGridView1.Rows[dongchon].Cells["tendangnhap"].Value.ToString()).ShowDialog();
                loadex();
            }
            else
            {
                MessageBox.Show("Chọn tài khoản cần sửa trong bảng!");
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            new capnhatnguoidung(null).ShowDialog();
            loadex();
        }
    }
}
