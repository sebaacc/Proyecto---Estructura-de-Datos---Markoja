using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PryEdMarkoja.Estilos;

namespace PryEdMarkoja
{
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
            clsCustomUI.CargarEstilos(this, TemaActual.TemaSeleccionado);
        }
        clsPila PilaDeCosas = new clsPila();
        clsArchivo x = new clsArchivo();
        private void frmPila_Load(object sender, EventArgs e)
        {
            try
            {
                x.nombreArchivo = "Pila.csv";
                if (File.Exists(x.nombreArchivo)) x.Recorrer(dgvPila);
                else MessageBox.Show("Archivo no encontrado");

                PilaDeCosas.Agregar();//lee datos archivo
                PilaDeCosas.Recorrer();//grabo en archivo
                PilaDeCosas.Recorrer(dgvPila);//muestra en 
                PilaDeCosas.Recorrer(lstPila);//muestra en lista
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Hoja = new clsNodo();
            Hoja.Codigo = Convert.ToInt32(txtCodigo.Text);
            Hoja.Nombre = txtNombre.Text;
            Hoja.Tramite = txtTramite.Text;
            PilaDeCosas.Agregar(Hoja);

            PilaDeCosas.Recorrer();
            PilaDeCosas.Recorrer(dgvPila);
            PilaDeCosas.Recorrer(lstPila);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (PilaDeCosas.Primero != null)
            {
                txtCodigoCaja.Text = PilaDeCosas.Primero.Codigo.ToString();
                txtNombreCaja.Text = PilaDeCosas.Primero.Nombre.ToString();
                txtTramiteCaja.Text = PilaDeCosas.Primero.Tramite.ToString();
                PilaDeCosas.Eliminar();
            }
            limpiarTodo();
        }
        private void limpiarTodo()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            PilaDeCosas.Recorrer();
            PilaDeCosas.Recorrer(dgvPila);
            PilaDeCosas.Recorrer(lstPila);
        }
    }
}
