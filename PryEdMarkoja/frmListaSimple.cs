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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
            clsCustomUI.CargarEstilos(this, TemaActual.TemaSeleccionado);
        }
        clsListaSimple ListaSimple = new clsListaSimple();
        clsArchivo x = new clsArchivo();
        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            x.nombreArchivo = "ListaSimple.csv";
            if (File.Exists(x.nombreArchivo)) x.Recorrer(dgvListaSimple);
            else MessageBox.Show("Archivo no encontrado");

            ListaSimple.Agregar();
            LosRecorrer();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            ListaSimple.Agregar(Persona);
            LosRecorrer();
            limpiarTodo();
        }
        private void limpiarTodo()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            cmbEliminar.Text = "";
            LosRecorrer();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbEliminar.SelectedItem != null)
            {
                try
                {
                    ListaSimple.Eliminar(Convert.ToInt32(cmbEliminar.SelectedItem));
                    MessageBox.Show("Se eliminó correctamente.");
                } catch (Exception ex)
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
        private void LosRecorrer()
        {
            ListaSimple.Recorrer();
            ListaSimple.Recorrer(cmbEliminar);
            ListaSimple.Recorrer(dgvListaSimple);
            ListaSimple.Recorrer(lstListaSimple);
        }
    }
}
