using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System;

namespace CITI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // para crear el archivo
        void GenerarTXT()
    {
        string rutaCompleta = @" D:\mi archivo.txt";
        string texto = "HOLA MUNDO ";

        using (StreamWriter mylogs = File.AppendText(rutaCompleta))         //se crea el archivo
        {

            //se adiciona alguna información y la fecha


            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            string strDate = Convert.ToDateTime(dateTime).ToString("yyMMdd");

            mylogs.WriteLine(texto + strDate);

            mylogs.Close();


        }
    }
}
}
