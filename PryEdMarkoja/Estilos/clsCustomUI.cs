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
        public enum Theme { LightPastel, Dark }

        public static void CargarEstilos(Form actualForm, Theme theme)
        {
            switch (theme)
            {
                case Theme.LightPastel:
                    AplicarEstiloPastel(actualForm);
                    break;
                case Theme.Dark:
                    AplicarEstiloOscuro(actualForm);
                    break;
            }
        }

        private static void AplicarEstiloPastel(Form actualForm)
        {
            actualForm.BackColor = Color.FromArgb(227, 242, 253);
            actualForm.ForeColor = Color.DarkSlateGray;
            actualForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            actualForm.StartPosition = FormStartPosition.CenterScreen;

            foreach (Control control in actualForm.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.FromArgb(179, 229, 252);
                    button.ForeColor = Color.DarkSlateGray;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 1;
                    button.FlatAppearance.BorderColor = Color.FromArgb(144, 202, 249);
                    button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(144, 202, 249);
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
                else if (control is Label label || control is CheckBox checkBox || control is RadioButton radioButton)
                {
                    control.ForeColor = Color.DarkSlateGray;
                }
                else if (control is MenuStrip menuStrip)
                {
                    menuStrip.BackColor = Color.FromArgb(200, 230, 250);
                    menuStrip.ForeColor = Color.DarkSlateGray;
                    menuStrip.RenderMode = ToolStripRenderMode.Professional;
                    menuStrip.Renderer = new clsLightPastelMenuStripRenderer();
                }
            }
        }

        private static void AplicarEstiloOscuro(Form actualForm)
        {
            actualForm.BackColor = Color.FromArgb(45, 45, 48);
            actualForm.ForeColor = Color.White;
            actualForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            actualForm.StartPosition = FormStartPosition.CenterScreen;

            AplicarEstilosOscurosEnControles(actualForm.Controls);
        }

        private static void AplicarEstilosOscurosEnControles(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
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
                else if (control is Label || control is CheckBox || control is RadioButton)
                {
                    control.ForeColor = Color.LightGray;
                }
                else if (control is MenuStrip menuStrip)
                {
                    menuStrip.BackColor = Color.FromArgb(58, 58, 60);
                    menuStrip.ForeColor = Color.White;
                    menuStrip.RenderMode = ToolStripRenderMode.Professional;
                    menuStrip.Renderer = new clsDarkMenuStripRenderer();
                }
                else if (control is GroupBox groupBox)
                {
                    groupBox.BackColor = Color.FromArgb(58, 58, 60);
                    groupBox.ForeColor = Color.White;

                    AplicarEstilosOscurosEnControles(groupBox.Controls);
                }
                else if (control.HasChildren)
                {
                    AplicarEstilosOscurosEnControles(control.Controls);
                }
            }
        }
    }
}
