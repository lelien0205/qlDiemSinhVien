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
    public partial class capnhatkhoa : Form
    {
        SqlConnection con;
        string id_khoa = "";
        public capnhatkhoa(string id_khoa)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            this.id_khoa = id_khoa;
        }

        private void capnhatkhoa_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (string.IsNullOrEmpty(id_khoa))
            {
                this.Text = "Thêm mới khoa";
            }
            else
            {
                this.Text = "Cập nhật khoa";
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_khoa where id_khoa = '" + id_khoa + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txt_tenkhoa.Text = dt.Rows[0][1].ToString();
            }
        }

        private void btquaylai_Click(object sender, EventArgs e)
        {
            //frm_QuanLyKhoa f = new frm_QuanLyKhoa("0");
            //this.Hide();
            //f.ShowDialog();
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

            if (kiemtra(txt_tenkhoa.Text))
            {
                return false;
            }

            return true;
        }

        private void btghilai_Click(object sender, EventArgs e)
        {
            if (!kiemtra_dulieu())
            {
                MessageBox.Show("Dữ liệu nhập chưa đúng");
                return;
            }
            if (string.IsNullOrEmpty(id_khoa))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO dbo.tbl_khoa (tenkhoa)" +
                    "VALUES( @tenkhoa)", con);
                cmd.Parameters.AddWithValue("@tenkhoa", txt_tenkhoa.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    //frm_QuanLyKhoa f = new frm_QuanLyKhoa("0");
                    //this.Hide();
                    //f.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Thêm thất bại");
            }
            else
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbl_khoa SET tenkhoa = @tenkhoa where id_khoa = '" + id_khoa + "'", con);
                cmd.Parameters.AddWithValue("@tenkhoa", txt_tenkhoa.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    //frm_QuanLyKhoa f = new frm_QuanLyKhoa("0");
                    //this.Hide();
                    //f.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Sửa thất bại");
            }
        }
    }
}
