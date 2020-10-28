using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using CapaNegocios;

namespace CITI
{
    public partial class Frm_CondicionIVA : Form
    {
        Funciones f = new Funciones();
        public Frm_CondicionIVA()
        {
            InitializeComponent();
        }

        private void Frm_CondicionIVA_Load(object sender, EventArgs e)
        {
            tablaCondicionIVA.Rows.Clear();
            ArrayList lista = new ArrayList();
            lista = f.buscarCondicionIVA();
            foreach (string[] s in lista)
            {
                tablaCondicionIVA.Rows.Add(s);
            }
            tablaCondicionIVA.AutoGenerateColumns = false;
            tablaCondicionIVA.AutoResizeColumns();
        }

        private void tablaCondicionIVA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tablaCondicionIVA.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    tablaCondicionIVA.CurrentRow.Selected = true;
                    campoCodigo.Text = tablaCondicionIVA.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
                    campoDescripcion.Text = tablaCondicionIVA.Rows[e.RowIndex].Cells["Descripcion"].FormattedValue.ToString();
                    if (tablaCondicionIVA.Rows[e.RowIndex].Cells["Baja"].FormattedValue.ToString() == "Si")
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

        private void botonEditar_Click(object sender, EventArgs e)
        {
            botonAceptar.Visible = true;
            botonCancelar.Visible = true;
            botonAlta.Visible = false;
            campoDescripcion.Enabled = true;
            bajaCheck.Enabled = true;
            tablaCondicionIVA.Enabled = true;
        }

        private void botonAlta_Click(object sender, EventArgs e)
        {
            botonAceptar.Visible = true;
            botonCancelar.Visible = true;
            botonEditar.Visible = false;
            campoCodigo.Enabled = true;
            campoDescripcion.Enabled = true;
            tablaCondicionIVA.Enabled = false;
            bajaCheck.Checked = false;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            tablaCondicionIVA.Enabled = true;
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
                MessageBox.Show("Se esta por dar de baja esta condicion de IVA", "Advertencia");
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
                        f.actualizarCondicionIVA(campoCodigo.Text, campoDescripcion.Text, baja);
                        DesactivarCampos();
                    }
                    else
                    {
                        Boolean encontrado = f.verificarCondicionIVA(campoCodigo.Text);
                        if (encontrado == false)
                        {
                            f.insertarCondicionIVA(campoCodigo.Text, campoDescripcion.Text);
                            DesactivarCampos();
                        }
                        else
                        {
                            MessageBox.Show("El codigo de condicion de IVA ya existe", "Error");
                        }
                    }
                    Frm_CondicionIVA_Load(sender, e);
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
