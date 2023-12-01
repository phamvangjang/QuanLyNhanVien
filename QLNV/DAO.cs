using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /*
        public bool Them(EmployeeModel e)
        {
            string sql = "INSERT INTO SanPham VALUES( @Name, @Price )";
            Object[] prms = new object[] { e.EmployeeID, e.FullName, e.Gender, e.PhoneNumber, e.HireDate,  };
            return DataProvider.Instance.execNonSql(sql, prms) > 0;
        }
        */
    }
}
