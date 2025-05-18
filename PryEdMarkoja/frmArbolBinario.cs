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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
            clsCustomUI.CargarEstilos(this, TemaActual.TemaSeleccionado);
        }
        clsArbolBinario Arbol = new clsArbolBinario();
        clsArchivo x = new clsArchivo();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||string.IsNullOrWhiteSpace(txtTramite.Text))
            {
                MessageBox.Show("Por favor complete todos los campos antes de agregar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            else
            {
                clsNodo aux = new clsNodo();
                aux.Codigo = Convert.ToInt32(txtCodigo.Text);
                aux.Nombre = txtNombre.Text;
                aux.Tramite = txtTramite.Text;
                Arbol.Agregar(aux);
            }
            LosRecorrer();
            limpiarTodo();
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            ValidarDatos();
        }
        private void LosRecorrer()
        {
            Arbol.Recorrer(tvArbol);
            Arbol.Recorrer(cmbEliminar);
            Arbol.Recorrer(dgvArbol);
        }
        private void limpiarTodo()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            cmbEliminar.Text = "";
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.Recorrer(tvArbol);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Arbol.Eliminar(Convert.ToInt32(cmbEliminar.Text));
            LosRecorrer();
        }
        private void ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTramite.Text))
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if(cmbEliminar.Items.Count > 0) Arbol.Recorrer(dgvArbol);
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbEliminar.Items.Count > 0) Arbol.RecorrerPre(dgvArbol);
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbEliminar.Items.Count > 0) Arbol.RecorrerPost(dgvArbol);
        }

        private void cmbEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEliminar.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }
    }
}
