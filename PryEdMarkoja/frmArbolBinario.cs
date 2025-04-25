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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
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
                aux.Codigo = Convert.ToInt32(txtCodigo);
                aux.Nombre = txtNombre.Text;
                aux.Tramite = txtTramite.Text;
                Arbol.Agregar(aux);
            }
            Arbol.Recorrer(tvArbol);
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }
    }
}
