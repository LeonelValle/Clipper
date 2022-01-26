using System;
using System.Linq;
using System.Windows.Forms;

namespace Clipper_Project
{
    public partial class Identificar_Operador : Form
    {
        readonly Conexion con = new Conexion();
        readonly Operador operador = new Operador();
        public Identificar_Operador()
        {
            InitializeComponent();
        }

        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                operador.Numeroempleado = Convert.ToInt32(txt_empleado.Text);
                if (txt_empleado.Text == "")
                    throw new Exception();

                int regreso = int.Parse(operador.ReturnValue("select id_user from tb_User where idemp = " + txt_empleado.Text));

                if (regreso > 0)
                {
                    operador.Id_operador = regreso;
                    this.Close();
                }
                else
                {
                    //if (!operador.Existe("select count(*) from tb_User where idemp = " + txt_empleado.Text.Trim()))
                    //{
                    //    operador.Crud("insert into tb_User (idemp) values('" + txt_empleado.Text.Trim() + "')");
                    //}
                    MessageBox.Show("No existe ese registro", "ERROR!");

                }

                con.Cerrar();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No existe ese registro", "ERROR!");
                con.Cerrar();
            }
            catch (Exception)
            {
                MessageBox.Show("Inserte un Operador!");
            }
        }

        private void Identificar_Operador_Load(object sender, EventArgs e)
        {

        }

        private void Txt_empleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_aceptar_Click(this, new EventArgs());
            }
        }
    }
}
