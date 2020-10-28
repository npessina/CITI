using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using CapaDatos;
namespace CapaNegocios
{
    public class Funciones
    {

        Conexion conexion = new Conexion();
        DatosComprasVentas mc = new DatosComprasVentas();
        DatosABM datos = new DatosABM();

        public static void mError(Form actual, String mensaje)
        {
            MessageBox.Show(actual, mensaje);
        }

        //FUNCION PARA GENERAR TXT Y ESCRIBIR

        public void generarArchivo(String texto)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TXT|*.txt";
            sfd.Title = "Guardar archivo";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter file = new StreamWriter(sfd.FileName))
                {
                    file.WriteLine(texto); //se agrega información al documento

                    file.Close();
                }
            }
        }

        //MOSTRAR TXT CABECERA COMPRAS

        public void mostrartxtCabecera(DateTime dateTime)
        {
            string tipo_Comprobante = "";
            string cantidadAlicuotaIVA = "";
            string concat = "";
            ArrayList list = new ArrayList();
            list = buscarComprobantesCompras(dateTime);

            foreach (string[] s in list)
            {
                tipo_Comprobante = mc.buscarCodigoComprobante(s.GetValue(1).ToString(), s.GetValue(2).ToString());

                string id_Comprobante = s.GetValue(0).ToString().PadLeft(20, '0');
                string despachoImportacion = "0000000000000000";
                string punto_Venta = s.GetValue(3).ToString().PadLeft(5, '0');
                DateTime fechac = Convert.ToDateTime(s.GetValue(5).ToString());
                string fecha_Comprobante = fechac.ToString("yyyyMMdd").PadLeft(8, '0');
                string codigoDocumentoVendedor = "00";
                string idVendedor = "00000000000000000000";
                string denominacionVendedor = "000000000000000000000000000000";
                string importeTotalOperacion = Math.Round(double.Parse(s.GetValue(15).ToString())).ToString().PadLeft(15, '0');
                string importeTotalNoGravados = Math.Round(double.Parse(s.GetValue(16).ToString())).ToString().PadLeft(15, '0');
                string importeExentas = "000000000000000";
                string importePercepcionesIVA = "000000000000000";
                string importePercepcionesImpNac = "000000000000000";
                string importePercepcionesIB = "000000000000000";
                string importePercepcionesImpMuni = "000000000000000";
                string importeImpuestosInternos = "000000000000000";
                string codigoMoneda = "PES";
                string tipoCambio = "0000000000";

                cantidadAlicuotaIVA = mc.obtenerCantidadAlicuotas(s.GetValue(0).ToString());

                string codigoOperacion = "X";
                string creditoFiscalComputable = "000000000000000";
                string otrosTributos = "000000000000000";
                string cuitEmisor = "00000000000";
                string denominacionEmisor = "000000000000000000000000000000";
                string ivaComision = "000000000000000";

                concat = concat + fecha_Comprobante + tipo_Comprobante + punto_Venta + id_Comprobante + despachoImportacion + codigoDocumentoVendedor + idVendedor + denominacionVendedor + importeTotalOperacion + importeTotalNoGravados + importeExentas + importePercepcionesIVA + importePercepcionesImpNac + importePercepcionesIB + importePercepcionesImpMuni + importeImpuestosInternos + codigoMoneda + tipoCambio + cantidadAlicuotaIVA + codigoOperacion + creditoFiscalComputable + otrosTributos + cuitEmisor + denominacionEmisor + ivaComision + "\n";

            }
            generarArchivo(concat);
        }

        //MOSTRAR TXT ALICUOTAS COMPRAS

        public void mostrartxtAlicuota(DateTime fecha)
        {
            string tipo_Comprobante = "";
            string concat = "";
            string codigo = "";
            ArrayList list = new ArrayList();
            ArrayList lista = new ArrayList();
            list = buscarComprobantesCompras(fecha);

            foreach (string[] s in list)
            {

                tipo_Comprobante = mc.buscarCodigoComprobante(s.GetValue(1).ToString(), s.GetValue(2).ToString());
                string punto_Venta = s.GetValue(3).ToString().PadLeft(5, '0');
                string id_Comprobante = s.GetValue(0).ToString().PadLeft(20, '0');

                string codigoDocumentoVendedor = "00";
                string idVendedor = s.GetValue(13).ToString().PadLeft(20, '0');

                string id = s.GetValue(0).ToString();
                //float id = float.Parse(s.GetValue(0).ToString());
                lista = mc.buscarAlicuota(id);

                foreach (string[] al in lista)
                {
                    string porcentaje = al.GetValue(0).ToString();

                    string subtotalgravado = Math.Round(double.Parse(al.GetValue(1).ToString())).ToString().PadLeft(15, '0');
                    string valor = Math.Round(double.Parse(al.GetValue(2).ToString())).ToString().PadLeft(15, '0');
                    switch (porcentaje)
                    {
                        case "21":
                            codigo = "5";
                            break;
                        case "10,5":
                            codigo = "4";
                            break;
                    }

                    codigo = codigo.PadLeft(4, '0');
                    concat = concat + tipo_Comprobante + punto_Venta + id_Comprobante + codigoDocumentoVendedor + idVendedor + subtotalgravado + codigo + valor + "\n";

                }

            }
            generarArchivo(concat);
        }

        //MOSTRAR TXT CABECERA VENTAS

        public void mostrartxtCabeceraVentas(DateTime dateTimeV)
        {
            string tipo_Comprobante = "";
            string cantidadAlicuotaIVA = "";
            string concat = "";
            ArrayList list = new ArrayList();
            list = buscarComprobantesCompras(dateTimeV);

            foreach (string[] s in list)
            {
                tipo_Comprobante = mc.buscarCodigoComprobante(s.GetValue(1).ToString(), s.GetValue(2).ToString());

                string punto_Venta = s.GetValue(3).ToString().PadLeft(5, '0');
                string id_Comprobante = s.GetValue(0).ToString().PadLeft(20, '0');
                string id_ComprobanteHasta = s.GetValue(0).ToString().PadLeft(20, '0');
                DateTime fechac = Convert.ToDateTime(s.GetValue(5).ToString());
                string fecha_Comprobante = fechac.ToString("yyyyMMdd").PadLeft(8, '0');
                string codigoDocumentoComprador = "80"; //duda
                string idComprador = s.GetValue(9).ToString().Replace(@"-", "").PadLeft(20, '0');

                string denominacionComprador = s.GetValue(7).ToString().Replace(@" ", "");
                if (denominacionComprador.Length > 30)
                    denominacionComprador = denominacionComprador.Substring(0, 30);
                else
                {
                    denominacionComprador = denominacionComprador.PadRight(30, ' ');
                }

                string importeTotalOperacion = s.GetValue(15).ToString().Replace(@",", "").PadLeft(15, '0');
                string importeTotalNoGravados = s.GetValue(16).ToString().Replace(@",", "").PadLeft(15, '0');
                string percepcionNoCat = "000000000000000";
                string importeExentas = "000000000000000";
                string importePercepcionesImpNac = "000000000000000";
                string importePercepcionesIB = "000000000000000";
                string importePercepcionesImpMuni = "000000000000000";
                string importeImpuestosInternos = "000000000000000";
                string codigoMoneda = "PES";
                string tipoCambio = "0000000000";
                string fechaVencimientoPago = s.GetValue(27).ToString().PadLeft(8, '0');//duda fecha

                cantidadAlicuotaIVA = mc.obtenerCantidadAlicuotas(s.GetValue(0).ToString());

                string codigoOperacion = "X";
                string otrosTributos = "000000000000000";

                concat = concat + fecha_Comprobante + tipo_Comprobante + punto_Venta + id_Comprobante + id_ComprobanteHasta + codigoDocumentoComprador + idComprador + denominacionComprador + importeTotalOperacion + importeTotalNoGravados + percepcionNoCat + importeExentas + importePercepcionesImpNac + importePercepcionesIB + importePercepcionesImpMuni + importeImpuestosInternos + codigoMoneda + tipoCambio + cantidadAlicuotaIVA + codigoOperacion + otrosTributos + fechaVencimientoPago + "\n";

            }
            generarArchivo(concat);
        }

        //MOSTRAR TXT ALICUOTA VENTAS

        public void mostrartxtAlicuotaVentas(DateTime dateTimeV)
        {
            string tipo_Comprobante = "";
            string concat = "";
            string codigo = "";
            ArrayList list = new ArrayList();
            ArrayList lista = new ArrayList();
            list = buscarComprobantesCompras(dateTimeV);

            foreach (string[] s in list)
            {
                tipo_Comprobante = mc.buscarCodigoComprobante(s.GetValue(1).ToString(), s.GetValue(2).ToString());

                string punto_Venta = s.GetValue(3).ToString().PadLeft(5, '0');
                string id_Comprobante = s.GetValue(0).ToString().PadLeft(20, '0');
                string id = s.GetValue(0).ToString();
                lista = mc.buscarAlicuota(id);

                foreach (string[] al in lista)
                {
                    string porcentaje = al.GetValue(0).ToString();
                    string subtotalgravado = Math.Round(double.Parse(al.GetValue(1).ToString())).ToString().PadLeft(15, '0');
                    string valor = Math.Round(double.Parse(al.GetValue(2).ToString())).ToString().PadLeft(15, '0');
                    switch (porcentaje)
                    {
                        case "21":
                            codigo = "5";
                            break;
                        case "10,5":
                            codigo = "4";
                            break;
                    }

                    codigo = codigo.PadLeft(4, '0');
                    concat = concat + tipo_Comprobante + punto_Venta + id_Comprobante + subtotalgravado + codigo + valor + "\n";
                }
            }
            generarArchivo(concat);
        }

        //BUSCAR COMPROBANTES Y MOSTRARLOS EN LA TABLA

        public ArrayList buscarComprobantesCompras(DateTime fecha)
        {
            return mc.buscarComprobantes(fecha);
        }

        public ArrayList buscarComprobantesVentas(DateTime fecha)
        {
            return mc.buscarComprobantes(fecha);
        }

        //ABMs

        public ArrayList buscarCodigoOperacion()
        {
            return datos.buscarCodigoOperacion();
        }

        public ArrayList buscarCondicionIVA()
        {
            return datos.buscarCondicionIVA();
        }

        public ArrayList buscarDocumentoIDComprador()
        {
            return datos.buscarDocumentoIDComprador();
        }

        public ArrayList buscarMoneda()
        {
            return datos.buscarMoneda();
        }

        public ArrayList buscarTipoComprobante()
        {
            return datos.buscarTipoComprobante();
        }

        public void actualizarCodigoOperacion(string codigo, string descripcion, string baja)
        {
            datos.actualizarCodigoOperacion(codigo, descripcion, baja);
        }

        public void actualizarCondicionIVA(string codigo, string descripcion, string baja)
        {
            datos.actualizarCondicionIVA(codigo, descripcion, baja);
        }

        public void actualizarDocumentoIDComprador(string codigo, string descripcion, string baja)
        {
            datos.actualizarDocumentoIDComprador(codigo, descripcion, baja);
        }

        public void actualizarMoneda(string codigo, string descripcion, string baja)
        {
            datos.actualizarMoneda(codigo, descripcion, baja);
        }

        public void actualizarTipoComprobante(string codigo, string descripcion, string baja)
        {
            datos.actualizarTipoComprobante(codigo, descripcion, baja);
        }

        public bool verificarCodigoOperacion(string codigo)
        {
            return datos.verificarCodigoOperacion(codigo);
        }

        public bool verificarCondicionIVA(string codigo)
        {
            return datos.verificarCondicionIVA(codigo);
        }

        public bool verificarDocumentoIDComprador(string codigo)
        {
            return datos.verificarDocumentoIDComprador(codigo);
        }

        public bool verificarMoneda(string codigo)
        {
            return datos.verificarMoneda(codigo);
        }

        public bool verificarTipoComprobante(string codigo)
        {
            return datos.verificarTipoComprobante(codigo);
        }

        public void insertarCodigoOperacion(string codigo, string descripcion)
        {
            datos.insertarCodigoOperacion(codigo, descripcion);
        }

        public void insertarCondicionIVA(string codigo, string descripcion)
        {
            datos.insertarCondicionIVA(codigo, descripcion);
        }

        public void insertarDocumentoIDComprador(string codigo, string descripcion)
        {
            datos.insertarDocumentoIDComprador(codigo, descripcion);
        }

        public void insertarMoneda(string codigo, string descripcion)
        {
            datos.insertarMoneda(codigo, descripcion);
        }

        public void insertarTipoComprobante(string codigo, string descripcion)
        {
            datos.insertarTipoComprobante(codigo, descripcion);
        }
    }
}
