using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdMarkoja
{
    public class clsUtilidadesFormularios
    {
        public void MostrarMensajeExitoso() 
        {
            MessageBox.Show("Dato grabado exitosamente...", "Proceso Exitoso");
        }
        public void MostrarMensajeExitoso(String frase)
        {
            MessageBox.Show(frase, "Proceso Exitoso");
        }

        public void LimpiarControles(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is ListBox)
                {
                    ((ListBox)control).Items.Clear();
                }
                if (control.HasChildren)
                {
                    LimpiarControles(control.Controls);
                }
            }
        }
        public bool ComprobarTextBox(params TextBox[] textBoxes)
        {
            bool algunTextBoxVacio = false;
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    algunTextBoxVacio = true;
                    break; 
                }
            }
            return algunTextBoxVacio;
        }
    }
}
