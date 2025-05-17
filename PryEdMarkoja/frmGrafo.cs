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
    public partial class frmGrafo : Form
    {
        clsGrafoMatricial grafo = new clsGrafoMatricial();
        public frmGrafo()
        {
            InitializeComponent();
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


    }
}
