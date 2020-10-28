using CapaNegocios;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CITI
{
    public partial class Frm_TipoComprobantes : Form
    {
        Funciones f = new Funciones();

        public Frm_TipoComprobantes()
        {   
            InitializeComponent();
        }

        private void Frm_TipoComprobantes_Load(object sender, EventArgs e)
        {
            tablaTipoComprobante.Rows.Clear();
            ArrayList lista = new ArrayList();
            lista = f.buscarTipoComprobante();
            foreach (string[] s in lista)
            {
                tablaTipoComprobante.Rows.Add(s);
            }
            tablaTipoComprobante.AutoGenerateColumns = false;
            tablaTipoComprobante.AutoResizeColumns();
        }

        private void tablaTipoComprobante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tablaTipoComprobante.Rows[e.RowIndex] != null)
                {
                    tablaTipoComprobante.CurrentRow.Selected = true;
                    campoCodigo.Text = tablaTipoComprobante.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
                    campoDescripcion.Text = tablaTipoComprobante.Rows[e.RowIndex].Cells["Descripcion"].FormattedValue.ToString();
                    if (tablaTipoComprobante.Rows[e.RowIndex].Cells["Baja"].FormattedValue.ToString() == "Si")
                    {
                        bajaCheck.Checked = true;
                    }
                    else
                    {
                        bajaCheck.Checked = false;
                    }
                    bajaCheck.Visible = true;
                    campoCodigo.Enabled = false;
                }
            }
            catch (Exception){
            }

        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            botonAceptar.Visible = true;
            botonCancelar.Visible = true;
            botonAlta.Visible = false;
            campoDescripcion.Enabled = true;
            bajaCheck.Enabled = true;
            tablaTipoComprobante.Enabled = true;
        }

        private void botonAlta_Click(object sender, EventArgs e)
        {
            botonAceptar.Visible = true;
            botonCancelar.Visible = true;
            botonEditar.Visible = false;
            campoCodigo.Enabled = true;
            campoDescripcion.Enabled = true;
            tablaTipoComprobante.Enabled = false;
            bajaCheck.Checked = false;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            tablaTipoComprobante.Enabled = true;
            botonAceptar.Visible = false;
            botonCancelar.Visible = false;
            botonAlta.Visible = true;
            botonEditar.Visible = true;
            campoCodigo.Enabled = false;
            campoDescripcion.Enabled = false;
            bajaCheck.Enabled = false;
            bajaCheck.Checked = false;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            String baja="No";
            if (bajaCheck.Checked)
            {
                MessageBox.Show("Se esta por dar de baja este tipo de comprobante", "Advertencia");
                baja = "Si";
            }
            if (String.IsNullOrEmpty(campoCodigo.Text) || String.IsNullOrEmpty(campoDescripcion.Text))
            {
                MessageBox.Show("Hay campos vacios", "Error");
            }
            else
            {
                if (MessageBox.Show("¿Confirmar?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bajaCheck.Enabled == true)
                    {
                        f.actualizarTipoComprobante(campoCodigo.Text, campoDescripcion.Text, baja);
                        DesactivarCampos();
                    }
                    else
                    {
                        Boolean encontrado = f.verificarTipoComprobante(campoCodigo.Text);
                        if (encontrado == false)
                        {
                            f.insertarTipoComprobante(campoCodigo.Text, campoDescripcion.Text);
                            DesactivarCampos();
                        }
                        else
                        {
                            MessageBox.Show("El codigo del comprobante ya existe", "Error");
                        }
                    }
                    Frm_TipoComprobantes_Load(sender, e);
                }
            }
        }

        private void DesactivarCampos()
        {
            botonAceptar.Visible = false;
            botonCancelar.Visible = false;
            botonAlta.Visible = true;
            botonEditar.Visible = true;
            campoCodigo.Enabled = false;
            campoDescripcion.Enabled = false;
            bajaCheck.Enabled = false;
        }
    }


}
