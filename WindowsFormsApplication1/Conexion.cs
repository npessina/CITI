using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CITI
{
    class Conexion
    {
        public void conectar()
        {
            try
            {
                MySqlConnection conect = new MySqlConnection();
                String cadena = "Server=localhost;User id = root;Database = citi;";
                conect.ConnectionString = cadena;
                MessageBox.Show("Conexion exitosa");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error," + ex);
            }
        }
    }
    
}
