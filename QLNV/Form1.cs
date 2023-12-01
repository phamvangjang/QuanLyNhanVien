using System;
using System.Windows.Forms;

namespace QLNV
{
    public partial class Form1 : Form
    {
        string gender = "";
        public Form1(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        
        }

        //Hỏi xác nhận khi đóng form 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có muốn đóng ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Ngăn chặn việc đóng ứng dụng nếu người dùng không đồng ý.
            }
        }
        /*
        public class Employee
        {
            public string EmployeeID { get; set; }
            public string FullName { get; set; }
            public string Gender { get; set; }
            public string PhoneNumber { get; set; }
            public string EmployeeType { get; set; }
            public DateTime HireDate { get; set; }
            public double BaseSalary { get; set; }
            public double Bonus { get; set; }
            public double FuelAllowance { get; set; }

            public Employee()
            {
                BaseSalary = 7000000; // Lương cơ bản
            }

            public double CalculateSalary()
            {
                return BaseSalary + Bonus + FuelAllowance;
            }
        }
        */
        //2.khi mới mỏ chương trình - sua trong properties
        //3. radiobutton loại nhân viên
        private void rdNVBH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNVBH.Checked)
            {
                txtDoanhSo.Visible = true;
                txtNL.Visible = false;
                lblDoanhthu.Visible = true;
                lblPCNL.Visible = false;
            }
        }

        private void rbNVGN_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNVGN.Checked)
            {
                txtDoanhSo.Visible = false;
                txtNL.Visible = true;
                lblPCNL.Visible = true;
                lblDoanhthu.Visible = false;
            }
        }
        //4. nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            // Xóa dữ liệu trong các TextBox nhập liệu
            txtID.Text = "";
            txtName.Text = "";
            txtDT.Text = "";
            txtDoanhSo.Text = "";
            rdNVBH.Checked = true;
            rdNam.Checked = true;
            txtNL.Text = "";

            // Gán giá trị mặc định cho các TextBox nhập liệu
            txtID.Focus();
            

        }
        /*
        private void btnLuu_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.EmployeeID = txtID.Text;
            employee.FullName = txtName.Text;
            employee.PhoneNumber = txtDT.Text;
            employee.HireDate = tdNVL.Value;

            // Kiểm tra thông tin có hợp lệ
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Mã nhân viên và họ tên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime ngayVaoLam;
            if (!DateTime.TryParse(tdNVL.Text, out ngayVaoLam))
            {
                MessageBox.Show("Ngày vào làm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ngayVaoLam > DateTime.Now)
            {
                MessageBox.Show("Ngày vào làm không được lớn hơn ngày hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rdNam.Checked)
            {
                employee.Gender = "Nam";
            }
            else if (rbNu.Checked)
            {
                employee.Gender = "Nữ";
            }

            if (rdNVBH.Checked)
            {
                employee.FuelAllowance = double.Parse(txtDoanhSo.Text);
            }
            else if (rbNVGN.Checked)
            {
                employee.Bonus = double.Parse(txtNL.Text);
            }

            double salary = employee.CalculateSalary();


            // Thêm thông tin nhân viên vào ListView
            ListViewItem item = new ListViewItem(employee.EmployeeID);
            item.SubItems.Add(employee.FullName);
            item.SubItems.Add(employee.Gender);
            item.SubItems.Add(employee.PhoneNumber);
            item.SubItems.Add(employee.HireDate.ToString("dd/MM/yyyy"));
            item.SubItems.Add(salary.ToString("N0")); // Hiển thị lương

            lvDSNV.Items.Add(item);
        }
        */
    }
}
