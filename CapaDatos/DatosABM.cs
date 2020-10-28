using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosABM
    {
        Conexion conexion = new Conexion();
        SqlDataReader dr;

        public ArrayList buscarCodigoOperacion()
        {
            ArrayList lista = new ArrayList();
            string query = "SELECT * FROM Codigo_operacion";

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();

                dr = conexion.comando.ExecuteReader();
                while (dr.Read())
                {
                    string[] datos = { dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString() };
                    lista.Add(datos);
                }

                dr.Close();
                conexion.close();
            }

            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }

            return lista;
        }

        public void actualizarCodigoOperacion(string codigo, string descripcion, string baja)
        {
            string query = "UPDATE Codigo_operacion SET Baja=@baja, Descripcion=@descripcion WHERE Codigo=@codigo";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@codigo", codigo);
            conexion.comando.Parameters.AddWithValue("@descripcion", descripcion);
            conexion.comando.Parameters.AddWithValue("@baja", baja);
            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();
                conexion.comando.ExecuteNonQuery();
                conexion.close();
            }
            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }
        }

        public bool verificarCodigoOperacion(string codigo)
        {
            bool encontrado = false;
            string query = "Select * From Codigo_operacion Where Codigo=@codigo";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@codigo", codigo);

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();

                dr = conexion.comando.ExecuteReader();

                if (dr.Read())
                {
                    encontrado = true;
                }

                dr.Close();
                conexion.close();
            }

            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }

            return encontrado;
        }

        public void insertarCodigoOperacion(string codigo, string descripcion)
        {
            string query = "Insert Into Codigo_operacion(Descripcion, Codigo) Values(@descripcion, @codigo)";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@codigo", codigo);
            conexion.comando.Parameters.AddWithValue("@descripcion", descripcion);

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();
                conexion.comando.ExecuteNonQuery();
                conexion.close();
            }

            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }
        }

        public ArrayList buscarCondicionIVA()
        {
            ArrayList lista = new ArrayList();
            string query = "SELECT * FROM Condicion_IVA";

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();

                dr = conexion.comando.ExecuteReader();
                while (dr.Read())
                {
                    string[] datos = { dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString() };
                    lista.Add(datos);
                }

                dr.Close();
                conexion.close();
            }

            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }

            return lista;
        }

        public void actualizarCondicionIVA(string codigo, string descripcion, string baja)
        {
            string query = "UPDATE Condicion_IVA SET Baja=@baja, Descripcion=@descripcion WHERE Codigo=@codigo";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@codigo", codigo);
            conexion.comando.Parameters.AddWithValue("@descripcion", descripcion);
            conexion.comando.Parameters.AddWithValue("@baja", baja);
            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();
                conexion.comando.ExecuteNonQuery();
                conexion.close();
            }
            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }
        }

        public bool verificarCondicionIVA(string codigo)
        {
            bool encontrado = false;
            string query = "Select * From Condicion_IVA Where Codigo=@codigo";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@codigo", codigo);

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();

                dr = conexion.comando.ExecuteReader();

                if (dr.Read())
                {
                    encontrado = true;
                }

                dr.Close();
                conexion.close();
            }

            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }

            return encontrado;
        }

        public void insertarCondicionIVA(string codigo, string descripcion)
        {
            string query = "Insert Into Condicion_IVA(Descripcion, Codigo) Values(@descripcion, @codigo)";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@codigo", codigo);
            conexion.comando.Parameters.AddWithValue("@descripcion", descripcion);

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();
                conexion.comando.ExecuteNonQuery();
                conexion.close();
            }

            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }
        }

        public ArrayList buscarDocumentoIDComprador()
        {
            ArrayList lista = new ArrayList();
            string query = "SELECT * FROM Doc_idcomprador";

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();

                dr = conexion.comando.ExecuteReader();
                while (dr.Read())
                {
                    string[] datos = { dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString() };
                    lista.Add(datos);
                }

                dr.Close();
                conexion.close();
            }

            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }

            return lista;
        }

        public void actualizarDocumentoIDComprador(string codigo, string descripcion, string baja)
        {
            string query = "UPDATE Doc_idcomprador SET Baja=@baja, Descripción=@descripcion WHERE Código=@codigo";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@codigo", codigo);
            conexion.comando.Parameters.AddWithValue("@descripcion", descripcion);
            conexion.comando.Parameters.AddWithValue("@baja", baja);
            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();
                conexion.comando.ExecuteNonQuery();
                conexion.close();
            }
            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }
        }

        public bool verificarDocumentoIDComprador(string codigo)
        {
            bool encontrado = false;
            string query = "Select * From Doc_idcomprador Where Código=@codigo";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@codigo", codigo);

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();

                dr = conexion.comando.ExecuteReader();

                if (dr.Read())
                {
                    encontrado = true;
                }

                dr.Close();
                conexion.close();
            }

            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }

            return encontrado;
        }

        public void insertarDocumentoIDComprador(string codigo, string descripcion)
        {
            string query = "Insert Into Doc_idcomprador(Descripción, Código) Values(@descripcion, @codigo)";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@codigo", codigo);
            conexion.comando.Parameters.AddWithValue("@descripcion", descripcion);

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();
                conexion.comando.ExecuteNonQuery();
                conexion.close();
            }

            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }
        }

        public ArrayList buscarMoneda()
        {
            ArrayList lista = new ArrayList();
            string query = "SELECT * FROM Tipo_moneda";

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();

                dr = conexion.comando.ExecuteReader();
                while (dr.Read())
                {
                    string[] datos = { dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString() };
                    lista.Add(datos);
                }

                dr.Close();
                conexion.close();
            }

            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }

            return lista;
        }

        public void actualizarMoneda(string codigo, string descripcion, string baja)
        {
            string query = "UPDATE Tipo_moneda SET Baja=@baja, Moneda=@descripcion WHERE Código=@codigo";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@codigo", codigo);
            conexion.comando.Parameters.AddWithValue("@descripcion", descripcion);
            conexion.comando.Parameters.AddWithValue("@baja", baja);
            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();
                conexion.comando.ExecuteNonQuery();
                conexion.close();
            }
            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }
        }

        public bool verificarMoneda(string codigo)
        {
            bool encontrado = false;
            string query = "Select * From Tipo_moneda Where Código=@codigo";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@codigo", codigo);

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();

                dr = conexion.comando.ExecuteReader();

                if (dr.Read())
                {
                    encontrado = true;
                }

                dr.Close();
                conexion.close();
            }

            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }

            return encontrado;
        }

        public void insertarMoneda(string codigo, string descripcion)
        {
            string query = "Insert Into Tipo_moneda(Moneda, Código) Values(@descripcion, @codigo)";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@codigo", codigo);
            conexion.comando.Parameters.AddWithValue("@descripcion", descripcion);

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();
                conexion.comando.ExecuteNonQuery();
                conexion.close();
            }

            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }
        }

        public ArrayList buscarTipoComprobante()
        {
            ArrayList lista = new ArrayList();
            string query = "SELECT * FROM Tipo_comprobante";

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();

                dr = conexion.comando.ExecuteReader();
                while (dr.Read())
                {
                    string[] datos = { dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString() };
                    lista.Add(datos);
                }

                dr.Close();
                conexion.close();
            }

            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }

            return lista;
        }

        public void actualizarTipoComprobante(string codigo, string descripcion, string baja)
        {
            string query = "UPDATE Tipo_comprobante SET Baja=@baja, Descripcion=@descripcion WHERE Codigo=@codigo";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@codigo", codigo);
            conexion.comando.Parameters.AddWithValue("@descripcion", descripcion);
            conexion.comando.Parameters.AddWithValue("@baja", baja);
            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();
                conexion.comando.ExecuteNonQuery();
                conexion.close();
            }
            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }
        }

        public bool verificarTipoComprobante(string codigo)
        {
            bool encontrado = false;
            string query = "Select * From Tipo_comprobante Where Codigo=@codigo";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@codigo", codigo);

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();

                dr = conexion.comando.ExecuteReader();

                if (dr.Read())
                {
                    encontrado = true;
                }

                dr.Close();
                conexion.close();
            }

            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }

            return encontrado;
        }

        public void insertarTipoComprobante(string codigo, string descripcion)
        {
            string query = "Insert Into Tipo_comprobante(Descripcion, Codigo) Values(@descripcion, @codigo)";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@codigo", codigo);
            conexion.comando.Parameters.AddWithValue("@descripcion", descripcion);

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();
                conexion.comando.ExecuteNonQuery();
                conexion.close();
            }

            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }
        }
    }
}
