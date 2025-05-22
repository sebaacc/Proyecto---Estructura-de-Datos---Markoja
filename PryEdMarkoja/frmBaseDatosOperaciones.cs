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
    public partial class frmBaseDatosOperaciones : Form
    {
        clsBD BD = new clsBD();
        public frmBaseDatosOperaciones()
        {
            InitializeComponent(); 
            clsCustomUI.CargarEstilos(this, TemaActual.TemaSeleccionado);
        }

        private void frmBaseDatosOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnPSimple_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT titulo " +
                "FROM Libro";
            BD.Consultar(SQL, dgvResultado);
        }

        private void btnPMulti_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT * " +
                "FROM Libro";
            BD.Consultar(SQL, dgvResultado);
        }
    }
}
