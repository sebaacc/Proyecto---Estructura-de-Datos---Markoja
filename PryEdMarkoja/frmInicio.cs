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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            clsCustomUI.CargarEstilos(this, TemaActual.TemaSeleccionado);
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
            //this.Close();
            Application.Exit();
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
            frmPooMes v = new frmPooMes();
            v.ShowDialog();
        }

        private void temaClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TemaActual.TemaSeleccionado = clsCustomUI.Theme.LightPastel;
            clsCustomUI.CargarEstilos(this, TemaActual.TemaSeleccionado);
        }
        private void temaOscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TemaActual.TemaSeleccionado = clsCustomUI.Theme.Dark;
            clsCustomUI.CargarEstilos(this, TemaActual.TemaSeleccionado);
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola v = new frmCola();
            v.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila v = new frmPila();
            v.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble v = new frmListaDoble();
            v.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple v = new frmListaSimple();
            v.ShowDialog();
        }

        private void árbolesBinariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario v = new frmArbolBinario();
            v.ShowDialog();
        }

        private void grafosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGrafo v = new frmGrafo();
            v.ShowDialog();
        }

        private void consultaDeUnaTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosMostrarTabla v = new frmBaseDatosMostrarTabla();
            v.ShowDialog();
        }

        private void consultaDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosConsultasSQL v = new frmBaseDatosConsultasSQL();
            v.ShowDialog();
        }

        private void operacionesEnBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosOperaciones v = new frmBaseDatosOperaciones();
            v.ShowDialog();
        }

        private void consultasVariasConOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosRepasoOperaciones v = new frmBaseDatosRepasoOperaciones();
            v.ShowDialog();
        }

        private void díasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPooDia v = new frmPooDia();
            v.ShowDialog();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPooMateria v = new frmPooMateria();
            v.ShowDialog();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPooCarrera v = new frmPooCarrera();
            v.ShowDialog();
        }
    }
}
