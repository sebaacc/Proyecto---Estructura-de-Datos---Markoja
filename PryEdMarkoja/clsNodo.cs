using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEdMarkoja
{
    internal class clsNodo
    {
        private Int32 cod; //codigo
        private String nom; //nombre
        private String tra; //tramite
        private clsNodo sig; //siguiente / puntero.
        private clsNodo ant; //siguiente / puntero.

        //Propiedades Nodo

        public Int32 Codigo 
        {
            get { return cod; }
            set { cod = value; }
        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Tramite
        {
            get { return tra; }
            set { tra = value; }
        }

        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
        public clsNodo Anterior
        {
            get { return sig; }
            set { ant = value; }
        }

    }
}
