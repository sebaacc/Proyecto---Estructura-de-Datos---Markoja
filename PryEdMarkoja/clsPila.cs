using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdMarkoja
{
    internal class clsPila
    {
        private clsNodo pri;
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        //métodos de la clase: agre, elim, recorrer.
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero != null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }
        public void Eliminar()
        {
            Primero = Primero.Siguiente;
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox ComboBox)
        {
            clsNodo aux = Primero;
            ComboBox.Items.Clear();
            while (aux != null)
            {
                ComboBox.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer() //para CSV
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("Cola.csv", false, Encoding.UTF8);
            AD.WriteLine("Listadeespera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
    }
}
