using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PryEdMarkoja
{
    public class clsArchivo
    {
        public String nombreArchivo = "";
        public void Grabar() 
        {
            StreamWriter AD = new StreamWriter(nombreArchivo, true);
            AD.WriteLine("Hola");
            AD.Close();
        }
        public void Grabar(String datoRecibido)
        {
            StreamWriter AD = new StreamWriter(nombreArchivo, true);
            AD.WriteLine(datoRecibido);
            AD.Close();
        }

        public void Recorrer(ListBox lista) 
        {
            StreamReader AD = new StreamReader(nombreArchivo);
            String dato = "";
            dato = AD.ReadLine();
            lista.Items.Clear();
            while (dato != null)
            {
                lista.Items.Add(dato);
                dato = AD.ReadLine();
            }
            AD.Close();
        }
        public void Recorrer(ComboBox cmb)
        {
            StreamReader AD = new StreamReader(nombreArchivo);
            String dato = "";
            dato = AD.ReadLine();
            cmb.Items.Clear();
            while (dato != null)
            {
                cmb.Items.Add(dato);
                dato = AD.ReadLine();
            }
            AD.Close();
        }
        public void Recorrer(DataGridView dgv)
        {
            StreamReader AD = new StreamReader(nombreArchivo);
            String dato = "";
            dato = AD.ReadLine();
            dgv.Rows.Clear();
            while (dato != null)
            {
                string[] valores = dato.Split(';');
                dgv.Rows.Add(valores);
                dato = AD.ReadLine();
            }
            AD.Close();
        }
    }
}
