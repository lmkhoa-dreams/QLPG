using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLPG
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem thằng nhân viên có gõ thiếu tên khách không
            if (txtHVT.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return; // Dừng lại không chạy tiếp code bên dưới
            }

            // Mở kết nối với Database (KingdomFitnessEntities là tên thằng "thư ký" EF sinh ra, mày gõ King... rồi ấn Tab cho nó tự điền nhé)
            using (var db = new KingdomFitnessEntities())
            {
                // 1. Tạo ra một đối tượng Hội Viên mới trong RAM
                HoiVien khachMoi = new HoiVien();
                khachMoi.TenHV = txtHVT.Text;
                khachMoi.SoDienThoai = txtSDT.Text;
                khachMoi.GioiTinh = cb_GT.Text;
                khachMoi.NgayDangKy = DateTime.Now; // Tự động lấy ngày giờ hiện tại của máy tính

                // 2. Thêm khách này vào bảng HoiViens
                db.HoiVien.Add(khachMoi);

                // 3. Lệnh này cực quan trọng: Lưu thẳng xuống SQL Server
                db.SaveChanges();

                MessageBox.Show("Thêm thành công");

                // Sau khi thêm xong thì xóa trắng các ô đi để nhập người tiếp theo
                txtHVT.Clear();
                txtSDT.Clear();
                cb_GT.SelectedIndex = -1;
                cb_Gtap.SelectedIndex = -1; // Sửa lại đúng tên ComboBox Gói Tập của mày
                cb_PT.SelectedIndex = -1;  // Sửa lại đúng tên ComboBox Thuê PT của mày
            }
        }
        

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Show();
            this.Hide();
        }

        private void txtHVT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
