using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        DB_QuanLyNhanVienEntitie _db;

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
            _db = new DB_QuanLyNhanVienEntitie();

            // load list view
            _db.NhanViens.ToList().ForEach(nv =>
            {
                ListViewItem listViewItem = new ListViewItem(nv.MaNV);
                listViewItem.SubItems.Add(nv.HoTen);
                listViewItem.SubItems.Add(nv.GioiTinh);
                listViewItem.SubItems.Add(nv.Dienthoai);
                listViewItem.SubItems.Add(nv.NgayVL?.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(nv.Luong.ToString());

                lvDSNV.Items.Add(listViewItem);
            });
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // validate
            // Kiểm tra thông tin có hợp lệ
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Họ tên nhân viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtDT.Text))
            {
                MessageBox.Show("Số điện thoại nhân viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime ngayVaoLam;
            if (!DateTime.TryParse(dtNVL.Text, out ngayVaoLam))
            {
                MessageBox.Show("Ngày vào làm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ngayVaoLam > DateTime.Now)
            {
                MessageBox.Show("Ngày vào làm không được lớn hơn ngày hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // luu vao db
            var nv = new NhanVien
            {
                MaNV = txtID.Text,
                HoTen = txtName.Text,
                GioiTinh = rdoNam.Checked ? "Nam" : "Nu",
                Dienthoai = txtDT.Text,
                NgayVL = dtNVL.Value,
            };
            if (rdoNVBH.Checked)
            {
                nv.DoanhSo = float.Parse(txtDoanhSo.Text);
                nv.NhienLieu = null;
            }
            else
            {
                nv.NhienLieu = float.Parse(txtNL.Text);
                nv.DoanhSo = null;
            }
            Luong(nv);

            _db.NhanViens.Add(nv);
            _db.SaveChanges();

            // hien thi len listview
            ListViewItem listViewItem = new ListViewItem(nv.MaNV);
            listViewItem.SubItems.Add(nv.HoTen);
            listViewItem.SubItems.Add(nv.GioiTinh);
            listViewItem.SubItems.Add(nv.Dienthoai);
            listViewItem.SubItems.Add(nv.NgayVL?.ToString("dd/MM/yyyy"));
            // Tính thâm niên
            TimeSpan thamNien = DateTime.Now - dtNVL.Value;

            // Kiểm tra nếu thâm niên lớn hơn 5 năm
            if (thamNien.TotalDays > 5 * 365) // 5 năm x 365 ngày
            {
                // Tô nền dòng dữ liệu thành màu vàng
                listViewItem.BackColor = Color.Yellow; // listViewItem là dòng dữ liệu bạn vừa thêm
            }
            listViewItem.SubItems.Add(Luong(nv).ToString());

            lvDSNV.Items.Add(listViewItem);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong các TextBox nhập liệu
            txtID.Text = "";
            txtName.Text = "";
            txtDT.Text = "";
            txtDoanhSo.Text = "";
            rdoNVBH.Checked = true;
            rdoNam.Checked = true;
            txtNL.Text = "";

            // Gán giá trị mặc định cho các TextBox nhập liệu
            txtID.Focus();
        }
        public double Luong(NhanVien nv)
        {
            double salary = 7000000;
            if (nv.DoanhSo != null)
            {
                return (double)(salary + nv.DoanhSo * 0.1);
            }
            else
            {
                return (double)(salary + nv.NhienLieu);
            }
        }
        //3. radiobutton loại nhân viên
        private void rdoNVBH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNVBH.Checked)
            {
                txtDoanhSo.Visible = true;
                txtNL.Visible = false;
                lblDoanhthu.Visible = true;
                lblPCNL.Visible = false;
            }
        }

        private void rdoNVGN_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNVGN.Checked)
            {
                txtDoanhSo.Visible = false;
                txtNL.Visible = true;
                lblPCNL.Visible = true;
                lblDoanhthu.Visible = false;
            }
        }
        //6. list view danh sach nhân vien 
        private void lvDSNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSNV.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvDSNV.SelectedItems[0]; // Lấy dòng đã chọn

                // Lấy dữ liệu từ các cột trong dòng đã chọn và hiển thị lên các điều khiển nhập liệu
                txtID.Text = selectedItem.SubItems[0].Text;
                txtName.Text = selectedItem.SubItems[1].Text;

                string gioiTinh = selectedItem.SubItems[2].Text; //cột giới tính

                // Đặt trạng thái RadioButton tương ứng
                if (gioiTinh == "Nam")
                {
                    rdoNam.Checked = true;
                    rdoNu.Checked = false;
                }
                else if (gioiTinh == "Nu")
                {
                    rdoNam.Checked = false;
                    rdoNu.Checked = true;
                }
                txtDT.Text = selectedItem.SubItems[3].Text;
                // Lấy giá trị ngày vào làm từ dòng đã chọn
                string ngayVLString = selectedItem.SubItems[4].Text; // Ví dụ: cột ngày vào làm

                if (DateTime.TryParse(ngayVLString, out DateTime ngayVL))
                {
                    // Nếu giá trị ngày vào làm hợp lệ, đặt giá trị cho DateTimePicker
                    dtNVL.Value = ngayVL;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDSNV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị hộp thoại xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xóa nhân viên được chọn
                lvDSNV.SelectedItems[0].Remove();

                // Kiểm tra xem có dữ liệu còn lại trong ListView
                if (lvDSNV.Items.Count == 0)
                {
                    // Nếu không còn dữ liệu, hiển thị thông tin mặc định
                    // Ví dụ: Clear các điều khiển nhập liệu
                    txtID.Clear();
                    txtName.Clear();
                    txtDT.Clear();
                    txtDoanhSo.Clear();
                    txtNL.Clear();
                    rdoNVBH.Checked = true;
                    rdoNam.Checked = true;

                    // Gán giá trị mặc định cho các TextBox nhập liệu
                    txtID.Focus();
                }
                else
                {
                    // Nếu còn dữ liệu, chọn dòng dữ liệu liền kề sau khi xóa
                    //int selectedIndex = Math.Min(lvDSNV.Items.Count - 1, lvDSNV.SelectedItems[0].Index);
                    int selectedIndex = Math.Min(lvDSNV.Items.Count - 1, lvDSNV.SelectedItems.Count > 0 ? lvDSNV.SelectedItems[0].Index : 0);
                    lvDSNV.Items[selectedIndex].Selected = true;
                }
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            // Tạo một ListViewItemComparer để tùy chỉnh cách sắp xếp
            lvDSNV.ListViewItemSorter = new ListViewItemComparer();
            // Sắp xếp theo cột thâm niên (cột thứ hai) giảm dần
            lvDSNV.Sorting = SortOrder.Descending;
            // Sắp xếp theo cột họ tên (cột thứ ba) tăng dần
            lvDSNV.Sorting = SortOrder.Ascending;
            // Áp dụng sắp xếp
            lvDSNV.Sort();
        }


        public bool NhanVienBanHang()
        {
            if (rdoNVBH.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool NhanVienGiaoNhan()
        {
            if (rdoNVGN.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnThongke_Click(object sender, EventArgs e)
        {
            using (var context = new DB_QuanLyNhanVienEntitie())
            {
                danhSachNhanVien = context.NhanViens.ToList();
            }
            int soNhanVienBanHang = 0;
            int soNhanVienGiaoNhan = 0;
            double tongLuongBanHang = 0;
            double tongLuongGiaoNhan = 0;

            // Duyệt qua danh sách nhân viên và tính toán thống kê
            /*
            foreach (var nv in danhSachNhanVien)
            {
                if (nv is NhanVienBanHang)
                {
                    soNhanVienBanHang++;
                    tongLuongBanHang += Luong(nv);
                }
                else if (nv is NhanVienGiaoNhan)
                {
                    soNhanVienGiaoNhan++;
                    tongLuongGiaoNhan += Luong(nv);
                }
            }
            */
            string thongBao = $"Công ty hiện có:\n";
            thongBao += $"- {soNhanVienBanHang} nhân viên bán hàng\n";
            thongBao += $"- {soNhanVienGiaoNhan} nhân viên giao nhận\n";
            thongBao += $"- Tổng lương chi cho nhân viên bán hàng: {tongLuongBanHang:C2}\n";
            thongBao += $"- Tổng lương chi cho nhân viên giao nhận: {tongLuongGiaoNhan:C2}";

            MessageBox.Show(thongBao, "Thống kê", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
