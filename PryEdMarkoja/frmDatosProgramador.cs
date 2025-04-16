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
    public partial class frmDatosProgramador : Form
    {
        public frmDatosProgramador()
        {
            InitializeComponent(); 
            clsCustomUI.CargarEstilos(this, TemaActual.TemaSeleccionado);
        }

        private void frmDatosProgramador_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked. " + ex);
            }
        }
        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
           
            System.Diagnostics.Process.Start("https://github.com/sebaacc");
        }
    }
}
