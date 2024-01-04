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
        public string Phone {  get; set; }
        public DateTime NVL { get; set; }
        public float Sale { get; set; }
        public float Delivery { get; set; }
        public float Salary {  get; set; }
        public string Type {  get; set; }
    }
}
