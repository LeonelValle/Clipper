namespace Clipper_Project
{
    class Operador : Conexion
    {
        static int id_operador;
        string nombre;
        int numeroempleado;

        public int Id_operador { get => id_operador; set => id_operador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Numeroempleado { get => numeroempleado; set => numeroempleado = value; }
    }
}
