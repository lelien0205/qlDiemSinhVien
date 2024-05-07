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
    public partial class capnhatmonhoc : Form
    {
        SqlConnection con;
        string id_monhoc = "";
        public capnhatmonhoc(string id_monhoc)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            this.id_monhoc = id_monhoc;
        }

        private void capnhatmonhoc_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (string.IsNullOrEmpty(id_monhoc))
            {
                this.Text = "Thêm mới môn học";
            }
            else
            {
                this.Text = "Cập nhật môn học";
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_monhoc where id_monhoc = '" + id_monhoc + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txttenmonhoc.Text = dt.Rows[0][1].ToString();
                txtsotin.Text = dt.Rows[0][2].ToString();
            }
        }

        private void btquaylai_Click(object sender, EventArgs e)
        {
            //frm_QuanLyMonHoc f = new frm_QuanLyMonHoc("0");
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
            int n;
            if (kiemtra(txtsotin.Text) || kiemtra(txttenmonhoc.Text))
                return false;
            if (!int.TryParse(txtsotin.Text, out n) || n < 0)
                return false;
            return true;
        }
        private void btghilai_Click(object sender, EventArgs e)
        {

            if (kiemtra_dulieu())
            {
                if (string.IsNullOrEmpty(id_monhoc))
                {
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO dbo.tbl_monhoc (tenmonhoc, sotinchi)" +
                        "VALUES( @tenmonhoc, @sotinchi)", con);
                    cmd.Parameters.AddWithValue("@tenmonhoc", txttenmonhoc.Text);
                    cmd.Parameters.AddWithValue("@sotinchi", txtsotin.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        //frm_QuanLyMonHoc f = new frm_QuanLyMonHoc("0");
                        //this.Hide();
                        //f.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE tbl_monhoc SET tenmonhoc = @tenmonhoc, sotinchi = @sotinchi where id_monhoc = '" + id_monhoc + "'", con);
                    cmd.Parameters.AddWithValue("@tenmonhoc", txttenmonhoc.Text);
                    cmd.Parameters.AddWithValue("@sotinchi", txtsotin.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                        //frm_QuanLyMonHoc f = new frm_QuanLyMonHoc("0");
                        //this.Hide();
                        //f.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("Sửa thất bại");
                }
            }
            else MessageBox.Show("Dữ liệu nhập không đúng");
            
        }
    }
}
