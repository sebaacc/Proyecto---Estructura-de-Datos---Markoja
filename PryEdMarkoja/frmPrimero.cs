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
    public partial class frmPrimero : Form
    {
        public frmPrimero()
        {
            InitializeComponent();
            clsCustomUI.CargarEstilos(this, (clsCustomUI.Theme)Theme.LightPastel);
        }
        public enum Theme { LightPastel, Dark }
        private void frmPrimero_Load(object sender, EventArgs e)
        {

        }
        private void datosDelProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosProgramador v = new frmDatosProgramador();
            v.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPooCiudades v = new frmPooCiudades();
            v.ShowDialog();
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPooProvincias v = new frmPooProvincias();
            v.ShowDialog();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void temaClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsCustomUI.CargarEstilos(this, (clsCustomUI.Theme)Theme.LightPastel);
        }

        private void temaOscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            clsCustomUI.CargarEstilos(this, (clsCustomUI.Theme)Theme.Dark );
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola v = new frmCola();
            v.ShowDialog();
        }
    }
}
