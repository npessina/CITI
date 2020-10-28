using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CapaNegocios;

namespace CITI
{
    public partial class Frm_Principal : Form
    {
        private String usuario;
        public Frm_Principal()
        {
            InitializeComponent();
        }

        public Frm_Principal(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void generarCITIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CITICompras frm = new Frm_CITICompras();
            frm.Show();
        }

        private void generarCITIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_CITIVentas frm = new Frm_CITIVentas();
            frm.Show();
        }

        private void tipoComprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TipoComprobantes frm = new Frm_TipoComprobantes();
            frm.Show();
        }

        private void documentoIDCompradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DocumentoIDComprador frm = new Frm_DocumentoIDComprador();
            frm.Show();
        }

        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Moneda frm = new Frm_Moneda();
            frm.Show();
        }

        private void códigoDeOperaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CodigoOperacion frm = new Frm_CodigoOperacion();
            frm.Show();
        }

        private void condiciónIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CondicionIVA frm = new Frm_CondicionIVA();
            frm.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AcercaDe frm = new Frm_AcercaDe();
            frm.Show();
        }
    }
}
