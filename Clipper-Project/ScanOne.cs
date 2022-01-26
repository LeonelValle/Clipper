using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Clipper_Project
{
    public partial class ScanOne : Form
    {
        Scan scan = new Scan();
        PN pn = new PN();
        WorkOrder wo = new WorkOrder();
        Box box = new Box();
        Operador op = new Operador();

        public ScanOne()
        {
            InitializeComponent();
        }

        private void ScanOne_Load(object sender, EventArgs e)
        {
            #region
            //box.TopBox = int.Parse(box.ReturnValue("select BoxSize from Config where id = 1"));
            //box.CountBox = int.Parse(box.ReturnValue("select count(*) from tb_scan sc join tb_box box on sc.box = box.id_box where id_wo = '" + wo.Id_wo + "'"));
            //box.Id_box = int.Parse(box.ReturnValue("select box.id_box from tb_wo wo join tb_box box on wo.id_box = box.id_box where id_wo = '" + wo.Id_wo + "'"));
            #endregion

            cb_PN.Items.Insert(0, "Part N#");
            cb_PN.SelectedIndex = 0;
            cb_PN.DataSource = pn.LlenarComboBox("select * from tb_PN");
            cb_PN.DisplayMember = ("pn");
            cb_PN.ValueMember = ("id_pn");

            txt_lblBox.Enabled = false;
            txt_lblDelphi.Enabled = false;
            txt_lblMasterwork.Enabled = false;

            txt_WO.Focus();

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

        private void btn_Comenzar_Click(object sender, EventArgs e)
        {
            StartWO();

        }

        private void StartWO()
        {

            if (wo.Id_wo != 0 && btn_Comenzar.Text == "Nueva Orden")
            {
                txt_Caja.Text = "";
                txt_WO.Text = "";
                txt_Cantidad.Text = "";
                txt_lblBox.Text = "";
                txt_lblDelphi.Text = "";
                txt_lblMasterwork.Text = "";
                cb_PN.SelectedIndex = -1;
                cb_Delphi.SelectedIndex = -1;

                txt_Caja.Enabled = true;
                txt_WO.Enabled = true;
                txt_Cantidad.Enabled = true;
                txt_lblBox.Enabled = false;
                txt_lblMasterwork.Enabled = false;
                txt_lblDelphi.Enabled = false;
                cb_PN.Enabled = true;
                cb_Delphi.Enabled = true;
                dg_Scan.DataSource = null;
                btn_Comenzar.Text = "Comenzar";
                txt_WO.Focus();
                return;
            }
            if (WorkOrderExist() == true)
            {

                txt_Caja.Enabled = false;
                txt_WO.Enabled = false;
                txt_Cantidad.Enabled = false;
                cb_PN.Enabled = false;
                cb_Delphi.Enabled = false;
                btn_Comenzar.Text = "Nueva Orden";

                if ((int)cb_Delphi.SelectedValue == 0)
                    txt_lblDelphi.Enabled = false;

                box.Id_box = int.Parse(box.ReturnValue("select box.id_box from tb_wo wo join tb_box box on wo.id_box = box.id_box where id_wo = '" + wo.Id_wo + "'"));


                txt_lblMasterwork.Focus();

            }
            else if (!string.IsNullOrEmpty(txt_WO.Text) || !string.IsNullOrEmpty(txt_Caja.Text) || cb_Delphi.SelectedIndex > 0 || cb_PN.SelectedIndex > 0 || !string.IsNullOrEmpty(txt_Cantidad.Text))
            {
                if (!wo.Existe("select count(*) from tb_wo where wo ='" + txt_WO.Text.Trim() + "'"))
                {
                    if ((int)cb_Delphi.SelectedValue == 0)
                    {
                        wo.Id_delphi = "";
                        txt_lblDelphi.Enabled = false;
                    }
                    else
                        wo.Id_delphi = cb_Delphi.SelectedValue.ToString();
                    //CreateBoxes();
                    wo.Id_wo = (wo.ReturnID("insert into tb_wo(wo, caja, dataReg, id_pn, quantity, id_delphi) values('" + txt_WO.Text.Trim() + "','" + txt_Caja.Text.Trim() + "','" +
                        DateTime.Now + "','" + cb_PN.SelectedValue + "','" + txt_Cantidad.Text.Trim() + "','" + wo.Id_delphi + "'); SELECT SCOPE_IDENTITY();"));

                    txt_Caja.Enabled = false;
                    txt_WO.Enabled = false;
                    cb_PN.Enabled = false;
                    cb_Delphi.Enabled = false;

                    btn_Comenzar.Text = "Nueva Orden";

                    txt_lblBox.Enabled = true;
                    txt_lblDelphi.Enabled = true;
                    txt_lblMasterwork.Enabled = true;

                    if ((int)cb_Delphi.SelectedValue == 0)
                        txt_lblDelphi.Enabled = false;

                    txt_lblMasterwork.Focus();

                    IdentifyEmp();

                }
            }
            else
                MessageBox.Show("No deje informacion vacia!", "Error!");

            txt_lblMasterwork.Focus();
        }

        private void txt_lblBox_Leave(object sender, EventArgs e)
        {
            //SendData();
        }

        private bool WorkOrderExist()
        {
            bool Exist = false;
            if (wo.Existe("select count(*) from tb_wo where wo = '" + txt_WO.Text.Trim() + "'"))
            {
                wo.Id_wo = (wo.ReturnID("select id_wo from tb_wo where wo = '" + txt_WO.Text + "'"));

                txt_Cantidad.Text = wo.ReturnValue("select quantity from tb_wo where id_wo = '" + wo.Id_wo + "'");
                txt_Caja.Text = wo.ReturnValue("select caja from tb_wo where id_wo = '" + wo.Id_wo + "'");
                cb_PN.SelectedValue = wo.ReturnValue("select id_pn from tb_wo where id_wo = '" + wo.Id_wo + "'");
                cb_Delphi.SelectedValue = wo.ReturnValue("select id_delphi from tb_wo where id_wo = '" + wo.Id_wo + "'");

                //CreateBoxes();

                txt_Caja.Enabled = false;
                txt_WO.Enabled = false;
                txt_Cantidad.Enabled = false;
                cb_PN.Enabled = false;
                cb_Delphi.Enabled = false;

                txt_lblDelphi.Enabled = true;
                txt_lblBox.Enabled = true;
                txt_lblMasterwork.Enabled = true;

                IdentifyEmp();

                ReloadGV();



                Exist = true;
            }

            return Exist;
        }

        private void ReloadGV()
        {
            dg_Scan.DataSource = wo.LlenarDG("select sc.label_masterwork, sc.label_delphi, sc.label_box, wo.wo, RIGHT(sc.label_masterwork,4) as Serial, sc.regdate, us.idemp,box.box, comment from tb_scan sc join tb_wo wo on sc.id_wo = wo.id_wo join tb_pn pn on pn.id_pn = wo.id_pn join tb_box box on sc.box = box.id_box join tb_User us on us.id_user = sc.id_user where wo.id_wo = '" + wo.Id_wo + "'").Tables[0];

            ColorRows();

            lbl_ActualBox.Visible = true;
            lbl_ActualBoxDesc.Visible = true;

            lbl_CajasPiezas.Visible = true;
            lbl_CajaPiezasDesc.Visible = true;

            lbl_Totalrecords.Visible = true;
            lbl_TotalrecordsDesc.Visible = true;
            lbl_BoxQty.Visible = true;

            lbl_BoxQty.Text = box.ReturnValue("select qty from tb_pn pn join tb_wo wo on wo.id_pn = pn.id_pn where id_wo = '" + wo.Id_wo + "'");

            //box.CountBox = int.Parse(box.ReturnValue("select COUNT(*) from tb_scan sc join tb_box box on sc.box = box.id_box join tb_wo wo on wo.id_box = box.id_box where sc.id_wo = 27 '" + box.Id_box + "'"));
            box.Id_box = wo.ReturnID("select id_box from tb_wo where id_wo = '" + wo.Id_wo + "'");
            lbl_ActualBox.Text = box.ReturnValue("select box.box from tb_wo wo join tb_box box on box.id_box = wo.id_box where wo.id_wo = " + wo.Id_wo);
            lbl_CajasPiezas.Text = box.ReturnValue("select COUNT(*) from tb_scan sc join tb_box box on sc.box = box.id_box join tb_wo wo on wo.id_box = box.id_box where sc.id_wo = '" + wo.Id_wo + "' and sc.box = '" + box.Id_box + "'");
            //lbl_CajasPiezas.Text = box.CountBox.ToString();
            lbl_Totalrecords.Text = box.ReturnValue("select count(*) from tb_scan where id_wo = " + wo.Id_wo);

        }

        private void cb_PN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
            catch (System.NullReferenceException) { }
            catch (System.Data.SqlClient.SqlException) { }

            //System.NullReferenceException
        }

        private void SendData()
        {
            //string lbl1 = txt_lblDelphi.Text.Trim().Substring(1, 8);
            //string lbl2 = txt_lblMasterwork.Text.Substring(0, 9);
            CreateBoxes();
            //string test = txt_lblMasterwork.Text.Substring(10, 7);

            if (!string.IsNullOrEmpty(txt_lblBox.Text) && (!string.IsNullOrEmpty(txt_lblDelphi.Text) || txt_lblDelphi.Enabled == false) && !string.IsNullOrEmpty(txt_lblMasterwork.Text))
            {
                //validate PN lbl to WO
                if (txt_lblMasterwork.Text.Substring(0, 9) == cb_PN.Text.Trim() || txt_lblMasterwork.Text.Substring(0, 10) == cb_PN.Text.Trim() || scan.combine == true)
                //if (lbl == cb_PN.Text)
                {
                    //validate WO lbl to WO
                    if (txt_lblMasterwork.Text.Substring(9, 7) == txt_WO.Text.Trim() || txt_lblMasterwork.Text.Substring(10, 7) == txt_WO.Text.Trim() || scan.combine == true)
                    {
                        // Validate PN Delphi to WO
                        if (txt_lblDelphi.Enabled == false || txt_lblDelphi.Text.Trim().Substring(0, 8) == cb_Delphi.Text || scan.combine == true)
                        {
                            //Validate Packing lbl Box to PN
                            if (txt_lblBox.Text.Trim() == txt_Caja.Text.Trim() || scan.combine == true)
                            {

                                if (Duplicates() == 0)
                                {
                                    scan.Crud("insert into tb_scan (label_masterwork, label_delphi, label_box, regdate, id_wo, box, id_user, approved, comment) values('" + txt_lblMasterwork.Text.Trim() + "','" + txt_lblDelphi.Text.Trim() + "','" + txt_lblBox.Text.Trim() + "','" + DateTime.Now + "','" + wo.Id_wo + "','" + box.Id_box + "','" + op.Id_operador + "','" + wo.Id_approved + "','" + wo.Comment + "')");
                                    txt_lblBox.Text = "";
                                    txt_lblDelphi.Text = "";
                                    txt_lblMasterwork.Text = "";

                                    pb_Delphi.Image = Clipper_Project.Properties.Resources.great;
                                    pb_pn.Image = Clipper_Project.Properties.Resources.great;
                                    pb_wo.Image = Clipper_Project.Properties.Resources.great;

                                    ReloadGV();
                                }
                                else if (Duplicates() == 1)
                                    MessageBox.Show("Serial Masterwork Duplicado!");
                                else if (Duplicates() == 2)
                                    MessageBox.Show("Serial Delphi Duplicado!");

                            }
                            else
                                MessageBox.Show("Label Box!");

                        }
                        else
                        {
                            MessageBox.Show("Numero De Parte Delphi!");
                            pb_Delphi.Image = Clipper_Project.Properties.Resources.bad;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Numero Orden!");
                        pb_wo.Image = Clipper_Project.Properties.Resources.bad;
                    }

                }
                else
                {
                    MessageBox.Show("Numero De Parte!");
                    pb_pn.Image = Clipper_Project.Properties.Resources.bad;
                }
            }
            else
                MessageBox.Show("Campos Vacios!");

            txt_lblBox.Text = "";
            txt_lblDelphi.Text = "";
            txt_lblMasterwork.Text = "";
            txt_lblMasterwork.Focus();
        }
        /// <summary>
        /// Label Masterwork = 1
        /// Label Delphi = 2
        /// </summary>
        /// <returns></returns>
        private int Duplicates()
        {
            int isDup = 0;

            if (scan.Existe("select count(*) from tb_scan where label_masterwork = '" + txt_lblMasterwork.Text.Trim() + "'"))
            {
                isDup = 1;
            }
            if (txt_lblDelphi.Enabled == true && scan.Existe("select count(*) from tb_scan where label_delphi = '" + txt_lblDelphi.Text.Trim() + "'"))
            {
                isDup = 2;
            }

            return isDup;
        }

        private void CreateBoxes()
        {
            //box.Id_box = int.Parse(box.ReturnValue("select box.id_box from tb_wo wo join tb_box box on wo.id_box = box.id_box where id_wo = '" + wo.Id_wo + "'"));
            //box.TopBox = int.Parse(box.ReturnValue("select BoxSize from Config where id = 1"));

            box.TopBox = int.Parse(box.ReturnValue("select qty from tb_pn pn join tb_wo wo on wo.id_pn = pn.id_pn where id_wo = '" + wo.Id_wo + "'"));

            box.CountBox = int.Parse(box.ReturnValue("select count(sc.id_scan) from tb_scan sc join tb_box box on sc.box = box.id_box where box.id_box = '" + box.Id_box + "'"));

            lbl_BoxQty.Text = box.TopBox.ToString();

            //insert box if the WO is NEW
            if (box.CountBox == 0 && box.Id_box == 0)
            {
                box.Id_box = box.ReturnID("insert into tb_box values(1); SELECT SCOPE_IDENTITY();");
                box.Crud("update tb_wo set id_box = '" + box.Id_box + "' where id_wo = '" + wo.Id_wo + "'");
                ReloadGV();
            }
            //insert new box if it was full 
            else if (box.CountBox >= box.TopBox)
            {
                box.Boxes = box.ReturnID("select top 1 box.box from tb_scan sc join tb_box box on sc.box = box.id_box where sc.id_wo = '" + wo.Id_wo + "' order by id_box desc");

                box.Boxes++;

                box.Id_box = box.ReturnID("insert into tb_box values('" + box.Boxes + "'); SELECT SCOPE_IDENTITY();");
                box.Crud("update tb_wo set id_box = '" + box.Id_box + "' where id_wo = '" + wo.Id_wo + "'");

                wo.Comment = "";
                wo.Id_approved = 0;
                scan.combine = false;

                ReloadGV();
            }
            else
            {
                box.Boxes = int.Parse(box.ReturnValue("select box.box from tb_wo wo join tb_box box on wo.id_box = box.id_box where id_wo = '" + wo.Id_wo + "'"));

            }

        }

        private void txt_lblBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendData();
            }
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            if (dg_Scan.Rows.Count != 0)
                SaveToCSV(dg_Scan);

            else
                MessageBox.Show("Realize una busqueda", "ERROR!");

        }

        private void SaveToCSV(DataGridView DGV)
        {
            SaveFileDialog dlGuardar = new SaveFileDialog
            {
                Filter = "Fichero CSV (*.csv)|*.csv",
                FileName = "",
                Title = "Exportar a CSV"
            };
            if (dlGuardar.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvMemoria = new StringBuilder();

                //para los títulos de las columnas, encabezado
                for (int i = 0; i < DGV.Columns.Count; i++)
                {
                    if (i == DGV.Columns.Count - 1)
                    {
                        csvMemoria.Append(String.Format("\"{0}\"",
                            DGV.Columns[i].HeaderText));
                    }
                    else
                    {
                        csvMemoria.Append(String.Format("\"{0}\",",
                            DGV.Columns[i].HeaderText));
                    }
                }

                csvMemoria.AppendLine();


                for (int m = 0; m < DGV.Rows.Count; m++)
                {
                    for (int n = 0; n < DGV.Columns.Count; n++)
                    {
                        //si es la última columna no poner el ;
                        if (n == DGV.Columns.Count - 1)
                        {
                            csvMemoria.Append(String.Format("\"{0}\"", DGV.Rows[m].Cells[n].Value, @"\d+"));
                        }
                        else
                        {
                            csvMemoria.Append(String.Format("\"{0}\",", DGV.Rows[m].Cells[n].Value, @"\d+"));
                        }

                    }
                    csvMemoria.AppendLine();
                }
                System.IO.StreamWriter sw = new System.IO.StreamWriter(dlGuardar.FileName, false, System.Text.Encoding.Default);
                sw.Write(csvMemoria.ToString());
                sw.Close();
            }
        }

        private void IdentifyEmp()
        {
            Identificar_Operador emp = new Identificar_Operador();
            Form pass;

            if ((pass = IsFormAlreadyOpen(typeof(Identificar_Operador))) == null)
            {
                emp.ShowDialog(this);
            }

            else
            {
                emp.WindowState = FormWindowState.Normal;
                emp.BringToFront();
            }
        }
        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }

        private void btn_NewBox_Click(object sender, EventArgs e)
        {
            box.CountBox = int.Parse(box.ReturnValue("select count(*) from tb_scan sc join tb_box box on sc.box = box.id_box where sc.box = '" + box.Id_box + "'"));

            box.Boxes = box.ReturnID("select top 1 box.box from tb_scan sc join tb_box box on sc.box = box.id_box where sc.id_wo = '" + wo.Id_wo + "' order by id_box desc");

            box.Boxes++;

            box.Id_box = box.ReturnID("insert into tb_box values('" + box.Boxes + "'); SELECT SCOPE_IDENTITY();");

            box.Crud("update tb_wo set id_box = '" + box.Id_box + "' where id_wo = '" + wo.Id_wo + "'");

            wo.Comment = "";
            wo.Id_approved = 0;


            ReloadGV();
        }

        private void btn_Combine_Click(object sender, EventArgs e)
        {
            IdentifyWO();
            scan.combine = true;
        }

        private void IdentifyWO()
        {
            IdentificarOrden iwo = new IdentificarOrden();
            Form pass;

            if ((pass = IsFormAlreadyOpen(typeof(IdentificarOrden))) == null)
            {
                iwo.ShowDialog(this);
            }

            else
            {
                iwo.WindowState = FormWindowState.Normal;
                iwo.BringToFront();
            }
        }

        private void ColorRows()
        {
            foreach (DataGridViewRow row in dg_Scan.Rows)
            {
                if (row.Cells[8].Value.ToString() != "")
                {
                    //int value = Convert.ToInt32(row.Cells[0].Value);
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }

        }

        private Color GetColor(int value)
        {
            Color c = new Color();
            if (value == 0)
                c = Color.Red;
            return c;
        }

        private void dg_Scan_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ColorRows();

            dg_Scan.ClearSelection();//If you want

            int nRowIndex = dg_Scan.Rows.Count - 1;
            int nColumnIndex = 3;

            dg_Scan.Rows[nRowIndex].Selected = true;
            dg_Scan.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

            //In case if you want to scroll down as well.
            dg_Scan.FirstDisplayedScrollingRowIndex = nRowIndex;
        }

        private void txt_lblBox_Leave_1(object sender, EventArgs e)
        {
            SendData();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_manto_Click(object sender, EventArgs e)
        {
            Mantenimiento manto = new Mantenimiento();
            manto.Show();
        }
    }
}
