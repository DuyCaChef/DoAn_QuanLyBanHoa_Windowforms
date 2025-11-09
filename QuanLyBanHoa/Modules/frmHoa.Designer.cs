namespace QuanLyBanHoa.Modules
{
    partial class Hoa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoa));
            groupBox1 = new GroupBox();
            dgDSHoa = new DataGridView();
            btnTim = new Button();
            txtTim = new TextBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            txtGhichu = new TextBox();
            lbGhichu = new Label();
            txtTenHoa = new TextBox();
            txtGia = new TextBox();
            cboSoLuong = new ComboBox();
            txtMaHoa = new TextBox();
            lbSoLuong = new Label();
            lbGia = new Label();
            lbTenHoa = new Label();
            lbMaHoa = new Label();
            lbTen = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnThoat = new Button();
            menuStrip1 = new MenuStrip();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            tsmQuanLy = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            hoaToolStripMenuItem = new ToolStripMenuItem();
            thốngKêBáoCáoToolStripMenuItem = new ToolStripMenuItem();
            hoaToolStripMenuItem1 = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDSHoa).BeginInit();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgDSHoa);
            groupBox1.Controls.Add(btnTim);
            groupBox1.Controls.Add(txtTim);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(693, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(722, 553);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Hoa";
            // 
            // dgDSHoa
            // 
            dgDSHoa.AllowUserToAddRows = false;
            dgDSHoa.AllowUserToResizeColumns = false;
            dataGridViewCellStyle4.BackColor = Color.LightGray;
            dgDSHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgDSHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDSHoa.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgDSHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgDSHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgDSHoa.DefaultCellStyle = dataGridViewCellStyle6;
            dgDSHoa.Location = new Point(23, 84);
            dgDSHoa.Name = "dgDSHoa";
            dgDSHoa.ReadOnly = true;
            dgDSHoa.RowHeadersWidth = 51;
            dgDSHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDSHoa.Size = new Size(673, 453);
            dgDSHoa.TabIndex = 11;
            dgDSHoa.CellContentClick += dgDSHoa_CellContentClick;
            dgDSHoa.SelectionChanged += dgDSHoa_SelectionChanged;
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTim.Location = new Point(591, 32);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(105, 34);
            btnTim.TabIndex = 8;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(147, 32);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(438, 34);
            txtTim.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 40);
            label8.Name = "label8";
            label8.Size = new Size(108, 26);
            label8.TabIndex = 9;
            label8.Text = "Tìm kiếm:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtGhichu);
            groupBox2.Controls.Add(lbGhichu);
            groupBox2.Controls.Add(txtTenHoa);
            groupBox2.Controls.Add(txtGia);
            groupBox2.Controls.Add(cboSoLuong);
            groupBox2.Controls.Add(txtMaHoa);
            groupBox2.Controls.Add(lbSoLuong);
            groupBox2.Controls.Add(lbGia);
            groupBox2.Controls.Add(lbTenHoa);
            groupBox2.Controls.Add(lbMaHoa);
            groupBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(148, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(539, 553);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Hoa";
            // 
            // txtGhichu
            // 
            txtGhichu.Location = new Point(34, 319);
            txtGhichu.Multiline = true;
            txtGhichu.Name = "txtGhichu";
            txtGhichu.Size = new Size(477, 218);
            txtGhichu.TabIndex = 17;
            // 
            // lbGhichu
            // 
            lbGhichu.AutoSize = true;
            lbGhichu.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbGhichu.Location = new Point(30, 280);
            lbGhichu.Name = "lbGhichu";
            lbGhichu.Size = new Size(74, 26);
            lbGhichu.TabIndex = 16;
            lbGhichu.Text = "Mô tả:";
            // 
            // txtTenHoa
            // 
            txtTenHoa.Location = new Point(146, 95);
            txtTenHoa.Name = "txtTenHoa";
            txtTenHoa.Size = new Size(365, 34);
            txtTenHoa.TabIndex = 15;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(146, 140);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(365, 34);
            txtGia.TabIndex = 14;
            // 
            // cboSoLuong
            // 
            cboSoLuong.DropDownHeight = 250;
            cboSoLuong.FormattingEnabled = true;
            cboSoLuong.IntegralHeight = false;
            cboSoLuong.Location = new Point(146, 185);
            cboSoLuong.Name = "cboSoLuong";
            cboSoLuong.Size = new Size(136, 33);
            cboSoLuong.TabIndex = 8;
            cboSoLuong.SelectedIndexChanged += cboSoLuong_SelectedIndexChanged;
            // 
            // txtMaHoa
            // 
            txtMaHoa.Location = new Point(146, 50);
            txtMaHoa.Name = "txtMaHoa";
            txtMaHoa.ReadOnly = true;
            txtMaHoa.Size = new Size(365, 34);
            txtMaHoa.TabIndex = 11;
            // 
            // lbSoLuong
            // 
            lbSoLuong.AutoSize = true;
            lbSoLuong.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSoLuong.Location = new Point(30, 193);
            lbSoLuong.Name = "lbSoLuong";
            lbSoLuong.Size = new Size(102, 26);
            lbSoLuong.TabIndex = 6;
            lbSoLuong.Text = "Số lượng:";
            // 
            // lbGia
            // 
            lbGia.AutoSize = true;
            lbGia.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbGia.Location = new Point(30, 149);
            lbGia.Name = "lbGia";
            lbGia.Size = new Size(90, 26);
            lbGia.TabIndex = 5;
            lbGia.Text = "Giá bán:";
            // 
            // lbTenHoa
            // 
            lbTenHoa.AutoSize = true;
            lbTenHoa.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTenHoa.Location = new Point(30, 101);
            lbTenHoa.Name = "lbTenHoa";
            lbTenHoa.Size = new Size(94, 26);
            lbTenHoa.TabIndex = 4;
            lbTenHoa.Text = "Tên hoa:";
            // 
            // lbMaHoa
            // 
            lbMaHoa.AutoSize = true;
            lbMaHoa.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMaHoa.Location = new Point(30, 53);
            lbMaHoa.Name = "lbMaHoa";
            lbMaHoa.Size = new Size(87, 26);
            lbMaHoa.TabIndex = 3;
            lbMaHoa.Text = "Mã hoa:";
            // 
            // lbTen
            // 
            lbTen.AutoEllipsis = true;
            lbTen.AutoSize = true;
            lbTen.BackColor = SystemColors.Control;
            lbTen.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTen.ForeColor = Color.Fuchsia;
            lbTen.Location = new Point(659, 58);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(259, 38);
            lbTen.TabIndex = 2;
            lbTen.Text = "QUẢN LÝ HOA";
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.ButtonFace;
            btnThem.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Orange;
            btnThem.Location = new Point(364, 720);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(127, 46);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.ButtonFace;
            btnSua.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.Magenta;
            btnSua.Location = new Point(529, 720);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(127, 46);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ButtonFace;
            btnXoa.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(694, 720);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(127, 46);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.ButtonFace;
            btnLuu.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(859, 720);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(127, 46);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ActiveCaptionText;
            btnThoat.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ButtonHighlight;
            btnThoat.Location = new Point(1028, 720);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(127, 46);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SkyBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, tsmQuanLy, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1582, 28);
            menuStrip1.TabIndex = 8;
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(89, 24);
            trangChủToolStripMenuItem.Text = "Trang Chủ";
            // 
            // tsmQuanLy
            // 
            tsmQuanLy.DropDownItems.AddRange(new ToolStripItem[] { kháchHàngToolStripMenuItem, hoaToolStripMenuItem, thốngKêBáoCáoToolStripMenuItem, hoaToolStripMenuItem1 });
            tsmQuanLy.Name = "tsmQuanLy";
            tsmQuanLy.Size = new Size(75, 24);
            tsmQuanLy.Text = "Quản Lý";
            tsmQuanLy.Click += toolStripMenuItem1_Click;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(218, 26);
            kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // hoaToolStripMenuItem
            // 
            hoaToolStripMenuItem.Name = "hoaToolStripMenuItem";
            hoaToolStripMenuItem.Size = new Size(218, 26);
            hoaToolStripMenuItem.Text = "Đơn Hàng";
            hoaToolStripMenuItem.Click += hoaToolStripMenuItem_Click;
            // 
            // thốngKêBáoCáoToolStripMenuItem
            // 
            thốngKêBáoCáoToolStripMenuItem.Name = "thốngKêBáoCáoToolStripMenuItem";
            thốngKêBáoCáoToolStripMenuItem.Size = new Size(218, 26);
            thốngKêBáoCáoToolStripMenuItem.Text = "Thống Kê, Báo Cáo";
            // 
            // hoaToolStripMenuItem1
            // 
            hoaToolStripMenuItem1.Name = "hoaToolStripMenuItem1";
            hoaToolStripMenuItem1.Size = new Size(218, 26);
            hoaToolStripMenuItem1.Text = "Hoa";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(93, 24);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // Hoa
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(btnThoat);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lbTen);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Hoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Hoa";
            Load += frmQuanLiHoa_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgDSHoa).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lbGia;
        private Label lbTenHoa;
        private Label lbMaHoa;
        private Label lbTen;
        private Button btnTim;
        private TextBox txtTim;
        private Label label8;
        private TextBox txtLoaiHoa;
        private TextBox txtMaHoa;
        private Label lbLoaiHoa;
        private Label lbSoLuong;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnThoat;
        private DataGridView dgDSHoa;
        private ComboBox cboSoLuong;
        private TextBox txtTenHoa;
        private TextBox txtGia;
        private TextBox txtGhichu;
        private Label lbGhichu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem tsmQuanLy;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem hoaToolStripMenuItem;
        private ToolStripMenuItem thốngKêBáoCáoToolStripMenuItem;
        private ToolStripMenuItem hoaToolStripMenuItem1;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}
