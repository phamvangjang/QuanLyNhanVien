﻿namespace QLNVEntityFramwork
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
            this.NgayVL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSale = new System.Windows.Forms.TextBox();
            this.lblSale = new System.Windows.Forms.Label();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.gbLNV = new System.Windows.Forms.GroupBox();
            this.rdbtnDelivery = new System.Windows.Forms.RadioButton();
            this.rdbtnSale = new System.Windows.Forms.RadioButton();
            this.gb_GT = new System.Windows.Forms.GroupBox();
            this.rdbtnNu = new System.Windows.Forms.RadioButton();
            this.rdbtnNam = new System.Windows.Forms.RadioButton();
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
            this.btnThongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThongke.Location = new System.Drawing.Point(25, 290);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(153, 34);
            this.btnThongke.TabIndex = 5;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSua.Location = new System.Drawing.Point(25, 189);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(153, 34);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoa.Location = new System.Drawing.Point(25, 136);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(153, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuu.Location = new System.Drawing.Point(26, 89);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(153, 34);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblLoaiNV
            // 
            this.lblLoaiNV.AutoSize = true;
            this.lblLoaiNV.Location = new System.Drawing.Point(11, 280);
            this.lblLoaiNV.Name = "lblLoaiNV";
            this.lblLoaiNV.Size = new System.Drawing.Size(145, 25);
            this.lblLoaiNV.TabIndex = 10;
            this.lblLoaiNV.Text = "Loại nhân viên:";
            // 
            // dtNVL
            // 
            this.dtNVL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNVL.Location = new System.Drawing.Point(161, 226);
            this.dtNVL.Name = "dtNVL";
            this.dtNVL.Size = new System.Drawing.Size(309, 30);
            this.dtNVL.TabIndex = 9;
            // 
            // lblNVL
            // 
            this.lblNVL.AutoSize = true;
            this.lblNVL.Location = new System.Drawing.Point(11, 230);
            this.lblNVL.Name = "lblNVL";
            this.lblNVL.Size = new System.Drawing.Size(137, 25);
            this.lblNVL.TabIndex = 8;
            this.lblNVL.Text = "Ngày vào làm:";
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(160, 177);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(311, 30);
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
            this.btnSapXep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSapXep.Location = new System.Drawing.Point(25, 237);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(153, 34);
            this.btnSapXep.TabIndex = 4;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = false;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThem.Location = new System.Drawing.Point(26, 36);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(153, 34);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gbDSNV
            // 
            this.gbDSNV.Controls.Add(this.lvDSNV);
            this.gbDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDSNV.Location = new System.Drawing.Point(97, 472);
            this.gbDSNV.Name = "gbDSNV";
            this.gbDSNV.Size = new System.Drawing.Size(696, 263);
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
            this.NgayVL});
            this.lvDSNV.FullRowSelect = true;
            this.lvDSNV.GridLines = true;
            this.lvDSNV.HideSelection = false;
            this.lvDSNV.Location = new System.Drawing.Point(14, 33);
            this.lvDSNV.Name = "lvDSNV";
            this.lvDSNV.Size = new System.Drawing.Size(671, 210);
            this.lvDSNV.TabIndex = 0;
            this.lvDSNV.UseCompatibleStateImageBehavior = false;
            this.lvDSNV.View = System.Windows.Forms.View.Details;
            this.lvDSNV.SelectedIndexChanged += new System.EventHandler(this.lvDSNV_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "Ma NV";
            this.ID.Width = 100;
            // 
            // Name
            // 
            this.Name.Text = "Ho Ten";
            this.Name.Width = 120;
            // 
            // Gender
            // 
            this.Gender.Text = "Giới tính";
            this.Gender.Width = 120;
            // 
            // NgayVL
            // 
            this.NgayVL.Text = "Ngày Vào làm";
            this.NgayVL.Width = 200;
            // 
            // txtSale
            // 
            this.txtSale.Location = new System.Drawing.Point(160, 328);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(310, 30);
            this.txtSale.TabIndex = 15;
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Location = new System.Drawing.Point(10, 333);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(135, 25);
            this.lblSale.TabIndex = 14;
            this.lblSale.Text = "PC Doanh số:";
            // 
            // txtDelivery
            // 
            this.txtDelivery.Location = new System.Drawing.Point(161, 371);
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(310, 30);
            this.txtDelivery.TabIndex = 13;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(11, 376);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(137, 25);
            this.lblDelivery.TabIndex = 12;
            this.lblDelivery.Text = "PC Nhiên liệu:";
            // 
            // gbLNV
            // 
            this.gbLNV.Controls.Add(this.rdbtnDelivery);
            this.gbLNV.Controls.Add(this.rdbtnSale);
            this.gbLNV.Location = new System.Drawing.Point(162, 258);
            this.gbLNV.Name = "gbLNV";
            this.gbLNV.Size = new System.Drawing.Size(309, 60);
            this.gbLNV.TabIndex = 11;
            this.gbLNV.TabStop = false;
            // 
            // rdbtnDelivery
            // 
            this.rdbtnDelivery.AutoSize = true;
            this.rdbtnDelivery.Location = new System.Drawing.Point(154, 20);
            this.rdbtnDelivery.Name = "rdbtnDelivery";
            this.rdbtnDelivery.Size = new System.Drawing.Size(123, 29);
            this.rdbtnDelivery.TabIndex = 1;
            this.rdbtnDelivery.Text = "Giao nhận";
            this.rdbtnDelivery.UseVisualStyleBackColor = true;
            this.rdbtnDelivery.CheckedChanged += new System.EventHandler(this.rdoNVGN_CheckedChanged);
            // 
            // rdbtnSale
            // 
            this.rdbtnSale.AutoSize = true;
            this.rdbtnSale.Checked = true;
            this.rdbtnSale.Location = new System.Drawing.Point(16, 20);
            this.rdbtnSale.Name = "rdbtnSale";
            this.rdbtnSale.Size = new System.Drawing.Size(117, 29);
            this.rdbtnSale.TabIndex = 0;
            this.rdbtnSale.TabStop = true;
            this.rdbtnSale.Text = "Bán hàng";
            this.rdbtnSale.UseVisualStyleBackColor = true;
            this.rdbtnSale.CheckedChanged += new System.EventHandler(this.rdoNVBH_CheckedChanged);
            // 
            // gb_GT
            // 
            this.gb_GT.Controls.Add(this.rdbtnNu);
            this.gb_GT.Controls.Add(this.rdbtnNam);
            this.gb_GT.Location = new System.Drawing.Point(160, 111);
            this.gb_GT.Name = "gb_GT";
            this.gb_GT.Size = new System.Drawing.Size(311, 60);
            this.gb_GT.TabIndex = 5;
            this.gb_GT.TabStop = false;
            // 
            // rdbtnNu
            // 
            this.rdbtnNu.AutoSize = true;
            this.rdbtnNu.Location = new System.Drawing.Point(176, 20);
            this.rdbtnNu.Name = "rdbtnNu";
            this.rdbtnNu.Size = new System.Drawing.Size(58, 29);
            this.rdbtnNu.TabIndex = 1;
            this.rdbtnNu.Text = "Nữ";
            this.rdbtnNu.UseVisualStyleBackColor = true;
            // 
            // rdbtnNam
            // 
            this.rdbtnNam.AutoSize = true;
            this.rdbtnNam.Checked = true;
            this.rdbtnNam.Location = new System.Drawing.Point(48, 21);
            this.rdbtnNam.Name = "rdbtnNam";
            this.rdbtnNam.Size = new System.Drawing.Size(74, 29);
            this.rdbtnNam.TabIndex = 0;
            this.rdbtnNam.TabStop = true;
            this.rdbtnNam.Text = "Nam";
            this.rdbtnNam.UseVisualStyleBackColor = true;
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
            this.gbTTNV.Controls.Add(this.txtSale);
            this.gbTTNV.Controls.Add(this.lblSale);
            this.gbTTNV.Controls.Add(this.txtDelivery);
            this.gbTTNV.Controls.Add(this.lblDelivery);
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
            this.gbTTNV.Size = new System.Drawing.Size(490, 417);
            this.gbTTNV.TabIndex = 5;
            this.gbTTNV.TabStop = false;
            this.gbTTNV.Text = "Thông tin nhân viên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(309, 30);
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
            this.txtID.Location = new System.Drawing.Point(162, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(309, 30);
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
            this.gbTacVu.Size = new System.Drawing.Size(203, 417);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(885, 746);
            this.Controls.Add(this.gbDSNV);
            this.Controls.Add(this.gbTTNV);
            this.Controls.Add(this.gbTacVu);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.ColumnHeader NgayVL;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.GroupBox gbLNV;
        private System.Windows.Forms.RadioButton rdbtnDelivery;
        private System.Windows.Forms.RadioButton rdbtnSale;
        private System.Windows.Forms.GroupBox gb_GT;
        private System.Windows.Forms.RadioButton rdbtnNu;
        private System.Windows.Forms.RadioButton rdbtnNam;
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

