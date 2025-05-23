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

        private void btnPJuntar_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT Libro.Titulo, Idioma.Nombre " +
                "FROM Libro " +
                "INNER JOIN Idioma ON Libro.IdIdioma = Idioma.IdIdioma";
            BD.Consultar(SQL, dgvResultado);
        }

        private void btnSSimple_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT * " +
               "FROM Libro " +
               "WHERE IdPais > 5 ";
            BD.Consultar(SQL, dgvResultado);
        }

        private void btnSMulti_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT * FROM " +
                "(SELECT * FROM Libro as T1 WHERE T1.IdAutor > 10) " +
                "AS T2 WHERE T2.IdAutor < 20";
            BD.Consultar(SQL, dgvResultado);
        }

        private void btnSConvol_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT * FROM Libro " +
                "WHERE IdAutor = 8 " +
                "AND precio < 150";
            BD.Consultar(SQL, dgvResultado);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT * FROM Libro " +
                "WHERE IdAutor = 9 " +
                "UNION SELECT * FROM Libro " +
                "WHERE IdAutor =  83";
            BD.Consultar(SQL, dgvResultado);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT * FROM Libro WHERE IdAutor > 50 AND IdLibro IN (SELECT IdLibro FROM Libro WHERE IdIdioma > 7);";
            BD.Consultar(SQL, dgvResultado);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT * FROM Libro " +
                "WHERE IdPais NOT IN " +
                "(SELECT DISTINCT IdPais FROM Libro " +
                "WHERE IdPais > 10)";
            BD.Consultar(SQL, dgvResultado);
        }
    }
}
