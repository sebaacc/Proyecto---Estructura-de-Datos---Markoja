using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace PryEdMarkoja
{
    public class clsBD
    {
        private String CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\BBDD\Libreria.mdb";
        private String CadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect; //En este caso nos devuelve una tabla que le pedimos si sabes su nombre exacto. Tenemos 2 opciones más, text (sql), StoredProcedure para llamar procedimientos dentro de la bd.
                comando.CommandText = "Autor";

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Autor");

                Grilla.DataSource = DS.Tables["Autor"];

                conexion.Close();
            }
            catch (Exception varError)
            {
                conexion.Close();
                MessageBox.Show(varError.Message);
            }
        }
        public void Listar(String tabla, DataGridView Grilla) //funciona para cambiar de tabla mediante parámetro de la función. 
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, tabla);

                Grilla.DataSource = DS.Tables[tabla];

                conexion.Close();
            }
            catch (Exception varError)
            {
                conexion.Close();
                MessageBox.Show(varError.Message);
            }
        }
    }
}
