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
    public partial class capnhatlophoc : Form
    {
        SqlConnection con;
        string id_lophoc = "";
        public capnhatlophoc(string id_lophoc)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            this.id_lophoc = id_lophoc;
        }
        private void loadex()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT tbl_khoa.tenkhoa, tbl_khoa.id_khoa  from tbl_khoa ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_id_khoa.DataSource = dt;
            cb_id_khoa.DisplayMember = "tenkhoa";
            cb_id_khoa.ValueMember = "id_khoa";
        }
        private void capnhatlophoc_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (string.IsNullOrEmpty(id_lophoc))
            {
                this.Text = "Thêm mới lớp học";
                loadex();
            }
            else
            {
                this.Text = "Cập nhật lớp học";
                loadex();
                SqlCommand cmd = new SqlCommand("SELECT tbl_lophoc.*, tbl_khoa.tenkhoa FROM tbl_lophoc INNER JOIN tbl_khoa ON tbl_lophoc.id_khoa = tbl_khoa.id_khoa where tbl_lophoc.id_lophoc = '" + id_lophoc + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txt_tenlop.Text = dt.Rows[0][1].ToString();
                txt_khoahoc.Text = dt.Rows[0][2].ToString();
                txt_hedaotao.Text = dt.Rows[0][3].ToString();
                string yearString = dt.Rows[0][4].ToString();
                int year;

                if (int.TryParse(yearString, out year))
                {
                    DateTime dateTimeValue = new DateTime(year, 1, 1);
                    dateTimePicker1.Value = dateTimeValue;
                }
                else
                {
                    MessageBox.Show("Không thể chuyển đổi thành DateTime.");
                }
                cb_id_khoa.Text = dt.Rows[0][6].ToString();
            }
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }
        bool kiemtra_dulieu()
        {
            int n;

            if (kiemtra(txt_hedaotao.Text)
                || kiemtra(txt_khoahoc.Text)
                || kiemtra(txt_tenlop.Text)
                || kiemtra(cb_id_khoa.Text))
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

            if (string.IsNullOrEmpty(id_lophoc))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO dbo.tbl_lophoc (tenlop, khoahoc, hedaotao, namnhaphoc, id_khoa)" +
                    "VALUES(@tenlop, @khoahoc,@hedaotao,@namnhaphoc,@id_khoa)", con);
                cmd.Parameters.AddWithValue("@tenlop", txt_tenlop.Text);
                cmd.Parameters.AddWithValue("@khoahoc", txt_khoahoc.Text);
                cmd.Parameters.AddWithValue("@hedaotao", txt_hedaotao.Text);
                cmd.Parameters.AddWithValue("@namnhaphoc", dateTimePicker1.Value.Year);
                cmd.Parameters.AddWithValue("@id_khoa", cb_id_khoa.SelectedValue.ToString());
                if (cmd.ExecuteNonQuery() > 0) {
                    MessageBox.Show("Thêm thành công");
                    //frm_QuanLyLopHoc f = new frm_QuanLyLopHoc("0");
                    //this.Hide();
                    //f.ShowDialog();
                    this.Close();
                } 
                else MessageBox.Show("Thêm thất bại");
            }
            else
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbl_lophoc SET tenlop = @tenlop,khoahoc = @khoahoc, " +
                    "hedaotao = @hedaotao,namnhaphoc = @namnhaphoc,id_khoa = @id_khoa " +
                    "WHERE id_lophoc = '"+id_lophoc+"' ", con);
                cmd.Parameters.AddWithValue("@tenlop", txt_tenlop.Text);
                cmd.Parameters.AddWithValue("@khoahoc", txt_khoahoc.Text);
                cmd.Parameters.AddWithValue("@hedaotao", txt_hedaotao.Text);
                cmd.Parameters.AddWithValue("@namnhaphoc", dateTimePicker1.Value.Year);
                cmd.Parameters.AddWithValue("@id_khoa", cb_id_khoa.SelectedValue.ToString());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    //frm_QuanLyLopHoc f = new frm_QuanLyLopHoc("0");
                    //this.Hide();
                    //f.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Sửa thất bại");
            }
        }

        private void btquaylai_Click(object sender, EventArgs e)
        {
            //frm_QuanLyLopHoc f = new frm_QuanLyLopHoc("0");
            //this.Hide();
            //f.ShowDialog();
            this.Close();
        }
    }
}
