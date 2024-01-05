using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLNVEntityFramwork
{
    public partial class Form1 : Form
    {
        private List<NhanVien> danhSachNhanVien;
        public Form1()
        {
            InitializeComponent();
        }

        DB_QuanLyNhanVienEntitie _db = new DB_QuanLyNhanVienEntitie();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có muốn đóng ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Ngăn chặn việc đóng ứng dụng nếu người dùng không đồng ý.
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
            ResetListView(_db.NhanViens.ToList());
        }

        private void rdoNVBH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnSale.Checked)
            {
                txtSale.Visible = true;
                lblSale.Visible = true;
                txtSale.Clear();
                txtDelivery.Visible = false;
                lblDelivery.Visible = false;
            }
        }

        private void rdoNVGN_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDelivery.Checked)
            {
                txtDelivery.Visible = true;
                lblDelivery.Visible = true;
                txtSale.Clear();
                txtSale.Visible = false;
                lblSale.Visible = false;
            }
        }

        private void Reset()
        {
            foreach (ListViewItem item in lvDSNV.Items)
            {
                item.Selected = false;
            }

            txtID.Clear();
            txtName.Clear();
            rdbtnNam.Checked = true;
            txtDT.Clear();
            dtNVL.Value = DateTime.Now;
            rdbtnSale.Checked = true;
            txtSale.Clear();
            txtDelivery.Clear();

            txtID.Enabled = true;
            txtID.Focus();
        }

        private void ResetListView(IEnumerable<NhanVien> nhanViens)
        {
            lvDSNV.Items.Clear();
            foreach (var a in nhanViens)
            {
                ListViewItem listViewItem = new ListViewItem(a.MaNV);
                listViewItem.SubItems.Add(a.HoTen.ToString());
                listViewItem.SubItems.Add(a.GioiTinh.ToString());
                listViewItem.SubItems.Add(a.NgayVL.Value.ToString("dd/MM/yyyy"));
                //hight light tn
                TimeSpan thamnien = DateTime.Now - DateTime.Parse(a.NgayVL.Value.ToString());
                int thamNienNgay = (int)thamnien.TotalDays;
                int tn = thamNienNgay / 365;
                if (tn > 5)
                {
                    listViewItem.BackColor = Color.LightGoldenrodYellow;
                }

                lvDSNV.Items.Add(listViewItem);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private bool validate
        {
            get
            {
                // Kiểm tra thông tin có hợp lệ
                if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDT.Text))
                {
                    MessageBox.Show("Thông tin không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (dtNVL.Value > DateTime.Now)
                {
                    MessageBox.Show("Ngày vào làm không được lớn hơn ngày hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtDT.Text.Any(n => !char.IsDigit(n)) || txtDT.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải là một dãy số và có 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtSale.Text.Any(n => !char.IsDigit(n)) && rdbtnSale.Checked)
                {
                    MessageBox.Show("Doanh nhanVien phải là số dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtDelivery.Text.Any(n => !char.IsDigit(n)) && rdbtnDelivery.Checked)
                {
                    MessageBox.Show("Phụ cấp phải là số dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (validate)
            {
                bool a = _db.NhanViens.Any(b => b.MaNV == txtID.Text);
                if (a)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    float s = 0, d = 0, sa = 0;
                    if (rdbtnSale.Checked)
                    {
                        s = float.Parse(txtSale.Text);
                        sa += (s + 7000000);
                    }
                    else
                    {
                        d = float.Parse(txtDelivery.Text);
                        sa += (d + 7000000);
                    }
                    //save to db
                    _db.NhanViens.Add(new NhanVien() { MaNV = txtID.Text, HoTen = txtName.Text, GioiTinh = rdbtnNam.Checked ? "Nam" : "Nữ", Dienthoai = txtDT.Text, NgayVL = dtNVL.Value, LoaiNV = rdbtnSale.Checked ? "sale" : "delivery", DoanhSo = s, NhienLieu = d, Luong = sa });
                    _db.SaveChanges();

                    //show to listview
                    ListViewItem listViewItem = new ListViewItem(txtID.Text);
                    listViewItem.SubItems.Add(txtName.Text);
                    listViewItem.SubItems.Add(rdbtnNam.Checked ? "Nam" : "Nữ");
                    listViewItem.SubItems.Add(dtNVL.Value.ToString("dd/MM/yyyy"));

                    //hight light tn
                    TimeSpan thamnien = DateTime.Now - DateTime.Parse(dtNVL.Value.ToString());
                    int thamNienNgay = (int)thamnien.TotalDays;
                    int tn = thamNienNgay / 365;
                    if (tn > 5)
                    {
                        listViewItem.BackColor = Color.LightGoldenrodYellow;
                    }
                    lvDSNV.Items.Add(listViewItem);
                    listViewItem.Selected = true;
                    MessageBox.Show("Đã thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    Reset();
                }
            }
        }

        private void lvDSNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSNV.SelectedItems.Count > 0)
            {
                //get id in listview
                string manv = lvDSNV.SelectedItems[0].SubItems[0].Text;
                txtID.Enabled = false;
                //find in _db if exists ?
                var nhanVien = _db.NhanViens.SingleOrDefault(z => z.MaNV == manv);
                if (nhanVien != null)
                {
                    txtID.Text = nhanVien.MaNV.Trim();
                    txtName.Text = nhanVien.HoTen.Trim();
                    if (nhanVien.GioiTinh == "Nam")
                    {
                        rdbtnNam.Checked = true;
                    }
                    else
                    {
                        rdbtnNu.Checked = true;
                    }
                    txtDT.Text = nhanVien.Dienthoai.Trim();
                    dtNVL.Value = nhanVien.NgayVL.Value;
                    if (nhanVien.LoaiNV.ToString() == "sale")
                    {
                        rdbtnSale.Checked = true;
                        txtSale.Text = nhanVien.DoanhSo.ToString();
                        txtDelivery.Clear();
                    }
                    else
                    {
                        rdbtnDelivery.Checked = true;
                        txtDelivery.Text = nhanVien.NhienLieu.ToString().Trim();
                        txtSale.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDSNV.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int index = lvDSNV.Items.IndexOf(lvDSNV.SelectedItems[0]);
                    string manvien = lvDSNV.SelectedItems[0].SubItems[0].Text.Trim();

                    NhanVien nhanVien = _db.NhanViens.Where(p => p.MaNV.Trim() == manvien).SingleOrDefault();
                    _db.NhanViens.Remove(nhanVien);
                    _db.SaveChanges();

                    lvDSNV.Items.Remove(lvDSNV.SelectedItems[0]);

                    if (lvDSNV.Items.Count > 0)
                    {
                        if (index < lvDSNV.Items.Count)
                        {
                            lvDSNV.Items[index].Selected = true;
                        }
                        else
                        {
                            Reset();
                        }
                    }
                    else if (lvDSNV.Items.Count == 0)
                    {
                        Reset();
                    }
                }
                MessageBox.Show("Đã xóa nhân viên thành công", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nào để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvDSNV.SelectedItems.Count > 0)
            {
                int index = lvDSNV.Items.IndexOf(lvDSNV.SelectedItems[0]);
                string manvien = lvDSNV.SelectedItems[0].SubItems[0].Text.Trim();

                NhanVien nhanVien = _db.NhanViens.Where(p => p.MaNV.Trim() == manvien).SingleOrDefault();
                float s = 0;
                float d = 0;
                float sa = 0;
                if (rdbtnSale.Checked)
                {
                    s = float.Parse(txtSale.Text);
                    sa = 7000000 + s*(float)0.1;
                }
                else
                {
                    d = float.Parse(txtDelivery.Text);
                    sa = 7000000 + d;
                }

                if (validate)
                {
                    nhanVien.HoTen = txtName.Text;
                    nhanVien.GioiTinh = rdbtnNam.Checked ? "Nam" : "Nữ";
                    nhanVien.Dienthoai = txtDT.Text;
                    nhanVien.NgayVL = dtNVL.Value;
                    nhanVien.DoanhSo = s;
                    nhanVien.NhienLieu = d;
                    nhanVien.Luong = sa;
                    nhanVien.LoaiNV = rdbtnSale.Checked ? "sale" : "delivery";
                    _db.SaveChanges();
                    txtID.Enabled = true;
                    ResetListView(_db.NhanViens.ToList());
                    Reset();
                    MessageBox.Show("Đã sửa nhân vien thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nào để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            try
            {
                var sort = _db.NhanViens.OrderByDescending(p => p.NgayVL).ThenBy(p => p.HoTen).ToList();
                ResetListView(sort);
                MessageBox.Show("Đã sắp xếp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            try
            {
                var s = from nv in _db.NhanViens
                        group nv by nv.LoaiNV into g
                        select new
                        {
                            loai = g.Key,
                            sonv = g.Count(),
                            Lchi = g.Sum(p => p.Luong)
                        };

                string message = "Thống kê theo loại nhân viên\n\n";

                foreach (var t in s)
                {
                    if (t.loai == "sale")
                        message += $"Nhân viên bán hàng:\n";
                    else
                        message += $"Nhân viên Giao hành:\n";
                    message += $"Số lượng: {t.sonv}\n";
                    message += $"Tổng chi phi: {t.Lchi:#,#}\n\n";
                }

                MessageBox.Show(message, "Thống kê", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
