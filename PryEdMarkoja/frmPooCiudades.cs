using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdMarkoja
{
    public partial class frmPooCiudades : Form
    {
        public frmPooCiudades()
        {
            InitializeComponent();
        }
        clsArchivo x = new clsArchivo();
        clsUtilidadesFormularios utilidades = new clsUtilidadesFormularios();
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            x.Grabar(txtNombre.Text);
            x.Recorrer(lstCiudades);
            utilidades.MostrarMensajeExitoso();
        }

        private void frmCiudades_Load(object sender, EventArgs e)
        {
            x.nombreArchivo = "Ciudades.txt";
            if(File.Exists(x.nombreArchivo)) x.Recorrer(lstCiudades);
            btnGrabar.Enabled = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnGrabar.Enabled = !utilidades.ComprobarTextBox(txtNombre);
        }
    }
}
