using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPG
{
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }
        // Viết một hàm LoadData riêng để dùng đi dùng lại cho tiện
        private void LoadData()
        {
            using (var db = new KingdomFitnessEntities())
            {
                // 1. Chỉ lấy đúng những thông tin cần hiện lên màn hình
                var bang = db.HoiVien.Select(h => new
                {
                    MaHV = h.MaHV,
                    TenHoiVien = h.TenHV,
                    SDT = h.SoDienThoai,
                    GioiTinh = h.GioiTinh,
                    NgayDangKy = h.NgayDangKy
                }).ToList();

                // 2. Đổ cái danh sách đã chọn lọc này vào bảng
                dgvDanhSach.DataSource = bang;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem mày đã click chọn dòng nào trong bảng chưa?
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Chọn người cần xóa");
                return;
            }

            // 2. Lấy cái Mã Hội Viên (MaHV) của cái dòng mà mày đang bấm chuột vào
            int idCanXoa = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["MaHV"].Value);

            // 3. Hỏi lại một câu cho chắc ăn (Sinh viên làm đồ án CỰC KỲ ĂN ĐIỂM chỗ này)
            DialogResult hoiLai = MessageBox.Show("Bạn có chắc chắn muốn xóa hội viên này không?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            // Nếu bấm Yes thì mới chém
            if (hoiLai == DialogResult.Yes)
            {
                using (var db = new KingdomFitnessEntities())
                {
                    // Tìm thằng đó trong Database
                    var khachCanXoa = db.HoiVien.Find(idCanXoa);

                    if (khachCanXoa != null)
                    {
                        db.HoiVien.Remove(khachCanXoa); // Ra lệnh xóa
                        db.SaveChanges(); // Chốt sổ xuống SQL Server

                        MessageBox.Show("Đã xóa thành công");

                        // Xóa xong thì gọi lại hàm LoadData() để cái bảng tự động load lại, thằng kia sẽ biến mất
                        LoadData();
                    }
                }
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Show();
            this.Hide();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtHVT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadData();
                return;
            }

            using (var db = new KingdomFitnessEntities())
            {
                // BIẾN CĂN BẢN: Tạo một list để chứa kết quả
                IQueryable<HoiVien> query = db.HoiVien;

                // LOGIC ĐỘC QUYỀN:
                // Kiểm tra xem người dùng có đang gõ SỐ hay không
                if (int.TryParse(tuKhoa, out int maTimKiem))
                {
                    // Nếu là số -> Tao tìm ĐÚNG CHÍNH XÁC cái mã đó (Dùng dấu ==)
                    query = query.Where(h => h.MaHV == maTimKiem);
                }
                else
                {
                    // Nếu là chữ -> Tao tìm theo kiểu "Chứa ký tự" (Contains) cho Tên hoặc SĐT
                    string tuKhoaLower = tuKhoa.ToLower();
                    query = query.Where(h => h.TenHV.ToLower().Contains(tuKhoaLower)
                                          || h.SoDienThoai.Contains(tuKhoaLower));
                }

                // Đổ ra GridView
                var ketQua = query.Select(h => new
                {
                    MaHV = h.MaHV,
                    TenHoiVien = h.TenHV,
                    SDT = h.SoDienThoai,
                    GioiTinh = h.GioiTinh,
                    NgayDangKy = h.NgayDangKy
                }).ToList();

                dgvDanhSach.DataSource = ketQua;

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Đéo tìm thấy ai khớp với mã hoặc tên này!", "Thông báo");
                }
            }
        }
    }
}
        
