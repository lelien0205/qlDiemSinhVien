using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLySinhVien
{
    public partial class frm_QuanLySinhVien : Form
    {
        SqlConnection con;
        string quyen = "";
        int i = 0;
        public frm_QuanLySinhVien(string quyen, int i)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
            this.quyen = quyen;
            this.i = i;
        }

        private void frm_QuanLySinhVien_Load(object sender, EventArgs e)
        {
            if (i == 1)
            {
                grchucnang.Visible = false;
                excel.Visible = true;
            }
            else
            {
                grchucnang.Visible = true;
                excel.Visible = false;
            }
            
            if(quyen == "1" || quyen == "3")
            {
                grchucnang.Visible = false;
            }
            if (con.State == ConnectionState.Closed)
                con.Open();
            loadex();
            loadlop();
        }
        private void loadex()
        {
            SqlCommand cmd = new SqlCommand("SELECT id_sv, hodem, ten,ngaysinh, quequan, sdt,id_lophoc,tendangnhap, CASE WHEN gioitinh = 0 THEN N'Nam' ELSE N'Nữ' END AS gioitinh FROM tbl_sinhvien", con);
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
        private void btxoa_Click(object sender, EventArgs e)
        {
            int dongchon = dataGridView1.CurrentRow.Index;
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM tbl_sinhvien WHERE id_sv = @id_sv", con);
            cmd.Parameters.AddWithValue("@id_sv", dataGridView1.Rows[dongchon].Cells["id_sv"].Value.ToString());
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
            loadex();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            new capnhatsinhvien(null).ShowDialog();
            loadex();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentRow.Index;
            if (dongchon >= 0)
            {
                new capnhatsinhvien(dataGridView1.Rows[dongchon].Cells["id_sv"].Value.ToString()).ShowDialog();
                loadex();
            }
            else
            {
                MessageBox.Show("Chọn mã lớp học cần sửa trong bảng!");
            }
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string selectedLop = cb_lop.SelectedValue?.ToString(); 

            if (string.IsNullOrEmpty(selectedLop) && string.IsNullOrEmpty(txtsv.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp hoặc mã sinh viên hoặc tên sinh viên trước.");
                loadex();
                return;
            }
            if ( cb_lop.Text != "" && txtsv.Text == "")
            {

                SqlCommand cmd = new SqlCommand("SELECT id_sv, hodem, ten, ngaysinh, quequan, sdt, id_lophoc, tendangnhap, " +
                    "CASE WHEN gioitinh = 0 THEN N'Nam' ELSE N'Nữ' END AS gioitinh " +
                    "FROM tbl_sinhvien " +
                    "WHERE tbl_sinhvien.id_lophoc LIKE @selectedLop", con);
                cmd.Parameters.AddWithValue("@selectedLop", "%" + selectedLop + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            else if(cb_lop.Text == "" && txtsv.Text != "")
            {
                SqlCommand cmd = new SqlCommand("SELECT id_sv, hodem, ten, ngaysinh, quequan, sdt, id_lophoc, tendangnhap, " +
                    "CASE WHEN gioitinh = 0 THEN N'Nam' ELSE N'Nữ' END AS gioitinh " +
                    "FROM tbl_sinhvien " +
                            "WHERE tbl_sinhvien.id_sv LIKE '%" +txtsv.Text+"%' " +
                            "or hodem LIKE  '%"+txtsv.Text+"%' " +
                            "or ten LIKE  '%"+txtsv.Text+"%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cb_lop.Text != "" && txtsv.Text != "")
            {
                SqlCommand cmd = new SqlCommand("SELECT id_sv, hodem, ten, ngaysinh, quequan, sdt, id_lophoc, tendangnhap, " +
                    "CASE WHEN gioitinh = 0 THEN N'Nam' ELSE N'Nữ' END AS gioitinh " +
                    "FROM tbl_sinhvien " +
                            "WHERE tbl_sinhvien.id_sv LIKE '%" + txtsv.Text + "%' and tbl_sinhvien.id_lophoc LIKE @selectedLop " +
                            "or hodem LIKE  '%" + txtsv.Text + "%'  and tbl_sinhvien.id_lophoc LIKE @selectedLop " +
                            "or ten LIKE  '%" + txtsv.Text + "%'  and tbl_sinhvien.id_lophoc LIKE @selectedLop ", con);
                cmd.Parameters.AddWithValue("@selectedLop", "%" + selectedLop + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void excel_Click(object sender, EventArgs e)
        {
            if (cb_lop.Text == "" )
            {
                MessageBox.Show("Vui lòng chọn lớp học trước.");
                loadex();
                return;
            }

            Excel.Application exApp = new Excel.Application();
            if (exApp == null)
            {
                MessageBox.Show("Không thể tạo ứng dụng Excel.");
                return;
            }

            exApp.Visible = false;

            Excel.Workbook exbook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            //Tạo một đối tượng Workbook (exbook) và thêm một Worksheet vào đó bằng cách sử dụng phương thức Add của đối tượng Workbooks trong ứng dụng Excel (exApp).
            Excel.Worksheet exSheet = (Excel.Worksheet)exbook.Worksheets[1];
            //Tạo một đối tượng Worksheet (exSheet) bằng cách lấy ra Worksheet đầu tiên từ Workbook (exbook).

            exSheet.Range["D2"].Font.Size = 20;
            exSheet.Range["D2"].Font.Bold = true;
            exSheet.Range["D2"].Font.Color = Color.Red;
            exSheet.Range["D2"].Value = "DANH SÁCH SINH VIÊN LỚP " + cb_lop.Text;

            exSheet.Range["A4:H4"].Font.Size = 11;
            exSheet.Range["A4:H4"].Font.Bold = true;

            exSheet.Range["A4"].Value = "STT";
            exSheet.Range["B4"].Value = "Mã Sinh Viên";
            exSheet.Range["C4"].Value = "Họ đệm";
            exSheet.Range["D4"].Value = "Tên";
            exSheet.Range["E4"].Value = "Ngày Sinh";
            exSheet.Range["F4"].Value = "Giới Tính";
            exSheet.Range["G4"].Value = "Quê Quán";
            exSheet.Range["H4"].Value = "Số Điện Thoại";

            int dong = 5;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                // xử lý dữ liệu từ dataGridView1 và ghi vào exSheet
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[0].Value?.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[1].Value?.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[2].Value?.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[3].Value?.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[8].Value?.ToString();
                exSheet.Range["G" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[4].Value?.ToString();
                exSheet.Range["H" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[5].Value?.ToString();
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Workbook|*.xlsx|All Files|*.*";
            save.FilterIndex = 1;
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    exbook.SaveAs(save.FileName);
                    MessageBox.Show("Báo cáo đã được lưu thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu tệp Excel: " + ex.Message);
                }
            }

            exbook.Close(false);
            Marshal.ReleaseComObject(exbook); // Giải phóng tài nguyên COM của Workbook.
            exApp.Quit();
            Marshal.ReleaseComObject(exApp);
        }

        private void txtsv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
