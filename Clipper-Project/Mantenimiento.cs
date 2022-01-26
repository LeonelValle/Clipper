using System;
using System.Windows.Forms;

namespace Clipper_Project
{
    public partial class Mantenimiento : Form
    {
        WorkOrder wo = new WorkOrder();
        PN pn = new PN();
        Scan sc = new Scan();
        Box box = new Box();
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            //cb_PN.Items.Insert(0, "Part N#");
            //cb_PN.SelectedIndex = 0;
            cb_PN.DataSource = pn.LlenarComboBox("select * from tb_PN");
            cb_PN.DisplayMember = ("pn");
            cb_PN.ValueMember = ("id_pn");


        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (wo.Existe("select count(*) from tb_wo where wo = '" + txt_WOBuscar.Text.Trim() + "'"))
            {
                wo.Id_wo = (wo.ReturnID("select id_wo from tb_wo where wo = '" + txt_WOBuscar.Text + "'"));

                txt_qty.Text = wo.ReturnValue("select quantity from tb_wo where id_wo = '" + wo.Id_wo + "'");
                txt_modeloCaja.Text = wo.ReturnValue("select caja from tb_wo where id_wo = '" + wo.Id_wo + "'");
                cb_PN.SelectedValue = wo.ReturnValue("select id_pn from tb_wo where id_wo = '" + wo.Id_wo + "'");
                cb_Delphi.SelectedValue = wo.ReturnValue("select id_delphi from tb_wo where id_wo = '" + wo.Id_wo + "'");
            }
            else
            {
                MessageBox.Show("No existe esa WO");
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            wo.Crud("update tb_wo set quantity = '" + txt_qty.Text.Trim() + "', caja = '" + txt_modeloCaja.Text.Trim() + "', id_pn = '" + cb_PN.SelectedValue + "', id_delphi = '" + cb_Delphi.SelectedValue + "' where id_wo = '" + wo.Id_wo + "'");
            txt_modeloCaja.Text = "";
            txt_qty.Text = "";
            MessageBox.Show("Cambios guardados!");
            Mantenimiento_Load(sender, e);
        }

        private void cb_PN_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cb_Delphi.DataSource = null;
            cb_Delphi.Enabled = false;
            if (cb_PN.SelectedValue.ToString() != "0")
            {
                string sql = string.Format("Select del.id_delphi, del.delphi from tb_delphi del join tbU_PnDelphi pd on del.id_delphi = pd.id_delphi Where pd.id_pn = {0}", cb_PN.SelectedValue);
                cb_Delphi.DataSource = pn.LlenarComboBox(sql);
                cb_Delphi.DisplayMember = "delphi";
                cb_Delphi.ValueMember = "id_delphi";
                cb_Delphi.Enabled = true;
            }
        }

        private void btn_BorrarLbl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_lblMasterwork.Text.Trim()))
            {
                if (sc.Existe("select count(*) from tb_scan where label_masterwork = '" + txt_lblMasterwork.Text.Trim() + "'"))
                {
                    sc.Crud("delete tb_scan where label_masterwork = '" + txt_lblMasterwork.Text.Trim() + "'");
                }
            }
        }

        private void btn_BuscarCaja_Click(object sender, EventArgs e)
        {

            if (wo.Existe("select count(*) from tb_scan where label_masterwork = '" + txt_lblMasterworkBuscarCaja.Text.Trim() + "'"))
            {
                sc.id_scan = sc.ReturnID("select id_scan from tb_scan where label_masterwork = '" + txt_lblMasterworkBuscarCaja.Text.Trim() + "'");
                wo.Id_wo = (wo.ReturnID("select id_wo from tb_scan where label_masterwork = '" + txt_lblMasterworkBuscarCaja.Text + "'"));
                box.Id_box = (wo.ReturnID("select box from tb_scan where label_masterwork = '" + txt_lblMasterworkBuscarCaja.Text + "'"));


                cb_caja.DataSource = pn.LlenarComboBox("select distinct box.id_box, box.box from tb_scan sc join tb_box box on box.id_box = sc.box join tb_wo wo on wo.id_wo = sc.id_wo where wo.id_wo = '" + wo.Id_wo + "' order by box.id_box asc ");
                cb_caja.DisplayMember = ("box");
                cb_caja.ValueMember = ("id_box");

                cb_caja.SelectedValue = wo.ReturnValue("select id_box from tb_wo where id_wo = '" + wo.Id_wo + "'");
            }
            else
            {
                MessageBox.Show("No existe esa WO");
            }


        }

        private void btn_GuardarCaja_Click(object sender, EventArgs e)
        {
            if (cb_caja.Text != "")
            {

                sc.Crud("update tb_scan set box = '" + cb_caja.SelectedValue + "' where id_scan = '" + sc.id_scan + "'");
                MessageBox.Show("Cambios Realizado!");
                Mantenimiento_Load(sender, e);
            }
            else
                MessageBox.Show("Seleccione una Caja");
        }

        private void btn_GuardarPN_Click(object sender, EventArgs e)
        {
            if (pn.Existe("select count(*) from tb_pn where pn = '" + txt_pn.Text.Trim() + "'"))
            {
                pn.id_pn = pn.ReturnID("insert into tb_pn values('" + txt_pn.Text.Trim() + "','" + txt_pnqty.Text.Trim() + "'); SELECT SCOPE_IDENTITY();");
                if (cb_pnDelphi.Text != "")
                {
                    pn.Crud("insert into tbU_PnDelphi values('" + pn.id_pn + "','" + cb_pnDelphi.SelectedValue + "')");

                }
                MessageBox.Show("N# Parte Guardado!");
            }
            else
                MessageBox.Show("N# Parte ya existe!");
        }
    }
}
