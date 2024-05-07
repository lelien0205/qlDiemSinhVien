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
    public partial class frm_thongtinsinhvien : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
        string id, hoten, quequan, sdt, lop;
        bool gioitinh;
        DateTime ngaysinh;
        public frm_thongtinsinhvien()
        {
            InitializeComponent();
        }

        private string getLop(string id_lophoc)
        {
            string query = $"SELECT * FROM tbl_lophoc WHERE id_lophoc = '{id_lophoc}'";
            string tenLop = "";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    tenLop = reader["tenlop"].ToString();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return tenLop;
        }

        void load_data()
        {
            string query = $"SELECT * FROM tbl_sinhvien WHERE tendangnhap = '{LoginSession.tendangnhap}'";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = reader["id_sv"].ToString();
                    hoten = reader["hodem"].ToString() + " " + reader["ten"].ToString();
                    ngaysinh = DateTime.Parse(reader["ngaysinh"].ToString());
                    gioitinh = (bool)reader["gioitinh"];
                    quequan = reader["quequan"].ToString();
                    sdt = reader["sdt"].ToString();
                    lop = reader["id_lophoc"].ToString();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            // Gán thông tin vừa đọc từ database cho các textbox
            label_msv.Text += id;
            label_hoten.Text += hoten;
            label_gioitinh.Text += !gioitinh ? "Nam" : "Nữ";
            label_ngaysinh.Text += ngaysinh.ToString("MM-dd-yyyy");
            label_quequan.Text += quequan;
            label_sodienthoai.Text += sdt;
            label_lop.Text += getLop(lop);
        }

        private void frm_thongtinsinhvien_Load(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
