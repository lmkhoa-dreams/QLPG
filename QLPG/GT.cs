using System;
using System.Linq;
using System.Windows.Forms;

namespace QLPG
{
    public partial class GT : Form
    {
        // ❗ KHÔNG khởi tạo ở đây nữa (tránh lỗi Designer)
        KingdomFitnessEntities context;

        public GT()
        {
            InitializeComponent();

            // ✅ Fix lỗi Designer
            try
            {
                context = new KingdomFitnessEntities();
            }
            catch
            {
                // Designer sẽ không crash nữa
            }
        }

        // LOAD DATA
        void LoadData()
        {
            if (context != null)
                dgvGoiTap.DataSource = context.GoiTaps.ToList();
        }

        // FORM LOAD
        private void GT_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // THÊM
        private void bttnThem_Click(object sender, EventArgs e)
        {
            try
            {
                GoiTap gt = new GoiTap()
                {
                    MaGoi = int.Parse(txtMa.Text),
                    TenGoi = txtTenGoi.Text,
                    SoThang = int.Parse(txtSoThang.Text),
                    GiaTien = decimal.Parse(txtGiaTien.Text)
                };

                context.GoiTaps.Add(gt);
                context.SaveChanges();
                LoadData();

                MessageBox.Show("Thêm thành công!");

                // Clear sau khi thêm
                txtMa.Clear();
                txtTenGoi.Clear();
                txtSoThang.Clear();
                txtGiaTien.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // CLICK TABLE
        private void dgvGoiTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMa.Text = dgvGoiTap.Rows[i].Cells["MaGoi"].Value.ToString();
                txtTenGoi.Text = dgvGoiTap.Rows[i].Cells["TenGoi"].Value.ToString();
                txtSoThang.Text = dgvGoiTap.Rows[i].Cells["SoThang"].Value.ToString();
                txtGiaTien.Text = dgvGoiTap.Rows[i].Cells["GiaTien"].Value.ToString();
            }
        }

        // SỬA
        private void bttnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = int.Parse(txtMa.Text);
                var gt = context.GoiTaps.FirstOrDefault(x => x.MaGoi == ma);

                if (gt != null)
                {
                    gt.TenGoi = txtTenGoi.Text;
                    gt.SoThang = int.Parse(txtSoThang.Text);
                    gt.GiaTien = decimal.Parse(txtGiaTien.Text);

                    context.SaveChanges();
                    LoadData();

                    MessageBox.Show("Sửa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // XÓA
        private void bttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = int.Parse(txtMa.Text);
                var gt = context.GoiTaps.FirstOrDefault(x => x.MaGoi == ma);

                if (gt != null)
                {
                    context.GoiTaps.Remove(gt);
                    context.SaveChanges();
                    LoadData();

                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // CLEAR
        private void bttnClear_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTenGoi.Clear();
            txtSoThang.Clear();
            txtGiaTien.Clear();
        }

        // tránh lỗi Designer
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormMain)
                {
                    f.Show();   // hiện lại MainForm cũ
                    break;
                }
            }

            this.Close(); // đóng form GT
        }
    }
}