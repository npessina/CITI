using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using CapaNegocios;

namespace CITI
{
    public partial class Frm_CodigoOperacion : Form
    {
        Funciones f = new Funciones();
        public Frm_CodigoOperacion()
        {
            InitializeComponent();
        }

        private void Frm_CodigoOperacion_Load(object sender, EventArgs e)
        {
            tablaCodigoOperacion.Rows.Clear();
            ArrayList lista = new ArrayList();
            lista = f.buscarCodigoOperacion();
            foreach (string[] s in lista)
            {
                tablaCodigoOperacion.Rows.Add(s);
            }
            tablaCodigoOperacion.AutoGenerateColumns = false;
            tablaCodigoOperacion.AutoResizeColumns();
        }

        private void tablaCodigoOperacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tablaCodigoOperacion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    tablaCodigoOperacion.CurrentRow.Selected = true;
                    campoCodigo.Text = tablaCodigoOperacion.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
                    campoDescripcion.Text = tablaCodigoOperacion.Rows[e.RowIndex].Cells["Descripcion"].FormattedValue.ToString();
                    if (tablaCodigoOperacion.Rows[e.RowIndex].Cells["Baja"].FormattedValue.ToString() == "Si")
                    {
                        bajaCheck.Checked = true;
                    }
                    else
                    {
                        bajaCheck.Checked = false;
                    }
                    bajaCheck.Visible = true;
                    campoDescripcion.Enabled = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            botonAceptar.Visible = true;
            botonCancelar.Visible = true;
            botonAlta.Visible = false;
            campoDescripcion.Enabled = true;
            bajaCheck.Enabled = true;
            tablaCodigoOperacion.Enabled = true;
        }

        private void botonAlta_Click(object sender, EventArgs e)
        {
            botonAceptar.Visible = true;
            botonCancelar.Visible = true;
            botonEditar.Visible = false;
            campoCodigo.Enabled = true;
            campoDescripcion.Enabled = true;
            tablaCodigoOperacion.Enabled = false;
            bajaCheck.Checked = false;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            tablaCodigoOperacion.Enabled = true;
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
            String baja = "No";
            if (bajaCheck.Checked)
            {
                MessageBox.Show("Se esta por dar de baja este codigo de operacion", "Advertencia");
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
                        f.actualizarCodigoOperacion(campoCodigo.Text, campoDescripcion.Text, baja);
                        DesactivarCampos();
                    }
                    else
                    {
                        Boolean encontrado = f.verificarCodigoOperacion(campoCodigo.Text);
                        if (encontrado == false)
                        {
                            f.insertarCodigoOperacion(campoCodigo.Text, campoDescripcion.Text);
                            DesactivarCampos();
                        }
                        else
                        {
                            MessageBox.Show("El codigo de operacion ya existe", "Error");
                        }
                    }

                    Frm_CodigoOperacion_Load(sender, e);
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
