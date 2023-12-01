using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV.Model
{
    internal class EmShip : Employee
    {
        public double Ship {  get; set; }
        public new double Salary()
        {
            return base.Salary() + Ship;
        }
    }
}
