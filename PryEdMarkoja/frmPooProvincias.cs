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
using PryEdMarkoja.Estilos;

namespace PryEdMarkoja
{
    public partial class frmPooProvincias : Form
    {
        public frmPooProvincias()
        {
            InitializeComponent(); 
            clsCustomUI.CargarEstilos(this, TemaActual.TemaSeleccionado);
        }
        clsArchivo x = new clsArchivo();
        clsUtilidadesFormularios utilidades = new clsUtilidadesFormularios();
        private void frmProvincias_Load(object sender, EventArgs e)
        {
            x.nombreArchivo = "Provincias.csv";
            if (File.Exists(x.nombreArchivo)) x.Recorrer(dgvProvincias);
            else MessageBox.Show("Archivo no encontrado");
            btnGrabar.Enabled = false;
            txtCodigo.Select();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            String Datos = "";
            Datos = txtCodigo.Text + ";" + txtNombre.Text;
            x.Grabar(Datos); 
            x.Recorrer(dgvProvincias);
            utilidades.MostrarMensajeExitoso();
            utilidades.LimpiarControles(this.Controls);
            txtCodigo.Select();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            btnGrabar.Enabled = !utilidades.ComprobarTextBox(txtCodigo, txtNombre);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnGrabar.Enabled = !utilidades.ComprobarTextBox(txtCodigo, txtNombre);
        }
    }
}
