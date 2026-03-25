namespace QLPG
{
    partial class GT
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTenGoi = new System.Windows.Forms.TextBox();
            this.txtSoThang = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnThem = new System.Windows.Forms.Button();
            this.bttnSua = new System.Windows.Forms.Button();
            this.bttonXoa = new System.Windows.Forms.Button();
            this.bttnClear = new System.Windows.Forms.Button();
            this.dgvGoiTap = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoiTap)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMa
            // 
            this.txtMa.ForeColor = System.Drawing.Color.Red;
            this.txtMa.Location = new System.Drawing.Point(151, 31);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 22);
            this.txtMa.TabIndex = 0;
            // 
            // txtTenGoi
            // 
            this.txtTenGoi.Location = new System.Drawing.Point(151, 85);
            this.txtTenGoi.Name = "txtTenGoi";
            this.txtTenGoi.Size = new System.Drawing.Size(100, 22);
            this.txtTenGoi.TabIndex = 1;
            // 
            // txtSoThang
            // 
            this.txtSoThang.Location = new System.Drawing.Point(151, 141);
            this.txtSoThang.Name = "txtSoThang";
            this.txtSoThang.Size = new System.Drawing.Size(100, 22);
            this.txtSoThang.TabIndex = 2;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(151, 198);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(100, 22);
            this.txtGiaTien.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Gói";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(42, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Gói";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(40, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số tháng";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(42, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá tiền";
            // 
            // bttnThem
            // 
            this.bttnThem.Location = new System.Drawing.Point(45, 391);
            this.bttnThem.Name = "bttnThem";
            this.bttnThem.Size = new System.Drawing.Size(75, 23);
            this.bttnThem.TabIndex = 8;
            this.bttnThem.Text = "Thêm";
            this.bttnThem.Click += new System.EventHandler(this.bttnThem_Click);
            // 
            // bttnSua
            // 
            this.bttnSua.Location = new System.Drawing.Point(176, 391);
            this.bttnSua.Name = "bttnSua";
            this.bttnSua.Size = new System.Drawing.Size(75, 23);
            this.bttnSua.TabIndex = 9;
            this.bttnSua.Text = "Sửa";
            this.bttnSua.Click += new System.EventHandler(this.bttnSua_Click);
            // 
            // bttonXoa
            // 
            this.bttonXoa.Location = new System.Drawing.Point(333, 391);
            this.bttonXoa.Name = "bttonXoa";
            this.bttonXoa.Size = new System.Drawing.Size(75, 23);
            this.bttonXoa.TabIndex = 10;
            this.bttonXoa.Text = "Xóa";
            this.bttonXoa.Click += new System.EventHandler(this.bttonXoa_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.Location = new System.Drawing.Point(491, 391);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(75, 23);
            this.bttnClear.TabIndex = 11;
            this.bttnClear.Text = "Clear";
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // dgvGoiTap
            // 
            this.dgvGoiTap.ColumnHeadersHeight = 29;
            this.dgvGoiTap.Location = new System.Drawing.Point(45, 235);
            this.dgvGoiTap.Name = "dgvGoiTap";
            this.dgvGoiTap.RowHeadersWidth = 51;
            this.dgvGoiTap.Size = new System.Drawing.Size(800, 150);
            this.dgvGoiTap.TabIndex = 12;
            this.dgvGoiTap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoiTap_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(649, 391);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GT
            // 
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtTenGoi);
            this.Controls.Add(this.txtSoThang);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttnThem);
            this.Controls.Add(this.bttnSua);
            this.Controls.Add(this.bttonXoa);
            this.Controls.Add(this.bttnClear);
            this.Controls.Add(this.dgvGoiTap);
            this.Name = "GT";
            this.Text = "Quản lý gói tập";
            this.Load += new System.EventHandler(this.GT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoiTap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTenGoi;
        private System.Windows.Forms.TextBox txtSoThang;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label1, label2, label3, label4;
        private System.Windows.Forms.Button bttnThem, bttnSua, bttonXoa, bttnClear;
        private System.Windows.Forms.DataGridView dgvGoiTap;
        private System.Windows.Forms.Button btnBack;
    }
}