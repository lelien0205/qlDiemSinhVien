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
    public partial class capnhatdiem : Form
    {
        SqlConnection con;
        string id = "";
        string stc = "";
        public capnhatdiem(string id_diem, string sotinchi)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
            this.id = id_diem;
            this.stc = sotinchi;
        }

        private void capnhatdiem_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            this.Text = "Cập nhật điểm";
            loadex();

        }
        private void loadex()
        {
            SqlCommand cmd = new SqlCommand("select DISTINCT " +
                "tbl_diem.id_diem, " +
                "tbl_diem.id_sv, tbl_sinhvien.hodem, tbl_sinhvien.ten," +
                "tbl_lophoc.tenlop, tbl_monhoc.tenmonhoc, tbl_diem.diemchuyencan," +
                "tbl_diem.diemheso1, tbl_diem.diemheso2_t1, tbl_diem.diemheso2_t2," +
                "tbl_diem.diemthi " +
                "from tbl_diem " +
                "inner join tbl_sinhvien on tbl_sinhvien.id_sv = tbl_diem.id_sv " +
                "inner join tbl_monhoc on tbl_monhoc.id_monhoc = tbl_diem.id_monhoc " +
                "inner join tbl_lophoc on tbl_sinhvien.id_lophoc = tbl_lophoc.id_lophoc " +
                "where tbl_diem.id_diem = '"+id+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void btquaylai_Click(object sender, EventArgs e)
        {
            //frm_QuanLyDiem f = new frm_QuanLyDiem("0", 0);
            //this.Hide();
            //f.ShowDialog();
            this.Close();
        }

        private void btghilai_Click_1(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand(
            //    "UPDATE tbl_diem " +
            //    "SET diemchuyencan = @diemchuyencan, diemheso1 = @diemheso1, " +
            //    "diemheso2_t1 = @diemheso2_t1, diemheso2_t2 = @diemheso2_t2, diemthi = @diemthi," +
            //    "diemquatrinh = @diemquatrinh," +
            //    "diemhocphan = @diemhocphan " +
            //    "WHERE id_diem = @id_diem ", con);

            //int sotc = Convert.ToInt32(stc.ToString());

            //float d1 = Convert.ToSingle(dataGridView1.Rows[0].Cells["diemheso1"].Value.ToString().Replace(",", "."));
            //float d21 = Convert.ToSingle(dataGridView1.Rows[0].Cells["diemheso2_t1"].Value.ToString().Replace(",", "."));
            //float d22 = Convert.ToSingle(dataGridView1.Rows[0].Cells["diemheso2_t2"].Value.ToString().Replace(",", "."));
            //float cc = Convert.ToSingle(dataGridView1.Rows[0].Cells["diemchuyencan"].Value.ToString().Replace(",", "."));
            //double diemquatrinh = Math.Round((cc * sotc + d1 + d21 * 2 + d22 * 2) / (sotc + 5), 2);

            //float dt = Convert.ToSingle(dataGridView1.Rows[0].Cells["diemthi"].Value.ToString().Replace(",", "."));
            //double dhp = Math.Round((diemquatrinh * 0.4 + dt * 0.6), 2);

            //cmd.Parameters.AddWithValue("@diemchuyencan", cc.ToString()); // use original string for storage
            //cmd.Parameters.AddWithValue("@diemheso1", d1.ToString());
            //cmd.Parameters.AddWithValue("@diemheso2_t1", d21.ToString());
            //cmd.Parameters.AddWithValue("@diemheso2_t2", d22.ToString());
            //cmd.Parameters.AddWithValue("@diemthi", dt.ToString());
            //cmd.Parameters.AddWithValue("@diemquatrinh", diemquatrinh);
            //cmd.Parameters.AddWithValue("@diemhocphan", dhp);
            //cmd.Parameters.AddWithValue("@id_diem", id);

            //if (cmd.ExecuteNonQuery() > 0)
            //{
            //    MessageBox.Show("Sửa thành công");
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Sửa thất bại");
            //}

            try
            {

                if (!string.IsNullOrEmpty(dataGridView1.Rows[0].Cells["diemchuyencan"].Value?.ToString()) &&
                    !string.IsNullOrEmpty(dataGridView1.Rows[0].Cells["diemheso1"].Value?.ToString()) &&
                    !string.IsNullOrEmpty(dataGridView1.Rows[0].Cells["diemheso2_t1"].Value?.ToString()) &&
                    !string.IsNullOrEmpty(dataGridView1.Rows[0].Cells["diemheso2_t2"].Value?.ToString()) &&
                    !string.IsNullOrEmpty(dataGridView1.Rows[0].Cells["diemthi"].Value?.ToString()))
                {
                    string diemchuyencanStr = dataGridView1.Rows[0].Cells["diemchuyencan"].Value.ToString().Replace(",", ".");
                    string diemheso1Str = dataGridView1.Rows[0].Cells["diemheso1"].Value.ToString().Replace(",", ".");
                    string diemheso2_t1Str = dataGridView1.Rows[0].Cells["diemheso2_t1"].Value.ToString().Replace(",", ".");
                    string diemheso2_t2Str = dataGridView1.Rows[0].Cells["diemheso2_t2"].Value.ToString().Replace(",", ".");
                    string diemthiStr = dataGridView1.Rows[0].Cells["diemthi"].Value.ToString().Replace(",", ".");

                    float cc, d1, d21, d22, dt;
                    if (float.TryParse(diemchuyencanStr, NumberStyles.Float, CultureInfo.InvariantCulture, out cc) &&
                        float.TryParse(diemheso1Str, NumberStyles.Float, CultureInfo.InvariantCulture, out d1) &&
                        float.TryParse(diemheso2_t1Str, NumberStyles.Float, CultureInfo.InvariantCulture, out d21) &&
                        float.TryParse(diemheso2_t2Str, NumberStyles.Float, CultureInfo.InvariantCulture, out d22) &&
                        float.TryParse(diemthiStr, NumberStyles.Float, CultureInfo.InvariantCulture, out dt))
                    {
                        // Nếu giá trị có thể chuyển đổi thành số, tiếp tục xử lý
                        int sotc = Convert.ToInt32(stc.ToString());
                        double diemquatrinh = (double)Math.Round((sotc * cc + d1 + d21 * 2 + d22 * 2) / (sotc + 5), 2);
                        double dhp = Math.Round((diemquatrinh * 0.4 + dt * 0.6), 2);


                        // Tiếp tục xử lý và lưu vào cơ sở dữ liệu
                        SqlCommand cmd = new SqlCommand(
                            "UPDATE tbl_diem " +
                            "SET diemchuyencan = @diemchuyencan, diemheso1 = @diemheso1, " +
                            "diemheso2_t1 = @diemheso2_t1, diemheso2_t2 = @diemheso2_t2, diemthi = @diemthi," +
                            "diemquatrinh = @diemquatrinh," +
                            "diemhocphan = @diemhocphan " +
                            "WHERE id_diem = @id_diem ", con);

                        cmd.Parameters.AddWithValue("@diemchuyencan", diemchuyencanStr);
                        cmd.Parameters.AddWithValue("@diemheso1", diemheso1Str);
                        cmd.Parameters.AddWithValue("@diemheso2_t1", diemheso2_t1Str);
                        cmd.Parameters.AddWithValue("@diemheso2_t2", diemheso2_t2Str);
                        cmd.Parameters.AddWithValue("@diemthi", diemthiStr);
                        cmd.Parameters.AddWithValue("@diemquatrinh", diemquatrinh);
                        cmd.Parameters.AddWithValue("@diemhocphan", dhp);
                        cmd.Parameters.AddWithValue("@id_diem", id);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Nhập không hợp lệ, vui lòng kiểm tra lại giá trị điểm.");
                        return;
                    }
                }
                MessageBox.Show("Sửa thành công");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại: " + ex.Message);
            }

        }

        private void btquaylai_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
