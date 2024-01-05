using QLNV.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLNV
{
    public partial class Form1 : Form
    {
        public Form1(){
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có muốn đóng ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Ngăn chặn việc đóng ứng dụng nếu người dùng không đồng ý.
            }
        }

        private void rdNVBH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnSale.Checked)
            {
                txtDelivery.Visible = false;
                lblDelivery.Visible = false;
                txtSale.Clear();
                txtSale.Visible = true;
                lblSale.Visible = true;
            }
        }

        private void rbNVGN_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDelivery.Checked)
            {
                txtSale.Visible = false;
                lblSale.Visible = false;
                txtDelivery.Clear();
                txtDelivery.Visible = true;
                lblDelivery.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
            Business.Instance.Xem(lvDSNV);
        }

        public void Reset()
        {
            // Xóa dữ liệu trong các TextBox nhập liệu
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            rdbtnNam.Checked = true;
            txtPhone.Text = string.Empty;
            dtNVL.Value = DateTime.Now;
            rdbtnSale.Checked = true;
            txtSale.Text = string.Empty;
            txtDelivery.Text = string.Empty;

            // Gán giá trị mặc định cho các TextBox nhập liệu
            txtID.Enabled = true;
            txtID.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public new bool Validate
        {
            get
            {
                // Kiểm tra thông tin có hợp lệ
                if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhone.Text))
                {
                    MessageBox.Show("Thông tin không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (dtNVL.Value > DateTime.Now)
                {
                    MessageBox.Show("Ngày vào làm không được lớn hơn ngày hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtPhone.Text.Any(n => !char.IsDigit(n)) || txtPhone.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải là một dãy số và có 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtSale.Text.Any(n => !char.IsDigit(n)) && rdbtnSale.Checked)
                {
                    MessageBox.Show("Doanh thu phải là số dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (Validate)
            {
                Business.Instance.Luu(lvDSNV);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDSNV.SelectedItems.Count > 0)
            {
                //hien thi hop thoai xac nhan
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //lay dong duoc chon
                    ListViewItem selectedRow = lvDSNV.SelectedItems[0];
                    // Lấy thông tin của phim từ dòng được chọn
                    string manv = lvDSNV.SelectedItems[0].SubItems[0].Text;
                    // Lấy index của dòng để xóa
                    int indexToRemove = selectedRow.Index;

                    // Xóa dòng khỏi ListView
                    lvDSNV.Items.Remove(selectedRow);

                    // Chọn dòng liền kề sau nếu có
                    if (indexToRemove < lvDSNV.Items.Count)
                    {
                        lvDSNV.Items[indexToRemove].Selected = true;
                        lvDSNV.Select();
                    }
                    else if (indexToRemove > 0)
                    {
                        // Nếu không có dòng liền kề sau, chọn dòng liền kề trước
                        lvDSNV.Items[indexToRemove - 1].Selected = true;
                        lvDSNV.Select();
                    }
                    else
                    {
                        // Nếu không còn dòng nào trong ListView, xóa thông tin ở bảng điều khiển và đưa trỏ chuột lên txtMaDon
                        Reset();
                    }

                    // Thực hiện xóa từ cơ sở dữ liệu
                    Business.Instance.XoaThongtinTheoMaNV(manv);
                    MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phong vien nào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void lvDSNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSNV.SelectedItems.Count > 0)
            {
                // Lấy giá trị của cột "Mã Đơn" từ dòng được chọn
                string manv = lvDSNV.SelectedItems[0].SubItems[0].Text;

                // Gọi phương thức trong Bussiness để lấy thông tin chi tiết từ cơ sở dữ liệu
                Employee employee = Business.Instance.LayThongTinNhanVienTheoMa(manv);
                txtID.Text = employee.ID.ToString();
                txtID.Enabled = false;
                txtName.Text = employee.Name.ToString();
                if (employee.Gender == "Nam")
                {
                    rdbtnNam.Checked = true;
                }
                else 
                {
                    rdbtnNu.Checked = true;
                }
                txtPhone.Text = employee.Phone.ToString();
                dtNVL.Text = employee.NVL.Date.ToShortDateString();
                if (employee.Type == "sale")
                {
                    rdbtnSale.Checked = true;
                    lblSale.Visible = true;
                    txtSale.Visible = true;
                    txtSale.Text = employee.Sale.ToString();
                }
                else
                {
                    rdbtnDelivery.Checked = true;
                    lblDelivery.Visible = true;
                    txtDelivery.Visible = true;
                    txtDelivery.Text = employee.Delivery.ToString();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Validate)
            {
                Business.Instance.Sua(lvDSNV);
                lvDSNV.Items.Clear();
                Business.Instance.Xem(lvDSNV);
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            lvDSNV.Items.Clear();
            Business.Instance.SapXepNhanVien(lvDSNV);
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            Business.Instance.ThongKe();
        }
    }
}
