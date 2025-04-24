using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PryEdMarkoja
{
    internal class clsArbolBinario
    {        
        private clsNodo PrimerNodo;
        
        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }

        public void Recorrer (ComboBox Lista)
        {
            Lista.Items.Clear();
            //falta
        }
        private void InOrderAsc(ComboBox Lst, clsNodo R)
        {
           
        }
    }
}
