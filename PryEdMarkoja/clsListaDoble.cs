using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdMarkoja
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ulti;
        clsArchivo x = new clsArchivo();

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ulti; }
            set { ulti = value; }
        }
        public void Agregar()
        {
            StreamReader AD = new StreamReader("ListaDoble.csv");
            String dato = "";
            dato = AD.ReadLine();
            dato = AD.ReadLine();
            dato = AD.ReadLine();
            dato = AD.ReadLine();
            while (dato != null)
            {
                clsNodo nodo = new clsNodo();

                String[] datos = dato.Split(';');

                nodo.Codigo = Convert.ToInt32(datos[0]);
                nodo.Nombre = datos[1];
                nodo.Tramite = datos[2];

                Agregar(nodo);
                dato = AD.ReadLine();
            }

            AD.Close();
        }
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {

                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;

                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {

                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;


                    }
                    else
                    {

                        clsNodo ant = pri;
                        clsNodo aux = pri;

                        while (aux.Codigo < ant.Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }

                        ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = aux;
                        Nuevo.Anterior = ant;
                        aux.Anterior = Nuevo;
                    }
                }
            }
        }
        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo && Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            } 
            else
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    clsNodo ant = Primero;
                    clsNodo aux = Primero;
                    while (aux.Codigo != Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                    }
                    aux = aux.Siguiente;
                    ant.Siguiente = aux;
                    aux.Anterior = ant;
                }
            }
        }

        //para recorrer
        //-----------------------------------------------------------------------------
        //RECORRIDO ASCENDENTE
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
        //RECORRIDO DESCENDENTE
        public void RecorrerDesc(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }
        public void RecorrerDesc(ListBox Lista)
        {
            clsNodo aux = Ultimo;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }
        public void RecorrerDesc(ComboBox Combo)
        {
            clsNodo aux = Ultimo;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }
        public void RecorrerDesc()
        {
            clsNodo aux = Ultimo;

            StreamWriter AD = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Anterior;
            }
            AD.Close();
        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox ComboBox)
        {
            clsNodo aux = Primero;
            ComboBox.Items.Clear();
            while (aux != null)
            {
                ComboBox.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer() //para CSV
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("Lista.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
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
        public void Recorrer(String NombreArchivo)
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Código;Nombre;Trámite");
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
