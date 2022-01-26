using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clipper_Project
{
    class Box : Conexion
    {
        int id_box;
        int box;
        int topBox;
        int countBox;

        public int Id_box { get => id_box; set => id_box = value; }
        public int Boxes { get => box; set => box = value; }
        public int TopBox { get => topBox; set => topBox = value; }
        public int CountBox { get => countBox; set => countBox = value; }
    }
}
