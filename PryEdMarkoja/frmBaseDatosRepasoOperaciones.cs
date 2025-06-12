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
    public partial class frmBaseDatosRepasoOperaciones : Form
    {
        List<clsConsultaPersonalizada> listaConsultas = new List<clsConsultaPersonalizada>();
        clsBD BD = new clsBD();
        public frmBaseDatosRepasoOperaciones()
        {
            InitializeComponent();
            clsCustomUI.CargarEstilos(this, TemaActual.TemaSeleccionado);

        }

        private void frmBaseDatosRepasoOperaciones_Load(object sender, EventArgs e)
        {
            cmbOperacion.Items.Clear();
            List<clsConsultaPersonalizada> consultas = ObtenerConsultas();
            cmbOperacion.DataSource = consultas;
            cmbOperacion.DisplayMember = "nombre";
        }
        public void cargarCMB(ComboBox cmb)
        {
            listaConsultas.Clear();
        }
        public List<clsConsultaPersonalizada> ObtenerConsultas()
        {
            listaConsultas.Add(new clsConsultaPersonalizada(
                "Proyección Simple",
                "Selecciona únicamente los títulos de todos los libros.",
                "SELECT titulo FROM Libro"
            ));

            listaConsultas.Add(new clsConsultaPersonalizada(
                "Proyección Múltiple",
                "Selecciona todas las columnas de todos los libros.",
                "SELECT * FROM Libro"
            ));

            listaConsultas.Add(new clsConsultaPersonalizada(
                "Proyección con JOIN",
                "Muestra el título del libro y el nombre del idioma, uniendo la tabla Libro con Idioma.",
                "SELECT Libro.Titulo, Idioma.Nombre FROM Libro INNER JOIN Idioma ON Libro.IdIdioma = Idioma.IdIdioma"
            ));

            listaConsultas.Add(new clsConsultaPersonalizada(
                "Selección Simple",
                "Selecciona todos los libros cuyo Id de país sea mayor a 5.",
                "SELECT * FROM Libro WHERE IdPais > 5"
            ));

            listaConsultas.Add(new clsConsultaPersonalizada(
                "Selección Múltiple",
                "Selecciona libros cuyo autor tenga ID entre 11 y 19 usando subconsultas anidadas.",
                "SELECT * FROM (SELECT * FROM Libro as T1 WHERE T1.IdAutor > 10) AS T2 WHERE T2.IdAutor < 20"
            ));

            listaConsultas.Add(new clsConsultaPersonalizada(
                "Selección con Conjunción",
                "Selecciona libros del autor con ID 8 y con precio menor a 150.",
                "SELECT * FROM Libro WHERE IdAutor = 8 AND precio < 150"
            ));

            listaConsultas.Add(new clsConsultaPersonalizada(
                "Operación Unión",
                "Une dos conjuntos de libros con ID de autor 9 y 83 respectivamente.",
                "SELECT * FROM Libro WHERE IdAutor = 9 UNION SELECT * FROM Libro WHERE IdAutor =  83"
            ));

            listaConsultas.Add(new clsConsultaPersonalizada(
                "Intersección (implícita)",
                "Muestra libros cuyo autor tenga ID mayor a 50 y además estén en el conjunto de libros con idioma con ID mayor a 7.",
                "SELECT * FROM Libro WHERE IdAutor > 50 AND IdLibro IN (SELECT IdLibro FROM Libro WHERE IdIdioma > 7)"
            ));

            listaConsultas.Add(new clsConsultaPersonalizada(
                "Diferencia",
                "Selecciona libros cuyo país no esté en el conjunto de países con ID mayor a 10.",
                "SELECT * FROM Libro WHERE IdPais NOT IN (SELECT DISTINCT IdPais FROM Libro WHERE IdPais > 10)"
            ));

            return listaConsultas;
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbOperacion.SelectedIndex != -1)
            {
                clsConsultaPersonalizada seleccion = cmbOperacion.SelectedItem as clsConsultaPersonalizada;

                if (seleccion != null)
                {
                    txtOperacionDescripcion.Text = seleccion.descripcion;
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cmbOperacion.SelectedIndex != -1)
            {
                clsConsultaPersonalizada seleccion = cmbOperacion.SelectedItem as clsConsultaPersonalizada;

                if (seleccion != null)
                {
                    try
                    {
                        String SQL = seleccion.consulta;
                        BD.Consultar(SQL, dgvOperaciones);
                    } 
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error: " + ex.Message);
                    }
                }
            }
        }
    }
}
