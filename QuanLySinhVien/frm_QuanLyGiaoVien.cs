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
    public partial class frm_QuanLyGiaoVien : Form
    {
        SqlConnection con;
        string quyen = "";
        public frm_QuanLyGiaoVien(string quyen)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
            this.quyen = quyen;
        }

        private void frm_QuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            if(quyen == "1" || quyen == "3")
            {
                grchucnang.Visible = false;
            }
            if (con.State == ConnectionState.Closed)
                con.Open();
            loadex();
        }
        private void loadex()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_giaovien", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            int dongchon = dataGridView1.CurrentRow.Index;
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM tbl_giaovien WHERE id_gv = @id_gv", con);
            cmd.Parameters.AddWithValue("@id_gv", dataGridView1.Rows[dongchon].Cells["id_gv"].Value.ToString());
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
            loadex();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentRow.Index;
            if (dongchon >= 0)
            {
                new capnhatgiaovien(dataGridView1.Rows[dongchon].Cells["id_gv"].Value.ToString()).ShowDialog();
                loadex();
            }
            else
            {
                MessageBox.Show("Chọn mã lớp học cần sửa trong bảng!");
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            new capnhatgiaovien(null).ShowDialog();
            loadex();
        }

        private void bttk_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_timkiem.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm");
                loadex();
                return;
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_giaovien " +
                                            "where hoten_gv like N'%" + txt_timkiem.Text + "%' " +
                                            "or id_gv like N'%" + txt_timkiem.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
