using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clipper_Project
{
    class Scan : Conexion
    {
        public int id_scan { get; set; }
        public string sn { get; set; }
        public DateTime dateReg { get; set; }
        public int id_wo { get; set; }
        public bool combine { get; set; }
    }
}
