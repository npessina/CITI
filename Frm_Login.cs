using System;
using System.Windows.Forms;
using CapaNegocios;

namespace CITI
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text.Trim();
                string contrasenia = txtContra.Text.Trim();
                Frm_Principal formulario = new Frm_Principal(usuario);
                formulario.Show();
                this.Hide();
            }
            catch (Exception)
            {
                Funciones.mError(this, "Error");
            }                
        }
    }
}
