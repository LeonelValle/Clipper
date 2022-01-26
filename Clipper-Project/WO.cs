using System;
using System.Windows.Forms;

namespace Clipper_Project
{
    public partial class WO : Form
    {
        WorkOrder wo = new WorkOrder();
        PN pn = new PN();

        public WO()
        {
            InitializeComponent();
        }

        private void WO_Load(object sender, EventArgs e)
        {
            dg_WO.DataSource = wo.LlenarDG("Select wo, qty, rev from tb_WO").Tables[0];

            cb_PN.DataSource = pn.LlenarComboBox("select * from tb_PN");
            cb_PN.DisplayMember = ("pn");
            cb_PN.ValueMember = ("id_pn");
            cb_PN.SelectedIndex = -1;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Qty.Text) && !string.IsNullOrEmpty(txt_WO.Text) && !string.IsNullOrEmpty(txt_Rev.Text) && cb_PN.SelectedIndex != -1)
            {
                if (!wo.Existe("select * from tb_WO where wo = '" + txt_WO.Text + "'"))
                {
                    wo.Crud("insert into tb_WO(wo, qty, rev, datecreated, id_pn) values('" + txt_WO.Text + "','" + txt_Qty.Text + "','" + txt_Rev.Text + "','" + DateTime.Now + "','" + cb_PN.SelectedValue + "')");
                    MessageBox.Show("WO Saved!");
                    WO_Load(sender, e);
                    ClearTextboxes();
                    cb_PN.SelectedIndex = -1;
                }
                else
                    MessageBox.Show("WO already exist!");
            }
            else
                MessageBox.Show("Fill all data!");
        }

        void ClearTextboxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);

        }
    }
}
