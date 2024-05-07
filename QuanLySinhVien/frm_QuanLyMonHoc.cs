﻿using System;
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
    public partial class frm_QuanLyMonHoc : Form
    {
        SqlConnection con;
        string quyen = "";
        public frm_QuanLyMonHoc(string quyen)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
            this.quyen = quyen;
        }

        private void frm_QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            if(quyen == "1" || quyen == "3")
            {
                grchucnang.Visible = false;
            }
            if (con.State == ConnectionState.Closed)
                con.Open();
            loadex();
        }
        private void loadex()
        {
            SqlCommand cmd = new SqlCommand("SELECT * from tbl_monhoc ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            int dongchon = dataGridView1.CurrentRow.Index;
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM tbl_monhoc WHERE id_monhoc = @id_monhoc", con);
            cmd.Parameters.AddWithValue("@id_monhoc", dataGridView1.Rows[dongchon].Cells["id_monhoc"].Value.ToString());
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
            loadex();
        }

        private void txt_timkiem_thao_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            new capnhatmonhoc(null).ShowDialog();
            loadex();

        }

        private void btsua_Click(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentRow.Index;
            if (dongchon >= 0)
            {
                new capnhatmonhoc(dataGridView1.Rows[dongchon].Cells["id_monhoc"].Value.ToString()).ShowDialog();
                loadex();
            }
            else
            {
                MessageBox.Show("Chọn mã môn học cần sửa trong bảng!");
            }
        }

        private void bttk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_timkiem.Text))
            {
                MessageBox.Show("Vui lòng điền mã môn hoặc tên môn cần tìm");
                loadex();
                return;
            }  
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_monhoc where tenmonhoc like N'%"
                + txt_timkiem.Text + "%' or id_monhoc like N'%"
                + txt_timkiem.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
