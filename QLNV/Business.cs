using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLNV.Model
{
    internal class Business
    {
        private static Business instance;
        internal static Business Instance
        {
            get
            {
                if (instance == null)
                    instance = new Business();
                return instance;
            }
        }
        public Business() { }

        public void Xem(ListView lv)
        {
            foreach (DataRow row in DAO.Instance.Xem().Rows)
            {
                //show to listview
                ListViewItem item = new ListViewItem(row["MaNV"].ToString());
                item.SubItems.Add(row["HoTen"].ToString());
                item.SubItems.Add(row["GioiTinh"].ToString());
                item.SubItems.Add(row["NgayVL"].ToString());

                //hight light tn
                TimeSpan thamnien = DateTime.Now - DateTime.Parse(row["NgayVL"].ToString());
                int thamNienNgay = (int)thamnien.TotalDays;
                int tn = thamNienNgay / 365;
                if (tn > 5)
                {
                    item.BackColor = Color.LightGoldenrodYellow;
                }
                lv.Items.Add(item);
            }
        }

        public void Luu(ListView lv)
        {
            Employee employee = new Employee();
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                string gt = "";
                if (form1.rdbtnNam.Checked)
                {
                    gt = "Nam";
                }
                else if (form1.rdbtnNu.Checked)
                {
                    gt = "Nữ";
                }
                //show to listview
                string ngayvl = form1.dtNVL.Value.ToString();
                ListViewItem listViewItem = new ListViewItem(form1.txtID.Text);
                listViewItem.SubItems.Add(form1.txtName.Text);
                listViewItem.SubItems.Add(gt);
                listViewItem.SubItems.Add(ngayvl);

                TimeSpan thamnien = DateTime.Now - DateTime.Parse(ngayvl);
                int thamNienNgay = (int)thamnien.TotalDays;
                int tn = thamNienNgay / 365;

                //hight light tn
                if (tn > 5)
                {
                    listViewItem.BackColor = Color.LightGoldenrodYellow;
                }
                form1.lvDSNV.Items.Add(listViewItem);

                //save info form object
                float s = 0, d = 0, sa = 0;
                employee.ID = form1.txtID.Text;
                employee.Name = form1.txtName.Text;
                employee.Gender = gt;
                employee.Phone = form1.txtPhone.Text;
                employee.NVL = DateTime.Parse(ngayvl);

                if (form1.rdbtnSale.Checked)
                {
                    employee.Type = "sale";
                    s = float.Parse(form1.txtSale.Text);
                    sa = 7000000 + s * (float)0.1;
                }
                else
                {
                    employee.Type = "delivery";
                    d = float.Parse(form1.txtDelivery.Text);
                    sa = 7000000 + d;
                }

                employee.Sale = s;
                employee.Delivery = d;
                employee.Salary = sa;

                DAO.Instance.Luu(employee);
                MessageBox.Show("Đã thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool XoaThongtinTheoMaNV(string manv)
        {
            return DAO.Instance.XoaThongtinTheoMaNV(manv);
        }

        public Employee LayThongTinNhanVienTheoMa(string manvien)
        {
            Employee employee = new Employee();
            DataTable dataTable = DAO.Instance.LayThongTinNhanVienTheoMa(manvien);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                employee.ID = dataRow[0].ToString();
                employee.Name = dataRow[1].ToString();
                employee.Gender = dataRow[2].ToString();
                employee.Phone = (dataRow[3].ToString());
                employee.NVL = DateTime.Parse(dataRow[4].ToString());
                employee.Sale = float.Parse(dataRow[5].ToString());
                employee.Delivery = float.Parse(dataRow[6].ToString());
                employee.Salary = float.Parse(dataRow[7].ToString());
                employee.Type = dataRow[8].ToString();
            }
            return employee;
        }

        public void Sua(ListView listView)
        {
            Employee employee = new Employee();
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1.lvDSNV.SelectedItems.Count > 0)
            {
                string manvien = form1.lvDSNV.SelectedItems[0].Text;
                if (!string.IsNullOrEmpty(manvien))
                {
                    float s = 0, d = 0, sa = 0;
                    string nvlam = form1.dtNVL.Value.ToShortDateString();
                    employee.Name = form1.txtName.Text;
                    employee.Gender = form1.rdbtnNam.Checked ? "Nam" : "Nữ";
                    employee.Phone = form1.txtPhone.Text;
                    employee.NVL = DateTime.Parse(nvlam);
                    if (form1.rdbtnSale.Checked)
                    {
                        s = float.Parse(form1.txtSale.Text);
                        sa = 7000000 + s*(float)0.1;
                        employee.Type = "sale";

                    }
                    else
                    {
                        d = float.Parse(form1.txtDelivery.Text);
                        sa = 7000000 + d;
                        employee.Type = "delivery";
                    }
                    employee.Sale = s;
                    employee.Delivery = d;
                    employee.Salary = sa;
                    DAO.Instance.SuaNhanVien(employee, manvien);
                    MessageBox.Show("Dữ liệu đã được sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thú cưng nào để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SapXepNhanVien(ListView listView)
        {
            foreach (DataRow row in DAO.Instance.SapXepNhanVien().Rows)
            {
                ListViewItem item = new ListViewItem(row["MaNV"].ToString());
                item.SubItems.Add(row["HoTen"].ToString());
                item.SubItems.Add(row["GioiTinh"].ToString());
                item.SubItems.Add(row["NgayVL"].ToString());

                TimeSpan thamnien = DateTime.Now - DateTime.Parse(row["NgayVL"].ToString());
                int thamNienNgay = (int)thamnien.TotalDays;
                int tn = thamNienNgay / 365;

                //hight light tn
                if (tn > 5)
                {
                    item.BackColor = Color.LightGoldenrodYellow;
                }

                listView.Items.Add(item);
            }
        }

        public void ThongKe()
        {
            DataTable dataTable = DAO.Instance.ThongKe();
            DataRow dataRow1 = dataTable.Rows[0];
            int slnvdeli = dataRow1.Field<int>("SoNhanVien");
            double lcgh = dataRow1.Field<double>("TongLuongChiDeli");

            DataRow dataRow2 = dataTable.Rows[1];
            int slnvsale = dataRow2.Field<int>("SoNhanVien");
            double lcdt = dataRow2.Field<double>("TongLuongChiSale");

            MessageBox.Show("Số nhân viên BH: " + slnvsale + " (nv)\n" +
                            $"Lương chi nhân viên BH: {lcdt:#,#}" + " VND\n\n\n" +
                            "Số nhân viên GH: " + slnvdeli + " (nv)\n" +
                            $"Lương chi nhân viên GH:  {lcgh:#,#}" + " VND",
                            "Thống kê", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
