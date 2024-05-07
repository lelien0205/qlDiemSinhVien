using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frm_diemthi : Form
    {
        SqlConnection con;
        //string idlophoc = "";
        //string idmonhoc = "";
        public frm_diemthi()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
            //this.idlophoc = id_lophoc;
            //this.idmonhoc = id_monhoc;
        }

        private void frm_diemthi_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            loadex();
            loadlop();
            loadmon();
            cb_lop.SelectedIndexChanged += cb_lop_SelectedIndexChanged;
        }
        private void loadex()
        {
            //SqlCommand cmd = new SqlCommand("SELECT " +
            //        "tbl_monhoc.tenmonhoc, tbl_sinhvien.id_sv, tbl_sinhvien.hodem, " +
            //        "tbl_sinhvien.ten, tbl_lophoc.tenlop, tbl_diem.diemquatrinh " +
            //        "from tbl_lophocphan " +
            //        "inner join tbl_lophoc on tbl_lophoc.id_lophoc = tbl_lophocphan.id_lophoc " +
            //        "inner join tbl_sinhvien on tbl_sinhvien.id_lophoc = tbl_lophoc.id_lophoc " +
            //        "inner join tbl_monhoc on tbl_monhoc.id_monhoc = tbl_lophocphan.id_monhoc " +
            //        "INNER JOIN tbl_diem ON tbl_diem.id_sv = tbl_sinhvien.id_sv " +
            //        "where " +
            //        " tbl_sinhvien.id_sv IN " +
            //        "(SELECT id_sv FROM tbl_diem  WHERE  diemthi is null)", con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
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
            //danhsachlophocphan f = new danhsachlophocphan("0");
            //this.Hide();
            //f.ShowDialog();
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

                        if (!string.IsNullOrEmpty(row.Cells["diemthi"].Value?.ToString()))
                        {
                            string diemthiStr = row.Cells["diemthi"].Value.ToString().Replace(",", ".");
                            string diemchuyencanStr = row.Cells["diemquatrinh"].Value.ToString().Replace(",", ".");
                            float dqt ;
                            float dt ;

                            // Sử dụng CultureInfo.InvariantCulture để đảm bảo định dạng số nhất quán
                            if (float.TryParse(diemchuyencanStr, NumberStyles.Float, CultureInfo.InvariantCulture, out dqt) &&
                                float.TryParse(diemthiStr, NumberStyles.Float, CultureInfo.InvariantCulture, out dt))
                            {
                                // Nếu giá trị có thể chuyển đổi thành số, tiếp tục xử lý
                                double dhp = (double)Math.Round((dqt * 0.4 + dt * 0.6), 2);

                                // Tiếp tục xử lý và lưu vào cơ sở dữ liệu
                                SqlCommand cmd = new SqlCommand(
                                 "UPDATE tbl_diem SET " +
                                 "diemthi = @diemthi, diemhocphan = @diemhocphan " +
                                 "WHERE id_sv = @id_sv and id_monhoc = @id_monhoc", con);

                                cmd.Parameters.AddWithValue("@id_sv", id_sv);
                                cmd.Parameters.AddWithValue("@id_monhoc", id_monhoc);
                                cmd.Parameters.AddWithValue("@diemthi", row.Cells["diemthi"].Value.ToString());
                                cmd.Parameters.AddWithValue("@diemhocphan", dhp);
                                cmd.ExecuteNonQuery();
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
                    "tbl_monhoc.tenmonhoc, tbl_sinhvien.id_sv, tbl_sinhvien.hodem, " +
                    "tbl_sinhvien.ten, tbl_lophoc.tenlop, tbl_diem.diemquatrinh " +
                    "from tbl_lophocphan " +
                    "inner join tbl_lophoc on tbl_lophoc.id_lophoc = tbl_lophocphan.id_lophoc " +
                    "inner join tbl_sinhvien on tbl_sinhvien.id_lophoc = tbl_lophoc.id_lophoc " +
                    "inner join tbl_monhoc on tbl_monhoc.id_monhoc = tbl_lophocphan.id_monhoc " +
                    "INNER JOIN tbl_diem ON tbl_diem.id_sv = tbl_sinhvien.id_sv " +
                    "where tbl_monhoc.tenmonhoc like N'%" + cb_mon.Text + "%' " +
                    "and tbl_lophoc.tenlop like N'%" + cb_lop.Text + "%' " +
                    "and tbl_sinhvien.id_sv IN " +
                    "(SELECT id_sv FROM tbl_diem  WHERE id_monhoc = '" + cb_mon.SelectedValue + "' and diemthi is null)", con);
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
    }
}
