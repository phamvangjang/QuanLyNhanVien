using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                string ngayvl = form1.dtNVL.Value.ToString("dd/MM/yyyy");
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
                employee.Name= form1.txtName.Text;
                employee.Gender= gt;
                employee.Phone= form1.txtPhone.Text;
                employee.NVL = DateTime.Parse(ngayvl);

                if (form1.rdbtnSale.Checked)
                {
                    employee.Type= "sale";
                    s= float.Parse(form1.txtSale.Text);
                    sa = 7000000 + (float)0.1 * float.Parse(form1.txtSale.Text);
                }
                else 
                {
                    employee.Type = "delivery";
                    d = float.Parse(form1.txtDelivery.Text);
                    sa = 7000000 + float.Parse(form1.txtDelivery.Text);
                }

                employee.Sale = s;
                employee.Delivery = d;
                employee.Salary=sa;

                DAO.Instance.Luu(employee);
                MessageBox.Show("Đã thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool XoaThongtinTheoMaNV(string manv)
        {
            return DAO.Instance.XoaThongtinTheoMaNV(manv);
        }
    }
}
