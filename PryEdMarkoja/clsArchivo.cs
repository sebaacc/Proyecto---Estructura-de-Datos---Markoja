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
        //public void Recorrer(TreeView treeView)
        //{
        //    StreamReader AD = new StreamReader(nombreArchivo);
        //    Dictionary<string, TreeNode> nodos = new Dictionary<string, TreeNode>();
        //    string dato = AD.ReadLine();
        //    treeView.Nodes.Clear();

        //    while (dato != null)
        //    {
        //        string[] valores = dato.Split(';');
        //        if (valores.Length >= 1)
        //        {
        //            string valor = valores[0];
        //            string izquierdo = valores.Length > 1 ? valores[1] : null;
        //            string derecho = valores.Length > 2 ? valores[2] : null;

        //            if (!nodos.ContainsKey(valor))
        //                nodos[valor] = new TreeNode(valor);

        //            TreeNode nodoPadre = nodos[valor];

        //            if (!string.IsNullOrEmpty(izquierdo))
        //            {
        //                TreeNode nodoIzq = new TreeNode(izquierdo);
        //                nodos[izquierdo] = nodoIzq;
        //                nodoPadre.Nodes.Add(nodoIzq);
        //            }

        //            if (!string.IsNullOrEmpty(derecho))
        //            {
        //                TreeNode nodoDer = new TreeNode(derecho);
        //                nodos[derecho] = nodoDer;
        //                nodoPadre.Nodes.Add(nodoDer);
        //            }
        //        }

        //        dato = AD.ReadLine();
        //    }

        //    AD.Close();

        //    if (nodos.Count > 0)
        //    {
        //        string raiz = nodos.Keys.First();
        //        treeView.Nodes.Add(nodos[raiz]);
        //    }

        //    treeView.ExpandAll();
        //}
    }
}
