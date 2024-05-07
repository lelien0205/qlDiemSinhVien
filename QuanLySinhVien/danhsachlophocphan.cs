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
    public partial class danhsachlophocphan : Form
    {
        SqlConnection con;
        string quyen = "";
        public danhsachlophocphan(string quyen)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
            this.quyen = quyen;
        }

        private void danhsachlophocphan_Load(object sender, EventArgs e)
        {
            if(quyen == "3")
            {
                grchucnang.Visible = false;
            }
            if (con.State == ConnectionState.Closed)
                con.Open();
            loadex();
            loadlop();
            loadmon();
        }
        private void loadex()
        {
            SqlCommand cmd = new SqlCommand("SELECT tbl_lophocphan.id_lophoc, " +
                "tbl_lophoc.tenlop,tbl_lophocphan.id_monhoc, tbl_monhoc.tenmonhoc, " +
                "tbl_giaovien.hoten_gv, tbl_lophocphan.hocky,tbl_lophocphan.nam " +
                "FROM tbl_lophocphan " +
                "INNER JOIN tbl_monhoc ON tbl_monhoc.id_monhoc = tbl_lophocphan.id_monhoc " +
                "inner join tbl_giaovien on tbl_giaovien.id_gv = tbl_lophocphan.id_gv " +
                "inner join tbl_lophoc on tbl_lophoc.id_lophoc = tbl_lophocphan.id_lophoc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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

        private void bttk_Click(object sender, EventArgs e)
        {
            if(cb_mon.Text == "" && cb_lop.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần tìm");
                loadex();
                return;
            }
            if (cb_mon.Text != "" && cb_lop.Text == "")
            {
                SqlCommand cmd = new SqlCommand("SELECT tbl_lophocphan.id_lophoc, " +
                "tbl_lophoc.tenlop,tbl_lophocphan.id_monhoc, tbl_monhoc.tenmonhoc, " +
                "tbl_giaovien.hoten_gv, tbl_lophocphan.hocky,tbl_lophocphan.nam " +
                "FROM tbl_lophocphan " +
                "INNER JOIN tbl_monhoc ON tbl_monhoc.id_monhoc = tbl_lophocphan.id_monhoc " +
                "inner join tbl_giaovien on tbl_giaovien.id_gv = tbl_lophocphan.id_gv " +
                "inner join tbl_lophoc on tbl_lophoc.id_lophoc = tbl_lophocphan.id_lophoc " +
                "where tbl_monhoc.tenmonhoc like N'%" + cb_mon.Text + "%' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cb_mon.Text == "" && cb_lop.Text != "")
            {
                SqlCommand cmd = new SqlCommand("SELECT tbl_lophocphan.id_lophoc, " +
                "tbl_lophoc.tenlop,tbl_lophocphan.id_monhoc, tbl_monhoc.tenmonhoc, " +
                "tbl_giaovien.hoten_gv, tbl_lophocphan.hocky,tbl_lophocphan.nam " +
                "FROM tbl_lophocphan " +
                "INNER JOIN tbl_monhoc ON tbl_monhoc.id_monhoc = tbl_lophocphan.id_monhoc " +
                "inner join tbl_giaovien on tbl_giaovien.id_gv = tbl_lophocphan.id_gv " +
                "inner join tbl_lophoc on tbl_lophoc.id_lophoc = tbl_lophocphan.id_lophoc " +
                "where tbl_lophoc.tenlop like N'%" + cb_lop.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cb_mon.Text != "" && cb_lop.Text != "")
            {
                SqlCommand cmd = new SqlCommand("SELECT tbl_lophocphan.id_lophoc, " +
                "tbl_lophoc.tenlop,tbl_lophocphan.id_monhoc, tbl_monhoc.tenmonhoc, " +
                "tbl_giaovien.hoten_gv, tbl_lophocphan.hocky,tbl_lophocphan.nam " +
                "FROM tbl_lophocphan " +
                "INNER JOIN tbl_monhoc ON tbl_monhoc.id_monhoc = tbl_lophocphan.id_monhoc " +
                "inner join tbl_giaovien on tbl_giaovien.id_gv = tbl_lophocphan.id_gv " +
                "inner join tbl_lophoc on tbl_lophoc.id_lophoc = tbl_lophocphan.id_lophoc " +
                "where tbl_monhoc.tenmonhoc like N'%" + cb_mon.Text + "%' " +
                "and tbl_lophoc.tenlop like N'%" + cb_lop.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            
        }

        private void btds_Click(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentRow.Index;
            if (dongchon >= 0)
            {
                //new frm_diemquatrinh(dataGridView1.Rows[dongchon].Cells["id_lophoc"].Value.ToString(), dataGridView1.Rows[dongchon].Cells["id_monhoc"].Value.ToString()).ShowDialog();
                //loadex();
            }
            else
            {
                MessageBox.Show("Chọn mã lớp học để nhập điểm cho sinh viên!");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentRow.Index;
            if (dongchon >= 0)
            {
                //new frm_diemthi(dataGridView1.Rows[dongchon].Cells["id_lophoc"].Value.ToString(), dataGridView1.Rows[dongchon].Cells["id_monhoc"].Value.ToString()).ShowDialog();
                //loadex();
            }
            else
            {
                MessageBox.Show("Chọn mã lớp học để nhập điểm cho sinh viên!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
