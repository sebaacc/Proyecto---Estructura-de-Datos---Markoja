using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEdMarkoja
{
    public class clsConsultaPersonalizada
    {
        public string nombre { get; set; }
        public string consulta { get; set; }
        public string descripcion { get; set; }

        public clsConsultaPersonalizada(string nom, string desc, string cons)
        {
            nombre = nom;
            consulta = cons;
            descripcion = desc;
        }
   
    }
}
