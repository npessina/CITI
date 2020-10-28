using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using CapaNegocios;

namespace CITI
{
    public partial class Frm_DocumentoIDComprador : Form
    {
        Funciones f = new Funciones();
        public Frm_DocumentoIDComprador()
        {
            InitializeComponent();
        }

        private void Frm_DocumentoIDComprador_Load(object sender, EventArgs e)
        {
            tablaDocumento.Rows.Clear();
            ArrayList lista = new ArrayList();
            lista = f.buscarDocumentoIDComprador();
            foreach (string[] s in lista)
            {
                tablaDocumento.Rows.Add(s);
            }
            tablaDocumento.AutoGenerateColumns = false;
            tablaDocumento.AutoResizeColumns();
        }

        private void tablaDocumento_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tablaDocumento.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    tablaDocumento.CurrentRow.Selected = true;
                    campoCodigo.Text = tablaDocumento.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
                    campoDescripcion.Text = tablaDocumento.Rows[e.RowIndex].Cells["Descripcion"].FormattedValue.ToString();
                    if (tablaDocumento.Rows[e.RowIndex].Cells["Baja"].FormattedValue.ToString() == "Si")
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
            catch (Exception)
            {
            }

        }

        private void botonEditar_Click_1(object sender, EventArgs e)
        {
            botonAceptar.Visible = true;
            botonCancelar.Visible = true;
            botonAlta.Visible = false;
            campoDescripcion.Enabled = true;
            bajaCheck.Enabled = true;
            tablaDocumento.Enabled = true;
        }

        private void botonAlta_Click_1(object sender, EventArgs e)
        {
            botonAceptar.Visible = true;
            botonCancelar.Visible = true;
            botonEditar.Visible = false;
            campoCodigo.Enabled = true;
            campoDescripcion.Enabled = true;
            tablaDocumento.Enabled = false;
            bajaCheck.Checked = false;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            tablaDocumento.Enabled = true;
            botonAceptar.Visible = false;
            botonCancelar.Visible = false;
            botonAlta.Visible = true;
            botonEditar.Visible = true;
            campoCodigo.Enabled = false;
            campoDescripcion.Enabled = false;
            bajaCheck.Enabled = false;
            bajaCheck.Checked = false;
        }

        private void botonAceptar_Click_1(object sender, EventArgs e)
        {
            String baja = "No";
            if (bajaCheck.Checked)
            {
                MessageBox.Show("Se esta por dar de baja este tipo de documento identificador del comprador", "Advertencia");
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
                        f.actualizarDocumentoIDComprador(campoCodigo.Text, campoDescripcion.Text, baja);
                        DesactivarCampos();
                    }
                    else
                    {
                        Boolean encontrado = f.verificarDocumentoIDComprador(campoCodigo.Text);
                        if (encontrado == false)
                        {
                            f.insertarDocumentoIDComprador(campoCodigo.Text, campoDescripcion.Text);
                            DesactivarCampos();
                        }
                        else
                        {
                            MessageBox.Show("El codigo del documento ya existe", "Error");
                        }
                    }
                    Frm_DocumentoIDComprador_Load(sender, e);
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
