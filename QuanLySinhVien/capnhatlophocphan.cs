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
    public partial class capnhatlophocphan : Form
    {
        SqlConnection con;
        string id_lophocphan = "";
        public capnhatlophocphan()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
        }
        public capnhatlophocphan(string id_lophocphan)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            this.id_lophocphan = id_lophocphan;
        }
        private void loadlop()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT tbl_lophoc.tenlop, tbl_lophoc.id_lophoc  from tbl_lophoc ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
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
            cb_mon.DataSource = dt;
            cb_mon.DisplayMember = "tenmonhoc";
            cb_mon.ValueMember = "id_monhoc";
        }
        private void loadgv()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT tbl_giaovien.hoten_gv, tbl_giaovien.id_gv  from tbl_giaovien ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_gv.DataSource = dt;
            cb_gv.DisplayMember = "hoten_gv";
            cb_gv.ValueMember = "id_gv";
        }
        private void capnhatlophocphan_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (string.IsNullOrEmpty(id_lophocphan))
            {
                this.Text = "Thêm mới lớp học";
                loadgv();
                loadlop();
                loadmon();
            }
            else
            {
                this.Text = "Cập nhật lớp học";
                loadgv();
                loadlop();
                loadmon();
                SqlCommand cmd = new SqlCommand("SELECT tbl_lophocphan.id_lophocphan, tbl_lophoc.tenlop, tbl_monhoc.tenmonhoc, tbl_giaovien.hoten_gv, tbl_lophocphan.hocky,tbl_lophocphan.nam FROM tbl_lophocphan " +
                "INNER JOIN tbl_monhoc ON tbl_monhoc.id_monhoc = tbl_lophocphan.id_monhoc " +
                "inner join tbl_giaovien on tbl_giaovien.id_gv = tbl_lophocphan.id_gv " +
                "inner join tbl_lophoc on tbl_lophoc.id_lophoc = tbl_lophocphan.id_lophoc where tbl_lophocphan.id_lophocphan = '"+id_lophocphan+"'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb_lop.Text = dt.Rows[0][1].ToString();
                cb_mon.Text = dt.Rows[0][2].ToString();
                cb_gv.Text = dt.Rows[0][3].ToString();
                cb_hocky.Text = dt.Rows[0][4].ToString();
                string yearString = dt.Rows[0][5].ToString();
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
            }
        }

        private void btquaylai_Click(object sender, EventArgs e)
        {
            //frm_QuanLyLopHocPhan f = new frm_QuanLyLopHocPhan("0");
            //this.Hide();
            //f.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }
        bool kiemtra_dulieu()
        {

            if (kiemtra(cb_gv.Text)
                || kiemtra(cb_hocky.Text)
                || kiemtra(cb_lop.Text)
                || kiemtra(cb_mon.Text))
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
            if (string.IsNullOrEmpty(id_lophocphan))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO dbo.tbl_lophocphan(id_lophoc, id_monhoc, id_gv, hocky, nam)" +
                    "VALUES(@id_lophoc,@id_monhoc,@id_gv,@hocky,@nam)", con);
                cmd.Parameters.AddWithValue("@id_lophoc", cb_lop.SelectedValue);
                cmd.Parameters.AddWithValue("@id_monhoc", cb_mon.SelectedValue);
                cmd.Parameters.AddWithValue("@id_gv", cb_gv.SelectedValue);
                cmd.Parameters.AddWithValue("@hocky",int.Parse(cb_hocky.Text));
                cmd.Parameters.AddWithValue("@nam",dateTimePicker1.Value.Year);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    //frm_QuanLyLopHocPhan f = new frm_QuanLyLopHocPhan("0");
                    //this.Hide();
                    //f.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Thêm thất bại");
            }
            else
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbl_lophocphan SET id_lophoc = @id_lophoc, id_monhoc = @id_monhoc, id_gv = @id_gv, hocky = @hocky, nam = @nam " +
                    "WHERE id_lophocphan = '" + id_lophocphan + "' ", con);
                cmd.Parameters.AddWithValue("@id_lophoc", cb_lop.SelectedValue);
                cmd.Parameters.AddWithValue("@id_monhoc", cb_mon.SelectedValue);
                cmd.Parameters.AddWithValue("@id_gv", cb_gv.SelectedValue);
                cmd.Parameters.AddWithValue("@hocky", int.Parse(cb_hocky.Text));
                cmd.Parameters.AddWithValue("@nam", dateTimePicker1.Value.Year);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    //frm_QuanLyLopHocPhan f = new frm_QuanLyLopHocPhan("0");
                    //this.Hide();
                    //f.ShowDialog();
                    this.Close();

                }
                else MessageBox.Show("Sửa thất bại");
            }
        }

        private void capnhatlophocphan_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
