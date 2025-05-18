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
    public partial class frmBaseDatosMostrarTabla : Form
    {
        clsBD BD = new clsBD();
        public frmBaseDatosMostrarTabla()
        {
            InitializeComponent();
            clsCustomUI.CargarEstilos(this, TemaActual.TemaSeleccionado);
        }

        private void frmBaseDatosMostrarTabla_Load(object sender, EventArgs e)
        {
            BD.Listar(dgvMostrarTabla);
            cargarCmb();
            cmbTabla.SelectedIndex = 0;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            BD.Listar(cmbTabla.Text, dgvMostrarTabla);
        }
        private void cargarCmb()
        {
            string[] tablas = {"Autor", "Idioma", "Libro", "Pais" };
            cmbTabla.Items.Clear();
            foreach (string s in tablas)
            {
                cmbTabla.Items.Add(s);
            }
        }
    }
}
