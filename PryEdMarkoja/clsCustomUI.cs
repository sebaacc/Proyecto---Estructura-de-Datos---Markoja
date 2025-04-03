using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PryEdMarkoja
{
    public class clsCustomUI
    {
        public static void CargarEstilos(Form actualForm)
        {
            foreach (Control control in actualForm.Controls)
            {
                if (control is Button)
                {
                    // Estilos para botones (puedes personalizarlos)
                }
                else if (control is CheckBox)
                {
                    // Estilos para CheckBox
                }
                else if (control is RadioButton)
                {
                    // Estilos para RadioButton
                }
                else if (control is TextBox)
                {
                    // Estilos para TextBox
                }
                else if (control is Label)
                {
                    ((Label)control).FlatStyle = FlatStyle.Flat;
                    ((Label)control).ForeColor = Color.DarkSlateGray;
                }
            }
        }
        /*
        public static void LoadDarkTheme(Form actualForm)
        {
            // Aplicar estilo al formulario
            actualForm.BackColor = Color.FromArgb(45, 45, 48); // Gris oscuro
            actualForm.ForeColor = Color.White;
            actualForm.FormBorderStyle = FormBorderStyle.FixedSingle; // Evita el resizing
            actualForm.StartPosition = FormStartPosition.CenterScreen;

            foreach (Control control in actualForm.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.FromArgb(60, 60, 65);
                    button.ForeColor = Color.White;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 1;
                    button.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 105);
                    button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(80, 80, 85);
                    button.MouseLeave += (s, e) => button.BackColor = Color.FromArgb(60, 60, 65);
                }
                else if (control is TextBox textBox)
                {
                    textBox.BackColor = Color.Black;
                    textBox.ForeColor = Color.White;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.BackColor = Color.Black;
                    comboBox.ForeColor = Color.White;
                    comboBox.FlatStyle = FlatStyle.Flat;
                }
                else if (control is Label label)
                {
                    label.ForeColor = Color.LightGray;
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.ForeColor = Color.LightGray;
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.ForeColor = Color.LightGray;
                }
                else if (control is MenuStrip menuStrip)
                {
                    menuStrip.BackColor = Color.FromArgb(58, 58, 60); // Fondo oscuro
                    menuStrip.ForeColor = Color.White;
                    menuStrip.RenderMode = ToolStripRenderMode.Professional;
                    menuStrip.Renderer = new DarkMenuStripRenderer();
                }
            }
        }
    }

    // Personalización del MenuStrip
    public class DarkMenuStripRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(80, 80, 85)), e.Item.ContentRectangle);
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
    }
    */
    //pasteles
    public static void LoadLightPastelTheme(Form actualForm)
    {
            // Aplicar estilo al formulario
            actualForm.BackColor = Color.FromArgb(227, 242, 253); // Celeste pastel
            actualForm.ForeColor = Color.DarkSlateGray;
            actualForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            actualForm.StartPosition = FormStartPosition.CenterScreen;

            foreach (Control control in actualForm.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.FromArgb(179, 229, 252); // Azul pastel
                    button.ForeColor = Color.DarkSlateGray;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 1;
                    button.FlatAppearance.BorderColor = Color.FromArgb(144, 202, 249); // Azul más oscuro
                    button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(144, 202, 249); // Hover
                    button.MouseLeave += (s, e) => button.BackColor = Color.FromArgb(179, 229, 252);
                }
                else if (control is TextBox textBox)
                {
                    textBox.BackColor = Color.White;
                    textBox.ForeColor = Color.DarkSlateGray;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.BackColor = Color.White;
                    comboBox.ForeColor = Color.DarkSlateGray;
                    comboBox.FlatStyle = FlatStyle.Flat;
                }
                else if (control is Label label)
                {
                    label.ForeColor = Color.DarkSlateGray;
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.ForeColor = Color.DarkSlateGray;
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.ForeColor = Color.DarkSlateGray;
                }
                else if (control is MenuStrip menuStrip)
                {
                    menuStrip.BackColor = Color.FromArgb(200, 230, 250); // Celeste pastel claro
                    menuStrip.ForeColor = Color.DarkSlateGray;
                    menuStrip.RenderMode = ToolStripRenderMode.Professional;
                    menuStrip.Renderer = new LightPastelMenuStripRenderer();
                }
            }
        }
    }

    // Personalización del MenuStrip para tema claro pastel
    public class LightPastelMenuStripRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(144, 202, 249)), e.Item.ContentRectangle); // Azul pastel más oscuro
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
    }
}
