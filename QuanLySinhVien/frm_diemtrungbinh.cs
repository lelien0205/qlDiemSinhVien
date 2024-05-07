using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frm_diemtrungbinh : Form
    {
        SqlConnection con;
        public frm_diemtrungbinh()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
            
        }
        private void frm_diemtrungbinh_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            loadex();
        }
        private void loadex()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT " +
                "tbl_sinhvien.id_sv, tbl_sinhvien.hodem, " +
                "tbl_sinhvien.ten, " +
                "(SUM(tbl_diem.diemhocphan * tbl_monhoc.sotinchi)) / (SUM(tbl_monhoc.sotinchi)) as diemtrungbinh " +
                "FROM tbl_diem " +
                "INNER JOIN tbl_monhoc ON tbl_diem.id_monhoc = tbl_monhoc.id_monhoc " +
                "INNER JOIN tbl_sinhvien ON tbl_sinhvien.id_sv = tbl_diem.id_sv " +
                "INNER JOIN tbl_lophoc ON tbl_sinhvien.id_lophoc = tbl_lophoc.id_lophoc " +
                "GROUP BY tbl_sinhvien.id_sv, tbl_sinhvien.hodem, tbl_sinhvien.ten", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {
                double diemTBChungKy = 7.0;
                int soLuongSinhVien = dataGridView1.Rows.Count;
                int soSinhVienDuocHocBong = (int)(soLuongSinhVien * 0.1);

                for (int i = 0; i < soLuongSinhVien; i++)
                {
                    double diemTB = Convert.ToDouble(dataGridView1.Rows[i].Cells["diemtrungbinh"].Value);
                    if (diemTB >= diemTBChungKy)
                    {
                        dataGridView1.Rows[i].Cells["hocbong"].Value = true; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
