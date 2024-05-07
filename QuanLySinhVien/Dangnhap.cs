using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Dangnhap : Form
    {
        SqlConnection con;
        public Dangnhap()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tbl_nguoidung where tendangnhap = N'" + txtdn.Text + "' " +
                "and matkhau = N'" + txtmk.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                menu f = new menu(dt.Rows[0][0].ToString(), dt.Rows[0][2].ToString());
                LoginSession.tendangnhap = txtdn.Text;
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khâu không chính xác!");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình? ", "Thông báo",
                 MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void Dangnhap_FromClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình? ", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
