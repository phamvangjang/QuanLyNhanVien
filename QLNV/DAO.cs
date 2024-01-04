using QLNV.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV
{
    internal class DAO
    {
        private static DAO instance;

        internal static DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO();
                return instance;
            }
        }
        private DAO() { }
        public DataTable Xem()
        {
            string sql = "SELECT * FROM NhanVien";
            return DataProvider.Instance.execSql(sql);
        }

        public bool Luu(Employee employee)
        {
            string sql = "INSERT INTO NhanVien(MaNV, HoTen, GioiTinh, Dienthoai, NgayVL, DoanhSo, NhienLieu, Luong, LoaiNV)" + "VALUES ( @MaNV, @HoTen, @GioiTinh, @Dienthoai, @ngayVL, @DoanhSo, @NhienLieu, @Luong, @LoaiNV )";
            Object[] prms = new object[] { employee.ID, employee.Name, employee.Gender, employee.Phone, employee.NVL, employee.Sale, employee.Delivery, employee.Salary, employee.Type };
            return DataProvider.Instance.execNonSql(sql, prms) > 0;
        }

        public bool XoaThongtinTheoMaNV(string madon)
        {
            try
            {
                string query = $"DELETE FROM NhanVien WHERE MaNV = '{madon}'";
                int affectedRows = DataProvider.Instance.execNonSql(query);

                // Kiểm tra số dòng bị ảnh hưởng, nếu lớn hơn 0, xóa thành công
                return affectedRows > 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Không xóa được nhân viên: ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
