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
    public partial class frmBaseDatosConsultasSQL : Form
    {
        clsBD BD = new clsBD();
        public frmBaseDatosConsultasSQL()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            BD.Consultar(txtQuery.Text, dgvMostrarConsulta);
        }

        private void frmBaseDatosConsultasSQL_Load(object sender, EventArgs e)
        {

        }
    }
}
