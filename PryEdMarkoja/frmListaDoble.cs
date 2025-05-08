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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
            clsCustomUI.CargarEstilos(this, TemaActual.TemaSeleccionado);
        }
        clsListaDoble ListaDoble = new clsListaDoble();
        clsArchivo x = new clsArchivo();
        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            x.nombreArchivo = "ListaDoble.csv";
            if (File.Exists(x.nombreArchivo)) x.Recorrer(dgvListaDoble);
            else MessageBox.Show("Archivo no encontrado");

            ListaDoble.Agregar();
            LosRecorrer();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Operacion = new clsNodo();
            Operacion.Codigo = Convert.ToInt32(txtCodigo.Text);
            Operacion.Nombre = txtNombre.Text;
            Operacion.Tramite = txtTramite.Text;

            ListaDoble.Agregar(Operacion);
            LosRecorrer();
            limpiarTodo();
        }
        private void limpiarTodo()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            cmbEliminar.Text = "";
        }
        private void LosRecorrer()
        {
            ListaDoble.Recorrer();
            ListaDoble.Recorrer(cmbEliminar);
            ListaDoble.Recorrer(dgvListaDoble);
            ListaDoble.Recorrer(lstLista);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbEliminar.SelectedItem != null)
            {
                try
                {
                    ListaDoble.Eliminar(Convert.ToInt32(cmbEliminar.SelectedItem));
                    MessageBox.Show("Se eliminó correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún valor a eliminar.");
            }
            limpiarTodo();
        }
    }
}
