using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.clases
{
    class clsventa
    {
        public int iId_venta { get; set; }
        public int iId_empleado { get; set; }
        public bool bTipo { get; set; }
        public DateTime dFecha { get; set; }
        public float fTotal { get; set; }
    }
}
