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

        public DataTable LayThongTinNhanVienTheoMa(string manvien)
        {
            // Viết câu truy vấn SQL để lấy thông tin chi tiết của phim từ cơ sở dữ liệu
            string query = $"SELECT * FROM NhanVien WHERE MaNV = '{manvien}'";

            // Thực hiện truy vấn và trả về đối tượng Phim
            return DataProvider.Instance.execSql(query);
        }

        public bool SuaNhanVien(Employee employee, string manvien)
        {
            string query = "UPDATE NhanVien SET HoTen = @HoTen, GioiTinh = @GioiTinh, Dienthoai = @Dienthoai, NgayVL = @NgayVL, DoanhSo = @DoanhSo, NhienLieu = @NhienLieu, Luong = @Luong, LoaiNV = @LoaiNV " +
                " WHERE MaNV = @MaNV";
            object[] prms = new object[] { employee.Name, employee.Gender, employee.Phone, employee.NVL, employee.Sale, employee.Delivery, employee.Salary, employee.Type, manvien };
            return DataProvider.Instance.execNonSql(query, prms) > 0;
        }

        public DataTable SapXepNhanVien()
        {
            string query = $"SELECT * FROM NhanVien ORDER BY NgayVL DESC, HoTen ASC";
            return DataProvider.Instance.execSql(query);
        }

        public DataTable ThongKe()
        {
            string query = $"SELECT LoaiNV, " +
                $"COUNT(*) AS SoNhanVien, " +
                $"SUM(CASE WHEN LoaiNV = 'sale' THEN Luong ELSE 0 END) AS TongLuongChiSale, " +
                $"SUM(CASE WHEN LoaiNV = 'delivery' THEN Luong ELSE 0 END) AS TongLuongChiDeli " +
                $"FROM NhanVien " +
                $"GROUP BY LoaiNV;";
            return DataProvider.Instance.execSql(query);
        }
    }
}
