using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Clipper_Project
{
    public partial class IdentificarOrden : Form
    {
        Conexion con = new Conexion();
        WorkOrder wo = new WorkOrder();
        Operador user = new Operador();
        public IdentificarOrden()
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
                wo.wo = txt_WO.Text;
                if (txt_WO.Text == "")
                    throw new Exception();

                wo.Id_approved = user.ReturnID("select id_user from tb_User where idemp = '" + txt_Approval.Text.Trim() + "' and admin = 1");
                //wo.Id_Cwo = wo.ReturnID("select id_wo from tb_wo where wo = '" + txt_WO.Text.Trim() + "'");
                wo.Comment = txt_WO.Text.Trim();


                //SqlCommand cmd = new SqlCommand("select id_wo from tb_wo where wo = '" + wo.wo + "'", con.Con1);
                //con.Abrir();
                //cmd.ExecuteNonQuery();
                //string regreso = cmd.ExecuteScalar().ToString();
                if (txt_WO.Text.Trim() != "")
                {
                    if (wo.Id_approved != 0)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Se necesita a ingeneria");
                        txt_Approval.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Llena toda la informacion!");
                    txt_WO.Text = "";
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
                MessageBox.Show("Inserte una orden");
            }
        }

        private void IdentificarOrden_Load(object sender, EventArgs e)
        {
            ActiveControl = txt_WO;
            txt_WO.Focus();
        }

        private void Txt_serial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_aceptar_Click(this, new EventArgs());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
