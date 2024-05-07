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
    public partial class frm_QuanLyDiem : Form
    {
        SqlConnection con;
        string quyen = "";
        int i = 0;
        public frm_QuanLyDiem(string quyen, int i)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
            this.i = i;
            this.quyen = quyen;
        }

        private void frm_QuanLyDiem_Thao_Load(object sender, EventArgs e)
        {
            if (i == 1 )
            {
                grchucnang.Visible = false;
                btexcel.Visible = true;
                xuatdiem.Visible = false;
            }
            else if(i == 2)
            {
                grchucnang.Visible = false;
                btexcel.Visible = false;
                xuatdiem.Visible = true;
            }
            else
            {
                grchucnang.Visible = true;
                btexcel.Visible = false;
                xuatdiem.Visible = false;
            }
            if(quyen == "3" )
            {
                grchucnang.Visible = false;
            }
            if (con.State == ConnectionState.Closed)
                con.Open();
            loadex();
            loadlop();
            loadmon();
            //loadsv();
            cb_lop.SelectedIndexChanged += cb_lop_SelectedIndexChanged;
        }
        private void loadex()
        {
            SqlCommand cmd = new SqlCommand("select DISTINCT " +
                "tbl_diem.id_diem, " +
                "tbl_diem.id_sv, tbl_sinhvien.hodem, tbl_sinhvien.ten," +
                "tbl_lophoc.tenlop, tbl_monhoc.tenmonhoc,tbl_monhoc.sotinchi, tbl_diem.diemchuyencan," +
                "tbl_diem.diemheso1, tbl_diem.diemheso2_t1, tbl_diem.diemheso2_t2," +
                "tbl_diem.diemquatrinh, tbl_diem.diemthi, tbl_diem.diemhocphan " +
                "from tbl_diem " +
                "inner join tbl_sinhvien on tbl_sinhvien.id_sv = tbl_diem.id_sv " +
                "inner join tbl_monhoc on tbl_monhoc.id_monhoc = tbl_diem.id_monhoc " +
                "inner join tbl_lophoc on tbl_sinhvien.id_lophoc = tbl_lophoc.id_lophoc ", con);
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
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT tbl_monhoc.tenmonhoc, tbl_monhoc.id_monhoc  from tbl_monhoc ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow newRow = dt.NewRow();
            dt.Rows.InsertAt(newRow, 0);
            cb_mon.DataSource = dt;
            cb_mon.DisplayMember = "tenmonhoc";
            cb_mon.ValueMember = "id_monhoc";
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            if (cb_lop.Text == "" && cb_mon.Text == "" && txtsv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn lớp và môn học trước.");
                loadex();
                return;
            }
            if (cb_mon.Text != "" && cb_lop.Text == "" && txtsv.Text == "")
            {
                SqlCommand cmd = new SqlCommand("select DISTINCT " +
                    "tbl_diem.id_diem, " +
                    "tbl_diem.id_sv, tbl_sinhvien.hodem, tbl_sinhvien.ten," +
                    "tbl_lophoc.tenlop, tbl_monhoc.tenmonhoc,tbl_monhoc.sotinchi, tbl_diem.diemchuyencan," +
                    "tbl_diem.diemheso1, tbl_diem.diemheso2_t1, tbl_diem.diemheso2_t2," +
                    "tbl_diem.diemquatrinh, tbl_diem.diemthi, tbl_diem.diemhocphan " +
                    "from tbl_diem " +
                    "inner join tbl_sinhvien on tbl_sinhvien.id_sv = tbl_diem.id_sv " +
                    "inner join tbl_monhoc on tbl_monhoc.id_monhoc = tbl_diem.id_monhoc " +
                    "inner join tbl_lophoc on tbl_sinhvien.id_lophoc = tbl_lophoc.id_lophoc " +
                    "where tbl_monhoc.tenmonhoc like N'%" + cb_mon.Text + "%'  ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cb_mon.Text == "" && cb_lop.Text != "" && txtsv.Text == "")
            {
                SqlCommand cmd = new SqlCommand("select DISTINCT " +
                    "tbl_diem.id_diem, " +
                    "tbl_diem.id_sv, tbl_sinhvien.hodem, tbl_sinhvien.ten," +
                    "tbl_lophoc.tenlop, tbl_monhoc.tenmonhoc,tbl_monhoc.sotinchi, tbl_diem.diemchuyencan," +
                    "tbl_diem.diemheso1, tbl_diem.diemheso2_t1, tbl_diem.diemheso2_t2," +
                    "tbl_diem.diemquatrinh, tbl_diem.diemthi, tbl_diem.diemhocphan " +
                    "from tbl_diem " +
                    "inner join tbl_sinhvien on tbl_sinhvien.id_sv = tbl_diem.id_sv " +
                    "inner join tbl_monhoc on tbl_monhoc.id_monhoc = tbl_diem.id_monhoc " +
                    "inner join tbl_lophoc on tbl_sinhvien.id_lophoc = tbl_lophoc.id_lophoc " +
                    "where tbl_lophoc.tenlop like N'%" + cb_lop.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cb_mon.Text == "" && cb_lop.Text == "" && txtsv.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select DISTINCT " +
                    "tbl_diem.id_diem, " +
                    "tbl_diem.id_sv, tbl_sinhvien.hodem, tbl_sinhvien.ten," +
                    "tbl_lophoc.tenlop, tbl_monhoc.tenmonhoc,tbl_monhoc.sotinchi, tbl_diem.diemchuyencan," +
                    "tbl_diem.diemheso1, tbl_diem.diemheso2_t1, tbl_diem.diemheso2_t2," +
                    "tbl_diem.diemquatrinh, tbl_diem.diemthi, tbl_diem.diemhocphan " +
                    "from tbl_diem " +
                    "inner join tbl_sinhvien on tbl_sinhvien.id_sv = tbl_diem.id_sv " +
                    "inner join tbl_monhoc on tbl_monhoc.id_monhoc = tbl_diem.id_monhoc " +
                    "inner join tbl_lophoc on tbl_sinhvien.id_lophoc = tbl_lophoc.id_lophoc " +
                    "where tbl_sinhvien.id_sv like N'%" + txtsv.Text + "%' " +
                    "or tbl_sinhvien.ten like N'%" + txtsv.Text + "%' " +
                    "or tbl_sinhvien.hodem like N'%" + txtsv.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cb_mon.Text != "" && cb_lop.Text != "" && txtsv.Text == "")
            {
                SqlCommand cmd = new SqlCommand("select DISTINCT " +
                    "tbl_diem.id_diem, " +
                    "tbl_diem.id_sv, tbl_sinhvien.hodem, tbl_sinhvien.ten," +
                    "tbl_lophoc.tenlop, tbl_monhoc.tenmonhoc,tbl_monhoc.sotinchi, tbl_diem.diemchuyencan," +
                    "tbl_diem.diemheso1, tbl_diem.diemheso2_t1, tbl_diem.diemheso2_t2," +
                    "tbl_diem.diemquatrinh, tbl_diem.diemthi, tbl_diem.diemhocphan " +
                    "from tbl_diem " +
                    "inner join tbl_sinhvien on tbl_sinhvien.id_sv = tbl_diem.id_sv " +
                    "inner join tbl_monhoc on tbl_monhoc.id_monhoc = tbl_diem.id_monhoc " +
                    "inner join tbl_lophoc on tbl_sinhvien.id_lophoc = tbl_lophoc.id_lophoc " +
                    "where tbl_lophoc.tenlop like N'%" + cb_lop.Text + "%' " +
                    "and tbl_monhoc.tenmonhoc like N'%" + cb_mon.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cb_mon.Text == "" && cb_lop.Text != "" && txtsv.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select DISTINCT " +
                    "tbl_diem.id_diem, " +
                    "tbl_diem.id_sv, tbl_sinhvien.hodem, tbl_sinhvien.ten," +
                    "tbl_lophoc.tenlop, tbl_monhoc.tenmonhoc,tbl_monhoc.sotinchi, tbl_diem.diemchuyencan," +
                    "tbl_diem.diemheso1, tbl_diem.diemheso2_t1, tbl_diem.diemheso2_t2," +
                    "tbl_diem.diemquatrinh, tbl_diem.diemthi, tbl_diem.diemhocphan " +
                    "from tbl_diem " +
                    "inner join tbl_sinhvien on tbl_sinhvien.id_sv = tbl_diem.id_sv " +
                    "inner join tbl_monhoc on tbl_monhoc.id_monhoc = tbl_diem.id_monhoc " +
                    "inner join tbl_lophoc on tbl_sinhvien.id_lophoc = tbl_lophoc.id_lophoc " +
                    "where tbl_lophoc.tenlop like N'%" + cb_lop.Text + "%' " +
                    "and tbl_sinhvien.id_sv like N'%" + txtsv.Text + "%' " +
                    "or tbl_lophoc.tenlop like N'%" + cb_lop.Text + "%' " +
                    "and tbl_sinhvien.ten like N'%" + txtsv.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cb_mon.Text != "" && cb_lop.Text == "" && txtsv.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select DISTINCT " +
                    "tbl_diem.id_diem, " +
                    "tbl_diem.id_sv, tbl_sinhvien.hodem, tbl_sinhvien.ten," +
                    "tbl_lophoc.tenlop, tbl_monhoc.tenmonhoc,tbl_monhoc.sotinchi, tbl_diem.diemchuyencan," +
                    "tbl_diem.diemheso1, tbl_diem.diemheso2_t1, tbl_diem.diemheso2_t2," +
                    "tbl_diem.diemquatrinh, tbl_diem.diemthi, tbl_diem.diemhocphan " +
                    "from tbl_diem " +
                    "inner join tbl_sinhvien on tbl_sinhvien.id_sv = tbl_diem.id_sv " +
                    "inner join tbl_monhoc on tbl_monhoc.id_monhoc = tbl_diem.id_monhoc " +
                    "inner join tbl_lophoc on tbl_sinhvien.id_lophoc = tbl_lophoc.id_lophoc " +
                    "where tbl_monhoc.tenmonhoc like N'%" + cb_mon.Text + "%' " +
                    "and tbl_sinhvien.id_sv like N'%" + txtsv.Text + "%' " +
                    "or tbl_monhoc.tenmonhoc like N'%" + cb_mon.Text + "%' " +
                    "and tbl_sinhvien.ten like N'%" + txtsv.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cb_mon.Text != "" && cb_lop.Text != "" && txtsv.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select DISTINCT " +
                    "tbl_diem.id_diem, " +
                    "tbl_diem.id_sv, tbl_sinhvien.hodem, tbl_sinhvien.ten," +
                    "tbl_lophoc.tenlop, tbl_monhoc.tenmonhoc,tbl_monhoc.sotinchi, tbl_diem.diemchuyencan," +
                    "tbl_diem.diemheso1, tbl_diem.diemheso2_t1, tbl_diem.diemheso2_t2," +
                    "tbl_diem.diemquatrinh, tbl_diem.diemthi, tbl_diem.diemhocphan " +
                    "from tbl_diem " +
                    "inner join tbl_sinhvien on tbl_sinhvien.id_sv = tbl_diem.id_sv " +
                    "inner join tbl_monhoc on tbl_monhoc.id_monhoc = tbl_diem.id_monhoc " +
                    "inner join tbl_lophoc on tbl_sinhvien.id_lophoc = tbl_lophoc.id_lophoc " +
                    "where tbl_monhoc.tenmonhoc like N'%" + cb_mon.Text + "%' " +
                    "and tbl_sinhvien.id_sv like N'%" + txtsv.Text + "%' " +
                    "and tbl_lophoc.tenlop like N'%" + cb_lop.Text + "%'" +
                    "or tbl_monhoc.tenmonhoc like N'%" + cb_mon.Text + "%' " +
                    "and tbl_sinhvien.ten like N'%" + txtsv.Text + "%' " +
                    "and tbl_lophoc.tenlop like N'%" + cb_lop.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentRow.Index;

            if (dongchon >= 0)
            {
                new capnhatdiem(dataGridView1.Rows[dongchon].Cells["id_diem"].Value.ToString(), dataGridView1.Rows[dongchon].Cells["sotinchi"].Value.ToString()).ShowDialog();
                loadex();
            }
            else
            {
                MessageBox.Show("Chọn mã lớp học cần sửa trong bảng!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_lop.Text == "" || cb_mon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn lớp và môn học trước.");
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
            Excel.Worksheet exSheet = (Excel.Worksheet)exbook.Worksheets[1];

            exSheet.Range["D2"].Font.Size = 20;
            exSheet.Range["D2"].Font.Bold = true;
            exSheet.Range["D2"].Font.Color = Color.Red;
            exSheet.Range["D2"].Value = "DANH SÁCH ĐIỂM MÔN " + cb_mon.Text + " CỦA LỚP " + cb_lop.Text;

            exSheet.Range["A4:N4"].Font.Size = 11;
            exSheet.Range["A4:N4"].Font.Bold = true;

            exSheet.Range["A4"].Value = "STT";
            exSheet.Range["B4"].Value = "Mã Sinh Viên";
            exSheet.Range["C4"].Value = "Họ đệm";
            exSheet.Range["D4"].Value = "Tên";
            exSheet.Range["E4"].Value = "Tên Lớp";
            exSheet.Range["F4"].Value = "Tên môn";
            exSheet.Range["G4"].Value = "Số TC";
            exSheet.Range["H4"].Value = "Điểm chuyên cần";
            exSheet.Range["I4"].Value = "Điểm hệ số 1";
            exSheet.Range["J4"].Value = "Điểm hệ số 2 (1)";
            exSheet.Range["K4"].Value = "Điểm hệ số 2 (2)";
            exSheet.Range["L4"].Value = "Điểm quá trình";
            exSheet.Range["M4"].Value = "Điểm thi";
            exSheet.Range["N4"].Value = "Điểm học phần";

            int dong = 5;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[1].Value?.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[2].Value?.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[3].Value?.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[4].Value?.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[5].Value?.ToString();
                exSheet.Range["G" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[6].Value?.ToString();
                exSheet.Range["H" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[7].Value?.ToString();
                exSheet.Range["I" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[8].Value?.ToString();
                exSheet.Range["J" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[9].Value?.ToString();
                exSheet.Range["K" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[10].Value?.ToString();
                exSheet.Range["L" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[11].Value?.ToString();
                exSheet.Range["M" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[12].Value?.ToString();
                exSheet.Range["N" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[13].Value?.ToString();
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
            Marshal.ReleaseComObject(exbook);
            exApp.Quit();
            Marshal.ReleaseComObject(exApp);
        }

        private void xuatdiem_Click(object sender, EventArgs e)
        {
            if (txtsv.Text == "")
            {
                MessageBox.Show("Vui lòng mã sinh viên trước.");
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
            Excel.Worksheet exSheet = (Excel.Worksheet)exbook.Worksheets[1];

            exSheet.Range["D2"].Font.Size = 20;
            exSheet.Range["D2"].Font.Bold = true;
            exSheet.Range["D2"].Font.Color = Color.Red;
            exSheet.Range["D2"].Value = "BẢNG ĐIỂM CỦA SINH VIÊN "+dataGridView1.Rows[0].Cells["hodem"].Value.ToString() +" "+ dataGridView1.Rows[0].Cells["ten"].Value.ToString();
;

            exSheet.Range["A4:N4"].Font.Size = 11;
            exSheet.Range["A4:N4"].Font.Bold = true;

            exSheet.Range["A4"].Value = "STT";
            exSheet.Range["B4"].Value = "Mã Sinh Viên";
            exSheet.Range["C4"].Value = "Họ đệm";
            exSheet.Range["D4"].Value = "Tên";
            exSheet.Range["E4"].Value = "Tên Lớp";
            exSheet.Range["F4"].Value = "Tên môn";
            exSheet.Range["G4"].Value = "Số TC";
            exSheet.Range["H4"].Value = "Điểm chuyên cần";
            exSheet.Range["I4"].Value = "Điểm hệ số 1";
            exSheet.Range["J4"].Value = "Điểm hệ số 2 (1)";
            exSheet.Range["K4"].Value = "Điểm hệ số 2 (2)";
            exSheet.Range["L4"].Value = "Điểm quá trình";
            exSheet.Range["M4"].Value = "Điểm thi";
            exSheet.Range["N4"].Value = "Điểm học phần";


            int dong = 5;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[1].Value?.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[2].Value?.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[3].Value?.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[4].Value?.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[5].Value?.ToString();
                exSheet.Range["G" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[6].Value?.ToString();
                exSheet.Range["H" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[7].Value?.ToString();
                exSheet.Range["I" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[8].Value?.ToString();
                exSheet.Range["J" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[9].Value?.ToString();
                exSheet.Range["K" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[10].Value?.ToString();
                exSheet.Range["L" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[11].Value?.ToString();
                exSheet.Range["M" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[12].Value?.ToString();
                exSheet.Range["N" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[13].Value?.ToString();
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
            Marshal.ReleaseComObject(exbook);
            exApp.Quit();
            Marshal.ReleaseComObject(exApp);
        }

        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_lop.SelectedItem is DataRowView)
            {
                // Ép kiểu giá trị được chọn thành DataRowView
                DataRowView selectedRow = (DataRowView)cb_lop.SelectedItem;

                // Kiểm tra xem giá trị "id_lophoc" có phải là DBNull không
                if (selectedRow["id_lophoc"] != DBNull.Value)
                {
                    // Lấy giá trị id_lophoc từ DataRowView
                    int selectedLopId = Convert.ToInt32(selectedRow["id_lophoc"]);

                    // Tiếp tục xử lý dữ liệu
                    // ...

                    // Tạo câu truy vấn để lấy danh sách môn học của lớp
                    string query = "SELECT DISTINCT tbl_monhoc.tenmonhoc, tbl_monhoc.id_monhoc " +
                                   "FROM tbl_lophocphan " +
                                   "INNER JOIN tbl_monhoc ON tbl_lophocphan.id_monhoc = tbl_monhoc.id_monhoc " +
                                   "WHERE tbl_lophocphan.id_lophoc = @lopId";

                    // Sử dụng tham số để tránh tấn công SQL injection
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@lopId", selectedLopId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Xóa dữ liệu cũ của cb_mon
                        cb_mon.DataSource = null;

                        // Kiểm tra xem DataTable có dữ liệu hay không
                        if (dt.Rows.Count > 0)
                        {
                            DataRow newRow = dt.NewRow();
                            dt.Rows.InsertAt(newRow, 0);

                            // Gán danh sách môn học của lớp vào cb_mon
                            cb_mon.DataSource = dt;
                            cb_mon.DisplayMember = "tenmonhoc";
                            cb_mon.ValueMember = "id_monhoc";
                        }
                    }
                }
                else
                {
                    loadmon();
                    return;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int dongchon = dataGridView1.CurrentRow.Index;
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM tbl_diem WHERE id_diem = @id_diem", con);
            cmd.Parameters.AddWithValue("@id_diem", dataGridView1.Rows[dongchon].Cells["id_diem"].Value.ToString());
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
            loadex();
        }
    }
}
