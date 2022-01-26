using System;

namespace Clipper_Project
{
    class WorkOrder : Conexion
    {
        static int id_wo;
        public string wo { get; set; }
        public int qty { get; set; }
        public string rev { get; set; }
        public DateTime datecreated { get; set; }
        public int ubox { get; set; }
        public int id_pn { get; set; }
        public int id_user { get; set; }
        public int id_box { get; set; }
        public int Id_wo { get => id_wo; set => id_wo = value; }
        public int Id_Cwo { get => id_Cwo; set => id_Cwo = value; }
        public int Id_approved { get => id_approved; set => id_approved = value; }
        public string Comment { get => comment; set => comment = value; }
        public string Id_delphi { get => id_delphi; set => id_delphi = value; }

        int id_Cwo;
        static int id_approved;
        static string comment;
        string id_delphi;


    }
}
