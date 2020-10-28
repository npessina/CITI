using System;
using System.Windows.Forms;

namespace CapaNegocios
{
    public class Funciones
    {
        public static void mError(Form actual, String mensaje)
        {
            MessageBox.Show(actual, mensaje);
        }
    }
}
