using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocios;
using System.Collections;

namespace CITI
{
    public partial class Frm_Moneda : Form
    {
        Funciones f = new Funciones();
        public Frm_Moneda()
        {
            InitializeComponent();
        }

        private void Frm_Moneda_Load(object sender, EventArgs e)
        {
            tablaMoneda.Rows.Clear();
            ArrayList lista = new ArrayList();
            lista = f.buscarMoneda();
            foreach (string[] s in lista)
            {
                tablaMoneda.Rows.Add(s);
            }
            tablaMoneda.AutoGenerateColumns = false;
            tablaMoneda.AutoResizeColumns();
        }

        private void tablaMoneda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tablaMoneda.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    tablaMoneda.CurrentRow.Selected = true;
                    campoCodigo.Text = tablaMoneda.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
                    campoMoneda.Text = tablaMoneda.Rows[e.RowIndex].Cells["Moneda"].FormattedValue.ToString();
                    if (tablaMoneda.Rows[e.RowIndex].Cells["Baja"].FormattedValue.ToString() == "Si")
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
            campoMoneda.Enabled = true;
            bajaCheck.Enabled = true;
            tablaMoneda.Enabled = true;
        }

        private void botonAlta_Click(object sender, EventArgs e)
        {
            botonAceptar.Visible = true;
            botonCancelar.Visible = true;
            botonEditar.Visible = false;
            campoCodigo.Enabled = true;
            campoMoneda.Enabled = true;
            tablaMoneda.Enabled = false;
            bajaCheck.Checked = false;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            tablaMoneda.Enabled = true;
            botonAceptar.Visible = false;
            botonCancelar.Visible = false;
            botonAlta.Visible = true;
            botonEditar.Visible = true;
            campoCodigo.Enabled = false;
            campoMoneda.Enabled = false;
            bajaCheck.Enabled = false;
            bajaCheck.Checked = false;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            String baja = "No";
            if (bajaCheck.Checked)
            {
                MessageBox.Show("Se esta por dar de baja este tipo de moneda", "Advertencia");
                baja = "Si";
            }
            if (String.IsNullOrEmpty(campoCodigo.Text) || String.IsNullOrEmpty(campoMoneda.Text))
            {
                MessageBox.Show("Hay campos vacios", "Error");
            }
            else
            {
                if (MessageBox.Show("¿Confirmar?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bajaCheck.Enabled == true)
                    {
                        f.actualizarMoneda(campoCodigo.Text, campoMoneda.Text, baja);
                        DesactivarCampos();
                    }
                    else
                    {
                        Boolean encontrado = f.verificarMoneda(campoCodigo.Text);
                        if (encontrado == false)
                        {
                            f.insertarMoneda(campoCodigo.Text, campoMoneda.Text);
                            DesactivarCampos();
                        }
                        else
                        {
                            MessageBox.Show("El codigo de operacion ya existe", "Error");
                        }
                    }

                    Frm_Moneda_Load(sender, e);
         
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
            campoMoneda.Enabled = false;
            bajaCheck.Enabled = false;
        }
    }
}
