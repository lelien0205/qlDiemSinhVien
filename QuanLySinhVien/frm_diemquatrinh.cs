using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frm_diemquatrinh : Form
    {
        SqlConnection con;
        //string idlophoc = "";
        //string idmonhoc = "";
        public frm_diemquatrinh()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
            //this.idlophoc = id_lophoc;
            //this.idmonhoc = id_monhoc;
        }

        private void frm_diemquatrinh_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            loadlop();
            loadmon();
            loadex();
            cb_lop.SelectedIndexChanged += cb_lop_SelectedIndexChanged;

        }
        private void loadex()
        {
            SqlCommand cmd = new SqlCommand("SELECT " +
                    "tbl_monhoc.tenmonhoc,tbl_monhoc.sotinchi, tbl_sinhvien.id_sv, " +
                    "tbl_sinhvien.hodem, tbl_sinhvien.ten, tbl_lophoc.tenlop " +
                    "from tbl_lophocphan " +
                    "inner join tbl_lophoc on tbl_lophoc.id_lophoc = tbl_lophocphan.id_lophoc " +
                    "inner join tbl_sinhvien on tbl_sinhvien.id_lophoc = tbl_lophoc.id_lophoc " +
                    "inner join tbl_monhoc on tbl_monhoc.id_monhoc = tbl_lophocphan.id_monhoc " +
                    "where tbl_monhoc.tenmonhoc like N'%" + cb_mon.Text + "%' " +
                    "and tbl_lophoc.tenlop like N'%" + cb_lop.Text + "%' " +
                    "and tbl_sinhvien.id_sv NOT IN (SELECT id_sv FROM tbl_diem )", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void loadlop()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT tbl_lophoc.tenlop, " +
                "tbl_lophoc.id_lophoc  from tbl_lophoc ", con);
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
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT tbl_monhoc.tenmonhoc, " +
                "tbl_monhoc.id_monhoc  from tbl_monhoc ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow newRow = dt.NewRow();
            dt.Rows.InsertAt(newRow, 0);
            cb_mon.DataSource = dt;
            cb_mon.DisplayMember = "tenmonhoc";
            cb_mon.ValueMember = "id_monhoc";

        }
        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        int id_sv = Convert.ToInt32(row.Cells["id_sv"].Value);
                        int id_monhoc = Convert.ToInt32(cb_mon.SelectedValue);

                        if (!string.IsNullOrEmpty(row.Cells["diemchuyencan"].Value?.ToString()) &&
                            !string.IsNullOrEmpty(row.Cells["diemheso1"].Value?.ToString()) &&
                            !string.IsNullOrEmpty(row.Cells["diemheso2_t1"].Value?.ToString()) &&
                            !string.IsNullOrEmpty(row.Cells["diemheso2_t2"].Value?.ToString()))
                        {
                            string diemchuyencanStr = row.Cells["diemchuyencan"].Value.ToString().Replace(",", ".");
                            string diemheso1Str = row.Cells["diemheso1"].Value.ToString().Replace(",", ".");
                            string diemheso2_t1Str = row.Cells["diemheso2_t1"].Value.ToString().Replace(",", ".");
                            string diemheso2_t2Str = row.Cells["diemheso2_t2"].Value.ToString().Replace(",", ".");

                            float cc, d1, d21, d22;

                            // Sử dụng CultureInfo.InvariantCulture để đảm bảo định dạng số nhất quán
                            if (float.TryParse(diemchuyencanStr, NumberStyles.Float, CultureInfo.InvariantCulture, out cc) &&
                                float.TryParse(diemheso1Str, NumberStyles.Float, CultureInfo.InvariantCulture, out d1) &&
                                float.TryParse(diemheso2_t1Str, NumberStyles.Float, CultureInfo.InvariantCulture, out d21) &&
                                float.TryParse(diemheso2_t2Str, NumberStyles.Float, CultureInfo.InvariantCulture, out d22))
                            {
                                // Nếu giá trị có thể chuyển đổi thành số, tiếp tục xử lý
                                int sotc = Convert.ToInt32(row.Cells["sotinchi"].Value.ToString());
                                double diemquatrinh = (double)Math.Round((sotc * cc + d1 + d21 * 2 + d22 * 2) / (sotc + 5), 2);

                                // Tiếp tục xử lý và lưu vào cơ sở dữ liệu
                                SqlCommand cmdInsert = new SqlCommand(
                                    "INSERT INTO tbl_diem (id_sv, id_monhoc, diemchuyencan, diemheso1, diemheso2_t1, diemheso2_t2,diemquatrinh) " +
                                    "VALUES (@id_sv, @id_monhoc, @diemchuyencan, @diemheso1, @diemheso2_t1, @diemheso2_t2, @diemquatrinh )", con);

                                //MessageBox.Show("sotc" + sotc + " - diemheso1 " + d1 + " - diemheso2_t1 " + d21 + " - diemheso2_t2 " + d22 + " - diemchuyencan " + cc);
                                cmdInsert.Parameters.AddWithValue("@id_sv", id_sv);
                                cmdInsert.Parameters.AddWithValue("@id_monhoc", id_monhoc);
                                cmdInsert.Parameters.AddWithValue("@diemchuyencan", diemchuyencanStr);
                                cmdInsert.Parameters.AddWithValue("@diemheso1", diemheso1Str);
                                cmdInsert.Parameters.AddWithValue("@diemheso2_t1", diemheso2_t1Str);
                                cmdInsert.Parameters.AddWithValue("@diemheso2_t2", diemheso2_t2Str);
                                cmdInsert.Parameters.AddWithValue("@diemquatrinh", diemquatrinh);
                                cmdInsert.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("Nhập không hợp lệ, vui lòng kiểm tra lại giá trị điểm.");
                                return;
                            }
                        }
                    }
                }

                MessageBox.Show("Lưu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại");
            }


        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void bttk_Click(object sender, EventArgs e)
        {
            if (cb_mon.Text == "" && cb_lop.Text == "")
            {
                MessageBox.Show("Vui lòng chọn cả lớp và môn học để tìm");
                loadex();
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT " +
                    "tbl_monhoc.tenmonhoc,tbl_monhoc.sotinchi, tbl_sinhvien.id_sv, " +
                    "tbl_sinhvien.hodem, tbl_sinhvien.ten, tbl_lophoc.tenlop " +
                    "from tbl_lophocphan " +
                    "inner join tbl_lophoc on tbl_lophoc.id_lophoc = tbl_lophocphan.id_lophoc " +
                    "inner join tbl_sinhvien on tbl_sinhvien.id_lophoc = tbl_lophoc.id_lophoc " +
                    "inner join tbl_monhoc on tbl_monhoc.id_monhoc = tbl_lophocphan.id_monhoc " +
                    "where tbl_monhoc.tenmonhoc like N'%" + cb_mon.Text + "%' " +
                    "and tbl_lophoc.tenlop like N'%" + cb_lop.Text + "%' " +
                    "and tbl_sinhvien.id_sv NOT IN (SELECT id_sv FROM tbl_diem  WHERE id_monhoc = '" + cb_mon.SelectedValue + "')", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
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

        private void cb_mon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
