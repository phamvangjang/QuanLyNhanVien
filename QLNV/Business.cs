using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV
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
    }
}
