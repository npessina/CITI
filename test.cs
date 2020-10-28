using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CITI
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
            txtNombreDB.Text = ConfigurationManager.AppSettings["Motor"].Trim();
            txtTablaCompras.Text = ConfigurationManager.AppSettings["DB"].Trim();
            txtTablaVentas.Text = ConfigurationManager.AppSettings["User"].Trim();
            txtIVACompras.Text = ConfigurationManager.AppSettings["Password"].Trim();
            txtIVAVentas.Text = ConfigurationManager.AppSettings["Puerto"].Trim();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
