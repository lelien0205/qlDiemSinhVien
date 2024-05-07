using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    public partial class frm_QuanLyLopHoc : Form
    {
        SqlConnection con;
        string quyen = "";
        public frm_QuanLyLopHoc(string quyen)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
            this.quyen = quyen;
        }
        private void frm_QuanLyLopHoc_Thao_Load(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("SELECT tbl_lophoc.*, tbl_khoa.tenkhoa " +
                                            "FROM tbl_lophoc " +
                                            "INNER JOIN tbl_khoa ON tbl_lophoc.id_khoa = tbl_khoa.id_khoa", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //int dongchon = -1;
            //dongchon = dataGridView1.CurrentRow.Index; // gán dòng trong data vào dòng chọn
            //if (dongchon >= 0)
            //{
            //    txt_id_lophoc_thao.Text = dataGridView1.Rows[dongchon].Cells["id_lophoc"].Value.ToString();
            //    txt_tenlop_thao.Text = dataGridView1.Rows[dongchon].Cells["tenlop"].Value.ToString();
            //    txt_khoahoc_thao.Text = dataGridView1.Rows[dongchon].Cells["khoahoc"].Value.ToString();
            //    txt_hedaotao_thao.Text = dataGridView1.Rows[dongchon].Cells["hedaotao"].Value.ToString();
            //    txt_namnhaphoc_thao.Text = dataGridView1.Rows[dongchon].Cells["namnhaphoc"].Value.ToString();
            //    cb_id_khoa_thao.Text = dataGridView1.Rows[dongchon].Cells["id_khoa"].Value.ToString();
            //}
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            new capnhatlophoc(null).ShowDialog();
            loadex();
        }
        private void btxoa_Click(object sender, EventArgs e)
        {
            int dongchon = dataGridView1.CurrentRow.Index;
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM tbl_lophoc WHERE id_lophoc = @id_lophoc", con);
            cmd.Parameters.AddWithValue("@id_lophoc",dataGridView1.Rows[dongchon].Cells["id_lophoc"].Value.ToString());
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
            loadex();
        }

        private void txt_timkiem_thao_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btsua_Click_1(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentRow.Index;
            if (dongchon >= 0)
            {
                new capnhatlophoc(dataGridView1.Rows[dongchon].Cells["id_lophoc"].Value.ToString()).ShowDialog();
                loadex();
            }
            else
            {
                MessageBox.Show("Chọn mã lớp học cần sửa trong bảng!");
            }
        }

        private void excel_Click(object sender, EventArgs e)
        {

        }

        private void bttk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_timkiem_thao.Text))
            {
                MessageBox.Show("Vui lòng điền thông tin tìm kiếm");
                loadex();
                return;
            }
            SqlCommand cmd = new SqlCommand("SELECT tbl_lophoc.*, tbl_khoa.tenkhoa " +
                                            "FROM tbl_lophoc " +
                                            "INNER JOIN tbl_khoa ON tbl_lophoc.id_khoa = tbl_khoa.id_khoa " +
                                            "where tenlop like N'%" + txt_timkiem_thao.Text + "%' or id_lophoc like N'%" + txt_timkiem_thao.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
