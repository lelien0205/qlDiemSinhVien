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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLySinhVien
{
    public partial class frm_QuanLyLopHocPhan : Form
    {
        SqlConnection con;
        string quyen = "";
        public frm_QuanLyLopHocPhan(string quyen)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
            this.quyen = quyen;
        }

        private void frm_QuanLyLopHocPhan_Load(object sender, EventArgs e)
        {
            if(quyen == "1" || quyen == "3")
            {
                grchucnang.Visible = false;
            }
            if (con.State == ConnectionState.Closed)
                con.Open();
            loadex();
            loadlop();
            loadmon();
            cb_lop.SelectedIndexChanged += cb_lop_SelectedIndexChanged;
        }
        private void loadex()
        {
            SqlCommand cmd = new SqlCommand("SELECT tbl_lophocphan.id_lophocphan, tbl_lophoc.tenlop, tbl_monhoc.tenmonhoc, tbl_giaovien.hoten_gv, tbl_lophocphan.hocky,tbl_lophocphan.nam FROM tbl_lophocphan " +
                "INNER JOIN tbl_monhoc ON tbl_monhoc.id_monhoc = tbl_lophocphan.id_monhoc " +
                "inner join tbl_giaovien on tbl_giaovien.id_gv = tbl_lophocphan.id_gv " +
                "inner join tbl_lophoc on tbl_lophoc.id_lophoc = tbl_lophocphan.id_lophoc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void loadlop()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT tbl_lophoc.tenlop, tbl_lophoc.id_lophoc  from tbl_lophoc ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow newRow = dt.NewRow();
            dt.Rows.InsertAt(newRow, 0);
            cb_lop.DataSource = dt;
            cb_lop.DisplayMember = "tenlop";
            cb_lop.ValueMember = "id_lophoc";
        }
        private void loadmon()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT tbl_monhoc.tenmonhoc, tbl_monhoc.id_monhoc  from tbl_monhoc ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow newRow = dt.NewRow();
            dt.Rows.InsertAt(newRow, 0);
            cb_mon.DataSource = dt;
            cb_mon.DisplayMember = "tenmonhoc";
            cb_mon.ValueMember = "id_monhoc";
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            int dongchon = dataGridView1.CurrentRow.Index;
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM tbl_lophocphan WHERE id_lophocphan = @id_lophocphan", con);
            cmd.Parameters.AddWithValue("@id_lophocphan", dataGridView1.Rows[dongchon].Cells["id_lophocphan"].Value.ToString());
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
            loadex();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttk_Click(object sender, EventArgs e)
        {
            if(cb_mon.Text == "" && cb_lop.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần tìm");
                loadex();
                return;
            }
            if (cb_mon.Text != "" && cb_lop.Text == "")
            {
                SqlCommand cmd = new SqlCommand("SELECT tbl_lophocphan.id_lophocphan, " +
                    "tbl_lophoc.tenlop, tbl_monhoc.tenmonhoc, tbl_giaovien.hoten_gv, " +
                    "tbl_lophocphan.hocky,tbl_lophocphan.nam " +
                    "FROM tbl_lophocphan " +
                    "INNER JOIN tbl_monhoc ON tbl_monhoc.id_monhoc = tbl_lophocphan.id_monhoc " +
                    "inner join tbl_giaovien on tbl_giaovien.id_gv = tbl_lophocphan.id_gv " +
                    "inner join tbl_lophoc on tbl_lophoc.id_lophoc = tbl_lophocphan.id_lophoc " +
                    "where tbl_monhoc.tenmonhoc like N'%" + cb_mon.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(cb_mon.Text == "" && cb_lop.Text != "")
            {
                SqlCommand cmd = new SqlCommand("SELECT tbl_lophocphan.id_lophocphan, " +
                    "tbl_lophoc.tenlop, tbl_monhoc.tenmonhoc, tbl_giaovien.hoten_gv, " +
                    "tbl_lophocphan.hocky,tbl_lophocphan.nam " +
                    "FROM tbl_lophocphan " +
                    "INNER JOIN tbl_monhoc ON tbl_monhoc.id_monhoc = tbl_lophocphan.id_monhoc " +
                    "inner join tbl_giaovien on tbl_giaovien.id_gv = tbl_lophocphan.id_gv " +
                    "inner join tbl_lophoc on tbl_lophoc.id_lophoc = tbl_lophocphan.id_lophoc " +
                    "where tbl_lophoc.tenlop like N'%" + cb_lop.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(cb_mon.Text != "" && cb_lop.Text != "")
            {
                SqlCommand cmd = new SqlCommand("SELECT tbl_lophocphan.id_lophocphan, " +
                    "tbl_lophoc.tenlop, tbl_monhoc.tenmonhoc, tbl_giaovien.hoten_gv, " +
                    "tbl_lophocphan.hocky,tbl_lophocphan.nam " +
                    "FROM tbl_lophocphan " +
                    "INNER JOIN tbl_monhoc ON tbl_monhoc.id_monhoc = tbl_lophocphan.id_monhoc " +
                    "inner join tbl_giaovien on tbl_giaovien.id_gv = tbl_lophocphan.id_gv " +
                    "inner join tbl_lophoc on tbl_lophoc.id_lophoc = tbl_lophocphan.id_lophoc " +
                    "where tbl_lophoc.tenlop like N'%" + cb_lop.Text + "%' " +
                    "and tbl_monhoc.tenmonhoc like N'%" + cb_mon.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentRow.Index;
            if (dongchon >= 0)
            {
                new capnhatlophocphan(dataGridView1.Rows[dongchon].Cells["id_lophocphan"].Value.ToString()).ShowDialog();
                loadex();
            }
            else
            {
                MessageBox.Show("Chọn mã lớp học phần cần sửa trong bảng!");
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            new capnhatlophocphan(null).ShowDialog();
            loadex();
        }

        private void frm_QuanLyLopHocPhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_lop.SelectedItem is DataRowView)
            {
                // Ép kiểu giá trị được chọn thành DataRowView
                DataRowView selectedRow = (DataRowView)cb_lop.SelectedItem;

                // Kiểm tra xem giá trị "id_lophoc" có phải là DBNull không
                if (selectedRow["id_lophoc"] != DBNull.Value)
                {
                    // Lấy giá trị id_lophoc từ DataRowView
                    int selectedLopId = Convert.ToInt32(selectedRow["id_lophoc"]);

                    // Tiếp tục xử lý dữ liệu
                    // ...

                    // Tạo câu truy vấn để lấy danh sách môn học của lớp
                    string query = "SELECT DISTINCT tbl_monhoc.tenmonhoc, tbl_monhoc.id_monhoc " +
                                   "FROM tbl_lophocphan " +
                                   "INNER JOIN tbl_monhoc ON tbl_lophocphan.id_monhoc = tbl_monhoc.id_monhoc " +
                                   "WHERE tbl_lophocphan.id_lophoc = @lopId";

                    // Sử dụng tham số để tránh tấn công SQL injection
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@lopId", selectedLopId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Xóa dữ liệu cũ của cb_mon
                        cb_mon.DataSource = null;

                        // Kiểm tra xem DataTable có dữ liệu hay không
                        if (dt.Rows.Count > 0)
                        {
                            DataRow newRow = dt.NewRow();
                            dt.Rows.InsertAt(newRow, 0);

                            // Gán danh sách môn học của lớp vào cb_mon
                            cb_mon.DataSource = dt;
                            cb_mon.DisplayMember = "tenmonhoc";
                            cb_mon.ValueMember = "id_monhoc";
                        }
                    }
                }
                else
                {
                    loadmon();
                    return;
                }
            }
        }
    }
}
