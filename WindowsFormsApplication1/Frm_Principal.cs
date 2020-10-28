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

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cITIComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_compras").SingleOrDefault();
            if (form1 != null)
            {
                form1.Select();
                form1.Show();
            }
            else
            {
                Frm_compras frm = new Frm_compras();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
