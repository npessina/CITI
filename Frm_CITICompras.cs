using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocios;
using System.Collections;

namespace CITI
{
    public partial class Frm_CITICompras : Form
    {
        Funciones f = new Funciones();
        private DataTable dtbl = new DataTable();
        public Frm_CITICompras()
        {
            InitializeComponent();
            seleccionMes.Format = DateTimePickerFormat.Custom;
            seleccionMes.CustomFormat = "MM/yyyy";
            tablaDatos.AllowUserToAddRows = false;
            btnGenerarArchivo.Enabled = false;
            seleccion.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tablaDatos.Rows.Clear();
            ArrayList lista = new ArrayList();
            lista = f.buscarComprobantesCompras(seleccionMes.Value);

            foreach (string[] s in lista)
            {
                tablaDatos.Rows.Add(s);
            }

            seleccion.Enabled = true;
        }

        private void btnGenerarArchivo_Click(object sender, EventArgs e)
        {
            int selec = seleccion.SelectedIndex;
            if (selec == 0)
            {
                f.mostrartxtCabecera(seleccionMes.Value);
            }
            else
            {
                f.mostrartxtAlicuota(seleccionMes.Value);
            }
        }
        
        private void seleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGenerarArchivo.Enabled = true;
        }
    }
}
