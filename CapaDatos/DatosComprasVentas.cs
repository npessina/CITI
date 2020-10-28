using System;
using System.Data.SqlClient;
using System.Collections;

namespace CapaDatos
{
    public class DatosComprasVentas
    {
        Conexion conexion = new Conexion();
        SqlDataReader dr;

        public string buscarCodigoComprobante (string comprobante, string tipo)
        {
            string tipo_Comprobante = "";
            string query = "Select Codigo FROM Codigo_Comprobante WHERE Comprobante = @comprobante AND Tipo = @tipo";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@comprobante", comprobante);
            conexion.comando.Parameters.AddWithValue("@tipo", tipo);

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();

                dr = conexion.comando.ExecuteReader();
                if (dr.Read())
                {
                    tipo_Comprobante = dr["Codigo"].ToString().PadLeft(3, '0');
                }
                dr.Close();

                conexion.close();
            }
            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }
            return tipo_Comprobante;
        } 

        public ArrayList buscarAlicuota (string id)
        {
            ArrayList lista = new ArrayList();
            string query = "Select porcentaje, subtotalgravado, valor FROM Alicuotas_IVA WHERE id_comprobante=@idcomprobante";;
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@idcomprobante", id);

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();

                dr = conexion.comando.ExecuteReader();
                while (dr.Read())
                {
                    string[] datos = { dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString()};
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

        public ArrayList buscarComprobantes(DateTime fecha)
        {
            ArrayList lista = new ArrayList();
            string query = "SELECT * FROM Comprobantes WHERE MONTH(@fecha)=MONTH(fecha) AND YEAR(@fecha)=YEAR(fecha)";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@fecha", fecha);

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();

                dr = conexion.comando.ExecuteReader();
                while (dr.Read())
                {
                    string[] datos = { dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString(),
                    dr.GetValue(6).ToString(), dr.GetValue(7).ToString(), dr.GetValue(8).ToString(), dr.GetValue(9).ToString(), dr.GetValue(10).ToString(), dr.GetValue(11).ToString(), dr.GetValue(12).ToString(),
                    dr.GetValue(13).ToString(), dr.GetValue(14).ToString(), dr.GetValue(15).ToString(), dr.GetValue(16).ToString(), dr.GetValue(17).ToString(), dr.GetValue(18).ToString(), dr.GetValue(19).ToString(),
                    dr.GetValue(20).ToString(), dr.GetValue(21).ToString(), dr.GetValue(22).ToString(), dr.GetValue(23).ToString(), dr.GetValue(24).ToString(), dr.GetValue(25).ToString(), dr.GetValue(26).ToString(),
                    dr.GetValue(27).ToString(), dr.GetValue(28).ToString() };
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

        public string obtenerCantidadAlicuotas(string id)
        {
            string query = "Select COUNT(AV.id_comprobante) AS cantidad FROM Alicuotas_IVA AV INNER JOIN Comprobantes C ON AV.id_comprobante = C.id_comprobante WHERE C.id_comprobante=@id GROUP BY AV.id_comprobante";
            conexion.comando.Parameters.Clear();
            conexion.comando.Parameters.AddWithValue("@id", id);
            string cantidadAlicuotaIVA = "0";

            try
            {
                conexion.setType();
                conexion.setQuery(query);
                conexion.open();

                dr = conexion.comando.ExecuteReader();

                if (dr.Read())
                {
                    cantidadAlicuotaIVA = dr["cantidad"].ToString();
                }
                else
                {
                    cantidadAlicuotaIVA = "0";
                }
                dr.Close();
                conexion.close();
            }
            catch (Exception e)
            {
                String mensaje = "Error al buscar los datos" + e.Message;
            }

            return cantidadAlicuotaIVA;

        }
    }
}
