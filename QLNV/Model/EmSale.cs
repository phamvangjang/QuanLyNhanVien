using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV.Model
{
    internal class EmSale : Employee
    {
        public double Sale {  get; set; }
        public new double Salary()
        {
            return base.Salary() + Sale * 0.1; 
        }
    }
}
