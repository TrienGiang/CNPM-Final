
namespace FinalPrj_CNPM
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbPhieuNhap = new System.Windows.Forms.ComboBox();
            this.dgvHangnhap = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTenPhieu = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtIdHangHoa = new System.Windows.Forms.TextBox();
            this.txtTenHangHoa = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnUpdateHang = new System.Windows.Forms.Button();
            this.btnAddHang = new System.Windows.Forms.Button();
            this.btnDeleteHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.ID_HangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_phieuNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangnhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPhieuNhap
            // 
            this.cbPhieuNhap.FormattingEnabled = true;
            this.cbPhieuNhap.Location = new System.Drawing.Point(152, 33);
            this.cbPhieuNhap.Name = "cbPhieuNhap";
            this.cbPhieuNhap.Size = new System.Drawing.Size(178, 26);
            this.cbPhieuNhap.TabIndex = 0;
            this.cbPhieuNhap.SelectedIndexChanged += new System.EventHandler(this.cbPhieuNhap_SelectedIndexChanged);
            // 
            // dgvHangnhap
            // 
            this.dgvHangnhap.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvHangnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_HangHoa,
            this.tenHangHoa,
            this.soLuong,
            this.ID_phieuNhapHang,
            this.giaSanPham});
            this.dgvHangnhap.Location = new System.Drawing.Point(15, 157);
            this.dgvHangnhap.Name = "dgvHangnhap";
            this.dgvHangnhap.Size = new System.Drawing.Size(806, 256);
            this.dgvHangnhap.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(152, 70);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(102, 26);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTenPhieu
            // 
            this.txtTenPhieu.Location = new System.Drawing.Point(150, 30);
            this.txtTenPhieu.Name = "txtTenPhieu";
            this.txtTenPhieu.Size = new System.Drawing.Size(218, 26);
            this.txtTenPhieu.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Location = new System.Drawing.Point(61, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Location = new System.Drawing.Point(153, 73);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 39);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Info;
            this.btnDelete.Location = new System.Drawing.Point(245, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 39);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtIdHangHoa
            // 
            this.txtIdHangHoa.Enabled = false;
            this.txtIdHangHoa.Location = new System.Drawing.Point(149, 31);
            this.txtIdHangHoa.Name = "txtIdHangHoa";
            this.txtIdHangHoa.Size = new System.Drawing.Size(166, 26);
            this.txtIdHangHoa.TabIndex = 7;
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.Location = new System.Drawing.Point(149, 64);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Size = new System.Drawing.Size(166, 26);
            this.txtTenHangHoa.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(149, 97);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(166, 26);
            this.txtSoLuong.TabIndex = 9;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(149, 130);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(166, 26);
            this.txtGia.TabIndex = 10;
            // 
            // btnUpdateHang
            // 
            this.btnUpdateHang.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdateHang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateHang.Location = new System.Drawing.Point(435, 508);
            this.btnUpdateHang.Name = "btnUpdateHang";
            this.btnUpdateHang.Size = new System.Drawing.Size(86, 39);
            this.btnUpdateHang.TabIndex = 11;
            this.btnUpdateHang.Text = "Update";
            this.btnUpdateHang.UseVisualStyleBackColor = false;
            this.btnUpdateHang.Click += new System.EventHandler(this.btnUpdateHang_Click);
            // 
            // btnAddHang
            // 
            this.btnAddHang.BackColor = System.Drawing.SystemColors.Info;
            this.btnAddHang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHang.Location = new System.Drawing.Point(435, 463);
            this.btnAddHang.Name = "btnAddHang";
            this.btnAddHang.Size = new System.Drawing.Size(86, 39);
            this.btnAddHang.TabIndex = 12;
            this.btnAddHang.Text = "Add";
            this.btnAddHang.UseVisualStyleBackColor = false;
            this.btnAddHang.Click += new System.EventHandler(this.btnAddHang_Click_1);
            // 
            // btnDeleteHang
            // 
            this.btnDeleteHang.BackColor = System.Drawing.SystemColors.Info;
            this.btnDeleteHang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHang.Location = new System.Drawing.Point(435, 553);
            this.btnDeleteHang.Name = "btnDeleteHang";
            this.btnDeleteHang.Size = new System.Drawing.Size(86, 39);
            this.btnDeleteHang.TabIndex = 13;
            this.btnDeleteHang.Text = "Delete";
            this.btnDeleteHang.UseVisualStyleBackColor = false;
            this.btnDeleteHang.Click += new System.EventHandler(this.btnDeleteHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên Phiếu Nhập";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mã Phiếu Nhập ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tên Phiếu Nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mã Hàng Hóa";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tên Hàng Hóa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Số Lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "Giá Hàng Hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã Phiếu";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(149, 162);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(166, 26);
            this.txtMaPhieu.TabIndex = 26;
            this.txtMaPhieu.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // ID_HangHoa
            // 
            this.ID_HangHoa.DataPropertyName = "ID_HangHoa";
            this.ID_HangHoa.HeaderText = "Mã Hàng Hóa";
            this.ID_HangHoa.Name = "ID_HangHoa";
            this.ID_HangHoa.Width = 150;
            // 
            // tenHangHoa
            // 
            this.tenHangHoa.DataPropertyName = "tenHangHoa";
            this.tenHangHoa.HeaderText = "Tên Hàng Hóa";
            this.tenHangHoa.Name = "tenHangHoa";
            this.tenHangHoa.Width = 200;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.Name = "soLuong";
            this.soLuong.Width = 140;
            // 
            // ID_phieuNhapHang
            // 
            this.ID_phieuNhapHang.DataPropertyName = "ID_phieuNhapHang";
            this.ID_phieuNhapHang.HeaderText = "Mã Phiếu Nhập";
            this.ID_phieuNhapHang.Name = "ID_phieuNhapHang";
            this.ID_phieuNhapHang.Width = 150;
            // 
            // giaSanPham
            // 
            this.giaSanPham.DataPropertyName = "giaSanPham";
            this.giaSanPham.HeaderText = "Giá Sản Phẩm";
            this.giaSanPham.Name = "giaSanPham";
            this.giaSanPham.Width = 180;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdHangHoa);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Controls.Add(this.txtTenHangHoa);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 205);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.cbPhieuNhap);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 133);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.txtTenPhieu);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(418, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 133);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chỉnh sửa phiếu";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(838, 646);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteHang);
            this.Controls.Add(this.btnAddHang);
            this.Controls.Add(this.btnUpdateHang);
            this.Controls.Add(this.dgvHangnhap);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuNhapHang";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangnhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPhieuNhap;
        private System.Windows.Forms.DataGridView dgvHangnhap;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTenPhieu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtIdHangHoa;
        private System.Windows.Forms.TextBox txtTenHangHoa;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnUpdateHang;
        private System.Windows.Forms.Button btnAddHang;
        private System.Windows.Forms.Button btnDeleteHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_phieuNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

