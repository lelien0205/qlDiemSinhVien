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
    public partial class capnhatsinhvien : Form
    {
        SqlConnection con;
        string id_sv = "";
        public capnhatsinhvien(string id_sv)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            this.id_sv = id_sv;
        }
        private void cb_lop_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (string.IsNullOrEmpty(id_sv))
            {
                this.Text = "Thêm mới lớp học";
                loadex();
            }
            else
            {
                this.Text = "Cập nhật lớp học";
                loadex();
                txttendangnhap.Enabled = true;
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_sinhvien where id_sv = '" + id_sv + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txthodem.Text = dt.Rows[0][1].ToString();
                txtten.Text = dt.Rows[0][2].ToString();
                object ngaySinhObject = dt.Rows[0][3];
                DateTime ngaySinh;

                if (ngaySinhObject != DBNull.Value)
                {
                    ngaySinh = DateTime.Parse(ngaySinhObject.ToString());
                    dateTimePicker1.Value = ngaySinh;
                }
                object gioiTinhObject = dt.Rows[0][4];
                bool gioiTinh;

                if (gioiTinhObject != DBNull.Value)
                {
                    gioiTinh = Convert.ToBoolean(gioiTinhObject);
                    if (gioiTinh == true)
                    {
                        rbnu.Checked = true;
                    }
                    else rbnam.Checked = true;
                }

                txtquequan.Text = dt.Rows[0][5].ToString();
                txtsdt.Text = dt.Rows[0][6].ToString();
                object maLopObject = dt.Rows[0][7];
                string maLop = maLopObject != DBNull.Value ? maLopObject.ToString() : "";
                // nếu maLopObject không phải là DBNull.Value, biến maLop sẽ nhận giá trị của maLopObject dưới dạng chuỗi và ngược lại
                cb_lop.SelectedValue = maLop;
                txttendangnhap.Text = dt.Rows[0][8].ToString();
            }
        }
        private void loadex()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT tbl_lophoc.tenlop, tbl_lophoc.id_lophoc  from tbl_lophoc ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_lop.DataSource = dt;
            cb_lop.DisplayMember = "tenlop";
            cb_lop.ValueMember = "id_lophoc";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btquaylai_Click(object sender, EventArgs e)
        {
            
        }
        private void them_user()
        {
            SqlCommand cmd = new SqlCommand(
                    "INSERT INTO tbl_nguoidung  (tendangnhap , matkhau, loainguoidung) " +
                    "VALUES ( @tendangnhap , @matkhau,  @quyen)", con);
            cmd.Parameters.AddWithValue("@tendangnhap", txttendangnhap.Text);
            cmd.Parameters.AddWithValue("@matkhau", "123");
            cmd.Parameters.AddWithValue("@quyen", "3");
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm tên đăng nhập thành công");
            }
            else MessageBox.Show("Thêm tên đăng nhập không thành công");
        }

        private void txttendangnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtquequan_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbnu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbnam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txthodem_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void btquaylai_Click_1(object sender, EventArgs e)
        {
            //frm_QuanLySinhVien f = new frm_QuanLySinhVien("0",0);
            //this.Hide();
            //f.ShowDialog();
            this.Close();
        }

        private void txthodem_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

            if (kiemtra(txttendangnhap.Text)
                || kiemtra(txthodem.Text)
                || kiemtra(txtten.Text)
                || kiemtra(txtsdt.Text)
                || kiemtra(txtquequan.Text)
                || kiemtra(cb_lop.Text))
            {
                return false;
            }
            if (!int.TryParse(txtsdt.Text, out n) || n < 0)
                return false;
            return true;
        }
        private void btluu_Click(object sender, EventArgs e)
        {
            if (!kiemtra_dulieu())
            {
                MessageBox.Show("Dữ liệu nhập chưa đúng");
                return;
            }
            if (string.IsNullOrEmpty(id_sv))
            {
                SqlCommand cmdCheckExist = new SqlCommand("SELECT COUNT(*) FROM tbl_nguoidung WHERE tendangnhap = @tendangnhap ", con);
                cmdCheckExist.Parameters.AddWithValue("@tendangnhap", txttendangnhap.Text);
                int count = (int)cmdCheckExist.ExecuteScalar();
                if (count == 0)
                {
                    SqlCommand _cmd = new SqlCommand(
                        "INSERT INTO tbl_nguoidung  (tendangnhap , matkhau, loainguoidung) " +
                        "VALUES ( @tendangnhap , @matkhau,  @quyen)", con);
                    _cmd.Parameters.AddWithValue("@tendangnhap", txttendangnhap.Text);
                    _cmd.Parameters.AddWithValue("@matkhau", "123");
                    _cmd.Parameters.AddWithValue("@quyen", "3");
                    if (_cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm tên đăng nhập thành công");
                    }
                    else MessageBox.Show("Thêm tên đăng nhập không thành công");
                    SqlCommand cmd = new SqlCommand(
                    "INSERT INTO dbo.tbl_sinhvien (hodem, ten, ngaysinh, gioitinh, quequan, sdt, id_lophoc, tendangnhap)" +
                    "VALUES(@hodem, @ten, @ngaysinh, @gioitinh, @quequan, @sdt, @id_lophoc, @tendangnhap)", con);
                    bool gioiTinh = false;
                    if (rbnu.Checked == true)
                    {
                        gioiTinh = true;
                    }
                    if (rbnam.Checked == true)
                    {
                        gioiTinh = false;
                    }
                    cmd.Parameters.AddWithValue("@hodem", txthodem.Text);
                    cmd.Parameters.AddWithValue("@ten", txtten.Text);
                    cmd.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@gioitinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@quequan", txtquequan.Text);
                    cmd.Parameters.AddWithValue("@sdt", int.Parse(txtsdt.Text));
                    cmd.Parameters.AddWithValue("@id_lophoc", cb_lop.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@tendangnhap", txttendangnhap.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        //frm_QuanLySinhVien f = new frm_QuanLySinhVien("0",0);
                        //this.Hide();
                        //f.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE tbl_sinhvien SET hodem = @hodem, ten = @ten, ngaysinh = @ngaysinh , gioitinh = @gioitinh" +
                    ", quequan = @quequan, sdt = @sdt, id_lophoc = @id_lophoc, tendangnhap = @tendangnhap " +
                    "WHERE id_sv = '" + id_sv + "' ", con);
                bool gioiTinh = false;
                if (rbnu.Checked == true)
                {
                    gioiTinh = true;
                }
                if (rbnam.Checked == true)
                {
                    gioiTinh = false;
                }
                cmd.Parameters.AddWithValue("@hodem", txthodem.Text);
                cmd.Parameters.AddWithValue("@ten", txtten.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@gioitinh", gioiTinh);
                cmd.Parameters.AddWithValue("@quequan", txtquequan.Text);
                cmd.Parameters.AddWithValue("@sdt", txtsdt.Text);
                cmd.Parameters.AddWithValue("@id_lophoc", cb_lop.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@tendangnhap", txttendangnhap.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    //frm_QuanLySinhVien f = new frm_QuanLySinhVien("0",0);
                    //this.Hide();
                    //f.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Sửa thất bại");
            }
        }
    }
}
