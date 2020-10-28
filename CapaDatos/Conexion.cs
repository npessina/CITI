using System;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Conexion
    {
        public SqlCommand comando;
        public SqlConnection conexion;

        public Conexion()
        {
            //string nico "data source=User-PC; initial catalog=Citi2; Integrated Security=True"
            //string rober "Data Source= USUARIO-PC\\SQLEXPRESS; Initial Catalog=Citi2; Integrated Security=SSPI;"
            //string mati "Data Source= MATIASS-PC\\SQLEXPRESS;  Initial Catalog=Citi2; user=sa ; password= whitebox-32"
            string ConnectionString = "data source=User-PC; initial catalog=Citi2; Integrated Security=True";
            conexion = new SqlConnection(ConnectionString);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandTimeout = 0;
        }

        public void open()
        {
            conexion.Open();
        }

        public void close()
        {
            conexion.Close();
        }

        public void setQuery(String query)
        {
            comando.CommandText = query;
        }

        public void setType()
        {
            comando.CommandType = CommandType.Text;
        }
    }


}
