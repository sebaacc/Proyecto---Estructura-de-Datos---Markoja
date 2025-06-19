using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PryEdMarkoja.Estilos;

namespace PryEdMarkoja
{
    public partial class frmGrafo : Form
    {
        clsGrafoMatricial grafo = new clsGrafoMatricial();
        public frmGrafo()
        {
            InitializeComponent();
            clsCustomUI.CargarEstilos(this, TemaActual.TemaSeleccionado);
        }

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            grafo.MostrarCiudades(cmbDestinoCarga);
            grafo.MostrarCiudades(cmbDestinoConsulta);
            grafo.MostrarCiudades(cmbDestinoListar);
            grafo.MostrarCiudades(cmbOrigenCarga);
            grafo.MostrarCiudades(cmbOrigenConsulta);
            grafo.MostrarCiudades(cmbOrigenListar);
            grafo.MostrarTodo(dgvGrafo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Int32 x = cmbOrigenCarga.SelectedIndex;
            Int32 y = cmbDestinoCarga.SelectedIndex;
            Decimal p = Convert.ToDecimal(txtPrecio.Text);
            grafo.Agregar(x, y, p);
            grafo.MostrarTodo(dgvGrafo);
            MessageBox.Show("Precio Cargado!");
            txtPrecio.Text = "";
            cmbOrigenCarga.SelectedIndex = 0;
            cmbDestinoCarga.SelectedIndex = 0;
        }

        private void btnConsultarViaje_Click(object sender, EventArgs e)
        {
            Int32 x = cmbOrigenCarga.SelectedIndex;
            Int32 y = cmbDestinoCarga.SelectedIndex;
            txtPrecioConsultado.Text = grafo.Consultar(x,y).ToString();
        }

        private void btnVerTodosLosViajes_Click(object sender, EventArgs e)
        {
            grafo.MostrarTodo(dgvGrafo);
        }

        private void btnListarOrigenes_Click(object sender, EventArgs e)
        {
            Int32 x = cmbOrigenListar.SelectedIndex;
            grafo.MostrarOrigenes(x,dgvGrafo);
        }

        private void btnListarDestinos_Click(object sender, EventArgs e)
        {
            Int32 x = cmbDestinoListar.SelectedIndex;
            grafo.MostrarDestinos(x, dgvGrafo);
        }
    }
}
