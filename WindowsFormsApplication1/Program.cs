﻿using System;
using System.Windows.Forms;

namespace CITI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_login());
            Conexion c = new Conexion();
            c.conectar();
        }
    }
}
