using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdMarkoja
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        clsCola FilaPersonas = new clsCola();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;
            FilaPersonas.Agregar(Persona);

            FilaPersonas.Recorrer();
            FilaPersonas.Recorrer(dgvCola);
            FilaPersonas.Recorrer(lstCola);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaPersonas.Primero != null)
            {
                lblCodigoCaja.Text = FilaPersonas.Primero.Codigo.ToString();
                lblNombreCaja.Text = FilaPersonas.Primero.Nombre.ToString();
                lblTramiteCaja.Text = FilaPersonas.Primero.Tramite.ToString();
                //falta

            }
        }

        private void frmCola_Load(object sender, EventArgs e)
        {
            FilaPersonas.Agregar();//lee datos archivo
            FilaPersonas.Recorrer();//grabo en archivo
            FilaPersonas.Recorrer(dgvCola);//muestra en 
            FilaPersonas.Recorrer(lstCola);//muestra en lista
        }
    }
}
