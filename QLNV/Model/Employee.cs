using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV.Model
{
    internal class Employee
    {
        public string ID {  get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string phoneNumber {  get; set; }
        public DateTime NgayVaoLam { get; set; }
        public int ThamNien()
        {
            return DateTime.Now.Year - NgayVaoLam.Year;
        }
        public double Salary()
        {
            return 7000000;
        }
    }
}
