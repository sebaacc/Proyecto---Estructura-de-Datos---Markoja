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
using PryEdMarkoja.Estilos;

namespace PryEdMarkoja
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
            clsCustomUI.CargarEstilos(this, TemaActual.TemaSeleccionado);
        }
        clsCola FilaPersonas = new clsCola();
        clsArchivo x = new clsArchivo();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;
            FilaPersonas.Agregar(Persona);

            limpiarTodo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaPersonas.Primero != null)
            {
                lblCodigoCaja.Text = FilaPersonas.Primero.Codigo.ToString();
                lblNombreCaja.Text = FilaPersonas.Primero.Nombre.ToString();
                lblTramiteCaja.Text = FilaPersonas.Primero.Tramite.ToString();
                FilaPersonas.Eliminar();
            }
            limpiarTodo();
        }

        private void frmCola_Load(object sender, EventArgs e)
        {
            x.nombreArchivo = "Cola.csv";
            if (File.Exists(x.nombreArchivo)) x.Recorrer(dgvCola);
            else MessageBox.Show("Archivo no encontrado");

            FilaPersonas.Agregar();//lee datos archivo
            FilaPersonas.Recorrer();//grabo en archivo
            FilaPersonas.Recorrer(dgvCola);//muestra en 
            FilaPersonas.Recorrer(lstCola);//muestra en lista

        }

        private void lblCodigoCaja_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbElementoEliminar_Enter(object sender, EventArgs e)
        {

        }
        private void limpiarTodo()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            FilaPersonas.Recorrer();
            FilaPersonas.Recorrer(dgvCola);
            FilaPersonas.Recorrer(lstCola);
        }
    }
}
