using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Clipper_Project
{
    public partial class Form1 : Form
    {
        WorkOrder wo = new WorkOrder();
        public Form1()
        {
            InitializeComponent();
        }
        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dg_Inprocess.DataSource = wo.LlenarDG("select wo, qty, rev from tb_WO").Tables[0];
        }

        private void btn_WO_Click(object sender, EventArgs e)
        {
            WO no = new WO();

            Form NuevaOrden;
            if ((NuevaOrden = IsFormAlreadyOpen(typeof(WO))) == null)
            {
                no.ShowDialog(this);
            }

            else
            {
                NuevaOrden.WindowState = FormWindowState.Normal;
                NuevaOrden.BringToFront();
            }

        }

        private void btn_Scanning_Click(object sender, EventArgs e)
        {
            //FindWO no = new FindWO();
            ScanOne so = new ScanOne();

            Form NuevaOrden;
            if ((NuevaOrden = IsFormAlreadyOpen(typeof(ScanOne))) == null)
            {
                so.ShowDialog(this);
            }

            else
            {
                NuevaOrden.WindowState = FormWindowState.Normal;
                NuevaOrden.BringToFront();
            }
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            //Reports no = new Reports();

            //Form NuevaOrden;
            //if ((NuevaOrden = IsFormAlreadyOpen(typeof(Reports))) == null)
            //{
            //    no.ShowDialog(this);
            //}

            //else
            //{
            //    NuevaOrden.WindowState = FormWindowState.Normal;
            //    NuevaOrden.BringToFront();
            //}
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
