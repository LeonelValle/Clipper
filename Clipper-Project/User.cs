using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clipper_Project
{
    class User : Conexion
    {
        static int id_user; 
        public string name { get; set; }
        public int idemp { get; set; }
        public int Id_user { get => id_user; set => id_user = value; }
    }
}
