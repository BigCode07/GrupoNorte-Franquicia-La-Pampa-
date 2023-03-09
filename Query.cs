using FullProgram;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace ChameleonProject
{
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        GrupoNorteEntities db = new GrupoNorteEntities();

        private void showMessage(string msg, int duration)
        {
            using (Timer t = new Timer())
            {
                Timer time = new Timer();
                time.Interval = duration;
                time.Tick += timeTick;  /* Evento enlazado */

                time.Start();

                /* Muestras el texto en el MB */
                MessageBox.Show(msg);
            }
        }
        private void timeTick(object sender, EventArgs e)
        {
            (sender as Timer).Stop();  /* Detiene el Timer */
            SendKeys.Send("{ESC}"); /* Hace la simulación de la tecla Escape, también puedes usar {ENTER} */
        }
        private void QueryData(object sender, EventArgs e)
        {
            UpdateData();
        }
        public void CallCarpeta()
        {
            var folder = db.Carpetas.ToList();
            cboCarpetas.DataSource = folder;
            CarpetaGrid.DataSource = folder;
            cboCarpetas.DisplayMember = "Nombre";
            CarpetaGrid.DisplayMember = "Nombre";
            cboCarpetas.ValueMember = "Id";
            CarpetaGrid.ValueMember = "Id";
            cboCarpetas.SelectedIndex = -1;
        }
        private void UpdateData()
        {

            dgv.Rows.Clear();

            IQueryable<Legajo> legajos = db.Legajos;



            if (txtCaja.Text != "")
            {
                int caja = Convert.ToInt32(txtCaja.Text);
                legajos = legajos.Where(a => a.Caja == caja);
            }

            if (txtLegajo.Text != "")
            {
                int legajo = Convert.ToInt32(txtLegajo.Text);
                legajos = legajos.Where(l => l.NroLegajo == legajo);
            }

            if (txtNombre.Text != "")
            {
                legajos = legajos.Where(l => l.ApellidoyNombre.Contains(txtNombre.Text));
            }

            if (txtDni.Text != "")
            {
                legajos = legajos.Where(l => l.DNI == txtDni.Text);
            }

            if (cboEstado.Text != "")
            {
                legajos = legajos.Where(l => l.Estado == cboEstado.Text);
            }

            if (cboCarpetas.Text != "")
            {
                legajos = legajos.Where(l => l.IdCarpetas == cboCarpetas.SelectedIndex);
            }

            if (txtUsuario.Text != "")
            {

                legajos = legajos.Where(l => l.Usuario == txtUsuario.Text);
            }

            if (mskFC.MaskCompleted == true)
            {
                DateTime fcarga = Convert.ToDateTime(mskFC.Text);
                legajos = legajos.Where(l => l.FechaCarga == fcarga);
            }

            if (mskFBaja.MaskCompleted == true)
            {
                DateTime fbaja = Convert.ToDateTime(mskFBaja.Text);
                legajos = legajos.Where(l => l.FechaBaja == fbaja);
            }
            if (legajos.Count() > 0)
            {

                foreach (var le in legajos.ToList())
                {
                    dgv.Rows.Add(le.Id, le.Caja, le.NroLegajo, le.ApellidoyNombre, le.DNI, le.Estado, le.IdCarpetas, le.Imagen, le.Usuario, le.FechaBaja, le.FechaCarga);
                }
            }
            else
            {
                showMessage("No hay registros", 1500);
            }


        }
        private void CallDgv(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MessageBox.Show("Seguro desea Eliminar este Registro?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        var reg = db.Legajos.Find(dgv.CurrentRow.Cells[0].Value);
                        db.Legajos.Remove(reg);
                        db.SaveChanges();
                        showMessage("Registro Eliminado", 1250);
                        UpdateData();

                    }
                    catch { MessageBox.Show("Error en la operacion, verifique o complete datos faltantes"); }
                }

            }


            if (dgv.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                if (MessageBox.Show("Seguro desea modificar este registro?", "Modificar?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        var hc = db.Legajos.Find(dgv.CurrentRow.Cells[0].Value);

                        if (dgv.CurrentRow.Cells[1].Value != null)
                        {
                            hc.Caja = Convert.ToInt32(dgv.CurrentRow.Cells[1].Value);
                        }

                        if (dgv.CurrentRow.Cells[2].Value != null)
                        {
                            hc.NroLegajo = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value.ToString());
                        }
                        if (dgv.CurrentRow.Cells[3].Value != null)
                        {
                            hc.ApellidoyNombre = dgv.CurrentRow.Cells[3].Value.ToString();
                        }
                        if (dgv.CurrentRow.Cells[4].Value != null)
                        {
                            hc.DNI = dgv.CurrentRow.Cells[4].Value.ToString();
                        }

                        if (dgv.CurrentRow.Cells[5].Value != null)
                        {
                            hc.Estado = dgv.CurrentRow.Cells[5].Value.ToString();
                        }

                        if (dgv.CurrentRow.Cells[6].Value != null)
                        {
                            hc.IdCarpetas = Convert.ToInt32(dgv.CurrentRow.Cells[6].Value.ToString());
                        }



                        

                       



                        db.SaveChanges();
                        showMessage("Registro Modificado", 1000);
                        UpdateData();

                    }
                    catch { MessageBox.Show("Error en la operacion, verifique o complete datos faltantes"); }
                }
            }
        }
        private void CallImage(object sender, DataGridViewCellEventArgs e)
        {
            axAcroPDF1.src = ConfigurationManager.AppSettings["Image"] + "\\" + dgv.CurrentRow.Cells["Imagen"].Value.ToString();
          
        }
        private void Desplace(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void DesplaceType(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }
        private void AllClear(object sender, EventArgs e)
        {

            txtCaja.Text = txtLegajo.Text = txtNombre.Text = txtDni.Text = cboCarpetas.Text = cboEstado.Text = txtUsuario.Text = mskFBaja.Text = mskFC.Text = "";
            dgv.Rows.Clear();
            txtCaja.Focus();

        }
        private void StartProgram(object sender, EventArgs e)
        {
            CallCarpeta();
            txtCaja.Focus();
        }
    }
}
