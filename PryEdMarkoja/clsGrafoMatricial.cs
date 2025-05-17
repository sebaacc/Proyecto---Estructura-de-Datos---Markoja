using System;
using System.Windows.Forms;

namespace PryEdMarkoja
{
    public class clsGrafoMatricial
    {
        String[] Ciudades = new string[5] { "Córdoba", "Buenos Aires", " Mendoza", "Santa Fe", "Salta" };
        Decimal[,] Precio = new Decimal[5, 5];


        // funciones con matrices
        public void Agregar(Int32 f, Int32 c, Decimal p)
        {
            Precio[f, c] = p;
        }
        public void Eliminar(Int32 f, Int32 c)
        {
            Precio[f, c] = 0;
        }
        public Decimal Consultar(Int32 f, Int32 c)
        {
            return Precio[f, c];
        }

        public void BorrarTodo()
        {
            for (Int32 f = 0; f < Ciudades.Length; f++)
            {
                for (Int32 c = 0; c < Ciudades.Length; c++)
                {
                    Precio[f, c] = 0;
                }
            }
        }
        public void MostrarTodo(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            Grilla.Columns.Add("NomOrigen", "Origen");

            for (Int32 i = 0; i < Ciudades.Length; i++)
            {
                Grilla.Columns.Add("Destino" + i.ToString(), Ciudades[i]); ;
            }

            for (Int32 f = 0; f < Ciudades.Length; f++)
            {
                Grilla.Rows.Add(Ciudades[f]);
                for (Int32 c = 0; c < Ciudades.Length; c++)
                {
                    Grilla.Rows[f].Cells[c + 1].Value = Precio[f, c];
                }
            }
        }

        //funciones con vectores
        public void CargarCiudad(ComboBox combo)
        {
            for (int i = 0; i < Ciudades.Length; i++)
            {
                combo.Items.Add(Ciudades[i]);
            }
        }
        public void MostrarCiudades(ComboBox cmb)
        {
            cmb.Items.Clear();
            cmb.Items.AddRange(Ciudades);
        }
        public void MostrarDestinos(Int32 f, DataGridView Grilla)
        {
            Grilla.Columns.Clear();
            Grilla.Rows.Clear();
            Grilla.Columns.Add("Col1", "Destino");
            Grilla.Columns.Add("Col2", "Precio");
            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;

            for (Int32 c = 0; c < Ciudades.Length; c++)
            {
                if (Precio[f, c] > 0)
                {
                    Grilla.Rows.Add(Ciudades[c], Precio[f, c]);
                }
            }

        }
        public void MostrarOrigenes(Int32 c, DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();

            // Agregar columnas manualmente
            Grilla.Columns.Add("Col1", "Origen");
            Grilla.Columns.Add("Col2", "Precio");
            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;

            for (Int32 f = 0; f < 5; f++)
            {
                if (Precio[f, c] > 0)
                {
                    Grilla.Rows.Add(Ciudades[f], Precio[f, c]);
                }
            }
        }
    }
}
