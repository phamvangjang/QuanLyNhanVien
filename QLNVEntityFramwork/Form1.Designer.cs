namespace QLNVEntityFramwork
{
    partial class Form1
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
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblLoaiNV = new System.Windows.Forms.Label();
            this.dtNVL = new System.Windows.Forms.DateTimePicker();
            this.lblNVL = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.lblDT = new System.Windows.Forms.Label();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbDSNV = new System.Windows.Forms.GroupBox();
            this.lvDSNV = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayVL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDoanhSo = new System.Windows.Forms.TextBox();
            this.lblDoanhthu = new System.Windows.Forms.Label();
            this.txtNL = new System.Windows.Forms.TextBox();
            this.lblPCNL = new System.Windows.Forms.Label();
            this.gbLNV = new System.Windows.Forms.GroupBox();
            this.rdoNVGN = new System.Windows.Forms.RadioButton();
            this.rdoNVBH = new System.Windows.Forms.RadioButton();
            this.gb_GT = new System.Windows.Forms.GroupBox();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.lblGT = new System.Windows.Forms.Label();
            this.gbTTNV = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.gbTacVu = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDSNV.SuspendLayout();
            this.gbLNV.SuspendLayout();
            this.gb_GT.SuspendLayout();
            this.gbTTNV.SuspendLayout();
            this.gbTacVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(25, 290);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(153, 34);
            this.btnThongke.TabIndex = 5;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(25, 189);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(153, 34);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(25, 136);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(153, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(26, 89);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(153, 34);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblLoaiNV
            // 
            this.lblLoaiNV.AutoSize = true;
            this.lblLoaiNV.Location = new System.Drawing.Point(11, 273);
            this.lblLoaiNV.Name = "lblLoaiNV";
            this.lblLoaiNV.Size = new System.Drawing.Size(145, 25);
            this.lblLoaiNV.TabIndex = 10;
            this.lblLoaiNV.Text = "Loại nhân viên:";
            // 
            // dtNVL
            // 
            this.dtNVL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNVL.Location = new System.Drawing.Point(161, 221);
            this.dtNVL.Name = "dtNVL";
            this.dtNVL.Size = new System.Drawing.Size(309, 30);
            this.dtNVL.TabIndex = 9;
            // 
            // lblNVL
            // 
            this.lblNVL.AutoSize = true;
            this.lblNVL.Location = new System.Drawing.Point(11, 225);
            this.lblNVL.Name = "lblNVL";
            this.lblNVL.Size = new System.Drawing.Size(137, 25);
            this.lblNVL.TabIndex = 8;
            this.lblNVL.Text = "Ngày vào làm:";
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(117, 177);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(354, 30);
            this.txtDT.TabIndex = 7;
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Location = new System.Drawing.Point(11, 182);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(99, 25);
            this.lblDT.TabIndex = 6;
            this.lblDT.Text = "Điện thoại";
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(25, 237);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(153, 34);
            this.btnSapXep.TabIndex = 4;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(26, 36);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(153, 34);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gbDSNV
            // 
            this.gbDSNV.Controls.Add(this.lvDSNV);
            this.gbDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDSNV.Location = new System.Drawing.Point(97, 438);
            this.gbDSNV.Name = "gbDSNV";
            this.gbDSNV.Size = new System.Drawing.Size(696, 306);
            this.gbDSNV.TabIndex = 7;
            this.gbDSNV.TabStop = false;
            this.gbDSNV.Text = "Danh sách nhân viên";
            // 
            // lvDSNV
            // 
            this.lvDSNV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.Gender,
            this.Phone,
            this.NgayVL,
            this.Salary});
            this.lvDSNV.GridLines = true;
            this.lvDSNV.HideSelection = false;
            this.lvDSNV.Location = new System.Drawing.Point(14, 33);
            this.lvDSNV.Name = "lvDSNV";
            this.lvDSNV.Size = new System.Drawing.Size(671, 263);
            this.lvDSNV.TabIndex = 0;
            this.lvDSNV.UseCompatibleStateImageBehavior = false;
            this.lvDSNV.View = System.Windows.Forms.View.Details;
            this.lvDSNV.SelectedIndexChanged += new System.EventHandler(this.lvDSNV_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "Ma NV";
            this.ID.Width = 80;
            // 
            // Name
            // 
            this.Name.Text = "Ho Ten";
            this.Name.Width = 120;
            // 
            // Gender
            // 
            this.Gender.Text = "Giới tính";
            this.Gender.Width = 100;
            // 
            // Phone
            // 
            this.Phone.Text = "Số ĐT";
            this.Phone.Width = 100;
            // 
            // NgayVL
            // 
            this.NgayVL.Text = "Ngày Vào làm";
            this.NgayVL.Width = 160;
            // 
            // Salary
            // 
            this.Salary.Text = "Lương";
            this.Salary.Width = 120;
            // 
            // txtDoanhSo
            // 
            this.txtDoanhSo.Location = new System.Drawing.Point(160, 317);
            this.txtDoanhSo.Name = "txtDoanhSo";
            this.txtDoanhSo.Size = new System.Drawing.Size(310, 30);
            this.txtDoanhSo.TabIndex = 15;
            // 
            // lblDoanhthu
            // 
            this.lblDoanhthu.AutoSize = true;
            this.lblDoanhthu.Location = new System.Drawing.Point(10, 322);
            this.lblDoanhthu.Name = "lblDoanhthu";
            this.lblDoanhthu.Size = new System.Drawing.Size(135, 25);
            this.lblDoanhthu.TabIndex = 14;
            this.lblDoanhthu.Text = "PC Doanh số:";
            // 
            // txtNL
            // 
            this.txtNL.Location = new System.Drawing.Point(161, 313);
            this.txtNL.Name = "txtNL";
            this.txtNL.Size = new System.Drawing.Size(310, 30);
            this.txtNL.TabIndex = 13;
            // 
            // lblPCNL
            // 
            this.lblPCNL.AutoSize = true;
            this.lblPCNL.Location = new System.Drawing.Point(11, 318);
            this.lblPCNL.Name = "lblPCNL";
            this.lblPCNL.Size = new System.Drawing.Size(137, 25);
            this.lblPCNL.TabIndex = 12;
            this.lblPCNL.Text = "PC Nhiên liệu:";
            // 
            // gbLNV
            // 
            this.gbLNV.Controls.Add(this.rdoNVGN);
            this.gbLNV.Controls.Add(this.rdoNVBH);
            this.gbLNV.Location = new System.Drawing.Point(162, 251);
            this.gbLNV.Name = "gbLNV";
            this.gbLNV.Size = new System.Drawing.Size(309, 60);
            this.gbLNV.TabIndex = 11;
            this.gbLNV.TabStop = false;
            // 
            // rdoNVGN
            // 
            this.rdoNVGN.AutoSize = true;
            this.rdoNVGN.Location = new System.Drawing.Point(154, 20);
            this.rdoNVGN.Name = "rdoNVGN";
            this.rdoNVGN.Size = new System.Drawing.Size(123, 29);
            this.rdoNVGN.TabIndex = 1;
            this.rdoNVGN.Text = "Giao nhận";
            this.rdoNVGN.UseVisualStyleBackColor = true;
            this.rdoNVGN.CheckedChanged += new System.EventHandler(this.rdoNVGN_CheckedChanged);
            // 
            // rdoNVBH
            // 
            this.rdoNVBH.AutoSize = true;
            this.rdoNVBH.Checked = true;
            this.rdoNVBH.Location = new System.Drawing.Point(16, 20);
            this.rdoNVBH.Name = "rdoNVBH";
            this.rdoNVBH.Size = new System.Drawing.Size(117, 29);
            this.rdoNVBH.TabIndex = 0;
            this.rdoNVBH.TabStop = true;
            this.rdoNVBH.Text = "Bán hàng";
            this.rdoNVBH.UseVisualStyleBackColor = true;
            this.rdoNVBH.CheckedChanged += new System.EventHandler(this.rdoNVBH_CheckedChanged);
            // 
            // gb_GT
            // 
            this.gb_GT.Controls.Add(this.rdoNu);
            this.gb_GT.Controls.Add(this.rdoNam);
            this.gb_GT.Location = new System.Drawing.Point(100, 111);
            this.gb_GT.Name = "gb_GT";
            this.gb_GT.Size = new System.Drawing.Size(371, 60);
            this.gb_GT.TabIndex = 5;
            this.gb_GT.TabStop = false;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(145, 20);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(58, 29);
            this.rdoNu.TabIndex = 1;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new System.Drawing.Point(17, 21);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(74, 29);
            this.rdoNam.TabIndex = 0;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(11, 133);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(93, 25);
            this.lblGT.TabIndex = 4;
            this.lblGT.Text = "Giới tính: ";
            // 
            // gbTTNV
            // 
            this.gbTTNV.Controls.Add(this.txtDoanhSo);
            this.gbTTNV.Controls.Add(this.lblDoanhthu);
            this.gbTTNV.Controls.Add(this.txtNL);
            this.gbTTNV.Controls.Add(this.lblPCNL);
            this.gbTTNV.Controls.Add(this.gbLNV);
            this.gbTTNV.Controls.Add(this.lblLoaiNV);
            this.gbTTNV.Controls.Add(this.dtNVL);
            this.gbTTNV.Controls.Add(this.lblNVL);
            this.gbTTNV.Controls.Add(this.txtDT);
            this.gbTTNV.Controls.Add(this.lblDT);
            this.gbTTNV.Controls.Add(this.gb_GT);
            this.gbTTNV.Controls.Add(this.lblGT);
            this.gbTTNV.Controls.Add(this.txtName);
            this.gbTTNV.Controls.Add(this.label2);
            this.gbTTNV.Controls.Add(this.txtID);
            this.gbTTNV.Controls.Add(this.lbl_ID);
            this.gbTTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTTNV.ForeColor = System.Drawing.Color.Black;
            this.gbTTNV.Location = new System.Drawing.Point(93, 49);
            this.gbTTNV.Name = "gbTTNV";
            this.gbTTNV.Size = new System.Drawing.Size(490, 383);
            this.gbTTNV.TabIndex = 5;
            this.gbTTNV.TabStop = false;
            this.gbTTNV.Text = "Thông tin nhân viên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(371, 30);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(371, 30);
            this.txtID.TabIndex = 1;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(11, 34);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(79, 25);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "Mã NV:";
            // 
            // gbTacVu
            // 
            this.gbTacVu.Controls.Add(this.btnThongke);
            this.gbTacVu.Controls.Add(this.btnSapXep);
            this.gbTacVu.Controls.Add(this.btnSua);
            this.gbTacVu.Controls.Add(this.btnXoa);
            this.gbTacVu.Controls.Add(this.btnLuu);
            this.gbTacVu.Controls.Add(this.btnThem);
            this.gbTacVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTacVu.Location = new System.Drawing.Point(591, 49);
            this.gbTacVu.Name = "gbTacVu";
            this.gbTacVu.Size = new System.Drawing.Size(203, 383);
            this.gbTacVu.TabIndex = 6;
            this.gbTacVu.TabStop = false;
            this.gbTacVu.Text = "Tác vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ NHÂN VIÊN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 746);
            this.Controls.Add(this.gbDSNV);
            this.Controls.Add(this.gbTTNV);
            this.Controls.Add(this.gbTacVu);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDSNV.ResumeLayout(false);
            this.gbLNV.ResumeLayout(false);
            this.gbLNV.PerformLayout();
            this.gb_GT.ResumeLayout(false);
            this.gb_GT.PerformLayout();
            this.gbTTNV.ResumeLayout(false);
            this.gbTTNV.PerformLayout();
            this.gbTacVu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblLoaiNV;
        private System.Windows.Forms.DateTimePicker dtNVL;
        private System.Windows.Forms.Label lblNVL;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbDSNV;
        private System.Windows.Forms.ListView lvDSNV;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader NgayVL;
        private System.Windows.Forms.ColumnHeader Salary;
        private System.Windows.Forms.TextBox txtDoanhSo;
        private System.Windows.Forms.Label lblDoanhthu;
        private System.Windows.Forms.TextBox txtNL;
        private System.Windows.Forms.Label lblPCNL;
        private System.Windows.Forms.GroupBox gbLNV;
        private System.Windows.Forms.RadioButton rdoNVGN;
        private System.Windows.Forms.RadioButton rdoNVBH;
        private System.Windows.Forms.GroupBox gb_GT;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.GroupBox gbTTNV;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.GroupBox gbTacVu;
        private System.Windows.Forms.Label label1;
    }
}

